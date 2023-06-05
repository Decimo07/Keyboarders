using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using The_Keyboarders.Class;
using The_Keyboarders.Forms;
using System.Runtime.InteropServices;
using System.Drawing;

namespace The_Keyboarders
{
    public partial class frm_Issued_Return : Form
    {
        Alerts ab = new Alerts();
        MySqlCommand cmd = new MySqlCommand();
        MySqlConnection con = new MySqlConnection();
        dbconnection db = new dbconnection();
        MySqlDataReader dr;
        public DateTime dateborrowed;
        public DateTime duedate;
        public string un;
        public string due;
        public string user;
        public string _status;
        public string _transno;
        public string _yearpub;
        public string _isbn;
        public string _subject;
        public string _publisher;
        public string _callno;
        public string _title;
        public string _author;
        public string _acqno, btitle, bauthor, bisbn;

        frm_MainDashboard frms;
        public string buttons = "borrow";
        public bool btnborrowclicked { get; private set; } = false;
        public bool bookDG { get; private set; } = false;
        public string _trans_no;
        public frm_Issued_Return(frm_MainDashboard form)
        {
            frms = form;
            con = new MySqlConnection(db.mycon());
            InitializeComponent();
            user = frms.lblUser.Text;
            un = frms.uname;
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
            cmd = new MySqlCommand("select p.transno, p.acquisition_no, p.call_no, p.title, p.author, p.date_borrowed, p.due_date, p.penalty, p.issuedby, p.status, c.year_published, c.isbn, c.subject, c.publisher from tblIssuedReturn as p inner join tblbook as c on p.call_no = c.call_no where p.borrower_id = @borrower", con);
            cmd.Parameters.AddWithValue("@borrower", tboxBorrower.Text);
            dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                i++;
            
                booksGridView.Rows.Add(i, dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString(), dr[5].ToString(), dr[6].ToString(), dr[7].ToString(), dr[8].ToString(), dr[9].ToString(), dr[10].ToString(), dr[11].ToString(), dr[12].ToString(), dr[13].ToString());
                

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
            bool datafound = false;
            
            con.Open();
            cmd = new MySqlCommand("select acquisition_no, book_title, book_author, isbn_no from tblbookacquired where call_no = @call_no", con);
            cmd.Parameters.AddWithValue("@call_no", tboxcallno.Text);
            dr = cmd.ExecuteReader();
            dr.Read();
            if (dr.HasRows)
            {
                datafound = true;
                _acqno = dr.GetValue(0).ToString();
                btitle = dr.GetValue(1).ToString();
                bauthor = dr.GetValue(2).ToString();
                bisbn = dr.GetValue(3).ToString();
            }
            dr.Close();
            con.Close();
            if(datafound == true)
            {
                tboxaccessionno.Text = _acqno;
                tboxtitle.Text = btitle;
                tboxauthor.Text = bauthor;
                tboxisbn.Text = bisbn;
                
            }
            else
            {
                ab.AlertBoxs(Color.White, Color.DarkRed, "Error", "No more copy for this book", Properties.Resources.cross); ab.AlertBoxs(Color.White, Color.DarkRed, "Error", "No more copy for this book", Properties.Resources.cross);

            }
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
        public void btnborrow_Click(object sender, EventArgs e)
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
                if (MessageBox.Show("Transaction #:   " + lbltransno.Text + Environment.NewLine + "Borrower ID:   " + tboxBorrower.Text + Environment.NewLine + "Name:   " + tboxfname.Text + Environment.NewLine + "Address:   " + tboxaddress.Text + Environment.NewLine + "Call No.:   " + tboxcallno.Text + Environment.NewLine + "Acquisition No.:   " + tboxaccessionno.Text + Environment.NewLine + "Title:   " + tboxtitle.Text + Environment.NewLine + "Author:   " + tboxauthor.Text + Environment.NewLine + "Date Borrowed:   " + dateborrowed.ToString("MM/dd/yyyy hh:mm:ss tt") + Environment.NewLine + "Due Date:   " + due + Environment.NewLine + Environment.NewLine +
                    "do you want approved this loan?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    btnborrowclicked = true;
                    Forms.frm_verifyPassword frm = new Forms.frm_verifyPassword(this, frms);
                    frm.ShowDialog();
                    frm.btns = buttons;
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

        private void btnLookUpbook_Click(object sender, EventArgs e)
        {
            frm_LookUpBook frm = new frm_LookUpBook(this);
            frm.ShowDialog();
        }

        private void btnLookUpborrower_Click(object sender, EventArgs e)
        {
            frm_LookUpBorrower frm = new frm_LookUpBorrower(this);
            frm.ShowDialog();
        }
        
        

        private void toppanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            frm_ScanQR frm = new frm_ScanQR(this);
            frm.ShowDialog();
        }

        private void booksGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            _trans_no = booksGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            _callno = booksGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            _title = booksGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            _author = booksGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            _yearpub = booksGridView.Rows[e.RowIndex].Cells[11].Value.ToString();
            _isbn = booksGridView.Rows[e.RowIndex].Cells[12].Value.ToString();
            _subject = booksGridView.Rows[e.RowIndex].Cells[13].Value.ToString();
            _publisher = booksGridView.Rows[e.RowIndex].Cells[14].Value.ToString();
            string colname = booksGridView.Columns[e.ColumnIndex].Name;
            if(colname == "returnbook")
            {
                if(MessageBox.Show("Mark this transaction as returned?","Confirmation",MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    frm_verifyPasswordReturn frm = new frm_verifyPasswordReturn(this, frms);
                    frm.ShowDialog();
                }
                
            }
        }

        private void booksGridView_RowEnter(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void booksGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {/*
            string colname = booksGridView.Columns[e.ColumnIndex].Name;
            if (colname == "status")
              {
                    if(e.Value.ToString() == "unreturned")
                {
                    booksGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Gray;
                    booksGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Red;
                }
                else
                {
                    booksGridView.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
                    booksGridView.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.Green;
                }
              }*/
            
        }
    }
}
