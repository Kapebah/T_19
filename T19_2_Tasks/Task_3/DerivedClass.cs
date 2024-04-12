using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_3
{
    class DerivedClass : IInterface3
    {
        public void Method1() => WriteLine("Метод Method1");

        public void Method2() => WriteLine("Метод Method2");

        public void Method3() => WriteLine("Метод Method3");
    }
}
