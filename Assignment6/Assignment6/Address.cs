using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6
{
    //Base class for Customer Class
    public class Address
    {
        protected string street;
        protected string suburb;
        protected int postcode;
        protected string state;
        protected string country;

        public Address(string street, string suburb, int postcode, string state, string country)
        {
            this.street = street;
            this.suburb = suburb;
            this.postcode = postcode;
            this.state = state;
            this.country = country;
        }

        public string Street
        {
            get { return street; }
            set { street = value; }
        }
        public string Suburb
        {
            get { return suburb; }
            set { suburb = value; }
        }
        public int Postcode
        {
            get { return postcode; }
            set { postcode = value; }
        }
        public string State
        {
            get { return state; }
            set { state = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }

        public override string ToString()
        {
            return string.Format("Street Name: {0}\n Suburb: {1}\n Postcode: {2}\n State: {3}\n Country: {4}", Street, Suburb, Postcode, State, Country);
        }
    }
}
