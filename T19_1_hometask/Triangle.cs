using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T19_1_hometask
{
    class Triangle : Shapes
    {
        /// <summary>
        /// Стороны треугольника
        /// </summary>
        public int Side1 { get; set; }
        public int Side2 { get; set; }
        public int Side3 { get; set; }

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
    }
}
