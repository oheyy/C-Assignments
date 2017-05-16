using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public abstract class Booking   //Question 1 Booking Class for Limousine & Airport
    {
        protected int bookingId;
        protected string customerName;
        protected string chaufferName;
        protected decimal hourlyRate;
        protected string pickUpdate; // convert into datetime
        protected string dropOffdate; // convert into datetime
        protected string pickUplocation;
        protected string dropOfflocation;

        //Properties
        public int BookingId
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

        public string PickUpDate
        {
            get { return pickUpdate; }
            set { pickUpdate = value; }
        }

        public string DropOffDate
        {
            get { return dropOffdate; }
            set { dropOffdate = value; }
        }

        public string PickUpLocation
        {
            get { return pickUplocation; }
            set { pickUplocation = value; }

        }

        public string DropOffLocation
        {
            get { return dropOfflocation; }
            set { dropOfflocation = value; }

        }
        //Question 2 - Abstract method Price
        public abstract decimal Price();


    }
}
