using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace AlphaGirlProto
{
    // Specific Event.
    class spEvent
    {
        public static void start()
        {
            DateTime nowDT = DateTime.Now;
            SoundPlayer startWP = new SoundPlayer(Properties.Resources.start);
            SoundPlayer greetingWP = null;

            if ( 6 <= int.Parse(nowDT.ToString("HH")) && int.Parse(nowDT.ToString("HH")) <= 11)
            {
                greetingWP = new SoundPlayer(Properties.Resources.morning);
            }
            else if (12 <= int.Parse(nowDT.ToString("HH")) && int.Parse(nowDT.ToString("HH")) <= 17)
            {
                greetingWP = new SoundPlayer(Properties.Resources.afternoon);
            }
            else// if (18 <= int.Parse(nowDT.ToString("HH")))
            {
                greetingWP = new SoundPlayer(Properties.Resources.evening);
            }
            startWP.PlaySync();

            System.Threading.Thread.Sleep(800);
            
            if(greetingWP != null)
            {
                greetingWP.PlaySync();
            }
            System.Threading.Thread.Sleep(500);
        }
    }
}
