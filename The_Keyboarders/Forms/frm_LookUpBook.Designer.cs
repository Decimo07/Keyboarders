namespace The_Keyboarders.Forms
{
    partial class frm_LookUpBook
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LookUpBook));
            this.panel1 = new System.Windows.Forms.Panel();
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessionNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Call_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearpub = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbox_search = new MetroFramework.Controls.MetroTextBox();
            this.toppanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.ellipseControlArtan1 = new The_Keyboarders.Class.EllipseControlArtan();
            this.ellipseControlArtan2 = new The_Keyboarders.Class.EllipseControlArtan();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.booksGridView);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.toppanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(990, 509);
            this.panel1.TabIndex = 0;
            // 
            // booksGridView
            // 
            this.booksGridView.AllowUserToAddRows = false;
            this.booksGridView.AllowUserToDeleteRows = false;
            this.booksGridView.BackgroundColor = System.Drawing.Color.White;
            this.booksGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.booksGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.booksGridView.ColumnHeadersHeight = 30;
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.booksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.accessionNum,
            this.Call_No,
            this.title,
            this.column1,
            this.yearpub,
            this.isbn,
            this.subject,
            this.publisher,
            this.qty,
            this.check});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.booksGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksGridView.EnableHeadersVisualStyles = false;
            this.booksGridView.GridColor = System.Drawing.SystemColors.Info;
            this.booksGridView.Location = new System.Drawing.Point(0, 69);
            this.booksGridView.Name = "booksGridView";
            this.booksGridView.ReadOnly = true;
            this.booksGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.booksGridView.RowHeadersVisible = false;
            this.booksGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            this.booksGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.booksGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksGridView.Size = new System.Drawing.Size(988, 438);
            this.booksGridView.TabIndex = 112;
            this.booksGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksGridView_CellContentClick);
            // 
            // book_id
            // 
            this.book_id.HeaderText = "";
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Visible = false;
            // 
            // accessionNum
            // 
            this.accessionNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accessionNum.HeaderText = "#";
            this.accessionNum.Name = "accessionNum";
            this.accessionNum.ReadOnly = true;
            this.accessionNum.Width = 41;
            // 
            // Call_No
            // 
            this.Call_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Call_No.HeaderText = "Call No";
            this.Call_No.Name = "Call_No";
            this.Call_No.ReadOnly = true;
            this.Call_No.Width = 71;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // column1
            // 
            this.column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.column1.HeaderText = "Author";
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            this.column1.Width = 68;
            // 
            // yearpub
            // 
            this.yearpub.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.yearpub.HeaderText = "Year Pub.";
            this.yearpub.Name = "yearpub";
            this.yearpub.ReadOnly = true;
            this.yearpub.Width = 81;
            // 
            // isbn
            // 
            this.isbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            this.isbn.Width = 56;
            // 
            // subject
            // 
            this.subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subject.HeaderText = "Subject";
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            this.subject.Width = 73;
            // 
            // publisher
            // 
            this.publisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.publisher.HeaderText = "Publisher";
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            this.publisher.Width = 82;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.HeaderText = "Copies";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 70;
            // 
            // check
            // 
            this.check.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.check.HeaderText = "";
            this.check.Image = ((System.Drawing.Image)(resources.GetObject("check.Image")));
            this.check.Name = "check";
            this.check.ReadOnly = true;
            this.check.Width = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbox_search);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(988, 51);
            this.groupBox2.TabIndex = 111;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Books";
            // 
            // tbox_search
            // 
            // 
            // 
            // 
            this.tbox_search.CustomButton.Image = null;
            this.tbox_search.CustomButton.Location = new System.Drawing.Point(344, 1);
            this.tbox_search.CustomButton.Name = "";
            this.tbox_search.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbox_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbox_search.CustomButton.TabIndex = 1;
            this.tbox_search.CustomButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tbox_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbox_search.CustomButton.UseSelectable = true;
            this.tbox_search.CustomButton.Visible = false;
            this.tbox_search.DisplayIcon = true;
            this.tbox_search.Dock = System.Windows.Forms.DockStyle.Right;
            this.tbox_search.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbox_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbox_search.Icon = ((System.Drawing.Image)(resources.GetObject("tbox_search.Icon")));
            this.tbox_search.Lines = new string[0];
            this.tbox_search.Location = new System.Drawing.Point(615, 21);
            this.tbox_search.MaxLength = 32767;
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.PasswordChar = '\0';
            this.tbox_search.PromptText = "Search";
            this.tbox_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbox_search.SelectedText = "";
            this.tbox_search.SelectionLength = 0;
            this.tbox_search.SelectionStart = 0;
            this.tbox_search.ShortcutsEnabled = true;
            this.tbox_search.Size = new System.Drawing.Size(370, 27);
            this.tbox_search.TabIndex = 107;
            this.tbox_search.UseSelectable = true;
            this.tbox_search.WaterMark = "Search";
            this.tbox_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbox_search.WaterMarkFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_search.TextChanged += new System.EventHandler(this.tbox_search_TextChanged);
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.Silver;
            this.toppanel.Controls.Add(this.pictureBox3);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Margin = new System.Windows.Forms.Padding(2);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(988, 18);
            this.toppanel.TabIndex = 110;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(968, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // ellipseControlArtan1
            // 
            this.ellipseControlArtan1.CornerRadius = 20;
            this.ellipseControlArtan1.TargetControl = this;
            // 
            // ellipseControlArtan2
            // 
            this.ellipseControlArtan2.CornerRadius = 20;
            this.ellipseControlArtan2.TargetControl = this.panel1;
            // 
            // frm_LookUpBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(990, 509);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_LookUpBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.toppanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Class.EllipseControlArtan ellipseControlArtan1;
        private Class.EllipseControlArtan ellipseControlArtan2;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox tbox_search;
        private System.Windows.Forms.DataGridView booksGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessionNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Call_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearpub;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewImageColumn check;
    }
}