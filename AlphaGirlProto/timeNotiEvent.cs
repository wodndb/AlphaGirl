using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;


namespace AlphaGirlProto
{
    class timeNotiEvent
    {
        public static void playSound(DateTime dt)
        {
            int h = int.Parse(dt.ToString("HH"));
            String soundFileName;
            SoundPlayer wp;

            if (h < 12)
            {
                soundFileName = String.Format("../../soundLib/{0}am.wav", h);
            }
            else
            {
                soundFileName = String.Format("../../soundLib/{0}pm.wav", h - 12);
            }

            wp = new SoundPlayer(soundFileName);
            wp.PlaySync();
        }
    }
}
