using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace AlphaGirlProto
{
    // Time Notification Event
    class timeNotiEvent
    {
        // Sound notification.
        // \DateTime dt : time to notify.
        public static void playSound(DateTime dt)
        {
            if (Properties.Settings.Default.timeNotiEventHour == true)
            {
                int h = dt.Hour;
                SoundPlayer wp;

                // Loading time notification sound to array.
                var rcArray = new UnmanagedMemoryStream[]
                {
                Properties.Resources._0am,
                Properties.Resources._1am,
                Properties.Resources._2am,
                Properties.Resources._3am,
                Properties.Resources._4am,
                Properties.Resources._5am,
                Properties.Resources._6am,
                Properties.Resources._7am,
                Properties.Resources._8am,
                Properties.Resources._9am,
                Properties.Resources._10am,
                Properties.Resources._11am,
                Properties.Resources._0pm,
                Properties.Resources._1pm,
                Properties.Resources._2pm,
                Properties.Resources._3pm,
                Properties.Resources._4pm,
                Properties.Resources._5pm,
                Properties.Resources._6pm,
                Properties.Resources._7pm,
                Properties.Resources._8pm,
                Properties.Resources._9pm,
                Properties.Resources._10pm,
                Properties.Resources._11pm,
                };

                // Play sound over time.
                if (h >= 0 && h < rcArray.Length)
                {
                    wp = new SoundPlayer(rcArray[h]);
                    wp.PlaySync();
                }
            }
        }
    }
}
