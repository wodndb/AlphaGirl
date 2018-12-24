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
        int googleCalNotiPrevTime = 0;  // Check if google calandar is already notified in period.

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

        // tUpdateTimer : Timer for updating current time
        private void tUpdateTimer_Tick(object sender, EventArgs e)
        {
            DateTime nowDt = DateTime.Now;
            int min = nowDt.Minute + (nowDt.Hour * 60);

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

            // Google Calandar Noti
            if ((Properties.Settings.Default.googleCalNoti == true) && (min != googleCalNotiPrevTime) &&
                (min % Properties.Settings.Default.googleCalNotiPeriod == 0))
            {
                mFormGoogleCalList formGoogleCalList = new AlphaGirlProto.mFormGoogleCalList();
                formGoogleCalList.Show();
                googleCalNotiPrevTime = min;
            }
        }

        private void settingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mFormSetting settingForm = new AlphaGirlProto.mFormSetting();
            settingForm.Show();
        }
    }
}
