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
        public string _callno;
        public string _isbn;
        public frm_Books(frm_MainDashboard ds)
        {
            con = new MySqlConnection(db.mycon());
            dash = ds;
            InitializeComponent();
            LoadBook();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        public void LoadBook()
        {
            int i = 0;
            booksGridView.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("select b.call_no, b.title, b.author,  b.year_published, b.isbn, b.subject, b.publisher, count(c.call_no) as qty from tblbook as b left join tblbookAcquired as c on b.call_no = c.call_no where b.call_no like '%" + tbox_search.Text + "%' or title like '%" + tbox_search.Text + "%' or author like '%" + tbox_search.Text + "%' or publisher like '%" + tbox_search.Text + "%' group by call_no", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                booksGridView.Rows.Add(i, dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr["qty"].ToString());

            }
            dr.Close();
            con.Close();
           

        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_AddBooks frm = new frm_AddBooks(this, dash);
            frm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            dash.CountBooks();
            this.Dispose();
        }

        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void booksGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
            _callno = booksGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            _isbn = booksGridView.Rows[e.RowIndex].Cells[6].Value.ToString();
        }
    }
}
