using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork___Delivery
{
    public class Order<TDelivery> where TDelivery : Delivery
        /*
            Класс заказ
            Генерит рандомный номер заказа
            и в зависости от выбранного типа заказа обращается к свойству для дальнейшего присвоения номера заказа со своим префиксом

            p.s Я понял как использовать обобщения, но в своей реализации так и не понял как их удобнее воткнуть, поэтому решил немного кастылить
            обязательно попрактикуюсь на менее замороченных заданиях :)
         
         
         */
    {



        public int Id { get; private set; }

        private List<Product> products;
        public Order(Customer user, List<Product> products, Delivery delivery)
        {
            Random random = new Random();
            Id = random.Next(0, 150);
            this.products = products;
            Delivery homeDelivery = new HomeDelivery(user);
            Delivery shopDelivery = new ShopDelivery(user);


        }


        public void Informer(Customer user, List<Product> product, Delivery delivery)
        {
            Console.WriteLine($"\nНомер заказа: {delivery.DeliveryType}_{Id}");
            Console.WriteLine($"\nПользователь: {user.Name} оформил заказ по адресу: {user.Address}");
            foreach (var p in product)
            {
                Console.WriteLine($"\nТовар {p.Name}\nЦена: {p.Price}\nСумма доставки: {delivery.DeliveryPrice}");

            }

        }





    }
}
