using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StoreLibrary
{
    public class Product
    {
        public string Name;
        private int price;
        public float Discount;

        public int GetPrice()
        {
            return this.price;
        }

        public void SetPrice(int price)
        {
            if (price > 200)
            {
                this.price = 200;
            }
            else if (price < 39)
            {
                this.price = 39;
            }
            else
            {
                this.price = price;
            }
        }
    }
}