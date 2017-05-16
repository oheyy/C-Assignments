using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    public class Limousine : Booking
    {

        protected int champagneBottles;
        protected int roses;

        //Properties for Champagne Bottles & Roses 
        public int ChampagneBottles
        {
            get { return champagneBottles; }
            set { champagneBottles = value; }
        }

        //Properties
        public int Roses
        {
            get { return roses; }
            set { roses = value; }
        }

        //Constructor
        public Limousine(int bookingId, string customerName, string chaufferName, decimal hourlyRate, string pickUpdate, string dropOffdate, string pickUplocation, string dropOfflocation, int champagneBottles, int roses)
            : base(bookingId, customerName, chaufferName, hourlyRate, pickUpdate, dropOffdate, pickUplocation, dropOfflocation)
        {
            this.champagneBottles = champagneBottles;
            this.roses = roses;
        }


        //Price method to calculate the correct price
        public override decimal Price()
        {
            champagneBottles = champagneBottles * 30;
            roses = roses * 12;

            DateTime start = DateTime.Parse(pickUpdate);
            DateTime end = DateTime.Parse(dropOffdate);

            TimeSpan duration = (end - start);
            return Convert.ToDecimal(duration.TotalHours) * hourlyRate + champagneBottles + roses;
        }



        public override string ToString()
        {
            return String.Format("Bookingid: {0} Customer Name: {1} Chauffer Name: {2} Hourly Rate: {3} Pickup Date: {4} Dropoff Date: {5} Pickup Location: {6} Dropoff location: {7} Champagne Bottles:{8} Roses:{9}", bookingId, customerName, chaufferName, hourlyRate, pickUpdate, dropOffdate, pickUplocation, dropOfflocation, champagneBottles, roses);

        }

    }
}
