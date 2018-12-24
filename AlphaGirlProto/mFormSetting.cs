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

namespace AlphaGirlProto
{
    public partial class mFormSetting : Form
    {
        public mFormSetting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            mCheckBoxSpEventStart.Checked = Properties.Settings.Default.spEventStart;
            mCheckBoxTimeNotiEventHour.Checked = Properties.Settings.Default.timeNotiEventHour;
            mCheckBoxGoogleCalNoti.Checked = Properties.Settings.Default.googleCalNoti;
            mComboBoxGoogleCalNotiPeriod.SelectedItem = Properties.Settings.Default.googleCalNotiPeriod.ToString();
        }

        private void mButtonInit_Click(object sender, EventArgs e)
        {
            // Init val
            Properties.Settings.Default.spEventStart = true;
            Properties.Settings.Default.timeNotiEventHour = true;
            Properties.Settings.Default.googleCalNoti = true;
            Properties.Settings.Default.googleCalNotiPeriod = 10;

            Properties.Settings.Default.Save();

            // Show checkbox
            mCheckBoxSpEventStart.Checked = Properties.Settings.Default.spEventStart;
            mCheckBoxTimeNotiEventHour.Checked = Properties.Settings.Default.timeNotiEventHour;
            mCheckBoxGoogleCalNoti.Checked = Properties.Settings.Default.googleCalNoti;

            // Show init
            mComboBoxGoogleCalNotiPeriod.SelectedItem = Properties.Settings.Default.googleCalNotiPeriod.ToString();

            MessageBox.Show("설정이 초기화되었습니다.");
        }

        private void mButtonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.spEventStart = mCheckBoxSpEventStart.Checked;
            Properties.Settings.Default.timeNotiEventHour = mCheckBoxTimeNotiEventHour.Checked;
            Properties.Settings.Default.googleCalNoti = mCheckBoxGoogleCalNoti.Checked;
            Properties.Settings.Default.googleCalNotiPeriod = System.Convert.ToInt32(mComboBoxGoogleCalNotiPeriod.SelectedItem);

            Properties.Settings.Default.Save();

            MessageBox.Show("설정이 저장되었습니다.");
        }

        private void mButtonDelGoogleAccount_Click(object sender, EventArgs e)
        {
            string credPath = "token.json";
            string currentPath = Environment.CurrentDirectory;
            string filePath = System.IO.Path.Combine(currentPath, credPath);

            // Delete a file by using File class static method...
            if (System.IO.Directory.Exists(filePath))
            {
                // Use a try block to catch IOExceptions, to
                // handle the case of the file already being
                // opened by another process.
                try
                {
                    System.IO.Directory.Delete(filePath, true);
                    MessageBox.Show("계정 인증 정보가 제거되었습니다.");
                }
                catch (System.IO.IOException ioEx)
                {
                    MessageBox.Show(ioEx.Message);
                    return;
                }
            }
        }
    }
}
