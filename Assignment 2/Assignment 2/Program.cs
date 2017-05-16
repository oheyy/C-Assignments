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
    class Program
    {
        
        static void Main(string[] args)
        {

            //6 - Create a list and initialize with two entries of each booking type
            List<Booking> Bookings = new List<Booking>()
            {
                new LimBooking() {
                    BookingID = 1,
                    ChampagneBottle = 1,
                    Roses = 2,
                    CustomerName = "Daniel Oh",
                    ChaufferName = "Hodor",
                    HourlyRate = 12,
                    PickupTimeDate = DateTime.Parse("30/11/2016 08:30:00 PM"),
                    DropoffTimeDate = DateTime.Parse("23/10/2016 03:00 PM"),
                    PickupLoc = "Miranda",
                    DropoffLoc = "Wollongong"
                },
                new AirportTrans()
                {
                    BookingID = 2,
                    FlightNumber = 1,
                    CustomerName = "James Oh",
                    ChaufferName = "Viper",
                    HourlyRate = 12,
                    PickupTimeDate = DateTime.Parse("30/11/2016 09:30:00 PM"),
                    DropoffTimeDate = DateTime.Parse("23/10/2016 02:00 PM"),
                    PickupLoc = "Winterfell",
                    DropoffLoc = "Kings Landing"
                },
                new AirportTrans()
                {
                    BookingID = 3,
                    FlightNumber = 2,
                    CustomerName = "Bob Dylan",
                    ChaufferName = "Frank",
                    HourlyRate = 12,
                    PickupTimeDate = DateTime.Parse("24/11/2016 09:00 AM"),
                    DropoffTimeDate = DateTime.Parse("24/11/2016 04:00 PM"),
                    PickupLoc = "Winterfell",
                    DropoffLoc = "Kings Landing"
                },
                new LimBooking()
                {
                    BookingID = 4,
                    ChampagneBottle = 1,
                    Roses = 2,
                    CustomerName = "Daniel Oh",
                    ChaufferName = "Hodor",
                    HourlyRate = 12,
                    PickupTimeDate = DateTime.Parse("22/12/2016 05:00 AM"),
                    DropoffTimeDate = DateTime.Parse("22/12/2016 09:00 AM"),
                    PickupLoc = "4 Nugget St",
                    DropoffLoc = "San Jose Airport"
                }
            };


            //Print(Bookings); //Call print method passing in the list
            //TotalPrice(Bookings); //Calls the price method

            //SaveBookings("booking.txt", Bookings);
            //Console.WriteLine("End of program");    

            List<Booking> bookList = LoadBookings("booking.txt");
            bookList.Sort();
            foreach(Booking b in bookList)
            {
                Console.WriteLine(b.ToString());
            }

        }

        public static void Print(List<Booking> List) // 6 - Print Method to print each of the list objects.
        {
            foreach (Booking b in List)
            {
                Console.WriteLine(b.ToString());
            }
        }
        public static void TotalPrice(List<Booking> List) // 7 - Method to calculate the total value of bookings - Use Price() Methods within derived classes
        {
            decimal sum = 0;

            foreach  (Booking a in List)
            {
                sum += a.Price();        
                Console.WriteLine("Booking ID: {0} | Booking Price: {1:C}\n", a.BookingID, a.Price()); //Print each of the bookings and their respective prices.
            }
            Console.WriteLine("The sum value of all the bookings is: {0:C}", sum);
            Console.Read();
        }
        public static void SaveBookings(string fileName, List<Booking> booking)
        {
            Console.WriteLine("Stubs");
            //Going through a list of bookings first

                try
                {
                    using (StreamWriter w = new StreamWriter(fileName))
                    {
                        foreach (Booking b in booking)
                        {
                            b.Write(w);
                        }
                    }
                return;
                }
                catch (IOException ex)
                {
                    Console.WriteLine(ex.Message);
                }
           
            
        }
        public static List<Booking> LoadBookings(string fileName)
        {
            List<Booking> loadList = new List<Booking>();
            Booking b = null;
            char objectType;

            using (StreamReader r = new StreamReader(fileName))
            {
                //While File is not empty
                while (!r.EndOfStream)
                {
                    //Reading character for Type
                    objectType = (Char)r.Read();

                        Console.WriteLine("ObjectType is: " + objectType);
                        //Determines the type of line
                        switch (objectType)
                        {
                            //Creates Booking of type Airport or LimoBooking
                            case 'A':
                                b = new AirportTrans();
                                break;
                            case 'L':
                                b = new LimBooking();
                                break;
                            default:
                                Console.WriteLine("Could not finish l oading");
                                return loadList;
                        }
                        //Call Booking Read method
                        b.Read(r);
                        //Add Booking to list 
                        loadList.Add(b);

                } 
            }
                

            return loadList;

        }
    }
}
