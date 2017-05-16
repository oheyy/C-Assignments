using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    public class Limousine : Booking
    {

        protected int champagneBottles;
        protected int roses;
        protected decimal price;

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
        public Limousine(int champagneBottles, int roses)
        {
            this.champagneBottles = champagneBottles;
            this.roses = roses;
        }


        //Question 3 - Price method to calculate the correct price
        public override decimal Price()
        {
            champagneBottles = champagneBottles * 30;
            roses = roses * 12;

            DateTime start = DateTime.Parse(pickUpdate);
            DateTime end = DateTime.Parse(dropOffdate);

            TimeSpan duration = (end - start);
            return decimal.Round((Convert.ToDecimal(duration.TotalHours) * hourlyRate + champagneBottles + roses),2);
        }


        //Question 5- Override the ToString method to return a nice formatted string containing the complete booking information
        public override string ToString()
        {
            return String.Format(
                "Bookingid: {0} \nCustomer Name: {1} \nChauffer Name: {2}" +
                "\nHourly Rate: {3}\nPickup Date: {4}\nDropoff Date: {5} \nPickup Location: {6} "+
                "\nDropoff location: {7} \nChampagne Price: {8}\n Rose/s Price: {9}\n"
                , bookingId, customerName, chaufferName, hourlyRate, pickUpdate, dropOffdate, 
                pickUplocation, dropOfflocation, champagneBottles, roses
            );

        }

    }
}
