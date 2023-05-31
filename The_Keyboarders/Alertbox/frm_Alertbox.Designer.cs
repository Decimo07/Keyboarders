namespace The_Keyboarders.Alertbox
{
    partial class frm_Alertbox
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
            this.components = new System.ComponentModel.Container();
            this.lblTitleAlertBox = new System.Windows.Forms.Label();
            this.lblTextAlertBox = new System.Windows.Forms.Label();
            this.timerAnimation = new System.Windows.Forms.Timer(this.components);
            this.LineAlertBox = new System.Windows.Forms.Panel();
            this.picAlertbox = new System.Windows.Forms.PictureBox();
            this.ellipseControlArtan1 = new The_Keyboarders.Class.EllipseControlArtan();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picAlertbox)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitleAlertBox
            // 
            this.lblTitleAlertBox.AutoSize = true;
            this.lblTitleAlertBox.Font = new System.Drawing.Font("Poppins", 10.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitleAlertBox.Location = new System.Drawing.Point(80, 16);
            this.lblTitleAlertBox.Name = "lblTitleAlertBox";
            this.lblTitleAlertBox.Size = new System.Drawing.Size(109, 25);
            this.lblTitleAlertBox.TabIndex = 1;
            this.lblTitleAlertBox.Text = "TitleAlertBox";
            // 
            // lblTextAlertBox
            // 
            this.lblTextAlertBox.AutoSize = true;
            this.lblTextAlertBox.Location = new System.Drawing.Point(81, 41);
            this.lblTextAlertBox.Name = "lblTextAlertBox";
            this.lblTextAlertBox.Size = new System.Drawing.Size(75, 19);
            this.lblTextAlertBox.TabIndex = 2;
            this.lblTextAlertBox.Text = "TextAlertBox";
            // 
            // timerAnimation
            // 
            this.timerAnimation.Interval = 1;
            this.timerAnimation.Tick += new System.EventHandler(this.timerAnimation_Tick);
            // 
            // LineAlertBox
            // 
            this.LineAlertBox.BackColor = System.Drawing.Color.Black;
            this.LineAlertBox.Location = new System.Drawing.Point(0, 68);
            this.LineAlertBox.Name = "LineAlertBox";
            this.LineAlertBox.Size = new System.Drawing.Size(5, 6);
            this.LineAlertBox.TabIndex = 3;
            // 
            // picAlertbox
            // 
            this.picAlertbox.Location = new System.Drawing.Point(24, 12);
            this.picAlertbox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.picAlertbox.Name = "picAlertbox";
            this.picAlertbox.Size = new System.Drawing.Size(50, 50);
            this.picAlertbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picAlertbox.TabIndex = 0;
            this.picAlertbox.TabStop = false;
            // 
            // ellipseControlArtan1
            // 
            this.ellipseControlArtan1.CornerRadius = 20;
            this.ellipseControlArtan1.TargetControl = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(338, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 19);
            this.label1.TabIndex = 5;
            this.label1.Text = "label1";
            this.label1.Visible = false;
            // 
            // frm_Alertbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(422, 75);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.LineAlertBox);
            this.Controls.Add(this.lblTextAlertBox);
            this.Controls.Add(this.lblTitleAlertBox);
            this.Controls.Add(this.picAlertbox);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frm_Alertbox";
            this.Text = "frm_Alertbox";
            this.Load += new System.EventHandler(this.frm_Alertbox_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAlertbox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox picAlertbox;
        private System.Windows.Forms.Label lblTitleAlertBox;
        private System.Windows.Forms.Label lblTextAlertBox;
        private System.Windows.Forms.Timer timerAnimation;
        private Class.EllipseControlArtan ellipseControlArtan1;
        public System.Windows.Forms.Panel LineAlertBox;
        private System.Windows.Forms.Label label1;
    }
}