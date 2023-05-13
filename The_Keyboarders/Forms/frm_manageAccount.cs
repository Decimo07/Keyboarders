using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Keyboarders.Class;


namespace The_Keyboarders
{
    public partial class frm_manageAccount : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        dbconnection db = new dbconnection();
        MySqlDataReader dr;
        public frm_manageAccount()
        {
            con = new MySqlConnection(db.mycon());
            InitializeComponent();
            con = new MySqlConnection(db.mycon());
        }

       

      

        private void text_firstname_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txt_lastname_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_role_TextChanged(object sender, EventArgs e)
        {

        }
   
        private void bttn_save_Click(object sender, EventArgs e)
        {
            
           try
            {
                if (MessageBox.Show("Are you sure you want to save this account?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    MySqlCommand cmd1 = new MySqlCommand();
                    cmd1 = new MySqlCommand("select max(user_id) from [tbl_user]",con);
                    int id = Convert.ToInt32(cmd1.ExecuteScalar());

                    cmd = new MySqlCommand("insert into tbl_user(firstname, lastname, username, password, role, user_id) values (@fname, @lname, @username, @password, @role, @id)", con);
                    cmd.Parameters.AddWithValue("@fname", text_firstname.Text);
                    cmd.Parameters.AddWithValue("@lname", txt_lastname.Text);
                    cmd.Parameters.AddWithValue("@username", txt_username.Text);
                    cmd.Parameters.AddWithValue("@password", txt_password.Text);
                    cmd.Parameters.AddWithValue("@role", txt_role.Text);
                    cmd.Parameters.AddWithValue("@id", id+1);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Student Details succesfully saved!");

                    con.Close();
                    Disablebtn();
                    text_firstname.Clear();
                    txt_lastname.Clear();
                    txt_username.Clear();
                    txt_password.Clear();
                    txt_role.Clear();
                    
                } 
                else
                {
                    MessageBox.Show("Inputs Cancelled!");
                }
            }

            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        public void EnableBtn()
        {
            
            text_firstname.Enabled = true;
            txt_lastname.Enabled = true;
            txt_username.Enabled = true;
            txt_password.Enabled = true;
            txt_role.Enabled = true;
            bttn_save.Enabled = true;
           

        }
        public void Disablebtn()
        {
            text_firstname.Enabled = false;
            txt_lastname.Enabled = false;
            txt_username.Enabled = false;
            txt_password.Enabled = false;
            txt_role.Enabled = false;
            bttn_save.Enabled = false;

        }
        private void btnaddStudent_Click(object sender, EventArgs e)
        {
            EnableBtn();

        }

        private void btnaddStudent_Click_1(object sender, EventArgs e)
        {
            EnableBtn();
        }

        private void frm_manageAccount_Load(object sender, EventArgs e)
        {

        }

       

        private void btn_back_Click(object sender, EventArgs e)
        {

        }

        private void bttn_logOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure want to Log out?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                frm_Login fmd = new frm_Login();
                fmd.Show();
                this.Close();
            }
        }
    }
}
