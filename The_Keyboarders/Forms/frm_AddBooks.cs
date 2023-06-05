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
        Forms.frm_Books frm;
        public string _callno;
        Alerts ab = new Alerts();
        frm_MainDashboard frms;
        public frm_AddBooks(Forms.frm_Books form, frm_MainDashboard forms)
        {
            frms = forms;
            frm = form;
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
                    cmd = new MySqlCommand("select call_no from tblbook", con);
                    dr = cmd.ExecuteReader();
                    dr.Read();
                    if (dr.HasRows)
                    {
                        _callno = dr[0].ToString();
                    }
                    dr.Close();
                    con.Close();
                    try
                    {
                        if (_callno == tboxcallno.Text)
                        {
                            ab.AlertBoxs(Color.White, Color.DarkRed, "Error", "Call # already exist", Properties.Resources.cross);
                            con.Close();
                            return;
                        }
                    }
                    catch (Exception)
                    {
                        ab.AlertBoxs(Color.White, Color.DarkRed, "Error", "Call # already exist", Properties.Resources.cross);
                        con.Close();
                    }
                    
                    if (String.IsNullOrEmpty(tboxcallno.Text) || String.IsNullOrEmpty(tboxtitle.Text) || String.IsNullOrEmpty(tboxauthor.Text)|| String.IsNullOrEmpty(tboxYpub.Text)||
                        String.IsNullOrEmpty(tboxISBN.Text)|| String.IsNullOrEmpty(tboxSubject.Text) || String.IsNullOrEmpty(tboxprice.Text) || String.IsNullOrEmpty(cbox_category.Text) || String.IsNullOrEmpty(tboxpublisher.Text))
                    {
                        ab.AlertBoxs(Color.White, Color.DarkRed, "Some text fields are Empty", "Please make sure to fill up the required fields", Properties.Resources.cross);
                        con.Close();

                    }
                    
                    
                    else
                    {
                        con.Open();
                        cmd = new MySqlCommand("insert into tblbook (call_no, title, author, year_published, isbn, notes, subject, series, price, publisher, cid, qrcode, book_image) values (@call_no, @title, @author, @year_publish, @isbn, @notes, @subject, @series, @price, @publisher, @category, @qrcode, @bookimage)", con);
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
                        ab.AlertBoxs(Color.White, Color.SeaGreen, "Success", "New book is added successfully!", Properties.Resources.check);
                        frm.LoadBook();
                        frms.CountBooks();
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
                }
                else
                {
                    ab.AlertBoxs(Color.White, Color.DarkRed, "Message", "Inputs Cancelled!", Properties.Resources.cross);
                    con.Close();
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
            encoder.TryEncode(tboxcallno.Text, out qr);
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
           
        }

        private void tboxauthor_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tboxYpub_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void tboxISBN_TextChanged(object sender, EventArgs e)
        {

        }
        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (MessageBox.Show("Cancel the current process?", "Cancel Process", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {

                tboxauthor.Clear();
                tboxcallno.Clear();
                tboxISBN.Clear();
                tboxNotes.Clear();
                tboxprice.Clear();
                tboxpublisher.Clear();
                tboxseries.Clear();
                tboxSubject.Clear();
                tboxtitle.Clear();
                tboxYpub.Clear();
                BOOKIMAGE.Image = Properties.Resources.user;
            }
        }
    }
}
