using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_5
{
    class Rectangle : Figure
    {
        /// <summary>
        /// Стороны прямоугольника
        /// </summary>
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        /// <summary>
        /// Конструкторы
        /// </summary>
        public Rectangle() { }
        public Rectangle(string name, double side1, double side2) : base(name)
        {
            Side1 = side1;
            Side2 = side2;
        }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns>Площадь прямоугольника</returns>
        public override double Area()
        {
            return Side1 * Side2;
        }

        /// <summary>
        /// Периметр прямоугольника
        /// </summary>
        /// <returns>Периметр прямоугольника</returns>
        public override double Perimeter()
        {
            return (Side1 + Side2) * 2;
        }
        /// <summary>
        /// Вывод информации
        /// </summary>
        /// <returns>Вывод информации о прямоугольнике</returns>
        public override string ToString()
        {
            return $"{Name}, {Side1}, {Side2}, {Perimeter():f2}, {Area():f2}";
        }

        /// <summary>
        /// Ввод данных с клавиатуры
        /// </summary>
        /// <returns>Ввод информации о прямоугольнике</returns>
        public static Rectangle Input()
        {
            Write("Enter the name of shape: ");
            string name = ReadLine();
            Write("Enter the first side: ");
            double side1 = Convert.ToDouble(ReadLine());
            Write("Enter the second side: ");
            double side2 = Convert.ToDouble(ReadLine());
            return new Rectangle(name, side1, side2);
        }
    }
}
