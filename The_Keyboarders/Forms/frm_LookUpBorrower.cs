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
using The_Keyboarders.Forms;
using System.Runtime.InteropServices;

namespace The_Keyboarders.Forms
{
    public partial class frm_LookUpBorrower : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        dbconnection db = new dbconnection();
        Alerts ab = new Alerts();
        MySqlDataReader dr;
        frm_Issued_Return frm;
        public DateTime _dateborrowed;
        public DateTime _duedate;
        public frm_LookUpBorrower(frm_Issued_Return forms)
        {
            frm = forms;
            InitializeComponent();
            con = new MySqlConnection(db.mycon());
            LoadBorrower();
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
        public void LoadBorrower()
        {
            int i = 0;
            booksGridView.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("select borrower_id, lastname, firstname, middlename, suffix, type from tblborrowers where borrower_id like '%" + tbox_search.Text + "%' or firstname like '%" + tbox_search.Text + "%' or lastname like '%" + tbox_search.Text + "%' or middlename like '%" + tbox_search.Text + "%'  or type like '%" + tbox_search.Text + "%'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                booksGridView.Rows.Add(i, dr.GetValue(0), dr.GetValue(1).ToString()+ " " + dr.GetValue(2).ToString()+ " " + dr.GetValue(3).ToString()+ " " + dr.GetValue(4).ToString(), dr.GetValue(5));

            }
            dr.Close();
            con.Close();
        }

        private void booksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            string colname = booksGridView.Columns[e.ColumnIndex].Name;
            if(colname == "check")
            {
                
                    frm.tboxBorrower.Text = booksGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    frm.getCredit();
                    this.Dispose();
            }
        }

        private void tbox_search_TextChanged(object sender, EventArgs e)
        {
            LoadBorrower();
        }
    }
}
