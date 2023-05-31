using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace The_Keyboarders.Alertbox
{
    public partial class frm_Alertbox : Form
    {
        int counter = 100;
        public frm_Alertbox()
        {
            InitializeComponent();
            
        }
        public Color BackColorAlertBox
        {
            get { return BackColor; }
            set { BackColor = value; }
        }
        public Color ColorAlertBox
        {
            get { return LineAlertBox.BackColor; }
            set { LineAlertBox.BackColor = lblTitleAlertBox.ForeColor = lblTextAlertBox.ForeColor = value; }
        }

        public Image IconeAlertBox
        {
            get { return picAlertbox.Image; }
            set { picAlertbox.Image = value; }
        }

        public string TitleAlertBox
        {
            get { return lblTitleAlertBox.Text; }
            set { lblTitleAlertBox.Text = value; }
        }

        public string TextAlertBox
        {
            get { return lblTextAlertBox.Text; }
            set { lblTextAlertBox.Text = value; }
        }

        private void PositionAlertBox()
        {
            int xPos = 0; int yPos = 0;
            xPos = Screen.GetWorkingArea(this).Width;
            yPos = Screen.GetWorkingArea(this).Height;
            Location = new Point(xPos - this.Width, yPos - this.Height);
        }
        private void timerAnimation_Tick(object sender, EventArgs e)
        {
            LineAlertBox.Width = LineAlertBox.Width + 5;
            counter--;
            if (counter == 0)
            {
                timerAnimation.Stop();
                this.Dispose();
            }
            label1.Text = counter.ToString();
        }

        private void frm_Alertbox_Load(object sender, EventArgs e)
        {

            PositionAlertBox();
            timerAnimation.Start();
            label1.Text = counter.ToString();

        }
    }
}
