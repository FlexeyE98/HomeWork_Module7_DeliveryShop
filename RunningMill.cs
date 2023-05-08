using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork___Delivery
{
    public class RunningMill : Product
    {
        //Класс беговой дорожки

        private string name;
        private string description;
        private int price;
        private double weight;
        public override string Name { get; }
        public override string Description { get; }

        public override int Price { get; }

        public override double Weight { get; }

        public RunningMill()
        {
            Name = "Беговая дорожка БЕГИ БЫСТРО";
            Description = "Беговая дорожка обычная, бегай дома когда захочешь";
            Price = 50000;
            Weight = 30;

        }

        public override void InfoProduct()
        {
            Console.WriteLine($"Название: {Name}\nОписание: {Description}\nЦена: {Price}\nВес: {Weight}");
        }



    }
}
