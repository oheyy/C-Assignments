using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_3
{
    public partial class limousineBooking : Form
    {
        protected int counter;
        List<Booking> bookings;
        public limousineBooking()
        {
            InitializeComponent();
            //Altering the DatePicker for Updown selector
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker2.ShowUpDown = true;
            counter = 0;
            bookings= new List<Booking>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Submit button was clicked");
            //Show the customer name, pickup and dropoff location

            //Variables from Form.
            string customerNameLabel = customerNameBox.Text;
            string pickUpLocationLabel = pickUpLocationBox.Text;
            string dropOffLocationLabel = dropOffLocationBox.Text;
            //converting to integer
            int champagne = Convert.ToInt32(numericUpDown1.Value);
            int roses = Convert.ToInt32(numericUpDown2.Value);
            //Concating pickupdate with pickuptime
            string pickupdate = pickUpdateTimePicker.Text + " " + dateTimePicker1.Text;
            string dropofftime = dropOffdateTimePicker.Text + " " + dateTimePicker2.Text;
            //Converts to decimal from a string value with a $ sign
            decimal hourlyRate = decimal.Parse(valuehourlyRateLabel.Text, System.Globalization.NumberStyles.AllowCurrencySymbol | System.Globalization.NumberStyles.Number);
            
            // Testing if null and displaying warning message
            if (string.IsNullOrWhiteSpace(customerNameLabel))
            {
                MessageBox.Show("Enter a Customer Name Please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(pickUpLocationLabel))
            {
                MessageBox.Show("Enter a Pickup Location Please!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else if (string.IsNullOrWhiteSpace(dropOffLocationLabel))
            {
                MessageBox.Show("Enter a Dropoff Location Please", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                //Booking ID incremented
                counter++;
                //Creating a new entry for list
                bookings.Add(new Limousine(champagne, roses)
                {
                    BookingId = counter,
                    CustomerName = customerNameBox.Text,
                    ChaufferName = driverLabel.Text,
                    HourlyRate = hourlyRate,
                    PickUpDate = pickupdate,
                    DropOffDate = dropofftime,
                    PickUpLocation = pickUpLocationBox.Text,
                    DropOffLocation = dropOffLocationBox.Text
                });
                decimal price = 0;
                //
                foreach (Booking b in bookings)
                {
                    if(b.BookingId == counter)
                    {
                        price = b.Price();
                        break;
                    }
                    //MessageBox.Show(b.ToString());
                }
               MessageBox.Show(
                    string.Format("Booking ID: {0},\n Customer Name: {1}, \nPickup Location: {2}," +
                    "\nDropoff Location: {3}, \nChampagne: {4}.\nRoses: {5} \nPickuptime: {6}," +
                    "\nDropofftime: {7},\nPrice: {8}.", 
                    counter, customerNameBox.Text, pickUpLocationBox.Text, 
                    dropOffLocationBox.Text, champagne, roses, pickupdate, dropofftime, price),
                    "Confirmation", MessageBoxButtons.OK, MessageBoxIcon.Question
                );
            }


        }

        private void customerNameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
