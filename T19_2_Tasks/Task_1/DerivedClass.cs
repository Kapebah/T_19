using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_1
{
    class DerivedClass : IInterface
    {
        public void Method() => WriteLine("Метод, реализованный в классе DerivedClass");
    }
}
