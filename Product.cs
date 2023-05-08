using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork___Delivery
{
    public abstract class Product
    {


        public abstract string Name { get; }
        public abstract string Description { get; }
        public abstract int Price { get; }

        public abstract double Weight { get; }

        public abstract void InfoProduct();

        











    }

}
