namespace Assignment_5
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView = new System.Windows.Forms.ListView();
            this.customerNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bookingIDHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.addButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pickUpLocationBox = new System.Windows.Forms.TextBox();
            this.dropOffLocationlabel = new System.Windows.Forms.Label();
            this.dropOffLocationBox = new System.Windows.Forms.TextBox();
            this.hourlyRatelabel = new System.Windows.Forms.Label();
            this.valuehourlyRateLabel = new System.Windows.Forms.Label();
            this.pickUpTimelabel = new System.Windows.Forms.Label();
            this.dropOffTimeLabel = new System.Windows.Forms.Label();
            this.champagneBottleslabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.Roseslabel = new System.Windows.Forms.Label();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            this.saveButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.pickuptime = new System.Windows.Forms.TextBox();
            this.dropofftime = new System.Windows.Forms.TextBox();
            this.bookingidtextbox = new System.Windows.Forms.TextBox();
            this.bookingID = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // listView
            // 
            this.listView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.customerNameHeader,
            this.bookingIDHeader});
            this.listView.FullRowSelect = true;
            this.listView.GridLines = true;
            this.listView.Location = new System.Drawing.Point(43, 25);
            this.listView.Margin = new System.Windows.Forms.Padding(2);
            this.listView.MultiSelect = false;
            this.listView.Name = "listView";
            this.listView.Size = new System.Drawing.Size(255, 381);
            this.listView.TabIndex = 0;
            this.listView.UseCompatibleStateImageBehavior = false;
            this.listView.View = System.Windows.Forms.View.Details;
            // 
            // customerNameHeader
            // 
            this.customerNameHeader.Text = "Customer Name";
            this.customerNameHeader.Width = 150;
            // 
            // bookingIDHeader
            // 
            this.bookingIDHeader.Text = "Booking ID";
            this.bookingIDHeader.Width = 100;
            // 
            // addButton
            // 
            this.addButton.Location = new System.Drawing.Point(43, 420);
            this.addButton.Margin = new System.Windows.Forms.Padding(2);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(95, 36);
            this.addButton.TabIndex = 1;
            this.addButton.Text = "Add";
            this.addButton.UseVisualStyleBackColor = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(203, 420);
            this.deleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(95, 36);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(371, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Customer Name";
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(491, 34);
            this.customerNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(209, 20);
            this.customerNameBox.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(371, 67);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pickup Location";
            // 
            // pickUpLocationBox
            // 
            this.pickUpLocationBox.Location = new System.Drawing.Point(491, 63);
            this.pickUpLocationBox.Margin = new System.Windows.Forms.Padding(2);
            this.pickUpLocationBox.Name = "pickUpLocationBox";
            this.pickUpLocationBox.Size = new System.Drawing.Size(209, 20);
            this.pickUpLocationBox.TabIndex = 6;
            // 
            // dropOffLocationlabel
            // 
            this.dropOffLocationlabel.AutoSize = true;
            this.dropOffLocationlabel.Location = new System.Drawing.Point(371, 99);
            this.dropOffLocationlabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dropOffLocationlabel.Name = "dropOffLocationlabel";
            this.dropOffLocationlabel.Size = new System.Drawing.Size(86, 13);
            this.dropOffLocationlabel.TabIndex = 7;
            this.dropOffLocationlabel.Text = "Dropoff Location";
            // 
            // dropOffLocationBox
            // 
            this.dropOffLocationBox.Location = new System.Drawing.Point(491, 99);
            this.dropOffLocationBox.Margin = new System.Windows.Forms.Padding(2);
            this.dropOffLocationBox.Name = "dropOffLocationBox";
            this.dropOffLocationBox.Size = new System.Drawing.Size(209, 20);
            this.dropOffLocationBox.TabIndex = 8;
            // 
            // hourlyRatelabel
            // 
            this.hourlyRatelabel.AutoSize = true;
            this.hourlyRatelabel.Location = new System.Drawing.Point(371, 129);
            this.hourlyRatelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hourlyRatelabel.Name = "hourlyRatelabel";
            this.hourlyRatelabel.Size = new System.Drawing.Size(63, 13);
            this.hourlyRatelabel.TabIndex = 9;
            this.hourlyRatelabel.Text = "Hourly Rate";
            // 
            // valuehourlyRateLabel
            // 
            this.valuehourlyRateLabel.AutoSize = true;
            this.valuehourlyRateLabel.Location = new System.Drawing.Point(489, 129);
            this.valuehourlyRateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valuehourlyRateLabel.Name = "valuehourlyRateLabel";
            this.valuehourlyRateLabel.Size = new System.Drawing.Size(40, 13);
            this.valuehourlyRateLabel.TabIndex = 10;
            this.valuehourlyRateLabel.Text = "$77.00";
            // 
            // pickUpTimelabel
            // 
            this.pickUpTimelabel.AutoSize = true;
            this.pickUpTimelabel.Location = new System.Drawing.Point(371, 165);
            this.pickUpTimelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pickUpTimelabel.Name = "pickUpTimelabel";
            this.pickUpTimelabel.Size = new System.Drawing.Size(69, 13);
            this.pickUpTimelabel.TabIndex = 11;
            this.pickUpTimelabel.Text = "Pick up Time";
            // 
            // dropOffTimeLabel
            // 
            this.dropOffTimeLabel.AutoSize = true;
            this.dropOffTimeLabel.Location = new System.Drawing.Point(371, 194);
            this.dropOffTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dropOffTimeLabel.Name = "dropOffTimeLabel";
            this.dropOffTimeLabel.Size = new System.Drawing.Size(71, 13);
            this.dropOffTimeLabel.TabIndex = 14;
            this.dropOffTimeLabel.Text = "Drop off Time";
            // 
            // champagneBottleslabel
            // 
            this.champagneBottleslabel.AutoSize = true;
            this.champagneBottleslabel.Location = new System.Drawing.Point(371, 270);
            this.champagneBottleslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.champagneBottleslabel.Name = "champagneBottleslabel";
            this.champagneBottleslabel.Size = new System.Drawing.Size(99, 13);
            this.champagneBottleslabel.TabIndex = 17;
            this.champagneBottleslabel.Text = "Champagne Bottles";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(491, 270);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 18;
            // 
            // Roseslabel
            // 
            this.Roseslabel.AutoSize = true;
            this.Roseslabel.Location = new System.Drawing.Point(374, 308);
            this.Roseslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Roseslabel.Name = "Roseslabel";
            this.Roseslabel.Size = new System.Drawing.Size(37, 13);
            this.Roseslabel.TabIndex = 19;
            this.Roseslabel.Text = "Roses";
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(491, 308);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown2.TabIndex = 20;
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(491, 412);
            this.saveButton.Margin = new System.Windows.Forms.Padding(2);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(79, 44);
            this.saveButton.TabIndex = 21;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(621, 412);
            this.cancelButton.Margin = new System.Windows.Forms.Padding(2);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(79, 44);
            this.cancelButton.TabIndex = 22;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // pickuptime
            // 
            this.pickuptime.Location = new System.Drawing.Point(491, 158);
            this.pickuptime.Name = "pickuptime";
            this.pickuptime.Size = new System.Drawing.Size(209, 20);
            this.pickuptime.TabIndex = 23;
            // 
            // dropofftime
            // 
            this.dropofftime.Location = new System.Drawing.Point(491, 194);
            this.dropofftime.Name = "dropofftime";
            this.dropofftime.Size = new System.Drawing.Size(209, 20);
            this.dropofftime.TabIndex = 24;
            // 
            // bookingidtextbox
            // 
            this.bookingidtextbox.Location = new System.Drawing.Point(491, 230);
            this.bookingidtextbox.Name = "bookingidtextbox";
            this.bookingidtextbox.Size = new System.Drawing.Size(209, 20);
            this.bookingidtextbox.TabIndex = 26;
            // 
            // bookingID
            // 
            this.bookingID.AutoSize = true;
            this.bookingID.Location = new System.Drawing.Point(371, 230);
            this.bookingID.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.bookingID.Name = "bookingID";
            this.bookingID.Size = new System.Drawing.Size(60, 13);
            this.bookingID.TabIndex = 25;
            this.bookingID.Text = "Booking ID";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(374, 345);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(209, 20);
            this.dateTimePicker1.TabIndex = 27;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.CustomFormat = "";
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(619, 345);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(81, 20);
            this.dateTimePicker2.TabIndex = 28;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 467);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.bookingidtextbox);
            this.Controls.Add(this.bookingID);
            this.Controls.Add(this.dropofftime);
            this.Controls.Add(this.pickuptime);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.Roseslabel);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.champagneBottleslabel);
            this.Controls.Add(this.dropOffTimeLabel);
            this.Controls.Add(this.pickUpTimelabel);
            this.Controls.Add(this.valuehourlyRateLabel);
            this.Controls.Add(this.hourlyRatelabel);
            this.Controls.Add(this.dropOffLocationBox);
            this.Controls.Add(this.dropOffLocationlabel);
            this.Controls.Add(this.pickUpLocationBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.addButton);
            this.Controls.Add(this.listView);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox pickUpLocationBox;
        private System.Windows.Forms.Label dropOffLocationlabel;
        private System.Windows.Forms.TextBox dropOffLocationBox;
        private System.Windows.Forms.Label hourlyRatelabel;
        private System.Windows.Forms.Label valuehourlyRateLabel;
        private System.Windows.Forms.Label pickUpTimelabel;
        private System.Windows.Forms.Label dropOffTimeLabel;
        private System.Windows.Forms.Label champagneBottleslabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Label Roseslabel;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.ColumnHeader customerNameHeader;
        private System.Windows.Forms.ColumnHeader bookingIDHeader;
        private System.Windows.Forms.TextBox pickuptime;
        private System.Windows.Forms.TextBox dropofftime;
        private System.Windows.Forms.TextBox bookingidtextbox;
        private System.Windows.Forms.Label bookingID;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}

