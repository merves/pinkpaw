using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Threading;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace Hanu.View
{
    public partial class Pet : UserControl
    {
        private FilterInfoCollection CaptureDevice;
        private VideoCaptureDevice FinalFrame;
        MySqlConnection connector = new MySqlConnection("server=pinkpawdb.cw2vs85p55vv.eu-central-1.rds.amazonaws.com;user id=pinkpaw; password = NaN; persistsecurityinfo=True;database=ppdb");
        MySqlCommand command;
        MySqlDataReader mdr;
        public Pet()
        {
            InitializeComponent();

        }
        
        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void Pet_Load(object sender, EventArgs e)
        {
            

        CaptureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo Device in CaptureDevice)
            {
                comboBox1.Items.Add(Device.Name);
            }
            comboBox1.SelectedIndex = 0;
            FinalFrame = new VideoCaptureDevice();
            Thread thread1 = new Thread(new ThreadStart(xx));
            thread1.Start();
            thread1.Join();
        }
        public void xx()
        {
            FinalFrame = new VideoCaptureDevice(CaptureDevice[comboBox1.SelectedIndex].MonikerString);
            FinalFrame.NewFrame += new NewFrameEventHandler(FinalFrame_NewFrame);
            FinalFrame.Start();
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
            btnGuncelle.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();
            timer1.Enabled = true;
            button1.Enabled = false;
        }


        private void timer1_Tick_1(object sender, EventArgs e)
        {

            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox1.Image);
            try
            {
                string decoded = result.ToString().Trim();
                connector.Open();
                //string str = "select petid,petname,pettype, IFNULL(petowner,'') as petowner from qrtest where petid = " + decoded;
                string str = "select * from qrtest where petid = " + decoded;
                command = new MySqlCommand(str, connector);
                mdr = command.ExecuteReader();
                if (mdr.Read())
                {
                    txtHastaAdi.Text = mdr.GetString("petname");
                    textBox1.Text = mdr.GetString("pettype");
                    // textBox4.Text = mdr.GetString("petowner");
                    textBox2.Text = mdr["petowner"] as string;
                    textBox3.Text = mdr["disease"] as string;
                    textBox4.Text = mdr["dst"] as string;
                    textBox5.Text = mdr["det"] as string;

                }
                button1.Enabled = true;
                connector.Close();
                timer1.Enabled = false;
                timer1.Stop();


            }
            catch (Exception ex)
            {

            }

        }


        private void Pet_Leave(object sender, EventArgs e)
        {
           
        }

        private void Pet_Layout(object sender, LayoutEventArgs e)
        {
            
        }
    }
}