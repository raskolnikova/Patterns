using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    public class MP4Player:IAdvancedMediaPlayer
    {
        public void PlayMP4(string name)
        {
            Console.WriteLine($"Playing mp4 format: {name}");
        }

        public void PlayOOG(string name)
        {
            Console.WriteLine($"Playing oog format: {name}");
        }
    }
}
