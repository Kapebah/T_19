using System;
using System.Collections.Generic;
using static System.Console;


namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                TVSet tvSet = new TVSet();
                PersonalComputer personalComputer = new PersonalComputer();

                List<bool> on_off_tv = new List<bool>();
                List<bool> on_off_PC = new List<bool>();
                bool flag = true;

                while (flag)
                {
                    WriteLine("1 - Включить телевизор\n2 - Выключить телевизор\n3 - Включить ПК\n4 - Выключить ПК" +
                        "\n5 - Посмотреть включения телевизора\n6 - Посмотреть включения ПК");
                    switch (ReadKey(true).KeyChar)
                    {
                        case '1':
                            Clear();
                            on_off_tv.Add(tvSet.On());
                            break;
                        case '2':
                            Clear();
                            on_off_tv.Add(tvSet.Off());
                            break;
                        case '3':
                            Clear();
                            on_off_PC.Add(personalComputer.On());
                            break;
                        case '4':
                            Clear();
                            on_off_PC.Add(personalComputer.Off());
                            break;
                        case '5':
                            Clear();
                            foreach (bool b in on_off_tv)
                            {
                                if (b) { WriteLine("Телевизор включен\n"); }
                                else { WriteLine("Телевизор выключен\n"); }
                            }
                            break;
                        case '6':
                            Clear();
                            foreach (bool b in on_off_PC)
                            {
                                if (b) { WriteLine("ПК включен\n"); }
                                else { WriteLine("ПК выключен\n"); }
                            }
                            break;
                    }
                }

            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
                WriteLine($"Метод: {ex.TargetSite}");
                WriteLine($"Трассировка стека: {ex.StackTrace}");
            }
            ReadKey();
        }
    }
}
