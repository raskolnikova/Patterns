using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    public static class Singleton
    {
        private static Random _random;

        public static int GetRandomNumber()
        {
            if (_random == null)
            {
                _random = new Random();
            }

            return _random.Next();
        }
    }
}
