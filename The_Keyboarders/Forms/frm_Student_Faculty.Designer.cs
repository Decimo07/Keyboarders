namespace The_Keyboarders
{
    partial class frm_Student_Faculty
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.buttom_panel = new System.Windows.Forms.Panel();
            this.bttn_close = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.mid_panel = new System.Windows.Forms.Panel();
            this.datagrid_SearchUser = new System.Windows.Forms.DataGridView();
            this.user_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id_no = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contact = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.l_book = new System.Windows.Forms.Label();
            this.top_panel = new System.Windows.Forms.Panel();
            this.tbox_search = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttom_panel.SuspendLayout();
            this.mid_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_SearchUser)).BeginInit();
            this.top_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttom_panel
            // 
            this.buttom_panel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttom_panel.Controls.Add(this.button1);
            this.buttom_panel.Controls.Add(this.bttn_close);
            this.buttom_panel.Controls.Add(this.btn_Add);
            this.buttom_panel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttom_panel.Location = new System.Drawing.Point(0, 551);
            this.buttom_panel.Name = "buttom_panel";
            this.buttom_panel.Size = new System.Drawing.Size(1143, 74);
            this.buttom_panel.TabIndex = 1;
            // 
            // bttn_close
            // 
            this.bttn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bttn_close.FlatAppearance.BorderSize = 0;
            this.bttn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bttn_close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bttn_close.Location = new System.Drawing.Point(1041, 8);
            this.bttn_close.Name = "bttn_close";
            this.bttn_close.Size = new System.Drawing.Size(99, 54);
            this.bttn_close.TabIndex = 3;
            this.bttn_close.Text = "[Close]";
            this.bttn_close.UseVisualStyleBackColor = true;
            this.bttn_close.Click += new System.EventHandler(this.bttn_close_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.FlatAppearance.BorderSize = 0;
            this.btn_Add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Add.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Add.Location = new System.Drawing.Point(5, 8);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(102, 54);
            this.btn_Add.TabIndex = 1;
            this.btn_Add.Text = "ADD Librarian";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // mid_panel
            // 
            this.mid_panel.Controls.Add(this.datagrid_SearchUser);
            this.mid_panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mid_panel.Location = new System.Drawing.Point(0, 137);
            this.mid_panel.Name = "mid_panel";
            this.mid_panel.Size = new System.Drawing.Size(1143, 414);
            this.mid_panel.TabIndex = 2;
            // 
            // datagrid_SearchUser
            // 
            this.datagrid_SearchUser.AllowUserToAddRows = false;
            this.datagrid_SearchUser.AllowUserToDeleteRows = false;
            this.datagrid_SearchUser.AllowUserToResizeColumns = false;
            this.datagrid_SearchUser.AllowUserToResizeRows = false;
            this.datagrid_SearchUser.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.datagrid_SearchUser.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.datagrid_SearchUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagrid_SearchUser.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.user_id,
            this.id_no,
            this.fullname,
            this.address,
            this.contact});
            this.datagrid_SearchUser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagrid_SearchUser.GridColor = System.Drawing.Color.Black;
            this.datagrid_SearchUser.Location = new System.Drawing.Point(0, 0);
            this.datagrid_SearchUser.Name = "datagrid_SearchUser";
            this.datagrid_SearchUser.ReadOnly = true;
            this.datagrid_SearchUser.RowHeadersVisible = false;
            this.datagrid_SearchUser.RowHeadersWidth = 51;
            this.datagrid_SearchUser.RowTemplate.Height = 24;
            this.datagrid_SearchUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagrid_SearchUser.Size = new System.Drawing.Size(1143, 414);
            this.datagrid_SearchUser.TabIndex = 0;
            this.datagrid_SearchUser.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagrid_SearchUser_CellContentClick);
            // 
            // user_id
            // 
            this.user_id.HeaderText = "ID";
            this.user_id.MinimumWidth = 6;
            this.user_id.Name = "user_id";
            this.user_id.ReadOnly = true;
            this.user_id.Visible = false;
            this.user_id.Width = 125;
            // 
            // id_no
            // 
            this.id_no.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id_no.HeaderText = "SCHOOL ID";
            this.id_no.MinimumWidth = 6;
            this.id_no.Name = "id_no";
            this.id_no.ReadOnly = true;
            this.id_no.Width = 112;
            // 
            // fullname
            // 
            this.fullname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.fullname.HeaderText = "FULLNAME";
            this.fullname.MinimumWidth = 6;
            this.fullname.Name = "fullname";
            this.fullname.ReadOnly = true;
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.HeaderText = "ADDRESS";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            // 
            // contact
            // 
            this.contact.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.contact.HeaderText = "CONTACT #";
            this.contact.MinimumWidth = 6;
            this.contact.Name = "contact";
            this.contact.ReadOnly = true;
            this.contact.Width = 115;
            // 
            // l_book
            // 
            this.l_book.AutoSize = true;
            this.l_book.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_book.Location = new System.Drawing.Point(3, 9);
            this.l_book.Name = "l_book";
            this.l_book.Padding = new System.Windows.Forms.Padding(10, 10, 0, 0);
            this.l_book.Size = new System.Drawing.Size(305, 38);
            this.l_book.TabIndex = 1;
            this.l_book.Text = "Faculty/Staff Information";
            this.l_book.Click += new System.EventHandler(this.l_book_Click);
            // 
            // top_panel
            // 
            this.top_panel.BackColor = System.Drawing.Color.White;
            this.top_panel.Controls.Add(this.tbox_search);
            this.top_panel.Controls.Add(this.label2);
            this.top_panel.Controls.Add(this.l_book);
            this.top_panel.Dock = System.Windows.Forms.DockStyle.Top;
            this.top_panel.Location = new System.Drawing.Point(0, 0);
            this.top_panel.Name = "top_panel";
            this.top_panel.Size = new System.Drawing.Size(1143, 137);
            this.top_panel.TabIndex = 0;
            // 
            // tbox_search
            // 
            this.tbox_search.Location = new System.Drawing.Point(186, 96);
            this.tbox_search.Name = "tbox_search";
            this.tbox_search.Size = new System.Drawing.Size(843, 22);
            this.tbox_search.TabIndex = 3;
            this.tbox_search.TextChanged += new System.EventHandler(this.tbox_search_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(114, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "SEARCH:";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe UI Light", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(195, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(98, 54);
            this.button1.TabIndex = 4;
            this.button1.Text = "ADD Librarian Staff";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frm_Student_Faculty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1143, 625);
            this.ControlBox = false;
            this.Controls.Add(this.mid_panel);
            this.Controls.Add(this.buttom_panel);
            this.Controls.Add(this.top_panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frm_Student_Faculty";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_AddUser";
            this.Load += new System.EventHandler(this.frm_AddUser_Load_1);
            this.buttom_panel.ResumeLayout(false);
            this.mid_panel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datagrid_SearchUser)).EndInit();
            this.top_panel.ResumeLayout(false);
            this.top_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel buttom_panel;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button bttn_close;
        private System.Windows.Forms.Panel mid_panel;
        private System.Windows.Forms.DataGridView datagrid_SearchUser;
        private System.Windows.Forms.Label l_book;
        private System.Windows.Forms.Panel top_panel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_search;
        private System.Windows.Forms.DataGridViewTextBoxColumn user_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_no;
        private System.Windows.Forms.DataGridViewTextBoxColumn fullname;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn contact;
        private System.Windows.Forms.Button button1;
    }
}