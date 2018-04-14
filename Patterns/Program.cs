using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.AbstractFactory;
using Patterns.AbstractFactory.Linux;
using Patterns.AbstractFactory.Windows;

namespace Patterns
{
    class Program
    {
        static void Main(string[] args)
        {

            do
                {
                Console.WriteLine($"1. {EnumHelper.GetEnumDescription(PatternsName.Singleton)} ");
                Console.WriteLine($"2. {EnumHelper.GetEnumDescription(PatternsName.AbstractFactory)}  ");
                Console.WriteLine("Введите номер паттерна:");

                var patternNumber = Console.ReadLine();
                PatternsName pattern;

                    try
                    {
                         pattern = (PatternsName) int.Parse(patternNumber);
                    }
                    catch
                    {
                        Console.WriteLine("Введен неизвестный номер паттерна");
                        continue;
                    }

                    switch (pattern)
                    {
                        case PatternsName.Singleton:
                        {
                            Console.WriteLine("Одиночка используется для  генерации случайных чисел");
                            Console.WriteLine(Singleton.GetRandomNumber());
                            Console.WriteLine(Singleton.GetRandomNumber());
                            Console.WriteLine(Singleton.GetRandomNumber());
                        }
                        break;
                        case PatternsName.AbstractFactory:
                        {
                            Console.WriteLine("Абстракная фабрика используется для генерации элементов интерфейса разных ОС");
                            Application appWin = new Application(new WinFactory());
                            appWin.Draw();

                            Application appLinux = new Application(new LinuxFactory());
                            appLinux.Draw();
                        }
                        break;
                        default:  Console.WriteLine("Введен неизвестный номер паттерна");
                        break;
                    }
                }
            while (Console.ReadKey().Key != ConsoleKey.Escape);


        }

    }
}
