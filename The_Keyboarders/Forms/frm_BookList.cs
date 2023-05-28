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
        //loadbook
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frm_AddBooks frm = new frm_AddBooks();
            frm.ShowDialog();
        }

        private void tbox_search_TextChanged(object sender, EventArgs e)
        {
            LoadBook();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void cbox_filter_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void bttn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            frm_AddBooks frm = new frm_AddBooks();
            frm.ShowDialog();
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

        byte[] ObjectToByteArray(object obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter bf = new BinaryFormatter();
            using (MemoryStream ms = new MemoryStream())
            {
                bf.Serialize(ms, obj);
                return ms.ToArray();
            }
        }

        public Image byteArrayToImage(byte[] byteArrayIn)
        {
            System.Drawing.ImageConverter converter = new System.Drawing.ImageConverter();
            Image img = (Image)converter.ConvertFrom(byteArrayIn);

            return img;
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
            dash.CountBooks();
        }
    }
}
