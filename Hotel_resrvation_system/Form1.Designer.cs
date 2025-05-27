namespace Hotel_resrvation_system
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnclearguist = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.btnSaveGuest = new System.Windows.Forms.Button();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtLastName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtFirstName = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblPhonenumber = new System.Windows.Forms.Label();
            this.lblLastname = new System.Windows.Forms.Label();
            this.lblFirstname = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.btnloadroomavailability = new System.Windows.Forms.Button();
            this.roomGridView = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btnloadservices = new System.Windows.Forms.Button();
            this.serviceGridView = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnLoadBilling = new System.Windows.Forms.Button();
            this.billingGridView = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.btnclearbooking = new System.Windows.Forms.Button();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.dtpCheckOut = new System.Windows.Forms.DateTimePicker();
            this.dtpCheckIn = new System.Windows.Forms.DateTimePicker();
            this.txtRoomId = new System.Windows.Forms.TextBox();
            this.txtGuestId = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomGridView)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceGridView)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingGridView)).BeginInit();
            this.tabPage5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage5);
            this.tabControl1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(1, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1076, 596);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.btnclearguist);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnSaveGuest);
            this.tabPage1.Controls.Add(this.txtAddress);
            this.tabPage1.Controls.Add(this.txtLastName);
            this.tabPage1.Controls.Add(this.txtPhoneNumber);
            this.tabPage1.Controls.Add(this.txtFirstName);
            this.tabPage1.Controls.Add(this.lblAddress);
            this.tabPage1.Controls.Add(this.lblPhonenumber);
            this.tabPage1.Controls.Add(this.lblLastname);
            this.tabPage1.Controls.Add(this.lblFirstname);
            this.tabPage1.Location = new System.Drawing.Point(4, 33);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1068, 559);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Guest Information";
            // 
            // btnclearguist
            // 
            this.btnclearguist.BackColor = System.Drawing.Color.LightGray;
            this.btnclearguist.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclearguist.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclearguist.Location = new System.Drawing.Point(579, 392);
            this.btnclearguist.Name = "btnclearguist";
            this.btnclearguist.Size = new System.Drawing.Size(169, 76);
            this.btnclearguist.TabIndex = 19;
            this.btnclearguist.Text = "Clear";
            this.btnclearguist.UseVisualStyleBackColor = false;
            this.btnclearguist.Click += new System.EventHandler(this.btnclearguist_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(418, 67);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(200, 36);
            this.label9.TabIndex = 18;
            this.label9.Text = "Register Guist";
            // 
            // btnSaveGuest
            // 
            this.btnSaveGuest.BackColor = System.Drawing.Color.LightGray;
            this.btnSaveGuest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveGuest.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGuest.Location = new System.Drawing.Point(320, 392);
            this.btnSaveGuest.Name = "btnSaveGuest";
            this.btnSaveGuest.Size = new System.Drawing.Size(169, 76);
            this.btnSaveGuest.TabIndex = 17;
            this.btnSaveGuest.Text = "Save";
            this.btnSaveGuest.UseVisualStyleBackColor = false;
            this.btnSaveGuest.Click += new System.EventHandler(this.btnSaveGuest_Click);
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(736, 273);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(292, 35);
            this.txtAddress.TabIndex = 16;
            // 
            // txtLastName
            // 
            this.txtLastName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastName.Location = new System.Drawing.Point(197, 276);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.Size = new System.Drawing.Size(292, 35);
            this.txtLastName.TabIndex = 15;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(736, 184);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(292, 35);
            this.txtPhoneNumber.TabIndex = 14;
            // 
            // txtFirstName
            // 
            this.txtFirstName.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstName.Location = new System.Drawing.Point(197, 187);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.Size = new System.Drawing.Size(292, 35);
            this.txtFirstName.TabIndex = 13;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(574, 276);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(107, 28);
            this.lblAddress.TabIndex = 12;
            this.lblAddress.Text = "Address :";
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhonenumber.Location = new System.Drawing.Point(540, 187);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(175, 28);
            this.lblPhonenumber.TabIndex = 11;
            this.lblPhonenumber.Text = "Phone number :";
            // 
            // lblLastname
            // 
            this.lblLastname.AutoSize = true;
            this.lblLastname.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastname.Location = new System.Drawing.Point(27, 276);
            this.lblLastname.Name = "lblLastname";
            this.lblLastname.Size = new System.Drawing.Size(131, 28);
            this.lblLastname.TabIndex = 10;
            this.lblLastname.Text = "Last name :";
            // 
            // lblFirstname
            // 
            this.lblFirstname.AutoSize = true;
            this.lblFirstname.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFirstname.Location = new System.Drawing.Point(26, 187);
            this.lblFirstname.Name = "lblFirstname";
            this.lblFirstname.Size = new System.Drawing.Size(133, 28);
            this.lblFirstname.TabIndex = 9;
            this.lblFirstname.Text = "First name :";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.btnloadroomavailability);
            this.tabPage2.Controls.Add(this.roomGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 33);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1068, 559);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Available Room";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(423, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(217, 34);
            this.label1.TabIndex = 2;
            this.label1.Text = "Available Rooms";
            // 
            // btnloadroomavailability
            // 
            this.btnloadroomavailability.BackColor = System.Drawing.Color.LightGray;
            this.btnloadroomavailability.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloadroomavailability.Location = new System.Drawing.Point(429, 487);
            this.btnloadroomavailability.Name = "btnloadroomavailability";
            this.btnloadroomavailability.Size = new System.Drawing.Size(182, 52);
            this.btnloadroomavailability.TabIndex = 1;
            this.btnloadroomavailability.Text = "Load Data";
            this.btnloadroomavailability.UseVisualStyleBackColor = false;
            this.btnloadroomavailability.Click += new System.EventHandler(this.btnloadroomavailability_Click);
            // 
            // roomGridView
            // 
            this.roomGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.roomGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomGridView.Location = new System.Drawing.Point(27, 89);
            this.roomGridView.Name = "roomGridView";
            this.roomGridView.RowHeadersWidth = 51;
            this.roomGridView.RowTemplate.Height = 26;
            this.roomGridView.Size = new System.Drawing.Size(1023, 376);
            this.roomGridView.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnloadservices);
            this.tabPage3.Controls.Add(this.serviceGridView);
            this.tabPage3.Controls.Add(this.label2);
            this.tabPage3.Location = new System.Drawing.Point(4, 33);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1068, 559);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Services";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // btnloadservices
            // 
            this.btnloadservices.BackColor = System.Drawing.Color.LightGray;
            this.btnloadservices.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnloadservices.Location = new System.Drawing.Point(447, 476);
            this.btnloadservices.Name = "btnloadservices";
            this.btnloadservices.Size = new System.Drawing.Size(182, 52);
            this.btnloadservices.TabIndex = 2;
            this.btnloadservices.Text = "Load Data";
            this.btnloadservices.UseVisualStyleBackColor = false;
            this.btnloadservices.Click += new System.EventHandler(this.btnloadservices_Click);
            // 
            // serviceGridView
            // 
            this.serviceGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.serviceGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.serviceGridView.Location = new System.Drawing.Point(21, 82);
            this.serviceGridView.Name = "serviceGridView";
            this.serviceGridView.RowHeadersWidth = 51;
            this.serviceGridView.RowTemplate.Height = 26;
            this.serviceGridView.Size = new System.Drawing.Size(1025, 377);
            this.serviceGridView.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(190, 34);
            this.label2.TabIndex = 0;
            this.label2.Text = "Hotel Services";
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnLoadBilling);
            this.tabPage4.Controls.Add(this.billingGridView);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Location = new System.Drawing.Point(4, 33);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1068, 559);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Billings";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnLoadBilling
            // 
            this.btnLoadBilling.BackColor = System.Drawing.Color.LightGray;
            this.btnLoadBilling.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadBilling.Location = new System.Drawing.Point(447, 484);
            this.btnLoadBilling.Name = "btnLoadBilling";
            this.btnLoadBilling.Size = new System.Drawing.Size(182, 52);
            this.btnLoadBilling.TabIndex = 5;
            this.btnLoadBilling.Text = "Load Data";
            this.btnLoadBilling.UseVisualStyleBackColor = false;
            this.btnLoadBilling.Click += new System.EventHandler(this.btnLoadBilling_Click);
            // 
            // billingGridView
            // 
            this.billingGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.billingGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.billingGridView.Location = new System.Drawing.Point(31, 78);
            this.billingGridView.Name = "billingGridView";
            this.billingGridView.RowHeadersWidth = 51;
            this.billingGridView.RowTemplate.Height = 26;
            this.billingGridView.Size = new System.Drawing.Size(1010, 383);
            this.billingGridView.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(418, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 34);
            this.label3.TabIndex = 3;
            this.label3.Text = "Billing Information";
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.btnclearbooking);
            this.tabPage5.Controls.Add(this.btnBookRoom);
            this.tabPage5.Controls.Add(this.dtpCheckOut);
            this.tabPage5.Controls.Add(this.dtpCheckIn);
            this.tabPage5.Controls.Add(this.txtRoomId);
            this.tabPage5.Controls.Add(this.txtGuestId);
            this.tabPage5.Controls.Add(this.label8);
            this.tabPage5.Controls.Add(this.label7);
            this.tabPage5.Controls.Add(this.label6);
            this.tabPage5.Controls.Add(this.label5);
            this.tabPage5.Controls.Add(this.label4);
            this.tabPage5.Location = new System.Drawing.Point(4, 33);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage5.Size = new System.Drawing.Size(1068, 559);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Booking";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // btnclearbooking
            // 
            this.btnclearbooking.BackColor = System.Drawing.Color.LightGray;
            this.btnclearbooking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnclearbooking.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnclearbooking.Location = new System.Drawing.Point(572, 408);
            this.btnclearbooking.Name = "btnclearbooking";
            this.btnclearbooking.Size = new System.Drawing.Size(203, 75);
            this.btnclearbooking.TabIndex = 10;
            this.btnclearbooking.Text = "Clear";
            this.btnclearbooking.UseVisualStyleBackColor = false;
            this.btnclearbooking.Click += new System.EventHandler(this.btnclearbooking_Click);
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.BackColor = System.Drawing.Color.LightGray;
            this.btnBookRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookRoom.Font = new System.Drawing.Font("Tahoma", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRoom.Location = new System.Drawing.Point(246, 408);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(203, 75);
            this.btnBookRoom.TabIndex = 9;
            this.btnBookRoom.Text = "Save";
            this.btnBookRoom.UseVisualStyleBackColor = false;
            this.btnBookRoom.Click += new System.EventHandler(this.btnBookRoom_Click);
            // 
            // dtpCheckOut
            // 
            this.dtpCheckOut.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckOut.Location = new System.Drawing.Point(783, 277);
            this.dtpCheckOut.Name = "dtpCheckOut";
            this.dtpCheckOut.Size = new System.Drawing.Size(258, 32);
            this.dtpCheckOut.TabIndex = 8;
            // 
            // dtpCheckIn
            // 
            this.dtpCheckIn.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpCheckIn.Location = new System.Drawing.Point(207, 279);
            this.dtpCheckIn.Name = "dtpCheckIn";
            this.dtpCheckIn.Size = new System.Drawing.Size(258, 32);
            this.dtpCheckIn.TabIndex = 7;
            // 
            // txtRoomId
            // 
            this.txtRoomId.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoomId.Location = new System.Drawing.Point(783, 175);
            this.txtRoomId.Name = "txtRoomId";
            this.txtRoomId.Size = new System.Drawing.Size(258, 35);
            this.txtRoomId.TabIndex = 6;
            // 
            // txtGuestId
            // 
            this.txtGuestId.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGuestId.Location = new System.Drawing.Point(207, 175);
            this.txtGuestId.Name = "txtGuestId";
            this.txtGuestId.Size = new System.Drawing.Size(258, 35);
            this.txtGuestId.TabIndex = 5;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(553, 279);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 28);
            this.label8.TabIndex = 4;
            this.label8.Text = "Check-out Date:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(9, 279);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(162, 28);
            this.label7.TabIndex = 3;
            this.label7.Text = "Check-in Date:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(590, 178);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 28);
            this.label6.TabIndex = 2;
            this.label6.Text = "Room id:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(39, 178);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 28);
            this.label5.TabIndex = 1;
            this.label5.Text = "Guest id:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(421, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(226, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Booking Room";
            // 
            // Form1
            // 
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(1082, 603);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.roomGridView)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.serviceGridView)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.billingGridView)).EndInit();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSaveGuest;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtLastName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtFirstName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblPhonenumber;
        private System.Windows.Forms.Label lblLastname;
        private System.Windows.Forms.Label lblFirstname;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.Button btnloadroomavailability;
        private System.Windows.Forms.DataGridView roomGridView;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView serviceGridView;
        private System.Windows.Forms.Button btnloadservices;
        private System.Windows.Forms.Button btnLoadBilling;
        private System.Windows.Forms.DataGridView billingGridView;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtRoomId;
        private System.Windows.Forms.TextBox txtGuestId;
        private System.Windows.Forms.DateTimePicker dtpCheckOut;
        private System.Windows.Forms.DateTimePicker dtpCheckIn;
        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnclearguist;
        private System.Windows.Forms.Button btnclearbooking;
    }
}
