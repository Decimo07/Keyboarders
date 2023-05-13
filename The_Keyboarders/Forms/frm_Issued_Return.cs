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
    public partial class frm_Issued_Return : Form
    {
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection con = new MySqlConnection();
        dbconnection db = new dbconnection();
        MySqlDataReader dr;
        public DateTime dateborrowed;
        public DateTime duedate;
        public frm_Issued_Return()
        {
            con = new MySqlConnection(db.mycon());
            InitializeComponent();
           
        }
        //loadbook
        
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }
        public void LoadIssuedBook()
        {
            int i = 0;
            booksGridView.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("select borrower_id, name, accession_no, title, author, date_borrowed, due_date from tblIssuedReturn where borrower_id = @borrower", con);
            cmd.Parameters.AddWithValue("@borrower", tboxstudentID.Text);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                booksGridView.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString());

            }
            dr.Close();
            con.Close();
        }
        private void frm_BookList_Load(object sender, EventArgs e)
        {
            LoadIssuedBook();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            LoadIssuedBook();
            con.Open();
            cmd = new MySqlCommand("select fullname, address, contact_# from tblstudent where school_id = @id", con);
            cmd.Parameters.AddWithValue("@id", tboxstudentID.Text);
            dr= cmd.ExecuteReader();
            while (dr.Read())
            {
                tboxfname.Text = dr.GetValue(0).ToString();
                tboxcontactnumber.Text = dr.GetValue(2).ToString();
                tboxaddress.Text = dr.GetValue(1).ToString();  
            }
            dr.Close();
            con.Close();
        }

        private void tboxaccession_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            cmd = new MySqlCommand("select call_no, title, author, isbn from tblbook where accession_no = @accession_no", con);
            cmd.Parameters.AddWithValue("@accession_no", tboxaccession.Text);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tboxcallno.Text = dr.GetValue(0).ToString();
                tboxtitle.Text = dr.GetValue(1).ToString();
                tboxauthor.Text = dr.GetValue(2).ToString();
                tboxisbn.Text = dr.GetValue(3).ToString();
            }
            dr.Close();
            con.Close();
        }

        private void btnborrow_Click(object sender, EventArgs e)
        {
            try
            {
                dateborrowed = DateTime.Now;
                duedate = dateborrowed.AddDays(int.Parse(tboxdaysallowed.Text));
                


                if (MessageBox.Show("Borrower ID:   " + tboxstudentID.Text + Environment.NewLine + "Name:   " + tboxfname.Text + Environment.NewLine + "Address:   " + tboxaddress.Text + Environment.NewLine + "Accession No.:   " + tboxaccession.Text + Environment.NewLine + "Title:   " + tboxtitle.Text + Environment.NewLine + "Author:   " + tboxauthor.Text + Environment.NewLine + "Date Borrowed:   " + dateborrowed + Environment.NewLine + "Due Date:   " + duedate + Environment.NewLine + Environment.NewLine +
                    "do you want approved this loan?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    con.Open();
                    cmd = new MySqlCommand("insert into tblIssuedReturn (borrower_id, Name, accession_no, title, author, date_borrowed, due_date) values(@borrower_id, @Name, @accession_no, @title, @author, @dateborrowed, @duedate)", con);
                    cmd.Parameters.AddWithValue("@borrower_id", tboxstudentID.Text);
                    cmd.Parameters.AddWithValue("@Name", tboxfname.Text);
                    cmd.Parameters.AddWithValue("@accession_no", tboxaccession.Text);
                    cmd.Parameters.AddWithValue("@title", tboxtitle.Text);
                    cmd.Parameters.AddWithValue("@author", tboxauthor.Text);
                    cmd.Parameters.AddWithValue("@dateborrowed", dateborrowed);
                    cmd.Parameters.AddWithValue("@duedate", duedate);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Done!");
                    con.Close();
                    LoadIssuedBook();
                }
            }catch(Exception ex) {
                con.Close();
                MessageBox.Show(ex.Message); }

        }
    }
}
