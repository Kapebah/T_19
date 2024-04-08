using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace T19_1
{
    class MyClass : IMyInterface
    {
        public void Show()
        {
            WriteLine("MyClass() is implemented\n//MyClass() - реализован");
        }
    }
}
