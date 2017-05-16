using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Threading;
using System.IO;

/*
 * Assignment 2 - ISIT114
 * By Jonothan Stankovski
 * Minor modifications by Angela Piper
*/
namespace Assignment_2
{
    // 1 - Define a booking class
    public abstract class Booking: IComparable<Booking> //Class is abstract - not allowed to create instances of the class
    {
        // 1 - Define attributes - attributes must be "protected" (Access Modifiers) to be accessable from derived classes - Access is Limited.
        protected int bookingId;
        protected string customerName;
        protected string chaufferName;
        protected decimal hourlyRate;
        protected DateTime pickupTimeDate; //Constructor converts string into DateTime
        protected DateTime dropoffTimeDate; //Constructor converts string into DateTime
        protected string pickupLoc;
        protected string dropoffLoc;


        // 1 - Constructor 
        /*public Booking(int bookingId, string customerName, string chaufferName, decimal hourlyRate, string pickupTimeDate,
            string dropoffTimeDate, string pickupLoc, string dropoffLoc)
        {
            this.bookingId = bookingId;
            this.customerName = customerName;
            this.chaufferName = chaufferName;
            this.hourlyRate = hourlyRate;
            //Convert the string valuesto DateTime for storage and manipulation. 
            this.pickupTimeDate = DateTime.Parse(pickupTimeDate); //note the date passed to the constructor must match the current locale or we will get an exception here
            this.dropoffTimeDate = DateTime.Parse(dropoffTimeDate);//e.g.  if locale is australian dd/mm/yyyy if it is US mm/dd/yyyy
            this.pickupLoc = pickupLoc;
            this.dropoffLoc = dropoffLoc;
        }*/
        public Booking() { }

        // 1 - Properties for respective attributes
        public int BookingID
        {
            get { return bookingId; }
            set { bookingId = value; }
        }
        public string CustomerName
        {
            get { return customerName; }
            set { customerName = value; }
        }
        public string ChaufferName
        {
            get { return chaufferName; }
            set { chaufferName = value; }
        }
        public decimal HourlyRate
        {
            get { return hourlyRate; }
            set { hourlyRate = value; }
        }
        public DateTime PickupTimeDate
        {
            get { return pickupTimeDate; }
            set { pickupTimeDate = value; }
        }
        public DateTime DropoffTimeDate
        {
            get { return dropoffTimeDate; }
            set { dropoffTimeDate = value; }
        }
        public string PickupLoc
        {
            get { return pickupLoc; }
            set { pickupLoc = value; }
        }
        public string DropoffLoc
        {
            get { return dropoffLoc; }
            set { dropoffLoc = value; }
        }
        public int CompareTo(Booking other)
        {
            if (this.CustomerName != other.CustomerName)
            {
                return this.CustomerName.CompareTo(this.CustomerName);
            }
            return other.CustomerName.CompareTo(this.CustomerName);
        }
        public abstract decimal Price(); // 2 - Addition of abstract method -> must be overridden in derived classes 
        public abstract void Write(StreamWriter w);
        public abstract void Read(StreamReader r);

    }
}
