using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using The_Keyboarders.Class;
using static System.Net.Mime.MediaTypeNames;
using System.IO;
using System.Runtime.InteropServices;

namespace The_Keyboarders
{
    public partial class frm_addborrower : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        dbconnection db = new dbconnection();
        Class.Alerts ab = new Class.Alerts();
        MySqlDataReader dr;
        frm_borrower student;
        public string borrower_id;
        public frm_addborrower(frm_borrower faculty)
        {
            student = faculty;
            
            InitializeComponent();
            con = new MySqlConnection(db.mycon());
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnSave_Click_1(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand("select borrower_id from tblborrowers", con);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.Read())
            {
                borrower_id = dr.GetValue(0).ToString();
            }
            dr.Close();
            con.Close();
            try
            {
                if (MessageBox.Show("Are you sure you want to save this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    if (borrower_id == tboxBorrowerId.Text)
                    {
                        ab.AlertBoxs(Color.LightPink, Color.DarkRed, "Borrower ID Exist",tboxBorrowerId.Text + " is already exits", Properties.Resources.cross);
                        con.Close();
                        return;
                    }
                    cmd = new MySqlCommand("insert into tblborrowers(borrower_id, lastname, firstname, middlename, suffix, address, contactno, type, photo) values (@id, @lname ,@fname, @mname, @suffix, @address, @contact, @type, @photo)", con);
                    MemoryStream ms = new MemoryStream();
                    picPhoto.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] photo = ms.ToArray();
                    cmd.Parameters.AddWithValue("@id", tboxBorrowerId.Text);
                    cmd.Parameters.AddWithValue("@lname", tboxLname.Text);
                    cmd.Parameters.AddWithValue("@fname", tboxFname.Text);
                    cmd.Parameters.AddWithValue("@mname", tboxMname.Text);
                    cmd.Parameters.AddWithValue("@suffix", tboxSuffix.Text);
                    cmd.Parameters.AddWithValue("@address", tboxAddress.Text);
                    cmd.Parameters.AddWithValue("@contact", tboxContact.Text);
                    if(cboxFaculty.CheckState == CheckState.Checked)
                    {
                        cmd.Parameters.AddWithValue("@type", "Faculty");
                    }
                    else if(cboxStudent.CheckState == CheckState.Checked)
                    {
                        cmd.Parameters.AddWithValue("@type", "Student");
                    }
                    cmd.Parameters.AddWithValue("@photo", photo);

                    cmd.ExecuteNonQuery();
                    ab.AlertBoxs(Color.LightGreen, Color.SeaGreen, "Success", "New Borrower has been added", Properties.Resources.check);

                    con.Close();
                    student.LoadUser();
                    tboxBorrowerId.Clear();
                    tboxLname.Clear();
                    tboxAddress.Clear();
                    tboxContact.Clear();
                    tboxContact.Clear();
                }
                else
                {
                    con.Close();
                }
            }
            catch (Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tboxBorrowerId.Clear();
            tboxAddress.Clear();
            tboxContact.Clear();
            tboxFname.Clear();
            tboxLname.Clear();
            tboxMname.Clear();
            tboxSuffix.Clear();
           
        }
    }
}
