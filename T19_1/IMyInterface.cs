namespace T19_1
{
    /// <summary>
    /// Example 1
    /// </summary>
    interface IMyInterface1
    {
        void Show();
    }

    /// <summary>
    /// Example 2
    /// </summary>
    interface IMyInterface2
    {
        void Show1();
        void Show2();
    }

    /// <summary>
    /// Example 3
    /// </summary>
    interface IMyInterfaceA1
    {
        void ShowA();
    }
    interface IMyInterfaceB1
    {
        void ShowB();
    }

    /// <summary>
    /// Example 4
    /// </summary>
    interface IMyInterfaceA2
    {
        void Show();
    }
    interface IMyInterfaceB2
    {
        void Show();
    }

    /// <summary>
    /// Example 5
    /// </summary>
    interface IMyInterfaceA3
    {
        void ShowInterfaceA();
    }
    interface IMyInterfaceB3
    {
        void ShowInterfaceB();
    }
    interface IMyInterfaceC : IMyInterfaceA3, IMyInterfaceB3
    {
        void ShowInterfaceC();
    }
}
