using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Example #3\n");
                ResetColor();

                DerivedClass dClass = new DerivedClass();
                dClass.Method1();
                dClass.Method2();
                dClass.Method3();
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
