using System;
using static System.Console;


namespace T19_1_hometask
{
    class Triangle : Shapes
    {
        /// <summary>
        /// Название фигуры
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Стороны треугольника
        /// </summary>
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }

        /// <summary>
        /// Проверка сторон
        /// </summary>
        public static bool validSides { get; set; }

        /// <summary>
        /// Конструкторы
        /// </summary>
        public Triangle() { }
        public Triangle(string name, double side1, double side2, double side3)
        {
            Name = name;
            if (side1 < (side2 + side3) && side2 < (side1 + side3) && side3 < (side1 + side2))
            {
                Side1 = side1;
                Side2 = side2;
                Side3 = side3;
                validSides = true;
            }
            else 
            { 
                validSides = false; 
                ForegroundColor = ConsoleColor.Red; 
                Write($"\nTriangle doesn't exist.\n\n"); 
                ResetColor(); 
            }
        }

        /// <summary>
        /// Вычисление площади
        /// </summary>
        /// <returns>Площадь треугольника</returns>
        public double Area()
        {
            double p = Perimeter() / 2;
            return Math.Sqrt(p * (p - Side1) * (p - Side2) * (p - Side3));
        }

        /// <summary>
        /// Вычисление периметра
        /// </summary>
        /// <returns>Периметр треугольника</returns>
        public double Perimeter()
        {
            return Side1 + Side2 + Side3;
        }
        /// <summary>
        /// Вывод информации
        /// </summary>
        /// <returns>Вывод информации о треугольнике</returns>
        public override string ToString()
        {
            return $"Name: {Name}\nFirst side: {Side1}\nSecond side: {Side2}\nThird side: {Side3}\nPerimeter: {Perimeter():f2}\nArea: {Area():f2}";
        }

        /// <summary>
        /// Ввод данных с клавиатуры
        /// </summary>
        /// <returns>Ввод информации о треугольнике</returns>
        public static Triangle Input()
        {
            Write("Enter the name of shape: ");
            string name = ReadLine();
            Write("Enter the first side: ");
            double side1 = Convert.ToDouble(ReadLine());
            Write("Enter the second side: ");
            double side2 = Convert.ToDouble(ReadLine());
            Write("Enter the third side: ");
            double side3 = Convert.ToDouble(ReadLine());
            return new Triangle(name, side1, side2, side3);
        }
    }
}
