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
            SoundPlayer wp;
            wp = new SoundPlayer(Properties.Resources.start);
            wp.PlaySync();
        }
    }
}
