using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T19_1_hometask
{
    class Rectangle : Shapes
    {
        /// <summary>
        /// Стороны прямоугольника
        /// </summary>
        public int Side1 { get; set; }
        public int Side2 { get; set; }

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
    }
}
