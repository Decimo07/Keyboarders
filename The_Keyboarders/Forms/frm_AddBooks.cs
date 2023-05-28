using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using MySql.Data.MySqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_Keyboarders.Class;
using Gma.QrCodeNet.Encoding;
using Gma.QrCodeNet.Encoding.Windows.Render;
using System.IO;
using System.Drawing.Imaging;
using System.Runtime.InteropServices;

namespace The_Keyboarders
{
    public partial class frm_AddBooks : Form
    {

       
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        dbconnection db = new dbconnection();
        MySqlDataReader dr;
        public frm_AddBooks()
        {
          
            con = new MySqlConnection(db.mycon());
            InitializeComponent();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        //populate category from tbl_category
        public void LoadCategory()
        {
            con.Open();
            cmd = new MySqlCommand("Select category from tblcategory", con);
            dr = cmd.ExecuteReader();
            while(dr.Read()) 
            {
                cbox_category.Items.Add(dr[0].ToString());
                
            }
            dr.Close();
            con.Close();   
        }


        private void bttn_save_Click(object sender, EventArgs e)
        {

            
            try
            {
                if (MessageBox.Show("Are you sure you want to save this book?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    //edited saving method

                    string category = "";
                    con.Open();
                    cmd = new MySqlCommand("select id from tblcategory where category like '" + cbox_category.Text + "'", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if(dr.HasRows) 
                    {
                        category = dr[0].ToString(); 
                    }
                    dr.Close();
                    con.Close();

                    con.Open();
                    cmd = new MySqlCommand("insert into tblbook (accession_no, call_no, title, author, year_published, isbn, notes, subject, series, price, publisher, cid, qty, qrcode, book_image) values (@accession_no, @call_no, @title, @author, @year_publish, @isbn, @notes, @subject, @series, @price, @publisher, @category, 0, @qrcode, @bookimage)", con);
                    cmd.Parameters.AddWithValue("@accession_no", tboxasseccion.Text);
                    cmd.Parameters.AddWithValue("@call_no", tboxcallno.Text);
                    cmd.Parameters.AddWithValue("@title", tboxtitle.Text);
                    cmd.Parameters.AddWithValue("@author", tboxauthor.Text);
                    cmd.Parameters.AddWithValue("@year_publish", tboxYpub.Text);
                    cmd.Parameters.AddWithValue("@isbn", tboxISBN.Text);
                    cmd.Parameters.AddWithValue("@notes", tboxNotes.Text);
                    cmd.Parameters.AddWithValue("@subject", tboxSubject.Text);
                    cmd.Parameters.AddWithValue("@series", tboxseries.Text);
                    cmd.Parameters.AddWithValue("@price", tboxprice.Text);
                    cmd.Parameters.AddWithValue("@publisher", tboxpublisher.Text);
                    cmd.Parameters.AddWithValue("@category", category);
                    MemoryStream ms = new MemoryStream();
                    MemoryStream mr = new MemoryStream();
                    QRCODE.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                    BOOKIMAGE.Image.Save(mr, System.Drawing.Imaging.ImageFormat.Jpeg);
                    byte[] qr_code = ms.ToArray();
                    byte[] book_image = mr.ToArray();

                    cmd.Parameters.AddWithValue("@qrcode", qr_code);
                    cmd.Parameters.AddWithValue("@bookimage", book_image);
                    cmd.ExecuteNonQuery();

                    con.Close();
                    MessageBox.Show("Book succesfully added");

                    tboxasseccion.Clear();  
                    tboxcallno.Clear();
                    tboxtitle.Clear();
                    tboxauthor.Clear();
                    tboxYpub.Clear();
                    tboxISBN.Clear();
                    tboxNotes.Clear();
                    tboxSubject.Clear();
                    tboxseries.Clear();
                    tboxprice.Clear();
                    tboxpublisher.Clear();
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

     

        private void cbox_category_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void frm_AddBooks_Load(object sender, EventArgs e)
        {
            LoadCategory();
        }


     

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void tboxcallno_TextChanged(object sender, EventArgs e)
        {
            QrEncoder encoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qr;
            encoder.TryEncode("Call No: " + tboxcallno.Text + Environment.NewLine + "Main Title: " +
                tboxtitle.Text + Environment.NewLine + "Author: " + tboxauthor.Text + Environment.NewLine + "Year Published: " + tboxYpub.Text
                + Environment.NewLine + "ISBN: " + tboxISBN.Text, out qr);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedModuleSize(4, QuietZoneModules.Two), Brushes.Black, Brushes.White);
            using (MemoryStream ms = new MemoryStream())
            {
                renderer.WriteToStream(qr.Matrix, ImageFormat.Png, ms);
                QRCODE.Image = new Bitmap(ms);
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tboxtitle_TextChanged(object sender, EventArgs e)
        {
            QrEncoder encoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qr;
            encoder.TryEncode("Call No: " + tboxcallno.Text + Environment.NewLine + "Main Title: " +
                tboxtitle.Text + Environment.NewLine + "Author: " + tboxauthor.Text + Environment.NewLine + "Year Published: " + tboxYpub.Text
                + Environment.NewLine + "ISBN: " + tboxISBN.Text, out qr);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedModuleSize(4, QuietZoneModules.Two), Brushes.Black, Brushes.White);
            using (MemoryStream ms = new MemoryStream())
            {
                renderer.WriteToStream(qr.Matrix, ImageFormat.Png, ms);
                QRCODE.Image = new Bitmap(ms);
            }
        }

        private void tboxauthor_TextChanged(object sender, EventArgs e)
        {
            QrEncoder encoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qr;
            encoder.TryEncode("Call No: " + tboxcallno.Text + Environment.NewLine + "Main Title: " +
                tboxtitle.Text + Environment.NewLine + "Author: " + tboxauthor.Text + Environment.NewLine + "Year Published: " + tboxYpub.Text
                + Environment.NewLine + "ISBN: " + tboxISBN.Text, out qr);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedModuleSize(4, QuietZoneModules.Two), Brushes.Black, Brushes.White);
            using (MemoryStream ms = new MemoryStream())
            {
                renderer.WriteToStream(qr.Matrix, ImageFormat.Png, ms);
                QRCODE.Image = new Bitmap(ms);
            }
        }

        private void tboxYpub_TextChanged(object sender, EventArgs e)
        {
            QrEncoder encoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qr;
            encoder.TryEncode("Call No: " + tboxcallno.Text + Environment.NewLine + "Main Title: " +
                tboxtitle.Text + Environment.NewLine + "Author: " + tboxauthor.Text + Environment.NewLine + "Year Published: " + tboxYpub.Text
                + Environment.NewLine + "ISBN: " + tboxISBN.Text, out qr);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedModuleSize(4, QuietZoneModules.Two), Brushes.Black, Brushes.White);
            using (MemoryStream ms = new MemoryStream())
            {
                renderer.WriteToStream(qr.Matrix, ImageFormat.Png, ms);
                QRCODE.Image = new Bitmap(ms);
            }
        }

        private void tboxISBN_TextChanged(object sender, EventArgs e)
        {
            QrEncoder encoder = new QrEncoder(ErrorCorrectionLevel.H);
            QrCode qr;
            encoder.TryEncode("Call No: " + tboxcallno.Text + Environment.NewLine + "Main Title: " +
                tboxtitle.Text + Environment.NewLine + "Author: " + tboxauthor.Text + Environment.NewLine + "Year Published: " + tboxYpub.Text
                + Environment.NewLine + "ISBN: " + tboxISBN.Text, out qr);
            GraphicsRenderer renderer = new GraphicsRenderer(new FixedModuleSize(4, QuietZoneModules.Two), Brushes.Black, Brushes.White);
            using (MemoryStream ms = new MemoryStream())
            {
                renderer.WriteToStream(qr.Matrix, ImageFormat.Png, ms);
                QRCODE.Image = new Bitmap(ms);
            } 
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
