using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaGirlProto
{
    public partial class From : Form
    {
        public From()
        {
            InitializeComponent();

            // Timer for updating current time and checking to notification.
            tUpdateTimer.Interval = 1000;
            tUpdateTimer.Start();

            new Thread(() => spEvent.start()).Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Show Current Directory
            //MessageBox.Show(System.Environment.CurrentDirectory);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        // tUpdateTimer : Timer for updating current time
        private void tUpdateTimer_Tick(object sender, EventArgs e)
        {
            DateTime nowDt = DateTime.Now;

            // Check time notification
            if (int.Parse(nowDt.ToString("mm")) == 0 && int.Parse(nowDt.ToString("ss")) == 0)
            {
                new Thread(() => timeNotiEvent.playSound(nowDt)).Start();
            }

            if(nowDt.Second % 4 != 0)
            {
                pictureBox1.BackgroundImage = Properties.Resources.普通_01;
            }
            else
            {
                pictureBox1.BackgroundImage = Properties.Resources.喜び_01;
            }
        }

        // Sound Test. This function play notification about current hour.
        private void SoundTest_Click(object sender, EventArgs e)
        {
            new Thread(() => timeNotiEvent.playSound(DateTime.Now)).Start();
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Setting settingForm = new AlphaGirlProto.Setting();
            settingForm.Show();
        }
    }
}
