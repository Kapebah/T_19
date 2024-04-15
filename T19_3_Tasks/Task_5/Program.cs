using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                List<Figure> figures = new List<Figure>
                {
                    new Triangle("Triangle", 4, 2, 3),
                    new Triangle("Triag", 5, 4, 3),
                    new Rectangle("Rectangle", 5, 8),
                    new Rectangle("Rect", 2, 4),
                    new Circle("Circle", 3),
                    new Circle("Circ", 7),
                };

                WriteLine("Before: \n");
                foreach (var figure in figures)
                {
                    WriteLine(figure.ToString());
                    WriteLine();
                }

                WriteLine("\nSort: \n");
                figures.Sort();
                foreach (var figure in figures)
                {
                    WriteLine(figure.ToString());
                    WriteLine();
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
