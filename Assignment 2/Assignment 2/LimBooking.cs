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
    public class LimBooking : Booking
    {
        //4 - Define additional attributes

        decimal champagneBottle; //Is hardcoded within the Price() method. 
        decimal roses; //Is hardcoded within the Price() method. 


        //4 - Constructor
        /*public LimBooking(decimal champagneBottle, decimal roses, int bookingId, string customerName, string chaufferName, decimal hourlyRate, string pickupTimeDate,
            string dropoffTimeDate, string pickupLoc, string dropoffLoc) : base(bookingId, customerName, chaufferName, hourlyRate, pickupTimeDate, dropoffTimeDate, pickupLoc, dropoffLoc)
        {
            this.champagneBottle = champagneBottle;
            this.roses = roses;
        }*/
        public LimBooking() { }

        
        //4 - Properties

        public decimal ChampagneBottle
        {
            get { return champagneBottle; }
            set { champagneBottle = value; }
        }
        public decimal Roses
        {
            get { return roses; }
            set { roses = value; }
        }
           


    //4 - Override method within Booking Class
     public override decimal Price()
    {
            decimal priceLim;



            //Calculate the difference - hours between 
            TimeSpan Diff = DropoffTimeDate - PickupTimeDate;
            //Difference in hours
            int DiffInHours = Diff.Hours;

            //Calculation of price for Lim
            priceLim = (ChampagneBottle * 30) + (Roses * 12) + (DiffInHours * HourlyRate);
            return priceLim;
    }
        //5 - Override Method ToString() - Neatly formatted :D
        public override string ToString()
        {
            return string.Format("Limousine transfer:\n Booking ID: {0}\n No. of Bottles: {1}\n No. of Roses: {2}\n Customer Name: {3}\n" + 
                " Chauffer Name: {4}\n Pickup Time: {5}\n Dropoff Time: {6}\n Pickup Location: {7}\n Droppoff Location: {8}\n", BookingID, ChampagneBottle, Roses,
                CustomerName, ChaufferName, PickupTimeDate, DropoffTimeDate, PickupLoc, DropoffLoc);
        }

        public override void Write(StreamWriter w)
        {
            //throw new NotImplementedException();
            Console.WriteLine("Start--L");
            string line = string.Format("L{0}\t{1}\t{2}\t{3}\t{4}\t{5}\t{6}\t{7}\t{8}", BookingID, ChampagneBottle, Roses, CustomerName, ChaufferName, PickupTimeDate, DropoffTimeDate, PickupLoc, DropoffLoc);
            w.WriteLine(line);
        }

        public override void Read(StreamReader r)
        {
            string line = r.ReadLine();
            string[] str = line.Split('\t');
            /*Console.WriteLine("The type is: " + str[0]);
            Console.WriteLine("The type is: " + str[1]);
            Console.WriteLine("The type is: " + str[2]);
            Console.WriteLine("The type is: " + str[3]);
            Console.WriteLine("The type is: " + str[4]);
            Console.WriteLine("The type is: " + str[5]);
            Console.WriteLine("The type is: " + str[6]);
            Console.WriteLine("The type is: " + str[7]);
            Console.WriteLine("The type is: " + str[8]);*/

            BookingID = int.Parse(str[0]);
            ChampagneBottle = decimal.Parse(str[1]);
            Roses = decimal.Parse(str[2]);
            CustomerName = str[3];
            ChaufferName = str[4];
            pickupTimeDate = DateTime.Parse(str[5]);
            DropoffTimeDate = DateTime.Parse(str[6]);
            PickupLoc = str[7];
            DropoffLoc = str[8];

        }
    }
}
  