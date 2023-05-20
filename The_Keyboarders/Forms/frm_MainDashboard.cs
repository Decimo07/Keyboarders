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
using System.Runtime.InteropServices;

namespace The_Keyboarders
{
    public partial class frm_MainDashboard : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        dbconnection db = new dbconnection();
        MySqlDataReader dr;
        int NoOfBooks;
        public static frm_MainDashboard instance;
        public Form activeFrm;
        DateTime datenow;
        frm_Login login;




        public frm_MainDashboard(frm_Login form)
        {
            login = form;
            con = new MySqlConnection(db.mycon());
            InitializeComponent();
            instance = this;
            MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            User();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        
        public void User()
        {
            txtRole.Text = login._role;
            txtUser.Text = login._name + " " + login._lname;
            if(login._role != "administrator")
            {
                btnMaintenance.Visible = false;
                btnPullOut.Visible = false;
            }
        }
        
        public void Openform(Form Children)
        {
            if (activeFrm != null)
                activeFrm.Close();
            activeFrm = Children;
            Children.TopLevel = false;
            MainPanel.Controls.Add(activeFrm);
            Children.Dock = DockStyle.Fill;
            MainPanel.Tag = Children;
            Children.BringToFront();
            Children.Show();
        }
        public void CountBooks()
        {
            con.Open();
            cmd = new MySqlCommand("select count(*) from tblbook",con);
            lblNoOfBook.Text = cmd.ExecuteScalar().ToString();
            con.Close();
        }
        public void CountCategory()
        {
            con.Open();
            cmd = new MySqlCommand("select count(*) from tblcategory", con);
            lblcategory.Text = cmd.ExecuteScalar().ToString();
            con.Close();
        }
        public void CountIssuedBooks()
        {
            con.Open();
            cmd = new MySqlCommand("select count(*) from tblIssuedReturn", con);
            lblIssued.Text = cmd.ExecuteScalar().ToString();
            con.Close();
        }
        public void CountOverdue()
        {
            datenow = DateTime.Now;
            con.Open();
            cmd = new MySqlCommand("select count(*) from tblissuedReturn where due_date < @datenow", con);
            cmd.Parameters.AddWithValue("@datenow", datenow);
            lbloverdue.Text = cmd.ExecuteScalar().ToString();
            con.Close();
        }
        public void CountStudent()
        {
            con.Open();
            cmd = new MySqlCommand("select count(*) from tblStudent", con);
            lblstudent.Text = cmd.ExecuteScalar().ToString();
            con.Close();
        }
        private void frm_MainDashboard_Load(object sender, EventArgs e)
        {
            if(activeFrm != null)
                activeFrm.Close();
            CountBooks();
            CountCategory();
            CountIssuedBooks();
            CountOverdue();
            CountStudent();
        }

        private void lblNoOfBook_TextChanged(object sender, EventArgs e)
        {

        }


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }


        private void lblcategory_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (activeFrm != null)
                activeFrm.Close();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            frm_BookList frm = new frm_BookList(this);
            frm.Show();
        }

        private void btnIssuedReturn_Click(object sender, EventArgs e)
        {
            Openform(new frm_Issued_Return());
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to logout?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                frm_Login frm = new frm_Login();
                this.Hide();
                frm.Show();
                this.Close();
            }
        }

        private void TopPanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
                this.WindowState = FormWindowState.Maximized;
            else
                this.WindowState = FormWindowState.Normal;
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
    }
}
