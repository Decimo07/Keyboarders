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

namespace The_Keyboarders.Forms
{
    public partial class frm_Books : Form
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection con = new MySqlConnection();
        Class.dbconnection db = new Class.dbconnection();
        Class.Alerts ab = new Class.Alerts();
        MySqlDataReader dr;
        frm_MainDashboard dash;
        public frm_Books(frm_MainDashboard ds)
        {
            con = new MySqlConnection(db.mycon());
            dash = ds;
            InitializeComponent();
            LoadBook();
        }
        public void LoadBook()
        {
            int i = 0;
            booksGridView.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("select accession_no, call_no, title, author,  year_published,isbn,subject,publisher, qty, qrcode, book_image from tblbook where call_no like '%" + tbox_search.Text + "%' or title like '%" + tbox_search.Text + "%' or author like '%" + tbox_search.Text + "%' or publisher like '%" + tbox_search.Text + "%'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                booksGridView.Rows.Add(i, dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8));

            }
            dr.Close();
            con.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_AddBooks frm = new frm_AddBooks(this);
            frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dash.CountBooks();
            this.Dispose();
        }
    }
}
