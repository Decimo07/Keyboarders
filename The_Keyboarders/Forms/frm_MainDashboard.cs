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

namespace The_Keyboarders
{
    public partial class frm_MainDashboard : Form
    {
        MySqlConnection con = new MySqlConnection();
        MySqlCommand cmd = new MySqlCommand();
        dbconnection db = new dbconnection();
        public string uname;
        DateTime datenow;
        frm_Login login;
        public frm_MainDashboard(frm_Login frm)
        {
            login = frm;
            con = new MySqlConnection(db.mycon());
            InitializeComponent();
            CountBooks();
            CountCategory();
            CountIssuedBooks();
            CountOverdue();
            CountStudent();
            CountFaculty();
            LoadUser();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public void LoadUser()
        {
            uname = login._username;
            lblUser.Text = login._name +" "+  login._mname +" "+ login._lname;
            lblRole.Text = login._role;
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
            cmd = new MySqlCommand("select count(*) from tblborrowers where type = 'Student'", con);
            lblstudent.Text = cmd.ExecuteScalar().ToString();
            con.Close();
        }
        public void CountFaculty()
        {
            con.Open();
            cmd = new MySqlCommand("select count(*) from tblborrowers where type = 'Faculty'", con);
            lblfaculty.Text = cmd.ExecuteScalar().ToString();
            con.Close();
        }


        private void btnBookEntry_Click(object sender, EventArgs e)
        {
            Forms.frm_Books frm = new Forms.frm_Books(this);
            frm.ShowDialog();
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frm_Maintenance frm = new frm_Maintenance();
            frm.ShowDialog();
        }

        private void lblNoOfBook_TextChanged(object sender, EventArgs e)
        {
        }

        private void panel10_Paint(object sender, PaintEventArgs e)
        {

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

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void Logout_Click(object sender, EventArgs e)
        {

        }

        private void btnIssuedReturn_Click(object sender, EventArgs e)
        {
            frm_Issued_Return frm = new frm_Issued_Return(this);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to exit?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnPullOut_Click(object sender, EventArgs e)
        {
            frm_Maintenance frm = new frm_Maintenance();
            frm.ShowDialog();
        }

        private void btnBookAcquired_Click(object sender, EventArgs e)
        {
            frm_BookAcquired frm = new frm_BookAcquired();
            frm.ShowDialog();
        }

        private void btnBorrowers_Click(object sender, EventArgs e)
        {
            frm_borrower frm = new frm_borrower();
            frm.ShowDialog();
        }
    }
}
