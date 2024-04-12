using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Player player = new Player();
                bool flag = true;

                while (flag)
                {
                    WriteLine("1 - Включить\n2 - Записать\n3 - Пауза\n4 - Выключить\n\n");
                    switch (ReadKey(true).KeyChar)
                    {
                        case '1':
                            player.Play();
                            WriteLine();
                            break;
                        case '2':
                            player.Record();
                            WriteLine();
                            break;
                        case '3':
                            player.Pause();
                            WriteLine();
                            break;
                        case '4':
                            player.Stop();
                            WriteLine();
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
