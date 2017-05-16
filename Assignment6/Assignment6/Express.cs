using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Express:ShippingCalculator
    {
        protected decimal price500g = 8.50m;
        protected decimal price3000g = 13.80m;
        protected decimal price5000g = 17.60m;
        protected string estTime;

        public Express(decimal weight, Address source, Customer destination):base(weight, source, destination)
        {
            
        }
        public override decimal shippingPrice()
        {
            //Domestic
            if(Source.Country == Destination.ShippingAddress.Country)
            {
                //Same postcode
                if(Source.Postcode == Destination.ShippingAddress.Postcode)
                {
                    return Weight * 0.02m;
                }
                //Different postcode
                else
                {
                    return Weight * 0.03m;
                }
            }
            //International
            else
            {
                return Weight * 0.07m;
            }
        }
        public override string estDeliveryTime()
        {
            //Domestically
            if(Source.Country == Destination.ShippingAddress.Country)
            {
                if(Source.State == Destination.ShippingAddress.State)
                {
                    return "1 day";
                }
                else
                {
                    return "4 days";
                }
            }
            //International
            else
            {
                return "14 day";
            }
        }
    }
}
