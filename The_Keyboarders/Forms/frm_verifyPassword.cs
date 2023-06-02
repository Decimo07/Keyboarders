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
    public partial class frm_verifyPassword : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        dbconnection db = new dbconnection();
        Alerts ab = new Alerts();
        MySqlDataReader dr;
        frm_Issued_Return frm;
        frm_MainDashboard frms;
        public string _password;
        public frm_verifyPassword(frm_Issued_Return form, frm_MainDashboard forms)
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
                    //check if the student has reached the limit of borrow attempts
                    if (frm.booksGridView.RowCount == 2 && frm.tboxType.Text == "Student")
                    {
                        ab.AlertBoxs(Color.White, Color.DarkRed, "Error", "Unable to process. " + frm.lblMaxAllowed.Text + " maximum book allowed to borrow", Properties.Resources.cross);
                        con.Close();
                    }
                    else
                    {
                        con.Open();
                        cmd = new MySqlCommand("delete from tblbook where accession_no = @accessionno", con);
                        cmd.Parameters.AddWithValue("@accessionno", frm.tboxaccessionno.Text);
                        cmd.ExecuteNonQuery();
                        con.Close();
                        con.Open();
                        cmd = new MySqlCommand("insert into tblIssuedReturn (transno, borrower_id, borrower_name, call_no, accession_no, title, author, date_borrowed, due_date,status,issuedby) values(@transno, @borrower_id, @Name, @callno, @accession_no, @title, @author, @dateborrowed, @duedate, 'unreturned', @issuedby)", con);
                        cmd.Parameters.AddWithValue("@transno", frm.lbltransno.Text);
                        cmd.Parameters.AddWithValue("@borrower_id", frm.tboxBorrower.Text);
                        cmd.Parameters.AddWithValue("@Name", frm.tboxfname.Text);
                        cmd.Parameters.AddWithValue("@callno", frm.tboxcallno.Text);
                        cmd.Parameters.AddWithValue("@accession_no", frm.tboxaccessionno.Text);
                        cmd.Parameters.AddWithValue("@title", frm.tboxtitle.Text);
                        cmd.Parameters.AddWithValue("@author", frm.tboxauthor.Text);
                        cmd.Parameters.AddWithValue("@dateborrowed", frm.dateborrowed);
                        cmd.Parameters.AddWithValue("@duedate", frm.due);
                        cmd.Parameters.AddWithValue("@issuedby", frm.user);
                        cmd.ExecuteNonQuery();
                        ab.AlertBoxs(Color.LightGreen, Color.SeaGreen, "Success", "Transaction successfully saved!", Properties.Resources.check);
                        con.Close();


                        
                        frms.Unreturned();
                        frm.tboxcallno.Clear();
                        frm.LoadIssuedBook();
                        this.Dispose();
                    }
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
    }
}
