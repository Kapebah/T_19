using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Avto : IComparable<Avto>
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public double MaxSpeed { get; set; }
        public double Price { get; set; }
        public double Discount { get; set; }
        
        public Avto() { }
        public Avto(int id, string brand, double maxSpeed, double price, double discount)
        {
            Id = id;
            Brand = brand;
            MaxSpeed = maxSpeed;
            Price = price;
            Discount = discount;
        }

        public int CompareTo(Avto obj) => Price.CompareTo(obj.Price);
        public new string ToString() => $"{Id}, {Brand}, {MaxSpeed}km/h, {Price}$, {Discount}%";
    }
}
