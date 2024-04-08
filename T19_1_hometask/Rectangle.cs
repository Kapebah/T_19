using System;
using static System.Console;


namespace T19_1_hometask
{
    class Rectangle : Shapes
    {
        /// <summary>
        /// Название фигуры
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Стороны прямоугольника
        /// </summary>
        public double Side1 { get; set; }
        public double Side2 { get; set; }

        /// <summary>
        /// Конструкторы
        /// </summary>
        public Rectangle() { }
        public Rectangle(string name, double side1, double side2)
        {
            Name = name;
            Side1 = side1;
            Side2 = side2;
        }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns>Площадь прямоугольника</returns>
        public double Area()
        {
            return Side1 * Side2;
        }

        /// <summary>
        /// Периметр прямоугольника
        /// </summary>
        /// <returns>Периметр прямоугольника</returns>
        public double Perimeter()
        {
            return (Side1 + Side2) * 2;
        }
        /// <summary>
        /// Вывод информации
        /// </summary>
        /// <returns>Вывод информации о прямоугольнике</returns>
        public override string ToString()
        {
            return $"Name: {Name}\nFirst side: {Side1}\nSecond side: {Side2}\nPerimeter: {Perimeter():f2}\nArea: {Area():f2}";
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
