using static System.Console;

namespace T19_1
{
    /// <summary>
    /// Example 1
    /// </summary>
    class MyClass1 : IMyInterface1
    {
        public void Show()
        {
            WriteLine("MyClass.Show() is implemented\n//MyClass.Show() - реализован");
        }

        public void Show1()
        {
            throw new System.NotImplementedException();
        }

        public void Show2()
        {
            throw new System.NotImplementedException();
        }
    }

    /// <summary>
    /// Example 2
    /// </summary>
    abstract class MyClass2 : IMyInterface2
    {
        public void Show()
        {
            throw new System.NotImplementedException();
        }

        public void Show1()
        {
            WriteLine("MyClass.Show1() is implemented\n//MyClass.Show1() - реализован");
        }

        public abstract void Show2();
    }

    /// <summary>
    /// Example 3
    /// </summary>
    class MyClass3 : IMyInterfaceA1, IMyInterfaceB1
    {
        public void ShowA()
        {
            WriteLine("MyClass.ShowA() is implemented\n//MyClass.ShowA() - реализован");
        }
        public void ShowB()
        {
            WriteLine("MyClass.ShowB() is implemented\n//MyClass.ShowB() - реализован");
        }
    }

    /// <summary>
    /// Example 4
    /// </summary>
    class MyClass4 : IMyInterfaceA2, IMyInterfaceB2
    {
        public void Show()
        {
            WriteLine("MyClass.Show() is completed\n//MyClass.Show() - завершен");
        }

        void IMyInterfaceA2.Show()
        {
            WriteLine("Explicit interface implementation. IMyInterfaceA.Show().\n//Явная реализация интерфейса. IMyInterfaceA.Show().");
        }

        void IMyInterfaceB2.Show()
        {
            WriteLine("Explicit interface implementation. IMyInterfaceB.Show().\n//Явная реализация интерфейса. IMyInterfaceB.Show().");
        }
    }

    class MyClass5 : IMyInterfaceC
    {
        public void ShowInterfaceA()
        {
            WriteLine("ShowInterfaceA() is completed\n//ShowInterfaceA() - завершен");
        }

        public void ShowInterfaceB()
        {
            WriteLine("ShowInterfaceB() is completed\n//ShowInterfaceB() - завершен");
        }

        public void ShowInterfaceC()
        {
            WriteLine("ShowInterfaceC() is completed\n//ShowInterfaceC() - завершен");
        }
    }
}
