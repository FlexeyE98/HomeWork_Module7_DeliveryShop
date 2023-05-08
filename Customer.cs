using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork___Delivery
{
    public class Customer 
        /*Класс клиента. 
         *Здесь реализовал логику подсчета денежных средств на балансе, 
         *информация о пользователе
         *и итоговая сумма*/
    {
        private double balance;
        public string Name { get; private set; }
        public string Address { get; private set; }
        public double Balance
        {
            get { return balance; }
            private set
            {
                if (value < 1000)
                    while (true)

                    {
                        Console.Write("У вас недостаточно денежных средств. Пополните баланс: ");
                        balance = double.Parse(Console.ReadLine());
                        if (balance > 1000)
                        {
                            balance = value;
                            break;
                        }
                    }
                else
                {
                    balance = value;

                }
               
            }
        }




        public Customer(string name, string adress, double balance)
        {
            Name = name;
            Address = adress;
            Balance = balance;

        }

        public void ShowInfoUSer()
        {
            Console.WriteLine($"\nДанные пользователя:\nИмя: {Name}\nАдресс: {Address}\nБаланс: {Balance}");
        }

        public double ReduceBalance(double price, double deliveryPrice)
        {
            if (Balance < price)
            {
                while (true)
                {
                    Console.Write("Недостаточно денежных средств. Введите сумму больше ");
                    double correctbalance = double.Parse(Console.ReadLine());
                    if (correctbalance > price)
                    { 
                        Balance = correctbalance;
                    }
                        break;
                }
                
            }
            
            Balance -= price;
            return Balance;

        }

        public virtual double Summ(List<Product> products, Delivery deliveryPrice)
        {
            int price = 0;

            foreach (var p in products)
            {
                price += p.Price;

            }
            return price + deliveryPrice.DeliveryPrice;

        }








    }





}

