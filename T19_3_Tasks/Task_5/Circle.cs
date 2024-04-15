using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Task_5
{
    class Circle : Figure
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Конструкторы
        /// </summary>
        public Circle() { }
        public Circle(string name, double radius) : base(name) => Radius = radius;
        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns>Площадь круга</returns>
        public override double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Вычисление периметра
        /// </summary>
        /// <returns>Периметр</returns>
        public override double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
        /// <summary>
        /// Вывод информации
        /// </summary>
        /// <returns>Вывод информации о прямоугольнике</returns>
        public override string ToString()
        {
            return $"{Name}, {Radius}, {Perimeter():f2}, {Area():f2}";
        }

        /// <summary>
        /// Ввод данных с клавиатуры
        /// </summary>
        /// <returns>Ввод информации о круге</returns>
        public static Circle Input()
        {
            Write("Enter the name of shape: ");
            string name = ReadLine();
            Write("Enter the radius: ");
            double radius = Convert.ToDouble(ReadLine());
            return new Circle(name, radius);
        }
    }
}
