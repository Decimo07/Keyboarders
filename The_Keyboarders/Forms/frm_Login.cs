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
        public string _mmame;
        public frm_Login()
        {
            con = new MySqlConnection(db.mycon());
            InitializeComponent();
            instance = this;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Librarian_LogIn_Load(object sender, EventArgs e)

        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(showpassword.Checked) 
            {
                tbox_password.UseSystemPasswordChar = false;
            }
            else
            {
                tbox_password.UseSystemPasswordChar = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            tbox_username.Text = "";
            tbox_password.Text = "";
        }

        private void exit_button_Click(object sender, EventArgs e)
        {

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


                        frm_MainDashboard frm = new frm_MainDashboard();
                        this.Hide();
                        frm.ShowDialog();

                    }
                    else
                    {
                        MessageBox.Show("Welcome " + _name + " " + _lname + "!", "Login Successfully", MessageBoxButtons.OK, MessageBoxIcon.None);
                        frm_MainDashboard frm = new frm_MainDashboard();
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

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void bttn_NewAcc_Click(object sender, EventArgs e)
        {
           
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void bttn_NewAcc_Click_1(object sender, EventArgs e)
        {
            frm_manageAccount fma = new frm_manageAccount();
            fma.Show();
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to exit?","Message",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                System.Windows.Forms.Application.Exit();
            }
        }
    }
}
