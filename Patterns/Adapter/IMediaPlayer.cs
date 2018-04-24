using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
   public interface IMediaPlayer
   {
        void Play(string format, string name);
   }
}
