using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {
            do
                {
                    Console.WriteLine(Singleton.GetRandomNumber());
                    Console.WriteLine(Singleton.GetRandomNumber());
                    Console.WriteLine(Singleton.GetRandomNumber());
                    Console.WriteLine(Singleton.GetRandomNumber());
                }
            while (Console.ReadKey().Key != ConsoleKey.Escape);


        }
    }
}
