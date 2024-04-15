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
                List<Person> people = new List<Person>
                {
                    new Person("Darya", 19),
                    new Person("Artem", 18),
                    new Person("Kirill", 17)
                };

                WriteLine("Before: \n");
                foreach (Person person in people)
                {
                    WriteLine(person.ToString());
                    WriteLine();
                }

                people.Sort();

                WriteLine("\nSort: \n");
                foreach (Person person in people)
                {
                    WriteLine(person.ToString());
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
