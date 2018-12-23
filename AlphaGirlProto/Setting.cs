using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlphaGirlProto
{
    public partial class Setting : Form
    {
        public Setting()
        {
            InitializeComponent();
        }

        private void Setting_Load(object sender, EventArgs e)
        {
            mCheckBoxSpEventStart.Checked = Properties.Settings.Default.spEventStart;
            mCheckBoxTimeNotiEventHour.Checked = Properties.Settings.Default.timeNotiEventHour;
        }

        private void mButtonInit_Click(object sender, EventArgs e)
        {
            // Init val
            Properties.Settings.Default.spEventStart = true;
            Properties.Settings.Default.timeNotiEventHour = true;

            Properties.Settings.Default.Save();

            // Show checkbox
            mCheckBoxSpEventStart.Checked = Properties.Settings.Default.spEventStart;
            mCheckBoxTimeNotiEventHour.Checked = Properties.Settings.Default.timeNotiEventHour;

            MessageBox.Show("설정이 초기화되었습니다.");
        }

        private void mButtonSave_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.spEventStart = mCheckBoxSpEventStart.Checked;
            Properties.Settings.Default.timeNotiEventHour = mCheckBoxTimeNotiEventHour.Checked;

            Properties.Settings.Default.Save();

            MessageBox.Show("설정이 저장되었습니다.");
        }
    }
}
