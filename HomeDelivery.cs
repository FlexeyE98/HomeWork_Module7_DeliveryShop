using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork___Delivery
{
    public class HomeDelivery: Delivery
    {
        
        public override double DeliveryPrice { get; }
        public override string Adress { get;}

        public override string DeliveryType { get; }

        
        

        public HomeDelivery(Customer user) 
        {
            Adress = user.Address;
            DeliveryPrice = 300;
            DeliveryType = "HOME";
            
        
        }
       





        public override void ShowDeliveryPrice()
        {
            Console.WriteLine($"1.Стоимость доставки на дом: {DeliveryPrice} руб");
        }





    }
}
