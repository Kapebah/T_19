using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    abstract class Figure : IComparable<Figure>
    {
        public string Name { get; set; }

        public Figure() { }
        public Figure(string name) => Name = name;
        public new abstract string ToString();
        public abstract double Area();
        public abstract double Perimeter();

        public int CompareTo(Figure obj) => Area().CompareTo(obj.Area());
    }
}
