using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork___Delivery
{
    public class ShopDelivery: Delivery
        //Класс доставки в магазин по адресу

    {
        private int deliveryPrice;
        public override double DeliveryPrice { get; }

        public override string Adress { get; }

        public override string DeliveryType { get; }

        public ShopDelivery(Customer user)
        {
            Adress = user.Address;
            DeliveryPrice = 200;
            DeliveryType = "SHOP";
        }

        public override void ShowDeliveryPrice()
        {
            Console.WriteLine($"2.Стоимтость доставки в магазин по адресу {DefaultSettings.Adress} составляет: {DeliveryPrice} руб");
        }
    }
}
