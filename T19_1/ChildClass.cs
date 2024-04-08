using static System.Console;

namespace T19_1
{
    /// <summary>
    /// Example 2
    /// </summary>
    class ChildClass : MyClass2
    {
        public override void Show2()
        {
            WriteLine("MyClass.Show2() is implemented\n//MyClass.Show2() - реализован");
        }
    }
}
