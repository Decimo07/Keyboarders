using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using The_Keyboarders.Class;
using The_Keyboarders.Class;


namespace The_Keyboarders
{
    public partial class frm_Maintenance : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        dbconnection db = new dbconnection();
        MySqlDataReader dr;
        public string _category;
        public frm_Maintenance()
        {
            con = new MySqlConnection(db.mycon());
            InitializeComponent();
            con = new MySqlConnection(db.mycon());
        }
        
        private void bttn_add_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("Are you sure you want to save this Category?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    
                    con.Open();
                    bool found = false;
                    cmd = new MySqlCommand("select * from tblcategory", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        found = true;
                        _category = dr["category"].ToString();

                        
                    }
                    con.Close();
                    dr.Close();
                    if(_category == txtbox_category.Text)
                    {
                        MessageBox.Show("Category already exists");
                        con.Close();
                        return;
                        
                    }
                    else
                    {
                        con.Open();
                        cmd = new MySqlCommand("insert into tblcategory (category) values (@category)", con);
                        cmd.Parameters.AddWithValue("@category", txtbox_category.Text);
                        cmd.ExecuteNonQuery();

                        MessageBox.Show("Succesfully added");
                        con.Close();
                        LoadCategory();
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
        public void LoadCategory()
        {
            int i = 0;
            dataGridView_category.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("select * from tblcategory ", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                dataGridView_category.Rows.Add(i, dr[1].ToString());

            }
            dr.Close();
            con.Close();
        }
        private void dataGridView_category_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtbox_category_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_Maintenance_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
