﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.AbstractFactory;
using Patterns.AbstractFactory.Linux;
using Patterns.AbstractFactory.Windows;
using Patterns.Observer;

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
                Console.WriteLine($"3. {EnumHelper.GetEnumDescription(PatternsName.Observer)}  ");
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
                            Application appWin = new Application(new FloatFactory());
                            appWin.Draw();

                            Application appLinux = new Application(new MaterialFactory());
                            appLinux.Draw();
                        }
                        break;
                        case PatternsName.Observer:
                        {
                            Console.WriteLine("Наблюдатель используется для рассылки сообщений подписавшимся сущностям");
                            LoggingListner loggingListner = new LoggingListner();
                            FormListner formListner = new FormListner();
                            Form form = new Form();

                            form.EventManager.Subscribe(EventTypes.Click,loggingListner);
                            form.EventManager.Subscribe(EventTypes.KeyUp,formListner);

                            form.Click();
                            form.Hover();
                            form.KeyUp();

                            form.EventManager.Unsubscribe(EventTypes.KeyUp, formListner);
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
