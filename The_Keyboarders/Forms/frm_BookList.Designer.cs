namespace The_Keyboarders
{
    partial class frm_BookList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_BookList));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toppanel = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.mainpanel = new System.Windows.Forms.Panel();
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Call_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.author = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year_published = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isbn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisher = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.qr_code = new System.Windows.Forms.DataGridViewImageColumn();
            this.book_image = new System.Windows.Forms.DataGridViewImageColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tboxauthor = new System.Windows.Forms.TextBox();
            this.tboxtitle = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxcallno = new System.Windows.Forms.TextBox();
            this.tboxISBN = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tboxpub = new System.Windows.Forms.TextBox();
            this.tboxsubject = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tboxYP = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.bookimage = new System.Windows.Forms.PictureBox();
            this.qrcode = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbox_search = new MetroFramework.Controls.MetroTextBox();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.mainpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookimage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrcode)).BeginInit();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.Silver;
            this.toppanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toppanel.Controls.Add(this.pictureBox2);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Margin = new System.Windows.Forms.Padding(2);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(1062, 21);
            this.toppanel.TabIndex = 0;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseDown);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(1040, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 19);
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
            this.mainpanel.Size = new System.Drawing.Size(1062, 664);
            this.mainpanel.TabIndex = 1;
            // 
            // booksGridView
            // 
            this.booksGridView.AllowUserToAddRows = false;
            this.booksGridView.AllowUserToDeleteRows = false;
            this.booksGridView.AllowUserToResizeColumns = false;
            this.booksGridView.AllowUserToResizeRows = false;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.booksGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.booksGridView.BackgroundColor = System.Drawing.Color.White;
            this.booksGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.booksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.Call_No,
            this.title,
            this.author,
            this.year_published,
            this.isbn,
            this.subject,
            this.publisher,
            this.qty,
            this.qr_code,
            this.book_image});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.booksGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksGridView.GridColor = System.Drawing.Color.Black;
            this.booksGridView.Location = new System.Drawing.Point(0, 48);
            this.booksGridView.Margin = new System.Windows.Forms.Padding(2);
            this.booksGridView.Name = "booksGridView";
            this.booksGridView.ReadOnly = true;
            this.booksGridView.RowHeadersVisible = false;
            this.booksGridView.RowHeadersWidth = 51;
            this.booksGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.booksGridView.RowTemplate.Height = 23;
            this.booksGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.booksGridView.Size = new System.Drawing.Size(833, 357);
            this.booksGridView.TabIndex = 0;
            this.booksGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.booksGridView.SelectionChanged += new System.EventHandler(this.booksGridView_SelectionChanged);
            // 
            // book_id
            // 
            this.book_id.HeaderText = "ID";
            this.book_id.MinimumWidth = 6;
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Visible = false;
            this.book_id.Width = 125;
            // 
            // Call_No
            // 
            this.Call_No.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Call_No.HeaderText = "Call No";
            this.Call_No.MinimumWidth = 6;
            this.Call_No.Name = "Call_No";
            this.Call_No.ReadOnly = true;
            this.Call_No.Width = 72;
            // 
            // title
            // 
            this.title.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.title.HeaderText = "Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // author
            // 
            this.author.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.author.HeaderText = "Author";
            this.author.MinimumWidth = 6;
            this.author.Name = "author";
            this.author.ReadOnly = true;
            this.author.Width = 68;
            // 
            // year_published
            // 
            this.year_published.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.year_published.HeaderText = "Year Published";
            this.year_published.MinimumWidth = 6;
            this.year_published.Name = "year_published";
            this.year_published.ReadOnly = true;
            this.year_published.Width = 104;
            // 
            // isbn
            // 
            this.isbn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.isbn.HeaderText = "ISBN";
            this.isbn.MinimumWidth = 6;
            this.isbn.Name = "isbn";
            this.isbn.ReadOnly = true;
            this.isbn.Width = 56;
            // 
            // subject
            // 
            this.subject.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.subject.HeaderText = "Subject";
            this.subject.MinimumWidth = 6;
            this.subject.Name = "subject";
            this.subject.ReadOnly = true;
            this.subject.Width = 74;
            // 
            // publisher
            // 
            this.publisher.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.publisher.HeaderText = "Publisher";
            this.publisher.MinimumWidth = 6;
            this.publisher.Name = "publisher";
            this.publisher.ReadOnly = true;
            this.publisher.Width = 80;
            // 
            // qty
            // 
            this.qty.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qty.HeaderText = "Copies";
            this.qty.MinimumWidth = 6;
            this.qty.Name = "qty";
            this.qty.ReadOnly = true;
            this.qty.Width = 70;
            // 
            // qr_code
            // 
            this.qr_code.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.qr_code.HeaderText = "";
            this.qr_code.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.qr_code.MinimumWidth = 6;
            this.qr_code.Name = "qr_code";
            this.qr_code.ReadOnly = true;
            this.qr_code.Visible = false;
            // 
            // book_image
            // 
            this.book_image.HeaderText = "";
            this.book_image.MinimumWidth = 6;
            this.book_image.Name = "book_image";
            this.book_image.ReadOnly = true;
            this.book_image.Visible = false;
            this.book_image.Width = 125;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tboxauthor);
            this.groupBox1.Controls.Add(this.tboxtitle);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tboxcallno);
            this.groupBox1.Controls.Add(this.tboxISBN);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.tboxpub);
            this.groupBox1.Controls.Add(this.tboxsubject);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tboxYP);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox1.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(0, 405);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(833, 257);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Book Details";
            // 
            // tboxauthor
            // 
            this.tboxauthor.Enabled = false;
            this.tboxauthor.Location = new System.Drawing.Point(110, 89);
            this.tboxauthor.Margin = new System.Windows.Forms.Padding(2);
            this.tboxauthor.Multiline = true;
            this.tboxauthor.Name = "tboxauthor";
            this.tboxauthor.Size = new System.Drawing.Size(276, 20);
            this.tboxauthor.TabIndex = 14;
            // 
            // tboxtitle
            // 
            this.tboxtitle.Enabled = false;
            this.tboxtitle.Location = new System.Drawing.Point(110, 64);
            this.tboxtitle.Margin = new System.Windows.Forms.Padding(2);
            this.tboxtitle.Multiline = true;
            this.tboxtitle.Name = "tboxtitle";
            this.tboxtitle.Size = new System.Drawing.Size(276, 20);
            this.tboxtitle.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(61, 67);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Title :";
            // 
            // tboxcallno
            // 
            this.tboxcallno.Enabled = false;
            this.tboxcallno.Location = new System.Drawing.Point(110, 40);
            this.tboxcallno.Margin = new System.Windows.Forms.Padding(2);
            this.tboxcallno.Multiline = true;
            this.tboxcallno.Name = "tboxcallno";
            this.tboxcallno.Size = new System.Drawing.Size(276, 20);
            this.tboxcallno.TabIndex = 12;
            // 
            // tboxISBN
            // 
            this.tboxISBN.Enabled = false;
            this.tboxISBN.Location = new System.Drawing.Point(110, 138);
            this.tboxISBN.Margin = new System.Windows.Forms.Padding(2);
            this.tboxISBN.Multiline = true;
            this.tboxISBN.Name = "tboxISBN";
            this.tboxISBN.Size = new System.Drawing.Size(276, 20);
            this.tboxISBN.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(41, 164);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 16);
            this.label8.TabIndex = 9;
            this.label8.Text = "Subject :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(59, 140);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 16);
            this.label7.TabIndex = 8;
            this.label7.Text = "ISBN :";
            // 
            // tboxpub
            // 
            this.tboxpub.Enabled = false;
            this.tboxpub.Location = new System.Drawing.Point(110, 186);
            this.tboxpub.Margin = new System.Windows.Forms.Padding(2);
            this.tboxpub.Multiline = true;
            this.tboxpub.Name = "tboxpub";
            this.tboxpub.Size = new System.Drawing.Size(276, 20);
            this.tboxpub.TabIndex = 18;
            // 
            // tboxsubject
            // 
            this.tboxsubject.Enabled = false;
            this.tboxsubject.Location = new System.Drawing.Point(110, 162);
            this.tboxsubject.Margin = new System.Windows.Forms.Padding(2);
            this.tboxsubject.Multiline = true;
            this.tboxsubject.Name = "tboxsubject";
            this.tboxsubject.Size = new System.Drawing.Size(276, 20);
            this.tboxsubject.TabIndex = 17;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Author :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(5, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 16);
            this.label6.TabIndex = 7;
            this.label6.Text = "Year Published :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(35, 189);
            this.label9.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(61, 16);
            this.label9.TabIndex = 10;
            this.label9.Text = "Publisher :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 40);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Call No. :";
            // 
            // tboxYP
            // 
            this.tboxYP.Enabled = false;
            this.tboxYP.Location = new System.Drawing.Point(110, 113);
            this.tboxYP.Margin = new System.Windows.Forms.Padding(2);
            this.tboxYP.Multiline = true;
            this.tboxYP.Name = "tboxYP";
            this.tboxYP.Size = new System.Drawing.Size(276, 20);
            this.tboxYP.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.bookimage);
            this.panel2.Controls.Add(this.qrcode);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(833, 48);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 614);
            this.panel2.TabIndex = 25;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(8, 334);
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
            this.label1.Location = new System.Drawing.Point(8, 40);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 16);
            this.label1.TabIndex = 24;
            this.label1.Text = "Book Image :";
            // 
            // bookimage
            // 
            this.bookimage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.bookimage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.bookimage.Location = new System.Drawing.Point(11, 58);
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
            this.qrcode.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.qrcode.Location = new System.Drawing.Point(11, 352);
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
            this.panel1.Size = new System.Drawing.Size(1060, 48);
            this.panel1.TabIndex = 5;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbox_search);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 0);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1060, 48);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Book Acquired";
            // 
            // tbox_search
            // 
            // 
            // 
            // 
            this.tbox_search.CustomButton.Image = null;
            this.tbox_search.CustomButton.Location = new System.Drawing.Point(270, 1);
            this.tbox_search.CustomButton.Name = "";
            this.tbox_search.CustomButton.Size = new System.Drawing.Size(21, 21);
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
            this.tbox_search.Location = new System.Drawing.Point(757, 19);
            this.tbox_search.MaxLength = 32767;
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.PasswordChar = '\0';
            this.tbox_search.PromptText = "Search";
            this.tbox_search.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbox_search.SelectedText = "";
            this.tbox_search.SelectionLength = 0;
            this.tbox_search.SelectionStart = 0;
            this.tbox_search.ShortcutsEnabled = true;
            this.tbox_search.Size = new System.Drawing.Size(292, 23);
            this.tbox_search.TabIndex = 3;
            this.tbox_search.UseSelectable = true;
            this.tbox_search.WaterMark = "Search";
            this.tbox_search.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbox_search.WaterMarkFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbox_search.TextChanged += new System.EventHandler(this.metroTextBox1_TextChanged);
            // 
            // frm_BookList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1062, 685);
            this.ControlBox = false;
            this.Controls.Add(this.mainpanel);
            this.Controls.Add(this.toppanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_BookList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.frm_BookList_Load);
            this.toppanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.mainpanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookimage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qrcode)).EndInit();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel toppanel;
        private System.Windows.Forms.Panel mainpanel;
        private System.Windows.Forms.DataGridView booksGridView;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox qrcode;
        private System.Windows.Forms.TextBox tboxcallno;
        private System.Windows.Forms.TextBox tboxpub;
        private System.Windows.Forms.TextBox tboxauthor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tboxYP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tboxsubject;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tboxISBN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tboxtitle;
        private System.Windows.Forms.PictureBox bookimage;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn book_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Call_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewTextBoxColumn author;
        private System.Windows.Forms.DataGridViewTextBoxColumn year_published;
        private System.Windows.Forms.DataGridViewTextBoxColumn isbn;
        private System.Windows.Forms.DataGridViewTextBoxColumn subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisher;
        private System.Windows.Forms.DataGridViewTextBoxColumn qty;
        private System.Windows.Forms.DataGridViewImageColumn qr_code;
        private System.Windows.Forms.DataGridViewImageColumn book_image;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private MetroFramework.Controls.MetroTextBox tbox_search;
    }
}