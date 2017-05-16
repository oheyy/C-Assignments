using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public abstract class ShippingCalculator
    {
        protected Address source;
        protected Customer destination;
        protected decimal weight;
        public ShippingCalculator(decimal weight, Address source, Customer destination)
        {
            this.weight = weight;
            this.destination = destination;
            this.source = source;
        }
        public ShippingCalculator()
        {

        }
        //Properties
        public Address Source
        {
            get { return source; }
            set { source = value; }
        }
        public Customer Destination
        {
            get { return destination; }
            set { destination = value; }
        }
        public decimal Weight
        {
            get { return weight; }
            set { weight = value; }
        }
        //Methods
        public virtual decimal shippingPrice()
        {
            return 0;
        }
        public virtual string estDeliveryTime()
        {
            return "0";
        }
    }
}
