using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Person : IComparable<Person>
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public Person() { }
        public Person(string name, int age) {  Name = name; Age = age; }

        public int CompareTo(Person obj) => Name.CompareTo(obj.Name);
        public new string ToString()
        {
            return $"{Name}, {Age}";
        }
    }
}
