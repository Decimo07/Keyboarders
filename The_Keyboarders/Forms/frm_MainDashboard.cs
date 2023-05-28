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
        MySqlDataReader dr;
        public Form activeFrm;
        DateTime datenow;
        frm_Login login;
        public frm_MainDashboard(frm_Login frm)
        {
            login = frm;
            con = new MySqlConnection(db.mycon());
            InitializeComponent();
            LoadUser();
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
        }
        public void LoadUser()
        {
            lblUser.Text = login._name +" "+  login._mname +" "+ login._lname;
            lblRole.Text = login._role;
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

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            if (activeFrm != null)
                activeFrm.Close();
        }

        private void btnBookEntry_Click(object sender, EventArgs e)
        {
            frm_BookList frm = new frm_BookList(this);
            frm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Openform(new frm_Issued_Return()); 
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure you want to logout?","Message",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) 
            {
                frm_Login frm = new frm_Login();
                this.Hide();
                frm.Show();
                this.Close();
            }
        }



        private void bttn_user_Click_1(object sender, EventArgs e)
        {
            Openform(new frm_Student_Faculty());
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            frm_Maintenance frm = new frm_Maintenance();
            frm.ShowDialog();
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

        private void button_about_Click(object sender, EventArgs e)
        {
           Openform(new frm_about());
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

        private void SidePanel_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
