using System;
using static System.Console;

namespace T19_1_hometask
{
    class Circle : Shapes
    {
        /// <summary>
        /// Название фигуры
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Радиус
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Конструкторы
        /// </summary>
        public Circle() { }
        public Circle(string name, double radius)
        {
            Name = name; Radius = radius;
        }
        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns>Площадь круга</returns>
        public double Area()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }

        /// <summary>
        /// Вычисление периметра
        /// </summary>
        /// <returns>Периметр</returns>
        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
        /// <summary>
        /// Вывод информации
        /// </summary>
        /// <returns>Вывод информации о прямоугольнике</returns>
        public override string ToString()
        {
            return $"Name: {Name}\nRadius: {Radius}\nPerimeter: {Perimeter():f2}\nArea: {Area():f2}";
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
