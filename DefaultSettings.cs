using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace HomeWork___Delivery
{
    public static class DefaultSettings
    /*
     Статический класс
     здесь описана работа магазина,
     минимальная сумма заказа
     в общем все то, что не изменяется :)
     */
    {

        public static int MinPrice { get; private set; }

        public static DateTime Time;

        public static string TimeToWork { get; private set; }

        public static string Adress { get; private set; }




        static DefaultSettings()
        {

            MinPrice = 1000;
            Time = new DateTime(2023, 10, 11, 21, 00, 40);
            TimeToWork = Time.ToString("HH:mm");
            Adress = "Улица пушкина, Дом Колотушкина";

        }

        public static void ShowInfo()
        {

            {
                Console.WriteLine($"\nИнформация для оформления заказа!\nМинимальная сумма заказа: {DefaultSettings.MinPrice}\nМагазин работает до {DefaultSettings.TimeToWork}\nМагазин работает по адресу: {DefaultSettings.Adress}");


            }
        }



    }
}




