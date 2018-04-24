using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
   public class AudioPlayer:IMediaPlayer
    {
        private MediaAdapter MediaAdapter { get; set; }

        public void Play(string format, string name)
        {
            if (format == "mp3")
            {
                Console.WriteLine($"Playing mp3 format: {name}");
            }
            else if(format == "mp4" || format == "oog")
            {
                MediaAdapter = new MediaAdapter(format);
                MediaAdapter.Play(format,name);
            }
            else
            {
                Console.WriteLine($"Invalid format: {format}");
            }
        }
    }
}
