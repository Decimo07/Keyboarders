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
using System.Runtime.InteropServices;

namespace The_Keyboarders
{
    public partial class frm_borrower : Form
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection con = new MySqlConnection();
        dbconnection db = new dbconnection();
        MySqlDataReader dr;

        public frm_borrower()
        {
            con = new MySqlConnection(db.mycon());
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void LoadUser()
        {
            int i = 0;
            booksGridView.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("select borrower_id, lastname, firstname, middlename, suffix, address, contactno, type, photo from tblborrowers  where borrower_id like '%" + tbox_search.Text + "%' or lastname like '%" + tbox_search.Text + "%' or firstname like '%" + tbox_search.Text + "%' or middlename like '%" + tbox_search.Text + "%' or type like '%" + tbox_search.Text + "%' or address like '%" + tbox_search.Text + "%'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                booksGridView.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());

            }
            dr.Close();
            con.Close();
        }

        

        private void frm_AddUser_Load_1(object sender, EventArgs e)
        {
            LoadUser();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_addborrower frm = new frm_addborrower(this);
            frm.ShowDialog();
        }

        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void tbox_search_TextChanged(object sender, EventArgs e)
        {
            LoadUser();
        }
    }
}
