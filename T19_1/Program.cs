using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T19_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                MyClass myClassOb = new MyClass();
                myClassOb.Show();
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
