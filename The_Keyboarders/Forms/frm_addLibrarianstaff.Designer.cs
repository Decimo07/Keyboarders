namespace The_Keyboarders
{
    partial class frm_addLibrarianstaff
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_addLibrarianstaff));
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btncancel = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.tboxIDNumber = new MetroFramework.Controls.MetroTextBox();
            this.tboxFname = new MetroFramework.Controls.MetroTextBox();
            this.tboxMname = new MetroFramework.Controls.MetroTextBox();
            this.tboxLname = new MetroFramework.Controls.MetroTextBox();
            this.tboxUsername = new MetroFramework.Controls.MetroTextBox();
            this.tboxPassword = new MetroFramework.Controls.MetroTextBox();
            this.metroTextBox1 = new MetroFramework.Controls.MetroTextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Silver;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(478, 22);
            this.panel3.TabIndex = 57;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Right;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(456, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(20, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 22;
            this.pictureBox2.TabStop = false;
            // 
            // btncancel
            // 
            this.btncancel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncancel.Location = new System.Drawing.Point(348, 461);
            this.btncancel.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btncancel.Name = "btncancel";
            this.btncancel.Size = new System.Drawing.Size(93, 31);
            this.btncancel.TabIndex = 56;
            this.btncancel.Text = "Cancel";
            this.btncancel.UseVisualStyleBackColor = true;
            // 
            // btnsave
            // 
            this.btnsave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsave.Location = new System.Drawing.Point(237, 461);
            this.btnsave.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(93, 31);
            this.btnsave.TabIndex = 55;
            this.btnsave.Text = "Save";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(156, 23);
            this.label4.TabIndex = 58;
            this.label4.Text = "Add Librarian Staff";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // tboxIDNumber
            // 
            // 
            // 
            // 
            this.tboxIDNumber.CustomButton.Image = null;
            this.tboxIDNumber.CustomButton.Location = new System.Drawing.Point(384, 1);
            this.tboxIDNumber.CustomButton.Name = "";
            this.tboxIDNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tboxIDNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tboxIDNumber.CustomButton.TabIndex = 1;
            this.tboxIDNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tboxIDNumber.CustomButton.UseSelectable = true;
            this.tboxIDNumber.CustomButton.Visible = false;
            this.tboxIDNumber.Lines = new string[0];
            this.tboxIDNumber.Location = new System.Drawing.Point(35, 92);
            this.tboxIDNumber.MaxLength = 32767;
            this.tboxIDNumber.Name = "tboxIDNumber";
            this.tboxIDNumber.PasswordChar = '\0';
            this.tboxIDNumber.PromptText = "Employee ID Number*";
            this.tboxIDNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxIDNumber.SelectedText = "";
            this.tboxIDNumber.SelectionLength = 0;
            this.tboxIDNumber.SelectionStart = 0;
            this.tboxIDNumber.ShortcutsEnabled = true;
            this.tboxIDNumber.Size = new System.Drawing.Size(406, 23);
            this.tboxIDNumber.TabIndex = 61;
            this.tboxIDNumber.UseSelectable = true;
            this.tboxIDNumber.WaterMark = "Employee ID Number*";
            this.tboxIDNumber.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.tboxIDNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tboxFname
            // 
            // 
            // 
            // 
            this.tboxFname.CustomButton.Image = null;
            this.tboxFname.CustomButton.Location = new System.Drawing.Point(384, 1);
            this.tboxFname.CustomButton.Name = "";
            this.tboxFname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tboxFname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tboxFname.CustomButton.TabIndex = 1;
            this.tboxFname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tboxFname.CustomButton.UseSelectable = true;
            this.tboxFname.CustomButton.Visible = false;
            this.tboxFname.Lines = new string[0];
            this.tboxFname.Location = new System.Drawing.Point(35, 130);
            this.tboxFname.MaxLength = 32767;
            this.tboxFname.Name = "tboxFname";
            this.tboxFname.PasswordChar = '\0';
            this.tboxFname.PromptText = "First Name*";
            this.tboxFname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxFname.SelectedText = "";
            this.tboxFname.SelectionLength = 0;
            this.tboxFname.SelectionStart = 0;
            this.tboxFname.ShortcutsEnabled = true;
            this.tboxFname.Size = new System.Drawing.Size(406, 23);
            this.tboxFname.TabIndex = 62;
            this.tboxFname.UseSelectable = true;
            this.tboxFname.WaterMark = "First Name*";
            this.tboxFname.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.tboxFname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tboxMname
            // 
            // 
            // 
            // 
            this.tboxMname.CustomButton.Image = null;
            this.tboxMname.CustomButton.Location = new System.Drawing.Point(384, 1);
            this.tboxMname.CustomButton.Name = "";
            this.tboxMname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tboxMname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tboxMname.CustomButton.TabIndex = 1;
            this.tboxMname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tboxMname.CustomButton.UseSelectable = true;
            this.tboxMname.CustomButton.Visible = false;
            this.tboxMname.Lines = new string[0];
            this.tboxMname.Location = new System.Drawing.Point(35, 170);
            this.tboxMname.MaxLength = 32767;
            this.tboxMname.Name = "tboxMname";
            this.tboxMname.PasswordChar = '\0';
            this.tboxMname.PromptText = "Middle Name";
            this.tboxMname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxMname.SelectedText = "";
            this.tboxMname.SelectionLength = 0;
            this.tboxMname.SelectionStart = 0;
            this.tboxMname.ShortcutsEnabled = true;
            this.tboxMname.Size = new System.Drawing.Size(406, 23);
            this.tboxMname.TabIndex = 63;
            this.tboxMname.UseSelectable = true;
            this.tboxMname.WaterMark = "Middle Name";
            this.tboxMname.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.tboxMname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tboxLname
            // 
            // 
            // 
            // 
            this.tboxLname.CustomButton.Image = null;
            this.tboxLname.CustomButton.Location = new System.Drawing.Point(384, 1);
            this.tboxLname.CustomButton.Name = "";
            this.tboxLname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tboxLname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tboxLname.CustomButton.TabIndex = 1;
            this.tboxLname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tboxLname.CustomButton.UseSelectable = true;
            this.tboxLname.CustomButton.Visible = false;
            this.tboxLname.Lines = new string[0];
            this.tboxLname.Location = new System.Drawing.Point(36, 209);
            this.tboxLname.MaxLength = 32767;
            this.tboxLname.Name = "tboxLname";
            this.tboxLname.PasswordChar = '\0';
            this.tboxLname.PromptText = "Last Name*";
            this.tboxLname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxLname.SelectedText = "";
            this.tboxLname.SelectionLength = 0;
            this.tboxLname.SelectionStart = 0;
            this.tboxLname.ShortcutsEnabled = true;
            this.tboxLname.Size = new System.Drawing.Size(406, 23);
            this.tboxLname.TabIndex = 64;
            this.tboxLname.UseSelectable = true;
            this.tboxLname.WaterMark = "Last Name*";
            this.tboxLname.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.tboxLname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tboxUsername
            // 
            // 
            // 
            // 
            this.tboxUsername.CustomButton.Image = null;
            this.tboxUsername.CustomButton.Location = new System.Drawing.Point(384, 1);
            this.tboxUsername.CustomButton.Name = "";
            this.tboxUsername.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tboxUsername.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tboxUsername.CustomButton.TabIndex = 1;
            this.tboxUsername.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tboxUsername.CustomButton.UseSelectable = true;
            this.tboxUsername.CustomButton.Visible = false;
            this.tboxUsername.Lines = new string[0];
            this.tboxUsername.Location = new System.Drawing.Point(35, 249);
            this.tboxUsername.MaxLength = 32767;
            this.tboxUsername.Name = "tboxUsername";
            this.tboxUsername.PasswordChar = '\0';
            this.tboxUsername.PromptText = "Username*";
            this.tboxUsername.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxUsername.SelectedText = "";
            this.tboxUsername.SelectionLength = 0;
            this.tboxUsername.SelectionStart = 0;
            this.tboxUsername.ShortcutsEnabled = true;
            this.tboxUsername.Size = new System.Drawing.Size(406, 23);
            this.tboxUsername.TabIndex = 65;
            this.tboxUsername.UseSelectable = true;
            this.tboxUsername.WaterMark = "Username*";
            this.tboxUsername.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.tboxUsername.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // tboxPassword
            // 
            // 
            // 
            // 
            this.tboxPassword.CustomButton.Image = null;
            this.tboxPassword.CustomButton.Location = new System.Drawing.Point(384, 1);
            this.tboxPassword.CustomButton.Name = "";
            this.tboxPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.tboxPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.tboxPassword.CustomButton.TabIndex = 1;
            this.tboxPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.tboxPassword.CustomButton.UseSelectable = true;
            this.tboxPassword.CustomButton.Visible = false;
            this.tboxPassword.Lines = new string[0];
            this.tboxPassword.Location = new System.Drawing.Point(35, 291);
            this.tboxPassword.MaxLength = 32767;
            this.tboxPassword.Name = "tboxPassword";
            this.tboxPassword.PasswordChar = '\0';
            this.tboxPassword.PromptText = "Password*";
            this.tboxPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tboxPassword.SelectedText = "";
            this.tboxPassword.SelectionLength = 0;
            this.tboxPassword.SelectionStart = 0;
            this.tboxPassword.ShortcutsEnabled = true;
            this.tboxPassword.Size = new System.Drawing.Size(406, 23);
            this.tboxPassword.TabIndex = 66;
            this.tboxPassword.UseSelectable = true;
            this.tboxPassword.WaterMark = "Password*";
            this.tboxPassword.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.tboxPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // metroTextBox1
            // 
            // 
            // 
            // 
            this.metroTextBox1.CustomButton.Image = null;
            this.metroTextBox1.CustomButton.Location = new System.Drawing.Point(384, 1);
            this.metroTextBox1.CustomButton.Name = "";
            this.metroTextBox1.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.metroTextBox1.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroTextBox1.CustomButton.TabIndex = 1;
            this.metroTextBox1.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroTextBox1.CustomButton.UseSelectable = true;
            this.metroTextBox1.CustomButton.Visible = false;
            this.metroTextBox1.Lines = new string[0];
            this.metroTextBox1.Location = new System.Drawing.Point(35, 331);
            this.metroTextBox1.MaxLength = 32767;
            this.metroTextBox1.Name = "metroTextBox1";
            this.metroTextBox1.PasswordChar = '\0';
            this.metroTextBox1.PromptText = "Confirm Password*";
            this.metroTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.metroTextBox1.SelectedText = "";
            this.metroTextBox1.SelectionLength = 0;
            this.metroTextBox1.SelectionStart = 0;
            this.metroTextBox1.ShortcutsEnabled = true;
            this.metroTextBox1.Size = new System.Drawing.Size(406, 23);
            this.metroTextBox1.TabIndex = 67;
            this.metroTextBox1.UseSelectable = true;
            this.metroTextBox1.WaterMark = "Confirm Password*";
            this.metroTextBox1.WaterMarkColor = System.Drawing.Color.DarkGray;
            this.metroTextBox1.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // frm_addLibrarianstaff
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 521);
            this.Controls.Add(this.metroTextBox1);
            this.Controls.Add(this.tboxPassword);
            this.Controls.Add(this.tboxUsername);
            this.Controls.Add(this.tboxLname);
            this.Controls.Add(this.tboxMname);
            this.Controls.Add(this.tboxFname);
            this.Controls.Add(this.tboxIDNumber);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btncancel);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.label4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frm_addLibrarianstaff";
            this.Text = "frm_addLibrarianstaff";
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btncancel;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Label label4;
        private MetroFramework.Controls.MetroTextBox tboxIDNumber;
        private MetroFramework.Controls.MetroTextBox tboxFname;
        private MetroFramework.Controls.MetroTextBox tboxMname;
        private MetroFramework.Controls.MetroTextBox tboxLname;
        private MetroFramework.Controls.MetroTextBox tboxUsername;
        private MetroFramework.Controls.MetroTextBox tboxPassword;
        private MetroFramework.Controls.MetroTextBox metroTextBox1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}