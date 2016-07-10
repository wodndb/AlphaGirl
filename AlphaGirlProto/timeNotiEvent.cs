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
            int h = int.Parse(dt.ToString("HH"));
            SoundPlayer wp;

            switch (h)
            {
                case 0:
                    wp = new SoundPlayer(Properties.Resources._0am);
                    break;
                case 1:
                    wp = new SoundPlayer(Properties.Resources._1am);
                    break;
                case 2:
                    wp = new SoundPlayer(Properties.Resources._2am);
                    break;
                case 3:
                    wp = new SoundPlayer(Properties.Resources._3am);
                    break;
                case 4:
                    wp = new SoundPlayer(Properties.Resources._4am);
                    break;
                case 5:
                    wp = new SoundPlayer(Properties.Resources._5am);
                    break;
                case 6:
                    wp = new SoundPlayer(Properties.Resources._6am);
                    break;
                case 7:
                    wp = new SoundPlayer(Properties.Resources._7am);
                    break;
                case 8:
                    wp = new SoundPlayer(Properties.Resources._8am);
                    break;
                case 9:
                    wp = new SoundPlayer(Properties.Resources._9am);
                    break;
                case 10:
                    wp = new SoundPlayer(Properties.Resources._10am);
                    break;
                case 11:
                    wp = new SoundPlayer(Properties.Resources._11am);
                    break;
                case 12:
                    wp = new SoundPlayer(Properties.Resources._0pm);
                    break;
                case 13:
                    wp = new SoundPlayer(Properties.Resources._1pm);
                    break;
                case 14:
                    wp = new SoundPlayer(Properties.Resources._2pm);
                    break;
                case 15:
                    wp = new SoundPlayer(Properties.Resources._3pm);
                    break;
                case 16:
                    wp = new SoundPlayer(Properties.Resources._4pm);
                    break;
                case 17:
                    wp = new SoundPlayer(Properties.Resources._5pm);
                    break;
                case 18:
                    wp = new SoundPlayer(Properties.Resources._6pm);
                    break;
                case 19:
                    wp = new SoundPlayer(Properties.Resources._7pm);
                    break;
                case 20:
                    wp = new SoundPlayer(Properties.Resources._8pm);
                    break;
                case 21:
                    wp = new SoundPlayer(Properties.Resources._9pm);
                    break;
                case 22:
                    wp = new SoundPlayer(Properties.Resources._10pm);
                    break;
                case 23:
                    wp = new SoundPlayer(Properties.Resources._11pm);
                    break;
                default:
                    wp = null;
                    break;
            }

            if (wp != null)
            {
                wp.PlaySync();
            }
        }
    }
}
