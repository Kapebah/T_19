using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T19_1_hometask
{
    class Circle : Shapes
    {
        /// <summary>
        /// Радиус
        /// </summary>
        public int Radius { get; set; }
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
            throw new NotImplementedException();
        }
    }
}
