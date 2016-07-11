using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace AlphaGirlProto
{
    // Time Notification Event
    class timeNotiEvent
    {
        // Sound notification.
        public static void playSound(DateTime dt)
        {
            int h = dt.Hour;
            SoundPlayer wp;

            SoundPlayer[] wpArray = new SoundPlayer[]
            {
                new SoundPlayer(Properties.Resources._0am),
                new SoundPlayer(Properties.Resources._1am),
                new SoundPlayer(Properties.Resources._2am),
                new SoundPlayer(Properties.Resources._3am),
                new SoundPlayer(Properties.Resources._4am),
                new SoundPlayer(Properties.Resources._5am),
                new SoundPlayer(Properties.Resources._6am),
                new SoundPlayer(Properties.Resources._7am),
                new SoundPlayer(Properties.Resources._8am),
                new SoundPlayer(Properties.Resources._9am),
                new SoundPlayer(Properties.Resources._10am),
                new SoundPlayer(Properties.Resources._11am),
                new SoundPlayer(Properties.Resources._0pm),
                new SoundPlayer(Properties.Resources._1pm),
                new SoundPlayer(Properties.Resources._2pm),
                new SoundPlayer(Properties.Resources._3pm),
                new SoundPlayer(Properties.Resources._4pm),
                new SoundPlayer(Properties.Resources._5pm),
                new SoundPlayer(Properties.Resources._6pm),
                new SoundPlayer(Properties.Resources._7pm),
                new SoundPlayer(Properties.Resources._8pm),
                new SoundPlayer(Properties.Resources._9pm),
                new SoundPlayer(Properties.Resources._10pm),
                new SoundPlayer(Properties.Resources._11pm),
            };

            if (h >= 0 && h < wpArray.Length)
            {
                wp = wpArray[h];
                wp.PlaySync();
            }
        }
    }
}
