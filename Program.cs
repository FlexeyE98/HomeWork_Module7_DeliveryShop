using System.Security.Cryptography.X509Certificates;

namespace HomeWork___Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Приветствуем в нашем магазинчике. У нас есть на выбор следующие продукты. Приобретайте с удовольствием :)\n\n");

            Bycile bycile = new Bycile();
            Ellips ellips = new Ellips();
            RunningMill runningMill = new RunningMill();

            Product[] product = new Product[]
            {
                bycile,
                ellips,
                runningMill

            };
            for (int i = 0; i < product.Length; i++)
            {
                Console.WriteLine($"Товар №{i + 1}");
                product[i].InfoProduct();
                Console.WriteLine();
            }

            Console.Write("Перед приобретением товара рекомендуем ознакомиться с правилами оформления заказа. (y/n)  ");
            string rulles = Console.ReadLine();
            if (rulles.Contains('y'))
                DefaultSettings.ShowInfo();
            else
            {
                Console.WriteLine("\nМы вас предупреждали");

            }

            Console.Write("\nХотите сделать заказ? (y/n)  ");
            string newOrder = Console.ReadLine();
            if (newOrder.Contains('y'))
            {
                Console.WriteLine("\nПеред оформлением заказа необходимо зарегистрироваться.\nЗаполните данные ниже:");
                Console.Write("Введите вашем имя: ");
                string name = Console.ReadLine();
                Console.Write("Введите ваш адрес: ");
                string adress = Console.ReadLine();
                Console.Write("Введите сумму пополнения: ");
                double balance = double.Parse(Console.ReadLine());
                Customer customer = new Customer(name, adress, balance);
                Console.WriteLine("\nОтлично, ваш профиль готов!\n");
                customer.ShowInfoUSer();
                Console.WriteLine();
                List<Product> productss = new List<Product>();
                while (true)
                {   
                    for(int i = 0; i < product.Length; i++)
                        Console.WriteLine($"Товар №{i + 1}: {product[i].Name}: Цена {product[i].Price} ");

                    Console.Write("\nВведите номер товара который хотели бы приобрести: ");

                    int productNumber = int.Parse(Console.ReadLine());



                    switch (productNumber)
                    {
                        case 1:
                            productss.Add(bycile);
                            Console.WriteLine($"Товар {bycile.Name}. Цена: {bycile.Price} добавлен в корзину");
                            break;
                        case 2:
                            productss.Add(ellips);
                            Console.WriteLine($"Товар {ellips.Name}. Цена: {ellips.Price} добавлен в корзину");
                            break;
                        case 3:
                            productss.Add(runningMill);
                            Console.WriteLine($"Товар {runningMill.Name}. Цена: {runningMill.Price} добавлен в корзину");
                            break;

                        default:
                            Console.WriteLine("Такого товара нет");
                            break;

                    }
                    Console.WriteLine($"Корзина({productss.Count})");
                    Console.Write("Закончить оформление заказа? (y/n) ");
                    string finishOrder = Console.ReadLine();
                    if (finishOrder.Contains('y'))
                    {
                        Console.WriteLine();
                        Console.WriteLine("\nОтлично! В вашей корзине следующие товары: \n");
                        Console.WriteLine($"Количество: {productss.Count}");
                        foreach (var p in productss)
                        {
                            p.InfoProduct();
                            Console.WriteLine();
                        }

                        Console.Write("Желаете оформить заказ? (y/n) ");
                        string goOrder = Console.ReadLine();
                        if (goOrder.Contains('y'))
                        {
                            Console.WriteLine("Выберите желаемый способ доставки: ");
                            List<Delivery> deliveries = new List<Delivery>();
                            deliveries.Add(new HomeDelivery(customer));
                            deliveries.Add(new ShopDelivery(customer));
                            foreach (var delivery in deliveries)
                            {
                                delivery.ShowDeliveryPrice();
                            }
                            Console.Write("Введите номер подходящей доставки: ");
                            int numberDelivery = int.Parse(Console.ReadLine());
                            while (true)
                            {
                                if (numberDelivery == 1)
                                {
                                    HomeDelivery homeDelivery = new HomeDelivery(customer);
                                    Order<HomeDelivery> order = new Order<HomeDelivery>(customer, productss, homeDelivery);
                                    double summ = customer.Summ(productss, homeDelivery);
                                    customer.ReduceBalance(summ, homeDelivery.DeliveryPrice);
                                    order.Informer(customer, productss, homeDelivery);
                                    customer.ShowInfoUSer();
                                    break;

                                }
                                else 
                                {
                                    ShopDelivery shopDelivery = new ShopDelivery(customer);
                                    Order<ShopDelivery> order = new Order<ShopDelivery>(customer, productss, shopDelivery);
                                    double summ = customer.Summ(productss, shopDelivery);
                                    customer.ReduceBalance(summ, shopDelivery.DeliveryPrice);
                                    order.Informer(customer, productss, shopDelivery);
                                    customer.ShowInfoUSer();
                                    break;

                                }

                            
                            }

                          
                        }
                        break;

                        

                    }
                    



                }
            }













        }
    }
}