using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork___Delivery
{
    public abstract class Delivery
        /*
         Абстрактный класс доставки
         */

    {
        public abstract string Adress { get; }
        public abstract double DeliveryPrice { get; }

        public abstract string DeliveryType { get; }
        public abstract void ShowDeliveryPrice();





    }





}

