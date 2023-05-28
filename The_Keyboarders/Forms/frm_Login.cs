using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Keyboarders.Class;

namespace The_Keyboarders
{
    public partial class frm_Login : Form
    {
        public static frm_Login instance;
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        dbconnection db = new dbconnection();
        MySqlDataReader dr;
        public string _username;
        public string _name;
        public string _role;
        public string _lname;
        public string _mname;
        public frm_Login()
        {
            con = new MySqlConnection(db.mycon());
            InitializeComponent();
            instance = this;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(showpassword.Checked) 
            {
                tbox_password.UseSystemPasswordChar = false;
                tbox_password.PasswordChar = '\0';
            }
            else
            {
                tbox_password.UseSystemPasswordChar = true;
                tbox_password.PasswordChar = '●';
            }
        }


        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                bool found = false;
                con.Open();
                cmd = new MySqlCommand("select * from tbluser where username = @usern and password = @pass", con);
                cmd.Parameters.AddWithValue("@pass", tbox_password.Text);
                cmd.Parameters.AddWithValue("@usern", tbox_username.Text);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.HasRows)
                {
                    found = true;
                    _username = dr["username"].ToString();
                    _name = dr["firstname"].ToString();
                    _role = dr["role"].ToString();
                    _lname = dr["lastname"].ToString();
                }
                else
                {
                    found = false;
                }
                dr.Close();
                con.Close();
                if(found == true)
                {
                    if(_role == "administator")
                    {
                        MessageBox.Show("Welcome "+ _name + " "+_lname +"!", "Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.None);


                        frm_MainDashboard frm = new frm_MainDashboard(this);
                        this.Hide();
                        frm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Welcome " + _name + " " + _lname + "!", "Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.None);
                        frm_MainDashboard frm = new frm_MainDashboard(this);
                        this.Hide();
                        frm.ShowDialog();
                    }


                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect! ", "Login Unsuccessfully", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tbox_username.Clear();
                    tbox_password.Clear();
                    tbox_username.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?","Message",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                System.Windows.Forms.Application.Exit();
            }
        }

        private void panel3_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
