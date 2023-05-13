using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using The_Keyboarders.Class;
using System.Data.SqlClient;
using The_Keyboarders.Class;

namespace The_Keyboarders
{
    public partial class Category : Form
    {
        DataTable table = new DataTable("table");
        SqlConnection con = new SqlConnection();
        SqlCommand cmd = new SqlCommand();
        dbconnection db = new dbconnection();
        SqlDataReader dr;
        
        public Category()
        {
            con = new SqlConnection(db.mycon());
            InitializeComponent();
            con = new SqlConnection(db.mycon());
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void bttn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    SqlCommand cmd2 = new SqlCommand("select * from [tbl_category] where [category]='"+ txtbox_category.Text + "';", con);
                    dr = cmd2.ExecuteReader();
                    if (dr.Read())
                    {
                        dr.Close();

                        MessageBox.Show("Category already exists");
                        
                    }
                    else
                    {
                        dr.Close();
                        SqlCommand cmd1 = new SqlCommand("select max(id) from [tbl_category]", con);
                        int id = 0;
                        object result = cmd1.ExecuteScalar();

                        if (result.GetType() != typeof(DBNull))
                        {
                            id = Convert.ToInt32(cmd1.ExecuteScalar()) + 1;
                        }
                        else
                        {
                            id++;
                        }


                        cmd = new SqlCommand("insert into tbl_category (id,category) values (" + id + ",@Category)", con);
                        cmd.Parameters.AddWithValue("@Category", txtbox_category.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Succesfully added");
                        txtbox_category.Clear();
                        
                    }
                    
                    
                    con.Close();

                    


                }
                else
                {
                    MessageBox.Show("Inputs Cancelled!");

                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void txtbox_category_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Category_Load(object sender, EventArgs e)
        {

        }

        private void bttn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
  }