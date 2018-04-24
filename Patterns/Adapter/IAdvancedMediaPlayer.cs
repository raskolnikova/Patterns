using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Adapter
{
    interface IAdvancedMediaPlayer
    {
        void PlayMP4(string name);
        void PlayOOG(string name);
    }
}
