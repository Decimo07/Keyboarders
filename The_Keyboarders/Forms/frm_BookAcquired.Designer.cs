namespace The_Keyboarders
{
    partial class frm_BookAcquired
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BookAcquired));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toppanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accessionNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Call_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qr_code = new System.Windows.Forms.DataGridViewImageColumn();
            this.book_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.tboxCopies = new System.Windows.Forms.NumericUpDown();
            this.tbox_search = new MetroFramework.Controls.MetroTextBox();
            this.tboxauthor = new System.Windows.Forms.TextBox();
            this.tboxtitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxcallno = new System.Windows.Forms.TextBox();
            this.tboxISBN = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookimage = new System.Windows.Forms.PictureBox();
            this.qrcode = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ellipseControlArtan1 = new The_Keyboarders.Class.EllipseControlArtan();
            this.btnClose = new System.Windows.Forms.Button();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxCopies)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrcode)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.Silver;
            this.toppanel.Controls.Add(this.pictureBox2);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Margin = new System.Windows.Forms.Padding(2);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(970, 21);
            this.toppanel.TabIndex = 0;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(950, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 21);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 23;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // mainpanel
            // 
            this.mainpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainpanel.Controls.Add(this.booksGridView);
            this.mainpanel.Controls.Add(this.groupBox1);
            this.mainpanel.Controls.Add(this.panel2);
            this.mainpanel.Controls.Add(this.panel1);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Location = new System.Drawing.Point(0, 21);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(970, 554);
            this.mainpanel.TabIndex = 1;
            // 
            // booksGridView
            // 
            this.booksGridView.AllowUserToAddRows = false;
            this.booksGridView.AllowUserToDeleteRows = false;
            this.booksGridView.BackgroundColor = System.Drawing.Color.White;
            this.booksGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.booksGridView.ColumnHeadersHeight = 30;
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.booksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.accessionNum,
            this.Call_No,
            this.title,
            this.column1,
            this.isbn,
            this.qr_code,
            this.book_image,
            this.qty,
            this.edit});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.booksGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksGridView.EnableHeadersVisualStyles = false;
            this.booksGridView.Location = new System.Drawing.Point(0, 26);
            this.booksGridView.Name = "booksGridView";
            this.booksGridView.ReadOnly = true;
            this.booksGridView.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.booksGridView.RowHeadersVisible = false;
            this.booksGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            this.booksGridView.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.booksGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksGridView.Size = new System.Drawing.Size(746, 263);
            this.booksGridView.TabIndex = 105;
            this.booksGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksGridView_CellContentClick);
            this.booksGridView.SelectionChanged += new System.EventHandler(this.booksGridView_SelectionChanged);
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
            this.accessionNum.HeaderText = "";
            this.accessionNum.Name = "accessionNum";
            this.accessionNum.ReadOnly = true;
            this.accessionNum.Visible = false;
            // 
            // Call_No
            // 
            this.Call_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Call_No.HeaderText = "Call No";
            this.Call_No.Name = "Call_No";
            this.Call_No.ReadOnly = true;
            this.Call_No.Width = 75;
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
            this.column1.Width = 73;
            // 
            // isbn
            // 
            this.isbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isbn.HeaderText = "ISBN";
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            this.isbn.Width = 58;
            // 
            // qr_code
            // 
            this.qr_code.HeaderText = "";
            this.qr_code.Name = "qr_code";
            this.qr_code.ReadOnly = true;
            this.qr_code.Visible = false;
            // 
            // book_image
            // 
            this.book_image.HeaderText = "";
            this.book_image.Name = "book_image";
            this.book_image.ReadOnly = true;
            this.book_image.Visible = false;
            // 
            // qty
            // 
            this.qty.HeaderText = "";
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Visible = false;
            // 
            // edit
            // 
            this.edit.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.edit.HeaderText = "";
            this.edit.Image = ((System.Drawing.Image)(resources.GetObject("edit.Image")));
            this.edit.Name = "edit";
            this.edit.ReadOnly = true;
            this.edit.Width = 5;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSave);
            this.groupBox1.Controls.Add(this.tboxCopies);
            this.groupBox1.Controls.Add(this.tbox_search);
            this.groupBox1.Controls.Add(this.tboxauthor);
            this.groupBox1.Controls.Add(this.tboxtitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tboxcallno);
            this.groupBox1.Controls.Add(this.tboxISBN);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 289);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(746, 263);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Details";
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(529, 227);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(114, 30);
            this.btnSave.TabIndex = 18;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tboxCopies
            // 
            this.tboxCopies.Enabled = false;
            this.tboxCopies.Location = new System.Drawing.Point(465, 139);
            this.tboxCopies.Name = "tboxCopies";
            this.tboxCopies.Size = new System.Drawing.Size(90, 25);
            this.tboxCopies.TabIndex = 17;
            // 
            // tbox_search
            // 
            // 
            // 
            // 
            this.tbox_search.CustomButton.Image = null;
            this.tbox_search.CustomButton.Location = new System.Drawing.Point(520, 2);
            this.tbox_search.CustomButton.Name = "";
            this.tbox_search.CustomButton.Size = new System.Drawing.Size(25, 25);
            this.tbox_search.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbox_search.CustomButton.TabIndex = 1;
            this.tbox_search.CustomButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.tbox_search.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbox_search.CustomButton.UseSelectable = true;
            this.tbox_search.CustomButton.Visible = false;
            this.tbox_search.DisplayIcon = true;
            this.tbox_search.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbox_search.ForeColor = System.Drawing.SystemColors.ControlText;
            this.tbox_search.Icon = ((System.Drawing.Image)(resources.GetObject("tbox_search.Icon")));
            this.tbox_search.Lines = new string[0];
            this.tbox_search.Location = new System.Drawing.Point(91, 24);
            this.tbox_search.MaxLength = 32767;
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.PasswordChar = '\0';
            this.tbox_search.PromptText = "Search";
            this.tbox_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbox_search.SelectedText = "";
            this.tbox_search.SelectionLength = 0;
            this.tbox_search.SelectionStart = 0;
            this.tbox_search.ShortcutsEnabled = true;
            this.tbox_search.Size = new System.Drawing.Size(548, 30);
            this.tbox_search.TabIndex = 3;
            this.tbox_search.UseSelectable = true;
            this.tbox_search.WaterMark = "Search";
            this.tbox_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbox_search.WaterMarkFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_search.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // tboxauthor
            // 
            this.tboxauthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxauthor.Enabled = false;
            this.tboxauthor.Location = new System.Drawing.Point(71, 194);
            this.tboxauthor.Margin = new System.Windows.Forms.Padding(2);
            this.tboxauthor.Multiline = true;
            this.tboxauthor.Name = "tboxauthor";
            this.tboxauthor.ReadOnly = true;
            this.tboxauthor.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxauthor.Size = new System.Drawing.Size(276, 50);
            this.tboxauthor.TabIndex = 14;
            // 
            // tboxtitle
            // 
            this.tboxtitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxtitle.Enabled = false;
            this.tboxtitle.Location = new System.Drawing.Point(71, 129);
            this.tboxtitle.Margin = new System.Windows.Forms.Padding(2);
            this.tboxtitle.Multiline = true;
            this.tboxtitle.Name = "tboxtitle";
            this.tboxtitle.ReadOnly = true;
            this.tboxtitle.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.tboxtitle.Size = new System.Drawing.Size(276, 50);
            this.tboxtitle.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(0, 134);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Book Title :";
            // 
            // tboxcallno
            // 
            this.tboxcallno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxcallno.Enabled = false;
            this.tboxcallno.Location = new System.Drawing.Point(71, 88);
            this.tboxcallno.Margin = new System.Windows.Forms.Padding(2);
            this.tboxcallno.Multiline = true;
            this.tboxcallno.Name = "tboxcallno";
            this.tboxcallno.ReadOnly = true;
            this.tboxcallno.Size = new System.Drawing.Size(133, 30);
            this.tboxcallno.TabIndex = 12;
            // 
            // tboxISBN
            // 
            this.tboxISBN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxISBN.Enabled = false;
            this.tboxISBN.Location = new System.Drawing.Point(465, 88);
            this.tboxISBN.Margin = new System.Windows.Forms.Padding(2);
            this.tboxISBN.Multiline = true;
            this.tboxISBN.Name = "tboxISBN";
            this.tboxISBN.ReadOnly = true;
            this.tboxISBN.Size = new System.Drawing.Size(276, 30);
            this.tboxISBN.TabIndex = 16;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(424, 93);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "ISBN :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1, 199);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Author(s) :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(376, 144);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 19);
            this.label9.TabIndex = 10;
            this.label9.Text = "No. of Copies :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Call No. :";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bookimage);
            this.panel2.Controls.Add(this.qrcode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(746, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(222, 526);
            this.panel2.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 251);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(103, 16);
            this.label10.TabIndex = 25;
            this.label10.Text = "QR Code Image :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Book Image :";
            // 
            // bookimage
            // 
            this.bookimage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookimage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.bookimage.Location = new System.Drawing.Point(6, 27);
            this.bookimage.Margin = new System.Windows.Forms.Padding(2);
            this.bookimage.Name = "bookimage";
            this.bookimage.Size = new System.Drawing.Size(206, 214);
            this.bookimage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bookimage.TabIndex = 23;
            this.bookimage.TabStop = false;
            // 
            // qrcode
            // 
            this.qrcode.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.qrcode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.qrcode.Location = new System.Drawing.Point(6, 269);
            this.qrcode.Margin = new System.Windows.Forms.Padding(2);
            this.qrcode.Name = "qrcode";
            this.qrcode.Size = new System.Drawing.Size(206, 210);
            this.qrcode.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.qrcode.TabIndex = 20;
            this.qrcode.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(968, 26);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(968, 26);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Acquired";
            // 
            // ellipseControlArtan1
            // 
            this.ellipseControlArtan1.CornerRadius = 20;
            this.ellipseControlArtan1.TargetControl = this;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Location = new System.Drawing.Point(649, 227);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(88, 30);
            this.btnClose.TabIndex = 19;
            this.btnClose.Text = "Cancel";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Visible = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frm_BookAcquired
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(970, 575);
            this.ControlBox = false;
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_BookAcquired";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_BookList_Load);
            this.toppanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tboxCopies)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrcode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox qrcode;
        private System.Windows.Forms.TextBox tboxcallno;
        private System.Windows.Forms.TextBox tboxauthor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tboxISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxtitle;
        private System.Windows.Forms.PictureBox bookimage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox tbox_search;
        private System.Windows.Forms.DataGridView booksGridView;
        private System.Windows.Forms.NumericUpDown tboxCopies;
        private System.Windows.Forms.Button btnSave;
        private Class.EllipseControlArtan ellipseControlArtan1;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn accessionNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Call_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewImageColumn qr_code;
        private System.Windows.Forms.DataGridViewImageColumn book_image;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewImageColumn edit;
        private System.Windows.Forms.Button btnClose;
    }
}