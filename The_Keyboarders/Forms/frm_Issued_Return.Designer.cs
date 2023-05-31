namespace The_Keyboarders
{
    partial class frm_Issued_Return
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Issued_Return));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.LinkLabel();
            this.label15 = new System.Windows.Forms.Label();
            this.btnScan = new System.Windows.Forms.Button();
            this.btnLookUpbook = new System.Windows.Forms.Button();
            this.tboxcallno = new System.Windows.Forms.TextBox();
            this.tboxtitle = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.tboxaccessionno = new System.Windows.Forms.TextBox();
            this.btnborrow = new System.Windows.Forms.Button();
            this.tboxauthor = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tboxisbn = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lbltransno = new System.Windows.Forms.Label();
            this.tboxType = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.tboxBorrower = new System.Windows.Forms.TextBox();
            this.tboxfname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxPenalty = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tboxaddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.tboxcontactnumber = new System.Windows.Forms.TextBox();
            this.btnLookUpborrower = new System.Windows.Forms.Button();
            this.toppanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblPenalty = new System.Windows.Forms.Label();
            this.lbldaysallowed = new System.Windows.Forms.Label();
            this.lblMaxAllowed = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.transno = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accession_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date_borrowed = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.due_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.penalty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuedby = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.extend = new System.Windows.Forms.DataGridViewImageColumn();
            this.returnbook = new System.Windows.Forms.DataGridViewImageColumn();
            this.ellipseControlArtan1 = new The_Keyboarders.Class.EllipseControlArtan();
            this.mainpanel.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainpanel
            // 
            this.mainpanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainpanel.Controls.Add(this.groupBox2);
            this.mainpanel.Controls.Add(this.groupBox1);
            this.mainpanel.Controls.Add(this.toppanel);
            this.mainpanel.Controls.Add(this.panel1);
            this.mainpanel.Controls.Add(this.booksGridView);
            this.mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainpanel.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainpanel.Location = new System.Drawing.Point(0, 0);
            this.mainpanel.Margin = new System.Windows.Forms.Padding(2);
            this.mainpanel.Name = "mainpanel";
            this.mainpanel.Size = new System.Drawing.Size(1086, 561);
            this.mainpanel.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.btnCancel);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.btnScan);
            this.groupBox2.Controls.Add(this.btnLookUpbook);
            this.groupBox2.Controls.Add(this.tboxcallno);
            this.groupBox2.Controls.Add(this.tboxtitle);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.tboxaccessionno);
            this.groupBox2.Controls.Add(this.btnborrow);
            this.groupBox2.Controls.Add(this.tboxauthor);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.tboxisbn);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(542, 21);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(542, 304);
            this.groupBox2.TabIndex = 110;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Details :";
            // 
            // label18
            // 
            this.label18.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Transparent;
            this.label18.Font = new System.Drawing.Font("Poppins", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(453, 259);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(20, 17);
            this.label18.TabIndex = 53;
            this.label18.Text = "or";
            // 
            // btnCancel
            // 
            this.btnCancel.AutoSize = true;
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.Enabled = false;
            this.btnCancel.Font = new System.Drawing.Font("Poppins", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.LinkColor = System.Drawing.Color.Red;
            this.btnCancel.Location = new System.Drawing.Point(391, 276);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(145, 17);
            this.btnCancel.TabIndex = 52;
            this.btnCancel.TabStop = true;
            this.btnCancel.Text = "Cancel Current Transaction";
            this.btnCancel.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.btnCancel_LinkClicked);
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Poppins", 7F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(400, 41);
            this.label15.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(20, 17);
            this.label15.TabIndex = 51;
            this.label15.Text = "or";
            // 
            // btnScan
            // 
            this.btnScan.BackColor = System.Drawing.Color.Transparent;
            this.btnScan.FlatAppearance.BorderSize = 0;
            this.btnScan.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnScan.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnScan.Font = new System.Drawing.Font("Poppins", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScan.ForeColor = System.Drawing.Color.Black;
            this.btnScan.Image = ((System.Drawing.Image)(resources.GetObject("btnScan.Image")));
            this.btnScan.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnScan.Location = new System.Drawing.Point(431, 37);
            this.btnScan.Margin = new System.Windows.Forms.Padding(2);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(83, 21);
            this.btnScan.TabIndex = 44;
            this.btnScan.Text = "  Scan QR Code";
            this.btnScan.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnScan.UseVisualStyleBackColor = false;
            // 
            // btnLookUpbook
            // 
            this.btnLookUpbook.BackColor = System.Drawing.Color.Transparent;
            this.btnLookUpbook.FlatAppearance.BorderSize = 0;
            this.btnLookUpbook.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLookUpbook.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLookUpbook.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookUpbook.Font = new System.Drawing.Font("Poppins", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookUpbook.ForeColor = System.Drawing.Color.Black;
            this.btnLookUpbook.Image = ((System.Drawing.Image)(resources.GetObject("btnLookUpbook.Image")));
            this.btnLookUpbook.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLookUpbook.Location = new System.Drawing.Point(291, 37);
            this.btnLookUpbook.Margin = new System.Windows.Forms.Padding(2);
            this.btnLookUpbook.Name = "btnLookUpbook";
            this.btnLookUpbook.Size = new System.Drawing.Size(105, 21);
            this.btnLookUpbook.TabIndex = 23;
            this.btnLookUpbook.Text = "  Lookup Books";
            this.btnLookUpbook.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLookUpbook.UseVisualStyleBackColor = false;
            // 
            // tboxcallno
            // 
            this.tboxcallno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxcallno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxcallno.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxcallno.Location = new System.Drawing.Point(118, 38);
            this.tboxcallno.Margin = new System.Windows.Forms.Padding(2);
            this.tboxcallno.Name = "tboxcallno";
            this.tboxcallno.Size = new System.Drawing.Size(155, 24);
            this.tboxcallno.TabIndex = 30;
            this.tboxcallno.TextChanged += new System.EventHandler(this.tboxaccession_TextChanged);
            // 
            // tboxtitle
            // 
            this.tboxtitle.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxtitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxtitle.Enabled = false;
            this.tboxtitle.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxtitle.Location = new System.Drawing.Point(118, 125);
            this.tboxtitle.Margin = new System.Windows.Forms.Padding(2);
            this.tboxtitle.Name = "tboxtitle";
            this.tboxtitle.Size = new System.Drawing.Size(323, 24);
            this.tboxtitle.TabIndex = 31;
            // 
            // label16
            // 
            this.label16.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(47, 123);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(67, 19);
            this.label16.TabIndex = 24;
            this.label16.Text = "Book Title :";
            // 
            // tboxaccessionno
            // 
            this.tboxaccessionno.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxaccessionno.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxaccessionno.Enabled = false;
            this.tboxaccessionno.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxaccessionno.Location = new System.Drawing.Point(118, 67);
            this.tboxaccessionno.Margin = new System.Windows.Forms.Padding(2);
            this.tboxaccessionno.Name = "tboxaccessionno";
            this.tboxaccessionno.Size = new System.Drawing.Size(323, 24);
            this.tboxaccessionno.TabIndex = 43;
            // 
            // btnborrow
            // 
            this.btnborrow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnborrow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnborrow.Enabled = false;
            this.btnborrow.FlatAppearance.BorderSize = 0;
            this.btnborrow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnborrow.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnborrow.ForeColor = System.Drawing.Color.White;
            this.btnborrow.Location = new System.Drawing.Point(395, 225);
            this.btnborrow.Margin = new System.Windows.Forms.Padding(2);
            this.btnborrow.Name = "btnborrow";
            this.btnborrow.Size = new System.Drawing.Size(130, 31);
            this.btnborrow.TabIndex = 21;
            this.btnborrow.Text = "Issue Book";
            this.btnborrow.UseVisualStyleBackColor = false;
            this.btnborrow.Click += new System.EventHandler(this.btnborrow_Click);
            // 
            // tboxauthor
            // 
            this.tboxauthor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxauthor.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxauthor.Enabled = false;
            this.tboxauthor.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxauthor.Location = new System.Drawing.Point(118, 153);
            this.tboxauthor.Margin = new System.Windows.Forms.Padding(2);
            this.tboxauthor.Name = "tboxauthor";
            this.tboxauthor.Size = new System.Drawing.Size(323, 24);
            this.tboxauthor.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(67, 41);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 19);
            this.label9.TabIndex = 42;
            this.label9.Text = "Call # :";
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(76, 99);
            this.label11.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(38, 19);
            this.label11.TabIndex = 23;
            this.label11.Text = "ISBN :";
            // 
            // tboxisbn
            // 
            this.tboxisbn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tboxisbn.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxisbn.Enabled = false;
            this.tboxisbn.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxisbn.Location = new System.Drawing.Point(118, 96);
            this.tboxisbn.Margin = new System.Windows.Forms.Padding(2);
            this.tboxisbn.Name = "tboxisbn";
            this.tboxisbn.Size = new System.Drawing.Size(323, 24);
            this.tboxisbn.TabIndex = 41;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(64, 154);
            this.label10.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 19);
            this.label10.TabIndex = 26;
            this.label10.Text = "Author :";
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 70);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 19);
            this.label8.TabIndex = 40;
            this.label8.Text = "Accession # :";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lbltransno);
            this.groupBox1.Controls.Add(this.tboxType);
            this.groupBox1.Controls.Add(this.label17);
            this.groupBox1.Controls.Add(this.tboxBorrower);
            this.groupBox1.Controls.Add(this.tboxfname);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tboxPenalty);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tboxaddress);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tboxcontactnumber);
            this.groupBox1.Controls.Add(this.btnLookUpborrower);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(542, 304);
            this.groupBox1.TabIndex = 109;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Borrower Details";
            // 
            // lbltransno
            // 
            this.lbltransno.AutoSize = true;
            this.lbltransno.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbltransno.Location = new System.Drawing.Point(14, 282);
            this.lbltransno.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbltransno.Name = "lbltransno";
            this.lbltransno.Size = new System.Drawing.Size(0, 19);
            this.lbltransno.TabIndex = 54;
            this.lbltransno.Visible = false;
            // 
            // tboxType
            // 
            this.tboxType.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxType.Enabled = false;
            this.tboxType.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxType.Location = new System.Drawing.Point(112, 150);
            this.tboxType.Margin = new System.Windows.Forms.Padding(2);
            this.tboxType.Name = "tboxType";
            this.tboxType.Size = new System.Drawing.Size(323, 24);
            this.tboxType.TabIndex = 24;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(68, 153);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(40, 19);
            this.label17.TabIndex = 23;
            this.label17.Text = "Type :";
            // 
            // tboxBorrower
            // 
            this.tboxBorrower.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxBorrower.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxBorrower.Location = new System.Drawing.Point(112, 38);
            this.tboxBorrower.Margin = new System.Windows.Forms.Padding(2);
            this.tboxBorrower.Name = "tboxBorrower";
            this.tboxBorrower.Size = new System.Drawing.Size(198, 24);
            this.tboxBorrower.TabIndex = 12;
            this.tboxBorrower.TextChanged += new System.EventHandler(this.tboxBorrower_TextChanged);
            // 
            // tboxfname
            // 
            this.tboxfname.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxfname.Enabled = false;
            this.tboxfname.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxfname.Location = new System.Drawing.Point(112, 66);
            this.tboxfname.Margin = new System.Windows.Forms.Padding(2);
            this.tboxfname.Name = "tboxfname";
            this.tboxfname.Size = new System.Drawing.Size(323, 24);
            this.tboxfname.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 19);
            this.label4.TabIndex = 5;
            this.label4.Text = "Borrower Name :";
            // 
            // tboxPenalty
            // 
            this.tboxPenalty.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxPenalty.Enabled = false;
            this.tboxPenalty.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPenalty.Location = new System.Drawing.Point(112, 178);
            this.tboxPenalty.Margin = new System.Windows.Forms.Padding(2);
            this.tboxPenalty.Name = "tboxPenalty";
            this.tboxPenalty.Size = new System.Drawing.Size(323, 24);
            this.tboxPenalty.TabIndex = 16;
            this.tboxPenalty.Text = "0.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 181);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 19);
            this.label7.TabIndex = 8;
            this.label7.Text = "Penalty :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(38, 97);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 19);
            this.label5.TabIndex = 6;
            this.label5.Text = "Contact # :";
            // 
            // tboxaddress
            // 
            this.tboxaddress.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxaddress.Enabled = false;
            this.tboxaddress.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxaddress.Location = new System.Drawing.Point(112, 122);
            this.tboxaddress.Margin = new System.Windows.Forms.Padding(2);
            this.tboxaddress.Name = "tboxaddress";
            this.tboxaddress.Size = new System.Drawing.Size(323, 24);
            this.tboxaddress.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(19, 41);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "Borrower ID # :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(14, 125);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "Home Address :";
            // 
            // tboxcontactnumber
            // 
            this.tboxcontactnumber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tboxcontactnumber.Enabled = false;
            this.tboxcontactnumber.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxcontactnumber.Location = new System.Drawing.Point(112, 94);
            this.tboxcontactnumber.Margin = new System.Windows.Forms.Padding(2);
            this.tboxcontactnumber.Name = "tboxcontactnumber";
            this.tboxcontactnumber.Size = new System.Drawing.Size(323, 24);
            this.tboxcontactnumber.TabIndex = 14;
            // 
            // btnLookUpborrower
            // 
            this.btnLookUpborrower.BackColor = System.Drawing.Color.Transparent;
            this.btnLookUpborrower.FlatAppearance.BorderSize = 0;
            this.btnLookUpborrower.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnLookUpborrower.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnLookUpborrower.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLookUpborrower.Font = new System.Drawing.Font("Poppins", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLookUpborrower.ForeColor = System.Drawing.Color.Black;
            this.btnLookUpborrower.Image = ((System.Drawing.Image)(resources.GetObject("btnLookUpborrower.Image")));
            this.btnLookUpborrower.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLookUpborrower.Location = new System.Drawing.Point(314, 38);
            this.btnLookUpborrower.Margin = new System.Windows.Forms.Padding(2);
            this.btnLookUpborrower.Name = "btnLookUpborrower";
            this.btnLookUpborrower.Size = new System.Drawing.Size(167, 21);
            this.btnLookUpborrower.TabIndex = 22;
            this.btnLookUpborrower.Text = "  Lookup Students/ Faculty";
            this.btnLookUpborrower.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLookUpborrower.UseVisualStyleBackColor = false;
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.Silver;
            this.toppanel.Controls.Add(this.pictureBox3);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Margin = new System.Windows.Forms.Padding(2);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1084, 21);
            this.toppanel.TabIndex = 108;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(1064, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 21);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.lblPenalty);
            this.panel1.Controls.Add(this.lbldaysallowed);
            this.panel1.Controls.Add(this.lblMaxAllowed);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.label20);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 325);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1084, 28);
            this.panel1.TabIndex = 39;
            // 
            // lblPenalty
            // 
            this.lblPenalty.AutoSize = true;
            this.lblPenalty.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPenalty.Location = new System.Drawing.Point(565, 3);
            this.lblPenalty.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblPenalty.Name = "lblPenalty";
            this.lblPenalty.Size = new System.Drawing.Size(36, 19);
            this.lblPenalty.TabIndex = 53;
            this.lblPenalty.Text = "0.00";
            // 
            // lbldaysallowed
            // 
            this.lbldaysallowed.AutoSize = true;
            this.lbldaysallowed.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldaysallowed.Location = new System.Drawing.Point(431, 3);
            this.lbldaysallowed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbldaysallowed.Name = "lbldaysallowed";
            this.lbldaysallowed.Size = new System.Drawing.Size(17, 19);
            this.lbldaysallowed.TabIndex = 52;
            this.lbldaysallowed.Text = "0";
            // 
            // lblMaxAllowed
            // 
            this.lblMaxAllowed.AutoSize = true;
            this.lblMaxAllowed.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMaxAllowed.Location = new System.Drawing.Point(118, 2);
            this.lblMaxAllowed.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblMaxAllowed.Name = "lblMaxAllowed";
            this.lblMaxAllowed.Size = new System.Drawing.Size(17, 19);
            this.lblMaxAllowed.TabIndex = 51;
            this.lblMaxAllowed.Text = "0";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(874, 2);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 19);
            this.label1.TabIndex = 50;
            this.label1.Text = "Legend :";
            // 
            // label14
            // 
            this.label14.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(240, 3);
            this.label14.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(195, 19);
            this.label14.TabIndex = 44;
            this.label14.Text = "Number of day/s to be borrowed : ";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(1037, 2);
            this.label13.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(45, 19);
            this.label13.TabIndex = 49;
            this.label13.Text = "Return";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1016, 2);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(17, 16);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 47;
            this.pictureBox2.TabStop = false;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(951, 2);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(45, 19);
            this.label12.TabIndex = 48;
            this.label12.Text = "Extend";
            // 
            // label20
            // 
            this.label20.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(511, 3);
            this.label20.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(54, 19);
            this.label20.TabIndex = 44;
            this.label20.Text = "Penalty :";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(932, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(15, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 46;
            this.pictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 2);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 19);
            this.label2.TabIndex = 40;
            this.label2.Text = "Max Book Allowed :";
            // 
            // booksGridView
            // 
            this.booksGridView.AllowUserToAddRows = false;
            this.booksGridView.AllowUserToDeleteRows = false;
            this.booksGridView.BackgroundColor = System.Drawing.Color.White;
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
            this.transno,
            this.accession_no,
            this.column1,
            this.title,
            this.author,
            this.date_borrowed,
            this.due_date,
            this.penalty,
            this.issuedby,
            this.extend,
            this.returnbook});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.booksGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.booksGridView.EnableHeadersVisualStyles = false;
            this.booksGridView.GridColor = System.Drawing.SystemColors.Info;
            this.booksGridView.Location = new System.Drawing.Point(0, 353);
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
            this.booksGridView.Size = new System.Drawing.Size(1084, 206);
            this.booksGridView.TabIndex = 107;
            this.booksGridView.SelectionChanged += new System.EventHandler(this.booksGridView_SelectionChanged);
            // 
            // book_id
            // 
            this.book_id.HeaderText = "";
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Visible = false;
            // 
            // transno
            // 
            this.transno.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.transno.HeaderText = "#";
            this.transno.Name = "transno";
            this.transno.ReadOnly = true;
            this.transno.Width = 41;
            // 
            // accession_no
            // 
            this.accession_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.accession_no.HeaderText = "Accession #";
            this.accession_no.Name = "accession_no";
            this.accession_no.ReadOnly = true;
            this.accession_no.Width = 101;
            // 
            // column1
            // 
            this.column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.column1.HeaderText = "Call #";
            this.column1.Name = "column1";
            this.column1.ReadOnly = true;
            this.column1.Width = 65;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.HeaderText = "Title";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // author
            // 
            this.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.author.HeaderText = "Author";
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Width = 68;
            // 
            // date_borrowed
            // 
            this.date_borrowed.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.date_borrowed.HeaderText = "Date Borrowed";
            this.date_borrowed.Name = "date_borrowed";
            this.date_borrowed.ReadOnly = true;
            this.date_borrowed.Width = 113;
            // 
            // due_date
            // 
            this.due_date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.due_date.HeaderText = "Due Date";
            this.due_date.Name = "due_date";
            this.due_date.ReadOnly = true;
            this.due_date.Width = 83;
            // 
            // penalty
            // 
            this.penalty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.penalty.HeaderText = "Penalty";
            this.penalty.Name = "penalty";
            this.penalty.ReadOnly = true;
            this.penalty.Width = 72;
            // 
            // issuedby
            // 
            this.issuedby.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.issuedby.HeaderText = "Issued by";
            this.issuedby.Name = "issuedby";
            this.issuedby.ReadOnly = true;
            this.issuedby.Width = 84;
            // 
            // extend
            // 
            this.extend.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.extend.HeaderText = "";
            this.extend.Image = ((System.Drawing.Image)(resources.GetObject("extend.Image")));
            this.extend.Name = "extend";
            this.extend.ReadOnly = true;
            this.extend.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.extend.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.extend.Width = 17;
            // 
            // returnbook
            // 
            this.returnbook.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.returnbook.HeaderText = "";
            this.returnbook.Image = ((System.Drawing.Image)(resources.GetObject("returnbook.Image")));
            this.returnbook.Name = "returnbook";
            this.returnbook.ReadOnly = true;
            this.returnbook.Width = 5;
            // 
            // ellipseControlArtan1
            // 
            this.ellipseControlArtan1.CornerRadius = 20;
            this.ellipseControlArtan1.TargetControl = this;
            // 
            // frm_Issued_Return
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1086, 561);
            this.Controls.Add(this.mainpanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Issued_Return";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_BookList";
            this.Load += new System.EventHandler(this.frm_BookList_Load);
            this.mainpanel.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.toppanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.Button btnborrow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnLookUpborrower;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label14;
        private Class.EllipseControlArtan ellipseControlArtan1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnScan;
        private System.Windows.Forms.Button btnLookUpbook;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel btnCancel;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn transno;
        private System.Windows.Forms.DataGridViewTextBoxColumn accession_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn date_borrowed;
        private System.Windows.Forms.DataGridViewTextBoxColumn due_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn penalty;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuedby;
        private System.Windows.Forms.DataGridViewImageColumn extend;
        private System.Windows.Forms.DataGridViewImageColumn returnbook;
        public System.Windows.Forms.DataGridView booksGridView;
        public System.Windows.Forms.TextBox tboxBorrower;
        public System.Windows.Forms.TextBox tboxcontactnumber;
        public System.Windows.Forms.TextBox tboxaddress;
        public System.Windows.Forms.TextBox tboxPenalty;
        public System.Windows.Forms.TextBox tboxfname;
        public System.Windows.Forms.TextBox tboxcallno;
        public System.Windows.Forms.TextBox tboxauthor;
        public System.Windows.Forms.TextBox tboxtitle;
        public System.Windows.Forms.TextBox tboxaccessionno;
        public System.Windows.Forms.TextBox tboxisbn;
        public System.Windows.Forms.TextBox tboxType;
        public System.Windows.Forms.Label lbltransno;
        public System.Windows.Forms.Label lblPenalty;
        public System.Windows.Forms.Label lbldaysallowed;
        public System.Windows.Forms.Label lblMaxAllowed;
    }
}