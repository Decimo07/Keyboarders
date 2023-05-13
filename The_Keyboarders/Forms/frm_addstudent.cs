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

namespace The_Keyboarders
{
    public partial class frm_addstudent : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        dbconnection db = new dbconnection();
        MySqlDataReader dr;
        frm_Student_Faculty student;
        public string school_id;
        public frm_addstudent(frm_Student_Faculty faculty)
        {
            student = faculty;
            
            InitializeComponent();
            con = new MySqlConnection(db.mycon());
        }
        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void txt_schoolID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_name_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {
        }

        private void btncancel_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to cancel?","Message",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void btnsave_Click(object sender, EventArgs e)
        {

                    con.Open();
                    cmd = new MySqlCommand("select * from tblstudent", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.Read())
                    {
                        school_id = dr.GetValue(0).ToString();
                    }
                    dr.Close();
                    con.Close();
            try
            {
                if (MessageBox.Show("Are you sure you want to save this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    if (school_id == txt_schoolID.Text)
                    {
                        MessageBox.Show("School Id already exist!", "Message");
                        con.Close();
                        return;
                    }
                    cmd = new MySqlCommand("insert into tbl_student_info(school_id, fullname, address, contact_#) values (@id, @fname, @address, @contact)", con);
                    cmd.Parameters.AddWithValue("@id", txt_schoolID.Text);
                    cmd.Parameters.AddWithValue("@fname", txt_name.Text);
                    cmd.Parameters.AddWithValue("@address", txt_address.Text);
                    cmd.Parameters.AddWithValue("@contact", txt_contact.Text);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Information succesfully saved!");

                    con.Close();
                    student.LoadUser();
                    txt_schoolID.Clear();
                    txt_name.Clear();
                    txt_address.Clear();
                    txt_contact.Clear();
                    txt_contact.Clear();
                }
                else
                {
                    con.Close();
                }
            }
            catch(Exception ex)
            {
                con.Close();
                MessageBox.Show(ex.Message);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close this form?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}
