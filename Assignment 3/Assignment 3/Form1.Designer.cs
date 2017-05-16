namespace Assignment_3
{
    partial class limousineBooking
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
            this.customerNameLabel = new System.Windows.Forms.Label();
            this.customerNameBox = new System.Windows.Forms.TextBox();
            this.pickUpLocationLabel = new System.Windows.Forms.Label();
            this.pickUpLocationBox = new System.Windows.Forms.TextBox();
            this.dropOffLocationLabel = new System.Windows.Forms.Label();
            this.dropOffLocationBox = new System.Windows.Forms.TextBox();
            this.hourlyRateLabel = new System.Windows.Forms.Label();
            this.valuehourlyRateLabel = new System.Windows.Forms.Label();
            this.chaufferNamelabel = new System.Windows.Forms.Label();
            this.driverLabel = new System.Windows.Forms.Label();
            this.pickUpdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.pickUpTimelabel = new System.Windows.Forms.Label();
            this.dropOffTimeLabel = new System.Windows.Forms.Label();
            this.dropOffdateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.submitButton = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.champagneBottleslabel = new System.Windows.Forms.Label();
            this.Roseslabel = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDown2 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // customerNameLabel
            // 
            this.customerNameLabel.AutoSize = true;
            this.customerNameLabel.Location = new System.Drawing.Point(32, 19);
            this.customerNameLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.customerNameLabel.Name = "customerNameLabel";
            this.customerNameLabel.Size = new System.Drawing.Size(82, 13);
            this.customerNameLabel.TabIndex = 0;
            this.customerNameLabel.Text = "Customer Name";
            this.customerNameLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // customerNameBox
            // 
            this.customerNameBox.Location = new System.Drawing.Point(132, 16);
            this.customerNameBox.Margin = new System.Windows.Forms.Padding(2);
            this.customerNameBox.Name = "customerNameBox";
            this.customerNameBox.Size = new System.Drawing.Size(138, 20);
            this.customerNameBox.TabIndex = 1;
            this.customerNameBox.TextChanged += new System.EventHandler(this.customerNameBox_TextChanged);
            // 
            // pickUpLocationLabel
            // 
            this.pickUpLocationLabel.AutoSize = true;
            this.pickUpLocationLabel.Location = new System.Drawing.Point(32, 55);
            this.pickUpLocationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pickUpLocationLabel.Name = "pickUpLocationLabel";
            this.pickUpLocationLabel.Size = new System.Drawing.Size(84, 13);
            this.pickUpLocationLabel.TabIndex = 2;
            this.pickUpLocationLabel.Text = "Pickup Location";
            // 
            // pickUpLocationBox
            // 
            this.pickUpLocationBox.Location = new System.Drawing.Point(132, 51);
            this.pickUpLocationBox.Margin = new System.Windows.Forms.Padding(2);
            this.pickUpLocationBox.Name = "pickUpLocationBox";
            this.pickUpLocationBox.Size = new System.Drawing.Size(138, 20);
            this.pickUpLocationBox.TabIndex = 3;
            // 
            // dropOffLocationLabel
            // 
            this.dropOffLocationLabel.AutoSize = true;
            this.dropOffLocationLabel.Location = new System.Drawing.Point(32, 94);
            this.dropOffLocationLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dropOffLocationLabel.Name = "dropOffLocationLabel";
            this.dropOffLocationLabel.Size = new System.Drawing.Size(86, 13);
            this.dropOffLocationLabel.TabIndex = 4;
            this.dropOffLocationLabel.Text = "Dropoff Location";
            // 
            // dropOffLocationBox
            // 
            this.dropOffLocationBox.Location = new System.Drawing.Point(132, 89);
            this.dropOffLocationBox.Margin = new System.Windows.Forms.Padding(2);
            this.dropOffLocationBox.Name = "dropOffLocationBox";
            this.dropOffLocationBox.Size = new System.Drawing.Size(138, 20);
            this.dropOffLocationBox.TabIndex = 5;
            // 
            // hourlyRateLabel
            // 
            this.hourlyRateLabel.AutoSize = true;
            this.hourlyRateLabel.Location = new System.Drawing.Point(53, 136);
            this.hourlyRateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.hourlyRateLabel.Name = "hourlyRateLabel";
            this.hourlyRateLabel.Size = new System.Drawing.Size(63, 13);
            this.hourlyRateLabel.TabIndex = 6;
            this.hourlyRateLabel.Text = "Hourly Rate";
            // 
            // valuehourlyRateLabel
            // 
            this.valuehourlyRateLabel.AutoSize = true;
            this.valuehourlyRateLabel.Location = new System.Drawing.Point(145, 136);
            this.valuehourlyRateLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.valuehourlyRateLabel.Name = "valuehourlyRateLabel";
            this.valuehourlyRateLabel.Size = new System.Drawing.Size(40, 13);
            this.valuehourlyRateLabel.TabIndex = 7;
            this.valuehourlyRateLabel.Text = "$77.00";
            // 
            // chaufferNamelabel
            // 
            this.chaufferNamelabel.AutoSize = true;
            this.chaufferNamelabel.Location = new System.Drawing.Point(51, 168);
            this.chaufferNamelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.chaufferNamelabel.Name = "chaufferNamelabel";
            this.chaufferNamelabel.Size = new System.Drawing.Size(78, 13);
            this.chaufferNamelabel.TabIndex = 8;
            this.chaufferNamelabel.Text = "Chauffer Name";
            // 
            // driverLabel
            // 
            this.driverLabel.AutoSize = true;
            this.driverLabel.Location = new System.Drawing.Point(145, 168);
            this.driverLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.driverLabel.Name = "driverLabel";
            this.driverLabel.Size = new System.Drawing.Size(93, 13);
            this.driverLabel.TabIndex = 9;
            this.driverLabel.Text = "Alfred Pennyworth";
            // 
            // pickUpdateTimePicker
            // 
            this.pickUpdateTimePicker.Location = new System.Drawing.Point(148, 201);
            this.pickUpdateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.pickUpdateTimePicker.Name = "pickUpdateTimePicker";
            this.pickUpdateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.pickUpdateTimePicker.TabIndex = 10;
            // 
            // pickUpTimelabel
            // 
            this.pickUpTimelabel.AutoSize = true;
            this.pickUpTimelabel.Location = new System.Drawing.Point(53, 205);
            this.pickUpTimelabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.pickUpTimelabel.Name = "pickUpTimelabel";
            this.pickUpTimelabel.Size = new System.Drawing.Size(69, 13);
            this.pickUpTimelabel.TabIndex = 11;
            this.pickUpTimelabel.Text = "Pick up Time";
            // 
            // dropOffTimeLabel
            // 
            this.dropOffTimeLabel.AutoSize = true;
            this.dropOffTimeLabel.Location = new System.Drawing.Point(53, 237);
            this.dropOffTimeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dropOffTimeLabel.Name = "dropOffTimeLabel";
            this.dropOffTimeLabel.Size = new System.Drawing.Size(71, 13);
            this.dropOffTimeLabel.TabIndex = 12;
            this.dropOffTimeLabel.Text = "Drop off Time";
            // 
            // dropOffdateTimePicker
            // 
            this.dropOffdateTimePicker.Location = new System.Drawing.Point(148, 233);
            this.dropOffdateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.dropOffdateTimePicker.Name = "dropOffdateTimePicker";
            this.dropOffdateTimePicker.Size = new System.Drawing.Size(184, 20);
            this.dropOffdateTimePicker.TabIndex = 13;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(384, 401);
            this.submitButton.Margin = new System.Windows.Forms.Padding(2);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(50, 20);
            this.submitButton.TabIndex = 14;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(363, 200);
            this.dateTimePicker1.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker1.TabIndex = 15;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(363, 233);
            this.dateTimePicker2.Margin = new System.Windows.Forms.Padding(2);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(86, 20);
            this.dateTimePicker2.TabIndex = 16;
            // 
            // champagneBottleslabel
            // 
            this.champagneBottleslabel.AutoSize = true;
            this.champagneBottleslabel.Location = new System.Drawing.Point(53, 285);
            this.champagneBottleslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.champagneBottleslabel.Name = "champagneBottleslabel";
            this.champagneBottleslabel.Size = new System.Drawing.Size(99, 13);
            this.champagneBottleslabel.TabIndex = 17;
            this.champagneBottleslabel.Text = "Champagne Bottles";
            // 
            // Roseslabel
            // 
            this.Roseslabel.AutoSize = true;
            this.Roseslabel.Location = new System.Drawing.Point(53, 324);
            this.Roseslabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.Roseslabel.Name = "Roseslabel";
            this.Roseslabel.Size = new System.Drawing.Size(37, 13);
            this.Roseslabel.TabIndex = 18;
            this.Roseslabel.Text = "Roses";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(191, 285);
            this.numericUpDown1.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown1.TabIndex = 19;
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // numericUpDown2
            // 
            this.numericUpDown2.Location = new System.Drawing.Point(191, 324);
            this.numericUpDown2.Margin = new System.Windows.Forms.Padding(2);
            this.numericUpDown2.Name = "numericUpDown2";
            this.numericUpDown2.Size = new System.Drawing.Size(80, 20);
            this.numericUpDown2.TabIndex = 20;
            // 
            // limousineBooking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 438);
            this.Controls.Add(this.numericUpDown2);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.Roseslabel);
            this.Controls.Add(this.champagneBottleslabel);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.dropOffdateTimePicker);
            this.Controls.Add(this.dropOffTimeLabel);
            this.Controls.Add(this.pickUpTimelabel);
            this.Controls.Add(this.pickUpdateTimePicker);
            this.Controls.Add(this.driverLabel);
            this.Controls.Add(this.chaufferNamelabel);
            this.Controls.Add(this.valuehourlyRateLabel);
            this.Controls.Add(this.hourlyRateLabel);
            this.Controls.Add(this.dropOffLocationBox);
            this.Controls.Add(this.dropOffLocationLabel);
            this.Controls.Add(this.pickUpLocationBox);
            this.Controls.Add(this.pickUpLocationLabel);
            this.Controls.Add(this.customerNameBox);
            this.Controls.Add(this.customerNameLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "limousineBooking";
            this.Text = "Limousine Booking Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label customerNameLabel;
        private System.Windows.Forms.TextBox customerNameBox;
        private System.Windows.Forms.Label pickUpLocationLabel;
        private System.Windows.Forms.TextBox pickUpLocationBox;
        private System.Windows.Forms.Label dropOffLocationLabel;
        private System.Windows.Forms.TextBox dropOffLocationBox;
        private System.Windows.Forms.Label hourlyRateLabel;
        private System.Windows.Forms.Label valuehourlyRateLabel;
        private System.Windows.Forms.Label chaufferNamelabel;
        private System.Windows.Forms.Label driverLabel;
        private System.Windows.Forms.DateTimePicker pickUpdateTimePicker;
        private System.Windows.Forms.Label pickUpTimelabel;
        private System.Windows.Forms.Label dropOffTimeLabel;
        private System.Windows.Forms.DateTimePicker dropOffdateTimePicker;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label champagneBottleslabel;
        private System.Windows.Forms.Label Roseslabel;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.NumericUpDown numericUpDown2;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
    }
}

