namespace The_Keyboarders.Forms
{
    partial class frm_LookUpBorrower
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_LookUpBorrower));
            this.panel1 = new System.Windows.Forms.Panel();
            this.ellipseControlArtan1 = new The_Keyboarders.Class.EllipseControlArtan();
            this.ellipseControlArtan2 = new The_Keyboarders.Class.EllipseControlArtan();
            this.toppanel = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tbox_search = new MetroFramework.Controls.MetroTextBox();
            this.booksGridView = new System.Windows.Forms.DataGridView();
            this.book_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrower_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.borrower_name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.check = new System.Windows.Forms.DataGridViewImageColumn();
            this.panel1.SuspendLayout();
            this.toppanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(672, 450);
            this.panel1.TabIndex = 0;
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
            // toppanel
            // 
            this.toppanel.BackColor = System.Drawing.Color.Silver;
            this.toppanel.Controls.Add(this.pictureBox3);
            this.toppanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.toppanel.Location = new System.Drawing.Point(0, 0);
            this.toppanel.Margin = new System.Windows.Forms.Padding(2);
            this.toppanel.Name = "toppanel";
            this.toppanel.Size = new System.Drawing.Size(670, 18);
            this.toppanel.TabIndex = 111;
            this.toppanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.toppanel_MouseDown);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(650, 0);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(20, 18);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox3.TabIndex = 23;
            this.pictureBox3.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbox_search);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Font = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 51);
            this.groupBox2.TabIndex = 112;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Borrower List";
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
            this.tbox_search.Location = new System.Drawing.Point(297, 21);
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
            // booksGridView
            // 
            this.booksGridView.AllowUserToAddRows = false;
            this.booksGridView.AllowUserToDeleteRows = false;
            this.booksGridView.BackgroundColor = System.Drawing.Color.White;
            this.booksGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.booksGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.booksGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.booksGridView.ColumnHeadersHeight = 30;
            this.booksGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.booksGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.book_id,
            this.borrower_id,
            this.borrower_name,
            this.type,
            this.check});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(39)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.booksGridView.DefaultCellStyle = dataGridViewCellStyle5;
            this.booksGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.booksGridView.EnableHeadersVisualStyles = false;
            this.booksGridView.GridColor = System.Drawing.SystemColors.Info;
            this.booksGridView.Location = new System.Drawing.Point(0, 69);
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
            this.booksGridView.Size = new System.Drawing.Size(670, 379);
            this.booksGridView.TabIndex = 113;
            this.booksGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.booksGridView_CellContentClick);
            // 
            // book_id
            // 
            this.book_id.HeaderText = "";
            this.book_id.Name = "book_id";
            this.book_id.ReadOnly = true;
            this.book_id.Visible = false;
            // 
            // borrower_id
            // 
            this.borrower_id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.borrower_id.HeaderText = "Borrower ID #";
            this.borrower_id.Name = "borrower_id";
            this.borrower_id.ReadOnly = true;
            this.borrower_id.Width = 107;
            // 
            // borrower_name
            // 
            this.borrower_name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.borrower_name.HeaderText = "Borrower Name";
            this.borrower_name.Name = "borrower_name";
            this.borrower_name.ReadOnly = true;
            // 
            // type
            // 
            this.type.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.type.HeaderText = "Type";
            this.type.Name = "type";
            this.type.ReadOnly = true;
            this.type.Width = 58;
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
            // frm_LookUpBorrower
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(672, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frm_LookUpBorrower";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.toppanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.booksGridView)).EndInit();
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
        private System.Windows.Forms.DataGridViewTextBoxColumn borrower_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn borrower_name;
        private System.Windows.Forms.DataGridViewTextBoxColumn type;
        private System.Windows.Forms.DataGridViewImageColumn check;
    }
}