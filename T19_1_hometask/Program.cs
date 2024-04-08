using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T19_1_hometask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ShapesRepository shapesRepository = new ShapesRepository();
                bool flag = true;

                while (flag)
                {
                    shapesRepository.WorkWithShapes();
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
