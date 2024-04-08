using System;
using static System.Console;

namespace T19_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //Example 1
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine("Example #1\n");
                ResetColor();
                MyClass1 myClassOb1 = new MyClass1();
                myClassOb1.Show();

                //Example 2
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine("\nExample #2\n");
                ResetColor();
                ChildClass myOb = new ChildClass();
                myOb.Show1();
                WriteLine();
                myOb.Show2();

                //Example 3
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine("\nExample #3\n");
                ResetColor();
                MyClass3 myClassOb3 = new MyClass3();
                myClassOb3.ShowA();
                WriteLine();
                myClassOb3.ShowB();

                //Example 4
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine("\nExample #4\n");
                ResetColor();
                MyClass4 myClassOb4 = new MyClass4();
                myClassOb4.Show();
                WriteLine();
                IMyInterfaceA2 myInterfaceA2 = myClassOb4;
                myInterfaceA2.Show();
                WriteLine();
                IMyInterfaceB2 myInterfaceB2 = myClassOb4;
                myInterfaceB2.Show();

                //Example 5
                ForegroundColor = ConsoleColor.DarkCyan;
                WriteLine("\nExample #5\n");
                ResetColor();
                MyClass5 myClassOb5 = new MyClass5();
                myClassOb5.ShowInterfaceA();
                WriteLine();
                myClassOb5.ShowInterfaceB();
                WriteLine();
                myClassOb5.ShowInterfaceC();
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
