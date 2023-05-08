using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork___Delivery
{
    public class Ellips : Product
        /*
         Продукт эллипс (беговая дорожка только для ходьбы)
         
         */
    {
        private string name;
        private string description;
        private int price;
        private double weight;
        public override string Name { get; }
        public override string Description { get; }

        public override int Price { get; }

        public override double Weight { get; }

        public Ellips()
        {
            Name = "Еллипс степер У-20";
            Description = "Степпер для тех, кому лень бегать";
            Price = 15000;
            Weight = 50;

        }
        public override void InfoProduct()
        {
            Console.WriteLine($"Название: {Name}\nОписание: {Description}\nЦена: {Price}\nВес: {Weight}");
        }


    }
}
