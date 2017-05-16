using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
/*
 * Assignment 2 - ISIT114
 * By Jonothan Stankovski
*/
namespace Assignment_2
{
    public class AirportTrans : Booking
    {
        //3 - Attributes - Additional
        int flightNumber;

        //3 - Constructor - inclusive of those contained within the base class
        /*public AirportTrans (int flightNumber, int bookingId, string customerName, string chaufferName, decimal hourlyRate, string pickupTimeDate,
            string dropoffTimeDate, string pickupLoc, string dropoffLoc) :base(bookingId, customerName, chaufferName, hourlyRate, pickupTimeDate, dropoffTimeDate, pickupLoc, dropoffLoc)
        {
            this.flightNumber = flightNumber;
        }*/
        public AirportTrans()
        {

        }

        //3 - Properties for additional attributes specific to AirportTrans.cs
        public int FlightNumber
        {
            get { return flightNumber; }
            set { flightNumber = value; }
        }

        //3 - Overide method within Booking Class
        public override decimal Price()
        {
            decimal priceAir;

            //Calculate the difference - hours between 
            TimeSpan Diff = DropoffTimeDate - PickupTimeDate;
            //Difference in hours
            int DiffInHours = Diff.Hours;

            //Calculation of price for Air Trans
            priceAir = (DiffInHours * HourlyRate);

            return priceAir;
        }

        //5 - Override Method ToString()
        public override string ToString()
        {
            return string.Format("Air Tansfer Booking:\n Booking ID: {0}\n Flight Number: {1}\n Customer Name: {2}\n" +
                " Chauffer Name: {3}\n Pickup Date/Time: {4}\n Drop Off Date/Time: {5}\n Pickup Location {6}\n Drop Off Location: {7}\n", BookingID, FlightNumber,
                CustomerName, ChaufferName, PickupTimeDate, DropoffTimeDate, PickupLoc, DropoffLoc);
        }

        public override void Write(StreamWriter w)
        {
            Console.WriteLine("Start--A");

            string line = string.Format("A{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}",  BookingID, FlightNumber, CustomerName, ChaufferName, PickupTimeDate, DropoffTimeDate, PickupLoc, DropoffLoc);
                    w.WriteLine(line);
        }
        public override void Read(StreamReader r)
        {
            string line = r.ReadLine();
            string[] token = line.Split('\t');
            /*Console.WriteLine("The type is: " + Int32.Parse(token[0]));
            Console.WriteLine("The type is: " + Int32.Parse(token[1]));
            Console.WriteLine("The type is: " + token[2]);
            Console.WriteLine("The type is: " + token[3]);
            Console.WriteLine("The type is: " + token[4]);
            Console.WriteLine("The type is: " + token[5]);
            Console.WriteLine("The type is: " + token[6]);
            Console.WriteLine("The type is: " + token[7]);*/

            BookingID = int.Parse(token[0]);
            FlightNumber =int.Parse(token[1]);
            CustomerName = token[2];
            ChaufferName = token[3];
            PickupTimeDate = DateTime.Parse(token[4]);
            DropoffTimeDate = DateTime.Parse(token[5]);
            PickupLoc = token[6];
            DropoffLoc = token[7];


        }

    }
}
