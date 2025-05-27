using System;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hotel_resrvation_system
{
    public partial class Form1 : Form
    {

        private string connectionString = "Server=.;Database=Hotel_Reservation_System;User id=sa;Password=123456";

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Welcome to our Hotel!");
        }

        private async void btnloadroomavailability_Click(object sender, EventArgs e)
        {

            string query = @"SELECT Room_Id, Room_Number, Room_Type, Price_Per_Night, Availability_Status FROM Rooms
                                WHERE Availability_Status = 'Available'";

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();
                        dt.Load(reader);
                        roomGridView.DataSource = dt;
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private async void btnloadservices_Click(object sender, EventArgs e)
        {

            string query = "SELECT Service_Id, Service_Name, Service_Price FROM Services";
                
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    await connection.OpenAsync();

                    using (SqlDataReader reader = await command.ExecuteReaderAsync())
                    {
                        DataTable dt = new DataTable();

                        dt.Load(reader);
                        serviceGridView.DataSource = dt;
                    }
                }
                    
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private async void btnLoadBilling_Click(object sender, EventArgs e)
        {
            string query = "SELECT Billing_Id, Booking_Id, Total_Amount, Payment_Status FROM Billings";
            try
            {
                using (var connection = new SqlConnection(connectionString))
                using (var command = new SqlCommand(query, connection))
                {
                    await connection.OpenAsync();

                    var reader = await command.ExecuteReaderAsync();
                    DataTable dt = new DataTable();
                    dt.Load(reader);
                    billingGridView.DataSource = dt;
                } 
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
            }
        }

        private async void btnSaveGuest_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtFirstName.Text) ||
                string.IsNullOrEmpty(txtLastName.Text) ||
                string.IsNullOrEmpty(txtAddress.Text) ||
                string.IsNullOrEmpty(txtPhoneNumber.Text))
            {
                MessageBox.Show("Please provide valid data", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"INSERT INTO Guests (First_Name, Last_Name, Address, Phone)
                            VALUES (@FirstName, @LastName, @Address, @Phone);
                            SELECT SCOPE_IDENTITY();";

            try
            {
                
                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
                    command.Parameters.AddWithValue("@LastName", txtLastName.Text);
                    command.Parameters.AddWithValue("@Address", txtAddress.Text);
                    command.Parameters.AddWithValue("@Phone", txtPhoneNumber.Text);

                    await connection.OpenAsync();

                    object Result = await command.ExecuteScalarAsync();

                    if (Result != null && Int32.TryParse(Result.ToString(), out int InsertedID))
                    {
                        MessageBox.Show($"Guest information saved! New Guest ID: {InsertedID}");
                    }

                }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error {ex.Message}");
                return;
            }
        }

        private double GetRoomPrice(int RoomID)
        {
            double price = -1;

            string GetRoomPriceQuery = @"Select Price_Per_Night From Rooms
                                            Where Room_Id=@RoomID";

            using (SqlConnection connection = new SqlConnection(connectionString))
            using (SqlCommand GetPriceCommand = new SqlCommand(GetRoomPriceQuery, connection))
            {
                connection.Open();
                GetPriceCommand.Parameters.AddWithValue("@RoomID", RoomID);
                object Result = GetPriceCommand.ExecuteScalar();

                if(Result != null && double.TryParse(Result.ToString(), out double roomPrice))
                {
                    price = roomPrice;
                }
            }

            return price;
        }

        private double CalcTotalAmount(int RoomID, int Nights)
        {
            double RoomPrice = GetRoomPrice(RoomID);
            double TotalAmount = RoomPrice * Nights;
            return TotalAmount;
        }

        private bool AddBilling(int roomId, int bookingID, int Nights)
        {
            double TotalAmount = CalcTotalAmount(roomId, Nights);
            string Status = "Paid";
            int rowAffected = 0;

            string query = @"Insert into Billings
                                values(@BookingID, @TotalAmount, @Status)";

            try
            {

                using (SqlConnection connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    connection.Open();
                    command.Parameters.AddWithValue("@BookingID", bookingID);
                    command.Parameters.AddWithValue("@TotalAmount", TotalAmount);
                    command.Parameters.AddWithValue("@Status", Status);
                    rowAffected = command.ExecuteNonQuery();
                }

                if (rowAffected > 0)
                    return true;
                else
                    return false;
            }
            catch (Exception ex)
            {
                //MessageBox.Show($"Error + {ex.Message}");
                return false;
            }
        }

        private async void btnBookRoom_Click(object sender, EventArgs e)
        {
            int NumberOfNights = 0;

            if (Int32.TryParse(txtGuestId.Text, out int GuistID) && Int32.TryParse(txtRoomId.Text, out int RoomID))
            {
                if (dtpCheckIn.Value >= DateTime.Now && dtpCheckIn.Value < dtpCheckOut.Value)
                {
                    NumberOfNights = (dtpCheckOut.Value - dtpCheckIn.Value).Days;
                }
                else
                {
                    MessageBox.Show("Invalid check-in-date or check-out-date");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Please provide valid Guest ID and Room ID.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string bookingQuery = @"INSERT INTO Bookings (Guest_Id, Room_Id, Chick_in_Date, Chick_out_Date, Booking_Status) 
                                    VALUES (@GuestId, @RoomId, @CheckIn, @CheckOut, 'Confirmed'); 
                                    SELECT SCOPE_IDENTITY();";

            string updateRoomQuery = "UPDATE Rooms SET Availability_Status = 'Booked' WHERE Room_Id = @RoomId";

            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();
                using (var transaction = connection.BeginTransaction())
                {
                    try
                    {
                        int bookingId = -1;

                        using (var bookingCommand = new SqlCommand(bookingQuery, connection, transaction))
                        {
                            bookingCommand.Parameters.AddWithValue("@GuestId", GuistID);
                            bookingCommand.Parameters.AddWithValue("@RoomId", RoomID);
                            bookingCommand.Parameters.AddWithValue("@CheckIn", dtpCheckIn.Value);
                            bookingCommand.Parameters.AddWithValue("@CheckOut", dtpCheckOut.Value);

                            bookingId = Convert.ToInt32(await bookingCommand.ExecuteScalarAsync());
                        }

                        using (var updateRoomCommand = new SqlCommand(updateRoomQuery, connection, transaction))
                        {
                            updateRoomCommand.Parameters.AddWithValue("@RoomId", RoomID);
                            await updateRoomCommand.ExecuteNonQueryAsync();
                        }

                        transaction.Commit();

                        MessageBox.Show($"Room booked successfully! Booking ID: {bookingId}", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        if (AddBilling(RoomID, bookingId, NumberOfNights))
                        {
                            MessageBox.Show("Billing added successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("An error occured", "Error");
                        }
                    
                    }
                    catch (Exception ex)
                    {
                        transaction.Rollback();
                        //MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnclearguist_Click(object sender, EventArgs e)
        {
            txtFirstName.Clear();
            txtLastName.Clear();
            txtAddress.Clear();
            txtPhoneNumber.Clear();
        }

        private void btnclearbooking_Click(object sender, EventArgs e)
        {
            txtGuestId.Clear();
            txtRoomId.Clear();
        }
    }
}