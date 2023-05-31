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
    public partial class frm_Issued_Return : Form
    {
        Class.Alerts ab = new Alerts();
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection con = new MySqlConnection();
        dbconnection db = new dbconnection();
        MySqlDataReader dr;
        public DateTime dateborrowed;
        public DateTime duedate;
        public string un;
        public string due;
        public string user;
        frm_MainDashboard frm;
        public frm_Issued_Return(frm_MainDashboard form)
        {
            frm = form;
            con = new MySqlConnection(db.mycon());
            InitializeComponent();
            
            user = frm.lblUser.Text;
            un = frm.uname;
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void UpdateState()
        {
            if (!string.IsNullOrEmpty(tboxBorrower.Text)&& !string.IsNullOrEmpty(tboxcallno.Text))
            {
                btnborrow.Enabled = true;
                btnCancel.Enabled = true;
                
            }
            else
            {
                btnborrow.Enabled = false;
                btnCancel.Enabled = false;
            }
        }
        public void GetTransno()
        {
            try {
                string date = DateTime.Now.ToString("MMddyyyy");
                string transno;
                int count;

                con.Open();
                cmd = new MySqlCommand("select transno from tblissuedreturn where transno like '%" + date + "%' order by id desc LIMIT 1", con);
                dr = cmd.ExecuteReader();
                dr.Read();
            if (dr.HasRows)
            {
                
                transno = dr[0].ToString();
                count = int.Parse(transno.Substring(8, 4));
                lbltransno.Text = date + (count + 1);
            }
            else
            {
                transno = date + "1001";
                lbltransno.Text = transno;
            }
            dr.Close();
                con.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
}
        public void LoadIssuedBook()
        {
            int i = 0;
            booksGridView.Rows.Clear();
            con.Open();
            cmd = new MySqlCommand("select transno, accession_no, call_no, title, author, date_borrowed, due_date, penalty, issuedby from tblIssuedReturn where borrower_id = @borrower", con);
            cmd.Parameters.AddWithValue("@borrower", tboxBorrower.Text);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
                booksGridView.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString());

            }
            dr.Close();
            con.Close();
        }
        private void frm_BookList_Load(object sender, EventArgs e)
        {
            LoadIssuedBook();
            
        }

        private void tboxaccession_TextChanged(object sender, EventArgs e)
        {
            UpdateState();
            con.Open();
            cmd = new MySqlCommand("select accession_no, title, author, isbn from tblbook where call_no = @call_no", con);
            cmd.Parameters.AddWithValue("@call_no", tboxcallno.Text);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tboxaccessionno.Text = dr.GetValue(0).ToString();
                tboxtitle.Text = dr.GetValue(1).ToString();
                tboxauthor.Text = dr.GetValue(2).ToString();
                tboxisbn.Text = dr.GetValue(3).ToString();
            }
            dr.Close();
            con.Close();
        }
        public void getCredit()
        {
            con.Open();
            cmd = new MySqlCommand("select max_day, max_credit, penalty_price from tblcredit where type like '%"+tboxType.Text+"%'", con);
            
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                lblMaxAllowed.Text = dr.GetValue(1).ToString();
                lbldaysallowed.Text = dr.GetValue(0).ToString();
                lblPenalty.Text = dr.GetValue(2).ToString();
            }
            dr.Close();
            con.Close();
        }
        private void btnborrow_Click(object sender, EventArgs e)
        {
            GetTransno();
            try
            {
                
                
                dateborrowed = DateTime.Now;
                
                if (tboxType.Text == "Faculty")
                {
                    due = "no limit";
                }
                else
                {
                    duedate = dateborrowed.AddDays(int.Parse(lbldaysallowed.Text));
                    due = duedate.ToString("MM/dd/yyyy hh:mm:ss tt");
                }
                

               
                //display the transaction details
                if (MessageBox.Show("Transaction #:   " + lbltransno.Text + Environment.NewLine + "Borrower ID:   " + tboxBorrower.Text + Environment.NewLine + "Name:   " + tboxfname.Text + Environment.NewLine + "Address:   " + tboxaddress.Text + Environment.NewLine + "Call No.:   " + tboxcallno.Text + Environment.NewLine + "Title:   " + tboxtitle.Text + Environment.NewLine + "Author:   " + tboxauthor.Text + Environment.NewLine + "Date Borrowed:   " + dateborrowed.ToString("MM/dd/yyyy hh:mm:ss tt") + Environment.NewLine + "Due Date:   " + due + Environment.NewLine + Environment.NewLine +
                    "do you want approved this loan?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Forms.frm_verifyPassword frm = new Forms.frm_verifyPassword(this);
                    frm.ShowDialog();
                   
                }
            }catch(Exception ex) {
                con.Close();
                MessageBox.Show(ex.Message); }

        }

        private void tboxBorrower_TextChanged(object sender, EventArgs e)
        {
            UpdateState();
            LoadIssuedBook();
            getCredit();
            con.Open();
            cmd = new MySqlCommand("select lastname, firstname,middlename, address, contactno, type from tblborrowers where borrower_id = @id", con);
            cmd.Parameters.AddWithValue("@id", tboxBorrower.Text);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                tboxfname.Text = dr.GetValue(0).ToString() + ", " + dr.GetValue(1).ToString() + " " + dr.GetValue(2).ToString();
                tboxcontactnumber.Text = dr.GetValue(4).ToString();
                tboxaddress.Text = dr.GetValue(3).ToString();
                tboxType.Text = dr.GetValue(5).ToString();
            }
            dr.Close();
            con.Close();
        }

        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void booksGridView_SelectionChanged(object sender, EventArgs e)
        {
            DataGridViewCell cell = null;
            foreach (DataGridViewCell selectedCell in booksGridView.SelectedCells)
            {
                cell = selectedCell;
                break;
            }
            if (cell != null)
            {
                DataGridViewRow row = cell.OwningRow;
                tboxPenalty.Text = row.Cells[8].Value.ToString();
                
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCancel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            tboxcallno.Clear();
        }
    }
}
