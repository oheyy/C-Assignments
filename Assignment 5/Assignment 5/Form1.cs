using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_5
{
    public partial class Form1 : Form
    {
        protected List<Booking> limoBooking;
        private int bookID;
        private string custName;
        private string picktime;
        private string droptime;
        private string pickloc;
        private string droploc;
        private int bottles;
        private int roses;
        public Form1()
        {
            //List View - Create the list of objects

            InitializeComponent();
            dateTimePicker2.ShowUpDown = true;
            this.saveButton.Enabled = false;
            this.cancelButton.Enabled = false;

            string executable = System.Reflection.Assembly.GetExecutingAssembly().Location;
            string path = (System.IO.Path.GetDirectoryName(executable));
            AppDomain.CurrentDomain.SetData("DataDirectory", path);

            limoBooking = limoBookings();

            foreach (Booking e in limoBooking)
            {
                string[] row = { e.CustomerName.ToString(), e.BookingId.ToString() };
                ListViewItem item = new ListViewItem(row);
                item.Tag = e;
                listView.Items.Add(item);
            }
        }

        public List<Booking> limoBookings()
        {
            List<Booking> limoBookings = new List<Booking>();
            string strAccessConn ="limodatabase.accdb";
            OleDbConnection dbConn = loadLimoBookings(strAccessConn);
            string sql = "select* from limotable";
            dbConn.Open();
            OleDbCommand cmd = new OleDbCommand(sql, dbConn);
            OleDbDataReader reader = null;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                bookID = int.Parse(reader["BookingID"].ToString());
                custName = reader["CustomerName"].ToString();
                picktime = reader["PickupDate"].ToString();
                droptime = reader["DropoffDate"].ToString();
                pickloc = reader["PickupLocation"].ToString();
                droploc= reader["DropoffLocation"].ToString();
                bottles = int.Parse(reader["ChampagneBottles"].ToString());
                roses = int.Parse(reader["Roses"].ToString());

                limoBookings.Add(
                    new Limousine(bookID, custName, "Alfred Pennyworth", 77, picktime, droptime, pickloc, droploc, bottles, roses)
                    );
            }
            
            dbConn.Close();
            return limoBookings;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            //Enabling Save and Canel Buttons for the 2nd form
            this.saveButton.Enabled = true;
            this.cancelButton.Enabled = true;

            clearForm();
            foreach (ListViewItem item in listView.SelectedItems)
            {
                var emp = item.SubItems[0].Text;
                foreach (Limousine b in limoBooking)
                {
                    if (emp.ToString() == (b.CustomerName))
                    {
                        this.customerNameBox.AppendText(b.CustomerName);
                        this.pickUpLocationBox.AppendText(b.PickUpLocation);
                        this.dropOffLocationBox.AppendText(b.DropOffLocation);
                        this.pickuptime.AppendText(b.PickUpDate);
                        this.dropofftime.AppendText(b.DropOffDate);
                        DateTime pickDate = DateTime.Parse(b.PickUpDate);
                        DateTime dropDate = DateTime.Parse(b.DropOffDate);

                        this.dateTimePicker1.Value = pickDate.Date;
                        this.numericUpDown1.Value = b.ChampagneBottles;
                        this.numericUpDown2.Value = b.Roses;
                        this.bookingidtextbox.AppendText(b.BookingId.ToString());
                        break;
                    }

                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView.SelectedItems)
            {
                //Removing item from listview
                listView.Items.Remove(item);
                //Removing from list with condition
                limoBooking.RemoveAll(x => x.CustomerName == item.SubItems[0].Text.ToString());

                string strAccessConn =/* "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=*//*"O:/New folder/Assignment 5/Assignment 5/bin/Debug/*/"limodatabase.accdb";
                OleDbConnection dbConn = loadLimoBookings(strAccessConn);
                string sql = "DELETE FROM limotable WHERE CustomerName = '"+ item.SubItems[0].Text.ToString()+"'";
                OleDbCommand cmd = new OleDbCommand(sql, dbConn);
                dbConn.Open();
                cmd.ExecuteNonQuery();
                dbConn.Close();

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string[] row = { this.customerNameBox.Text, this.bookingidtextbox.Text };
            ListViewItem item = new ListViewItem(row);
            listView.Items.Add(item);
            limoBooking.Add
            (
                new Limousine(int.Parse(this.bookingidtextbox.Text), this.customerNameBox.Text, "Alfred Pennyworth", 77, this.pickuptime.Text, this.dropofftime.Text, this.pickUpLocationBox.Text, this.dropOffLocationBox.Text, int.Parse(this.numericUpDown1.Value.ToString()), int.Parse(this.numericUpDown2.Value.ToString()))
            );
            int bookid = int.Parse(this.bookingidtextbox.Text);
            string custName = this.customerNameBox.Text;
            string picktime = this.pickuptime.Text;
            string droptime = this.dropofftime.Text;
            string pickloc = this.pickUpLocationBox.Text;
            string droploc = this.dropOffLocationBox.Text;
            int bottles = int.Parse(this.numericUpDown1.Value.ToString());
            int roses = int.Parse(this.numericUpDown2.Value.ToString());

            //printList(limoBooking);
            clearForm();
            string strAccessConn =/* "Provider=Microsoft.ACE.OLEDB.12.0;" + "Data Source=*//*"O:/New folder/Assignment 5/Assignment 5/bin/Debug/*/"limodatabase.accdb";
            OleDbConnection dbConn = loadLimoBookings(strAccessConn);
            string sql = "INSERT INTO limotable(BookingID,CustomerName,PickupDate,DropoffDate,PickupLocation,DropoffLocation,ChampagneBottles,Roses)Values("
                +bookid +",'"+custName+"','"+picktime+"','"+droptime+"','"+pickloc+"','"+droploc+"',"+bottles+","+roses+")";
              
            OleDbCommand cmd = new OleDbCommand(sql, dbConn);
            dbConn.Open();
            cmd.ExecuteNonQuery();
            dbConn.Close();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            clearForm();
        }
        public void printList(List<Booking> limo)
        {
            foreach(Limousine b in limo)
            {
                MessageBox.Show(b.ToString());
            }
        }
        private void clearForm()
        {
            this.customerNameBox.Clear();
            this.pickUpLocationBox.Clear();
            this.dropOffLocationBox.Clear();
            this.pickuptime.Clear();
            this.dropofftime.Clear();
            this.numericUpDown1.ResetText();
            this.numericUpDown2.ResetText();
            this.bookingidtextbox.Clear();
        }
        public OleDbConnection loadLimoBookings(string dbpath)
        {
            OleDbConnection dbCon = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;"+ "Data Source=|DataDirectory|/" + dbpath);
            return dbCon;
        }
    }
}



