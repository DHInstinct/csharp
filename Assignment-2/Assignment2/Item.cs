using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{

    class Item
    {
        /* Attributes an Item has: 
         *  Price
         *  Name
         *  Quantity 
         *
         */

        private string itemName;
        private int price;
        private int quantity;
        public string ItemName
        {
            get { return itemName; }
            set { itemName = value; }
        }
        public int Price
        {
            get { return price; }
            set { price = value; }
        }
        public int Quantity
        {
            get { return quantity; }
            set { quantity = value; }
        }

        public Item(string ItemName = "", int Price = 0, int Quantity = 0)
        {
            this.itemName = ItemName;
            this.price = Price;
            this.quantity = Quantity;
        }

    }
}
