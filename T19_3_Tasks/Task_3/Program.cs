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
                List<Avto> avtos = new List<Avto>
                {
                    new Avto(1, "Lexus", 220, 30000, 5),
                    new Avto(2, "Toyota", 160, 24670, 3),
                    new Avto(3, "Mitsubishi", 120, 24760, 2),
                    new Avto(4, "KIA", 145, 10045, 0)
                };

                WriteLine("Before: \n");
                foreach(var avto in avtos)
                {
                    WriteLine(avto.ToString());
                    WriteLine();
                }

                WriteLine("\nSort: \n");
                avtos.Sort();
                foreach (var avto in avtos)
                {
                    WriteLine(avto.ToString());
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
