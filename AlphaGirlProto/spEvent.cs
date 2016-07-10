using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;

namespace AlphaGirlProto
{
    class spEvent
    {
        public static void start()
        {
            SoundPlayer wp;
            wp = new SoundPlayer("../../SoundLib/start.wav");
            wp.PlaySync();
        }
    }
}
