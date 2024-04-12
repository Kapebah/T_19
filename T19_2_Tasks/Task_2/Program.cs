using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ForegroundColor = ConsoleColor.Green;
                WriteLine("Example #2\n");
                ResetColor();
                MyClass myClass1 = new MyClass();
                Write("Введите число x: ");
                int x = Convert.ToInt32(ReadLine());
                WriteLine($"\nВаше целое число: {myClass1.Number(x)}\nЧисло PI: {myClass1.Pi():f2}\nВаше число в квадрате: {myClass1.SquareX(x):f2}\nКорень вашего числа: {myClass1.SqrtX(x):f2}");

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
