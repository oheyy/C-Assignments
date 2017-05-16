using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    public class Customer
    {
        protected Address shippingAddress;
        protected Address billingAddress;
        protected string customerID;
        protected string password;
        protected string name;
        //In Main create shipping and billing as address objects and pass through constructor.
        public Customer(string customerID, string name, string password, Address shippingAddress, Address billingAddress)
        {
            this.customerID = customerID;
            this.password = password;
            this.shippingAddress = shippingAddress;
            this.billingAddress = billingAddress;
        }
        public Customer()
        {

        }
        //Properties
        public string CustomerID
        {
            get { return customerID; }
            set { customerID = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public Address ShippingAddress
        {
            get { return shippingAddress; }
            set { shippingAddress = value; }
        }
        public Address BillingAddress
        {
            get { return billingAddress; }
            set { billingAddress = value; }
        }

        public override string ToString()
        {
            return string.Format("Name: {0}, CustomerID: {1}", name, customerID);
        }
    }
}
