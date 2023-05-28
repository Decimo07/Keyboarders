using System;
using System.Collections.Generic;
using System.ComponentModel;
using MySql.Data.MySqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Keyboarders.Class;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.InteropServices;

namespace The_Keyboarders
{
    public partial class frm_BookList : Form
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection con = new MySqlConnection();
        dbconnection db = new dbconnection();
        MySqlDataReader dr;
        frm_MainDashboard dash;
        public frm_BookList(frm_MainDashboard ds)
        {
            dash = ds;
            con = new MySqlConnection(db.mycon());
            InitializeComponent();
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
            cmd = new MySqlCommand("select call_no, title, author, year_published, isbn, subject, publisher, qty, qrcode, book_image from tblbook where call_no like '%"+tbox_search.Text+ "%' or title like '%"+tbox_search.Text+ "%' or author like '%"+tbox_search.Text+ "%' or publisher like '%"+tbox_search.Text+"%'", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                booksGridView.Rows.Add(i,dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9));

            }
            dr.Close();
            con.Close();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void frm_BookList_Load(object sender, EventArgs e)
        {
            LoadBook();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void booksGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach(DataGridViewCell selectedCell in booksGridView.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if(cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                tboxcallno.Text = row.Cells[1].Value.ToString();
                tboxtitle.Text = row.Cells[2].Value.ToString();
                tboxauthor.Text = row.Cells[3].Value.ToString();
                tboxYP.Text = row.Cells[4].Value.ToString();
                tboxISBN.Text = row.Cells[5].Value.ToString();
                tboxsubject.Text = row.Cells[6].Value.ToString();
                tboxpub.Text = row.Cells[7].Value.ToString();
                byte[] qrcd = (byte[])row.Cells[9].Value;
                byte[] imgbook = (byte[])row.Cells[10].Value;

                MemoryStream ms = new MemoryStream(qrcd);
                qrcode.Image = Image.FromStream(ms);

                MemoryStream ms1 = new MemoryStream(imgbook);
                bookimage.Image = Image.FromStream(ms1);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            dash.CountBooks();
        }

        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void metroTextBox1_TextChanged(object sender, EventArgs e)
        {
            LoadBook();
        }
    }
}
