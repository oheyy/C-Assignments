using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Parcel:ShippingCalculator
    {
        protected decimal price500g = 8.50m;
        protected decimal price3000g = 13.80m;
        protected decimal price5000g = 17.60m;
        protected decimal shipPrice;
        protected string estTime;
        public Parcel(decimal weight, Address source, Customer destination):base(weight, source, destination)
        {

        }
        public override decimal shippingPrice()
        {
            try {
                if ((Weight >= 0) && (Weight <= 500))
                {
                    shipPrice = price500g;
                }
                else if ((Weight >= 500) && (Weight <= 3000))
                {
                    shipPrice = price3000g;
                }
                else if ((Weight >= 3000) && (Weight <= 5000))
                {
                    shipPrice = price5000g;
                }
                else if (Weight > 5000)
                {
                    Console.WriteLine("Cannot ship objects over 5kg using parcel post");
                }
            }catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("Thrown exception" + ex.Message);
            }


            //Secondary If statement
            if(Source.Country == Destination.ShippingAddress.Country)
            {
                return shipPrice;
            }
            else
            {
                return 3 * shipPrice;
            }
        }
        public override string estDeliveryTime()
        {
            //Domestic
            if(Source.Country == Destination.ShippingAddress.Country)
            {
                //Same state 
                if(Source.State == Destination.ShippingAddress.State)
                {
                    return estTime = "3-4 days";
                }
                //Different state
                else
                {
                    return estTime = "5-6 days";
                }
            }
            //International
            else
            {
                return estTime = "21 days";
            }
        }
    }
}
