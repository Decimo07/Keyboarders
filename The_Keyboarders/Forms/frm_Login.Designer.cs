namespace The_Keyboarders
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.showpassword = new System.Windows.Forms.CheckBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.tbox_password = new MetroFramework.Controls.MetroTextBox();
            this.tbox_username = new MetroFramework.Controls.MetroTextBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // showpassword
            // 
            this.showpassword.AutoSize = true;
            this.showpassword.CheckAlign = System.Drawing.ContentAlignment.TopLeft;
            this.showpassword.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.showpassword.Location = new System.Drawing.Point(233, 47);
            this.showpassword.Margin = new System.Windows.Forms.Padding(2);
            this.showpassword.Name = "showpassword";
            this.showpassword.Size = new System.Drawing.Size(113, 23);
            this.showpassword.TabIndex = 3;
            this.showpassword.Text = "Show password";
            this.showpassword.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.showpassword.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.showpassword.UseVisualStyleBackColor = true;
            this.showpassword.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btn_login
            // 
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.Font = new System.Drawing.Font("Poppins", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(452, 22);
            this.btn_login.Margin = new System.Windows.Forms.Padding(2);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(110, 23);
            this.btn_login.TabIndex = 4;
            this.btn_login.Text = "Login";
            this.btn_login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_login.UseVisualStyleBackColor = true;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(573, 111);
            this.panel1.TabIndex = 17;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.tbox_password);
            this.panel4.Controls.Add(this.tbox_username);
            this.panel4.Controls.Add(this.linkLabel2);
            this.panel4.Controls.Add(this.showpassword);
            this.panel4.Controls.Add(this.btn_login);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 33);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(573, 78);
            this.panel4.TabIndex = 24;
            // 
            // tbox_password
            // 
            // 
            // 
            // 
            this.tbox_password.CustomButton.Image = null;
            this.tbox_password.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.tbox_password.CustomButton.Name = "";
            this.tbox_password.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbox_password.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbox_password.CustomButton.TabIndex = 1;
            this.tbox_password.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbox_password.CustomButton.UseSelectable = true;
            this.tbox_password.CustomButton.Visible = false;
            this.tbox_password.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbox_password.Lines = new string[0];
            this.tbox_password.Location = new System.Drawing.Point(233, 22);
            this.tbox_password.MaxLength = 32767;
            this.tbox_password.Name = "tbox_password";
            this.tbox_password.PasswordChar = '●';
            this.tbox_password.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbox_password.SelectedText = "";
            this.tbox_password.SelectionLength = 0;
            this.tbox_password.SelectionStart = 0;
            this.tbox_password.ShortcutsEnabled = true;
            this.tbox_password.Size = new System.Drawing.Size(214, 23);
            this.tbox_password.TabIndex = 27;
            this.tbox_password.UseSelectable = true;
            this.tbox_password.UseSystemPasswordChar = true;
            this.tbox_password.WaterMark = "Password*";
            this.tbox_password.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbox_password.WaterMarkFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // tbox_username
            // 
            // 
            // 
            // 
            this.tbox_username.CustomButton.Image = null;
            this.tbox_username.CustomButton.Location = new System.Drawing.Point(192, 1);
            this.tbox_username.CustomButton.Name = "";
            this.tbox_username.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tbox_username.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tbox_username.CustomButton.TabIndex = 1;
            this.tbox_username.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tbox_username.CustomButton.UseSelectable = true;
            this.tbox_username.CustomButton.Visible = false;
            this.tbox_username.FontWeight = MetroFramework.MetroTextBoxWeight.Light;
            this.tbox_username.Lines = new string[0];
            this.tbox_username.Location = new System.Drawing.Point(13, 22);
            this.tbox_username.MaxLength = 32767;
            this.tbox_username.Name = "tbox_username";
            this.tbox_username.PasswordChar = '\0';
            this.tbox_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tbox_username.SelectedText = "";
            this.tbox_username.SelectionLength = 0;
            this.tbox_username.SelectionStart = 0;
            this.tbox_username.ShortcutsEnabled = true;
            this.tbox_username.Size = new System.Drawing.Size(214, 23);
            this.tbox_username.TabIndex = 26;
            this.tbox_username.UseSelectable = true;
            this.tbox_username.WaterMark = "Username*";
            this.tbox_username.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.tbox_username.WaterMarkFont = new System.Drawing.Font("Poppins", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel2.Location = new System.Drawing.Point(9, 48);
            this.linkLabel2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(105, 19);
            this.linkLabel2.TabIndex = 25;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Forgot Password?";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(573, 33);
            this.panel3.TabIndex = 23;
            this.panel3.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel3_MouseDown);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 25);
            this.label1.TabIndex = 23;
            this.label1.Text = "CLCMS Library System";
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(551, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click_1);
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(573, 111);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "   ";
            this.panel1.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.CheckBox showpassword;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private MetroFramework.Controls.MetroTextBox tbox_password;
        private MetroFramework.Controls.MetroTextBox tbox_username;
        private System.Windows.Forms.Label label1;
    }
}