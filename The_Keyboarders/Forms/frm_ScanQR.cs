using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using The_Keyboarders.Class;
using The_Keyboarders.Forms;
using System.Runtime.InteropServices;
using ZXing;
using ZXing.QrCode;
using System.Drawing;
using AForge.Video.DirectShow;
using AForge.Video;
using System.IO;
using AForge;
using ZXing.Aztec;

namespace The_Keyboarders.Forms
{
    public partial class frm_ScanQR : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        frm_Issued_Return frm;
        public frm_ScanQR(frm_Issued_Return forms)
        {
            frm = forms;
            InitializeComponent();
            ScanQr();
            
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        public void ScanQr()
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                comboBox1.Items.Add(Device.Name);

            comboBox1.SelectedItem = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void toppanel_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
          
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBoxCamera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void frm_ScanQR_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(FinalFrame.IsRunning == true)
            {
                FinalFrame.Stop();
            }
        }

        private void frm_ScanQR_Load(object sender, EventArgs e)
        {
            
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
                BarcodeReader reader = new BarcodeReader();
                Result result = reader.Decode((Bitmap)pictureBoxCamera.Image);
                try
                {
                    string decoded = result.ToString().Trim();
                    timer1.Stop();
                    if (decoded != "")
                    {
                        frm.tboxcallno.Text = decoded;
                        this.Dispose();
                    
                    }
                }
                catch (Exception)
                {

                }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
