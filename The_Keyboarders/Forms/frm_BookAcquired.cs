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
    public partial class frm_BookAcquired : Form
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection con = new MySqlConnection();
        dbconnection db = new dbconnection();
        Alerts ab = new Alerts();
        MySqlDataReader dr;
        frm_MainDashboard frm;
        public string _yearpub;
        public string _notes;
        public string _subject;
        public string _series;
        public string _price;
        public string _publisher;
        public string _category;
        public byte[] qrcd;
        public byte[] imgbook;
        public frm_BookAcquired(frm_MainDashboard forms)
        {
            frm = forms;
            con = new MySqlConnection(db.mycon());
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
            cmd = new MySqlCommand("select accession_no, call_no, title, author,year_published, isbn, notes, subject, series, price, publisher, cid, qrcode, book_image, count(*) as qty from tblbook where call_no like '%"+tbox_search.Text+ "%' or title like '%"+tbox_search.Text+ "%' or author like '%"+tbox_search.Text+ "%' or publisher like '%"+tbox_search.Text+"%' group by call_no", con);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                booksGridView.Rows.Add(i,dr.GetValue(0), dr.GetValue(1), dr.GetValue(2), dr.GetValue(3), dr.GetValue(4), dr.GetValue(5), dr.GetValue(6), dr.GetValue(7), dr.GetValue(8), dr.GetValue(9), dr.GetValue(10), dr.GetValue(11), dr.GetValue(12), dr.GetValue(13),dr["qty"].ToString());

            }
            dr.Close();
            con.Close();
        }
        

        private void frm_BookList_Load(object sender, EventArgs e)
        {
            
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
                tboxcallno.Text = row.Cells[2].Value.ToString();
                tboxtitle.Text = row.Cells[3].Value.ToString();
                tboxauthor.Text = row.Cells[4].Value.ToString();
                tboxISBN.Text = row.Cells[6].Value.ToString();
                qrcd = (byte[])row.Cells[13].Value;
                imgbook = (byte[])row.Cells[14].Value;
                _yearpub = row.Cells[5].Value.ToString();
                _notes = row.Cells[7].Value.ToString();
                _subject = row.Cells[8].Value.ToString();
                _series = row.Cells[9].Value.ToString();
                _price = row.Cells[10].Value.ToString();
                _publisher = row.Cells[11].Value.ToString();
                _category = row.Cells[12].Value.ToString();

                MemoryStream ms = new MemoryStream(qrcd);
                qrcode.Image = Image.FromStream(ms);

                MemoryStream ms1 = new MemoryStream(imgbook);
                bookimage.Image = Image.FromStream(ms1);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Dispose();
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

        private void booksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            string colname = booksGridView.Columns[e.ColumnIndex].Name;
            if(colname == "edit")
            {
                tboxCopies.Enabled = true;
                btnSave.Visible = true;
                btnClose.Visible = true;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand("insertBooks", con);
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("CALLNO", tboxcallno.Text);
            cmd.Parameters.AddWithValue("TITLE", tboxtitle.Text);
            cmd.Parameters.AddWithValue("AUTHOR", tboxauthor.Text);
            cmd.Parameters.AddWithValue("YEARPUB", _yearpub);
            cmd.Parameters.AddWithValue("ISBN", tboxISBN.Text);
            cmd.Parameters.AddWithValue("NOTES", _notes);
            cmd.Parameters.AddWithValue("SUBJECT", _subject);
            cmd.Parameters.AddWithValue("SERIES", _series);
            cmd.Parameters.AddWithValue("PRICE", _price);
            cmd.Parameters.AddWithValue("PUBLISHER", _publisher);
            cmd.Parameters.AddWithValue("CATEGORY", _category);
            cmd.Parameters.AddWithValue("QRCODE", qrcd);
            cmd.Parameters.AddWithValue("BOOKIMAGE", imgbook);
            cmd.Parameters.AddWithValue("QTY", tboxCopies.Value);

            cmd.ExecuteNonQuery();
            if(MessageBox.Show("are you sure you want to update the no. of copies of "+ tboxtitle.Text + " to "+ tboxCopies.Text, "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if(tboxCopies.Text == "0")
                {
                    ab.AlertBoxs(Color.LightPink, Color.DarkRed, "Error", "Please put atleast 1 copy", Properties.Resources.cross);
                    con.Close();
                }
                else
                {
                    ab.AlertBoxs(Color.LightGreen, Color.SeaGreen, "Success", "Added No. of Copies!", Properties.Resources.check);
                    con.Close();
                    LoadBook();
                    
                    btnSave.Visible = false;
                    tboxCopies.Enabled = false;
                    btnClose.Visible = false;
                }
               
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            btnSave.Visible = false;
            tboxCopies.Enabled = false;
            btnClose.Visible = false;
            LoadBook();
        }
    }
}
