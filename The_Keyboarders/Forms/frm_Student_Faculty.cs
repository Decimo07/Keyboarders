using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using MySql.Data.MySqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Keyboarders.Class;

namespace The_Keyboarders
{
    public partial class frm_Student_Faculty : Form
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection con = new MySqlConnection();
        dbconnection db = new dbconnection();
        MySqlDataReader dr;

        public frm_Student_Faculty()
        {
            con = new MySqlConnection(db.mycon());
            InitializeComponent();
        }

        public void LoadUser()
        {
            int i = 0;
            datagrid_SearchUser.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("select school_id, name, address, contactno from tblstudent  where school_id like '%" + tbox_search.Text + "%' or fullname like '%" + tbox_search.Text + "%' or address like '%" + tbox_search.Text + "%'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                datagrid_SearchUser.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());

            }
            dr.Close();
            con.Close();
        }

        private void tbox_search_TextChanged(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void bttn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            frm_addstudent fas = new frm_addstudent(this);
            fas.Show();
        }

        private void datagrid_SearchUser_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_AddUser_Load_1(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void l_book_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
