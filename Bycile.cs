using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HomeWork___Delivery
{
    public class Bycile : Product
    {
        private string name;
        private string description;
        private int price;
        private double weight;
        public override string Name { get; }
        public override string Description { get; }

        public override int Price { get; }

        public override double Weight { get; }

        public Bycile()
        {
            Name = "Велосипед Т-200";
            Description = "Обычный велик для повседневной езды";
            Price = 20000;
            Weight = 20;
        
        }

        public override void InfoProduct()
        {
            Console.WriteLine($"Название: {Name}\nОписание: {Description}\nЦена: {Price}\nВес: {Weight}");
        }





    }
}
