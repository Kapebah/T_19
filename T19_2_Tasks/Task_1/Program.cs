using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Example #1\n");
                ResetColor();

                DerivedClass dClass1 = new DerivedClass();
                dClass1.Method();

                IInterface dClass2 = new DerivedClass();
                dClass1.Method();
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
