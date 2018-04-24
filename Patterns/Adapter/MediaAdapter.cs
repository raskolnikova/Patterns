using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
   public class MediaAdapter:IMediaPlayer
    {
        private IAdvancedMediaPlayer AdvancedMediaPlayer { get; set; }

        public MediaAdapter(string format)
        {
            if (format == "mp4" || format == "oog")
            {
                AdvancedMediaPlayer = new MP4Player();
            }
        }

        public void Play(string format, string name)
        {
            if (format == "mp4" )
            {
                AdvancedMediaPlayer.PlayMP4(name);
            }
            if (format == "oog")
            {
                AdvancedMediaPlayer.PlayOOG(name);
            }
        }
    }
}
