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
                TVSet tvSet = new TVSet();
                PersonalComputer personalComputer = new PersonalComputer();

                List<bool> on_off = new List<bool>();
                bool flag = true;

                while (flag)
                {
                    switch (ReadKey(true).KeyChar)
                    {
                        case '1':
                            on_off.Add(tvSet.On());
                            break;
                        case '2':
                            on_off.Add(tvSet.Off());
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
