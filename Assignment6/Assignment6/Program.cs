using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Program
    {
        //Method
        public static void saveOrder(List<Item> itemList, decimal totalPrice, decimal shipPrice, decimal totalCost, string fileName, string type)
        {
            string row = null;
            StringBuilder items = new StringBuilder();
            string itemsPurch;
            try
            {
                using (StreamWriter w = new StreamWriter(fileName))
                {
                    foreach (Item i in itemList)
                    {
                        items.Append(i.Name+ " ");

                    }
                    itemsPurch = items.ToString();
                    row = string.Format("{0}\t{1}\t{2}\t{3}\t{4}", itemsPurch, totalPrice, shipPrice, totalCost, type);
                    w.Write(row);
                }
            }
            catch (FileNotFoundException e)
            {
                Console.Error.WriteLine("File Not found!" + e.Message);
            }
        }
        static void Main(string[] args)
        {
            
            //Address object representing Store Location
            Address source = new Address("26 Dean Street", "Caringbah", 2229, "NSW", "Australia");

            //Shipping and Billing address object for Customer constructor parameters
            Address billshipAdd = new Address("24 Ash Avenue", "Cronulla", 2228, "NSW", "Australia");

            //Customer Object 
            Customer customer = new Customer("#123", "Daniel", "password", billshipAdd, billshipAdd);

            //List of items 
            List<Item> itemlist = new List<Item>()
            {
                new Item(1, "T-shirt", 25, 250),
                new Item(2, "Denim-Jeans", 40, 1000),
                new Item(3, "Parka Jacket", 125, 10000000)
            };

            //linq query to print out items less than 5kg
            var itemsUnder5kg = from i in itemlist
                                where i.Weight < 5000
                                select i;
            decimal totalItemPrice = 0;
            foreach (var item in itemsUnder5kg)
            {
                //Printing out the items under 5kg using the overridden ToString() method
                Console.WriteLine(item.ToString());
                //Total Aggregate of the price of items less than 5kg
                totalItemPrice += item.Price;
            }


            //linq total price including shipping (Express of Postal choice of user)
            Console.WriteLine("Type P for postal of E for express");
            char type = (char)Console.Read();
            type = Char.ToUpper(type);
            Console.WriteLine("Character pressed is: " + type);
            decimal totalprice = 0;
            string estDelTime = null;
            string postType = null;
            List<ShippingCalculator> totalShipCost = new List<ShippingCalculator>();
            if(type == 'P')
            {
                foreach(Item i in itemlist)
                {
                    Console.WriteLine("Item Weight = " + i.Weight + "Source State = " + source.State + "Customer state = " + customer.ShippingAddress.State);
                    Parcel expShip = new Parcel(i.Weight, source, customer);
                    totalShipCost.Add(expShip);
                    postType = "Parcel";
                }
            }
            else if(type == 'E')
            {
                foreach(Item i in itemlist)
                {
                    Express parShip = new Express(i.Weight, source, customer);
                    totalShipCost.Add(parShip);
                    postType = "Express";
                }

            }
            var allCosts = from i in totalShipCost
                           select i;

            foreach(var c in allCosts)
            {
                totalprice += c.shippingPrice();
                Console.WriteLine(totalprice);
                estDelTime = c.estDeliveryTime();

            }
            //Printing out the total price of items 
            Console.WriteLine("Total price of all items = " + totalItemPrice);
            Console.WriteLine("Total shipping cost = " + totalprice);
            Console.WriteLine("Estimated delivery time = " + estDelTime);
            decimal totalCost = totalItemPrice + totalprice;
            
            saveOrder(itemlist, totalItemPrice, totalprice, totalCost, "cost.txt", postType);
        }


    }
}
