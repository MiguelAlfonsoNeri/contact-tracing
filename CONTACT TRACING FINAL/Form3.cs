using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using AForge;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using ZXing.Aztec;

namespace CONTACT_TRACING_FINAL
{
    public partial class Form3 : Form
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
                cmb.Items.Add(Device.Name);

            cmb.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
        }

        private void Btnstart_Click(object sender, EventArgs e)
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[cmb.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
            timerscanner.Start();
        }
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pcbox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Form3_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (FinalFrame.IsRunning)
                FinalFrame.Stop();
        }

        private void timerscanner_Tick(object sender, EventArgs e)
        {
            timelblf3.Text = DateTime.Now.ToLongTimeString();
            datelblf3.Text = DateTime.Now.ToLongDateString();
            if (pcbox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pcbox.Image);
                if (result != null)
                { 
                    qrtxbx.Text = result.ToString();
                    timerscanner.Stop();
                }
            }
        }

        private void Btnread_Click(object sender, EventArgs e)
        {
            String DATA = qrtxbx.Text;
            if (DATA != "")
            {
                StreamWriter qrdata = new StreamWriter(@"C:\Users\Migo\OneDrive\Documents\Contact Tracing Responses\" + datelblf3.Text,
                                                       true);
                qrdata.WriteLine(DATA);
                qrdata.Close();
                MessageBox.Show("Information Recorded!");
                Application.Exit();
            }
            else
            {
                MessageBox.Show("No QR code detected!");
            }
        }
    }
}
