using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Task_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Example #4\n");
                ResetColor();

                Human human = new Human();
                human.SpeaksLoud();
                human.Think();
                human.SpeaksNormal();
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
