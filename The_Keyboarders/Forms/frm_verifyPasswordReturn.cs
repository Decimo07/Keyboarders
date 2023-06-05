using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using The_Keyboarders.Class;

namespace The_Keyboarders.Forms
{
    public partial class frm_verifyPasswordReturn : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        dbconnection db = new dbconnection();
        Alerts ab = new Alerts();
        MySqlDataReader dr;
        frm_Issued_Return frm;
        frm_MainDashboard frms;
        public string _password;
        public frm_verifyPasswordReturn(frm_Issued_Return form, frm_MainDashboard forms)
        {
            con = new MySqlConnection(db.mycon());
            frms = forms;
            frm = form;
            InitializeComponent();
            
        }


        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void tbox_password_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
        }

        private void tbox_password_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                
                bool btnDG = frm.bookDG;
                bool found = false;
                con.Open();
                cmd = new MySqlCommand("select * from tbluser where username = @un and password = @pw", con);
                cmd.Parameters.AddWithValue("@un", frm.un);
                cmd.Parameters.AddWithValue("@pw", tbox_password.Text);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                }
                else
                {
                    ab.AlertBoxs(Color.White, Color.DarkRed, "Error", "User Password is incorrect!", Properties.Resources.cross);
                    tbox_password.Clear();
                    con.Close();
                }
                dr.Close();
                con.Close();

                if (found == true)
                {
                    con.Open();
                    cmd = new MySqlCommand("insertBooks", con);
                    cmd.CommandType = System.Data.CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("CALLNO", frm._callno);
                    cmd.Parameters.AddWithValue("TITLE", frm._title);
                    cmd.Parameters.AddWithValue("AUTHOR", frm._author);
                    cmd.Parameters.AddWithValue("YEARPUB", frm._yearpub);
                    cmd.Parameters.AddWithValue("ISBN", frm._isbn);
                    cmd.Parameters.AddWithValue("SUBJECT", frm._subject);
                    cmd.Parameters.AddWithValue("PUBLISHER", frm._publisher);
                    cmd.Parameters.AddWithValue("QTY", 1);

                    cmd.ExecuteNonQuery();
                    frms.NoOfCopies();
                    con.Close();
                    con.Open();
                            cmd = new MySqlCommand("update tblissuedreturn set status = @status, date_returned = @datereturned, issuedby = @issuedby where transno = @transno", con);
                            cmd.Parameters.AddWithValue("@status", "Returned");
                            cmd.Parameters.AddWithValue("@transno", frm._trans_no);
                            cmd.Parameters.AddWithValue("@issuedby", frm.user);
                            cmd.Parameters.AddWithValue("@datereturned", DateTime.Now.ToString("MM/dd/yyyy hh: mm:ss tt"));
                            cmd.ExecuteNonQuery();
                            ab.AlertBoxs(Color.White, Color.SeaGreen, "Message", "This book has successfully returned", Properties.Resources.check);
                            con.Close();
                            frms.returned();
                            frms.Unreturned();
                    frm.LoadIssuedBook();
                    this.Dispose();
                }
            }
           
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if(tbox_password.PasswordChar == '\0')
            {
                pictureBox1.Image = Properties.Resources.hide;
                tbox_password.UseSystemPasswordChar = true;
                tbox_password.PasswordChar = '●';
            }
            else
            {
                pictureBox1.Image = Properties.Resources.show;
                tbox_password.UseSystemPasswordChar = false;
                tbox_password.PasswordChar = '\0';
            }
        }

        private void frm_verifyPassword_Load(object sender, EventArgs e)
        {
        }
    }
}
