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
using The_Keyboarders.Class;

namespace The_Keyboarders.Forms
{
    public partial class frm_LookUpBook : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        dbconnection db = new dbconnection();
        Alerts ab = new Alerts();
        MySqlDataReader dr;
        frm_Issued_Return frm;
       
        public frm_LookUpBook(frm_Issued_Return forms)
        {
            frm = forms;
            InitializeComponent();
            con = new MySqlConnection(db.mycon());
            LoadBook();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        public void LoadBook()
        {
            int i = 0;
            booksGridView.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("select acquisition_no, call_no, book_title, book_author,  yearpub,isbn_no,book_subject,book_publisher from tblbookAcquired where call_no like '%" + tbox_search.Text + "%' or book_title like '%" + tbox_search.Text + "%' or book_author like '%" + tbox_search.Text + "%' or book_publisher like '%" + tbox_search.Text + "%'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                booksGridView.Rows.Add(i, dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7));

            }
            dr.Close();
            con.Close();
        }
        private void booksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = booksGridView.Columns[e.ColumnIndex].Name;
            if(colname == "check")
            {
                    frm.tboxcallno.Text = booksGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                frm.tboxaccessionno.Text = booksGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                this.Dispose();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbox_search_TextChanged(object sender, EventArgs e)
        {
            LoadBook();
        }
    }
}
