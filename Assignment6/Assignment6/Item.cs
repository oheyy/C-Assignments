using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Item
    {
        //Class Variables
        //Integer for ID number
        protected int itemID;
        //String for name as a name is not always a single character
        protected string name;
        //Price in decimal data type for styling purpose
        protected decimal price;
        //Weight in grams therefore a decimal
        protected decimal weight;

        //Default Constructor
        public Item(int itemID, string name, decimal price, decimal weight)
        {
            this.itemID = itemID;
            this.name = name;
            this.price = price;
            this.weight = weight;
        }
        //Properties
        public int ItemID
        {
            get { return itemID; }
            set { itemID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public decimal Price
        {
            get { return price; }
            set { price = value; }
        }
        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }

        public override string ToString()
        {
            return string.Format("ItemID: {0} Name: {1} Price: {2} Weight:{3}", ItemID, Name, Price, Weight);
        }
    }
}
