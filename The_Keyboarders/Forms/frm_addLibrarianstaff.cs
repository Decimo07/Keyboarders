using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using The_Keyboarders.Class;

namespace The_Keyboarders
{
    public partial class frm_addLibrarianstaff : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        dbconnection db = new dbconnection();
        MySqlDataReader dr;
        public string empID;
        frm_Student_Faculty frm;
        public frm_addLibrarianstaff(frm_Student_Faculty frms)
        {
            frm = frms;
            InitializeComponent();
            con = new MySqlConnection(db.mycon());
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnsave_Click(object sender, EventArgs e)
        {
                con.Open();
                cmd = new MySqlCommand("select * from tbluser", con);
                dr = cmd.ExecuteReader();
                dr.Read();
                if (dr.Read())
                {
                    empID = dr.GetValue(0).ToString();
                }
                dr.Close();
                con.Close();
            try
            {
                if (MessageBox.Show("Are you sure you want to save this record?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new MySqlCommand("insert into tbl_student_info(school_id, fullname, address, contact_#) values (@id, @fname, @address, @contact)", con);
                    
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("User Information succesfully saved!");

                    con.Close();
                    frm.LoadUser();
                   
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
    }
}
