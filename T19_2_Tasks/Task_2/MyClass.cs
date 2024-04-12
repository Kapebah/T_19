using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class MyClass : IInterface2
    {
        public int Number(int x) => x;

        public double Pi() => Math.PI;

        public double SqrtX(int x) => Math.Sqrt(x);

        public double SquareX(int x) => Math.Pow(x, 2);
    }
}
