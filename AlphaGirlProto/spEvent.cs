﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.Windows.Forms;

namespace AlphaGirlProto
{
    // Specific Event.
    //
    // 1. Starting voice
    // 2. Greeting (morning / afternoon / evening)
    // 3. Google Event Notification --> move to Form 1
    // 
    class spEvent
    {
        public static void start()
        {
            if (Properties.Settings.Default.spEventStart == true)
            {
                DateTime nowDT = DateTime.Now;  // Now time
                SoundPlayer startWP = new SoundPlayer(Properties.Resources.start);  // Sound about program start
                SoundPlayer greetingWP = null;  // Sound about greeting.
                int hour = nowDT.Hour;

                // Set greeting sound by judging time.
                if (6 <= hour && hour <= 11)   // Morning
                {
                    greetingWP = new SoundPlayer(Properties.Resources.morning);
                }
                else if (12 <= hour && hour <= 17)  // Afternoon
                {
                    greetingWP = new SoundPlayer(Properties.Resources.afternoon);
                }
                else // Evening   // if (18 <= int.Parse(nowDT.ToString("HH")))
                {
                    greetingWP = new SoundPlayer(Properties.Resources.evening);
                }

                // Play sound
                startWP.PlaySync();

                System.Threading.Thread.Sleep(800); // Delay between sound.

                if (greetingWP != null)
                {
                    greetingWP.PlaySync();
                }
                System.Threading.Thread.Sleep(500);
            }
        }

        public static void googleCalNoti()
        {
            DateTime nowDT = DateTime.Now;  // Now time
            int min = ((nowDT.Minute + (nowDT.Hour * 60)) % Properties.Settings.Default.googleCalNotiPeriod);

            if((Properties.Settings.Default.googleCalNoti == true) && (min == 0))
            {
                mFormGoogleCalList formGoogleCalList = new AlphaGirlProto.mFormGoogleCalList();
                formGoogleCalList.Show();
            }
        }
    }
}
