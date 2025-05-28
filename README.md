# Hotel Reservation System – C# Desktop Application 🏨

A fully functional hotel reservation system developed using C# and Windows Forms, with integrated SQL Server database. The application allows users to manage bookings, rooms, guests, billing, and service tracking through a clean desktop interface.

## 🧠 Features

- Add, update, and delete hotel room bookings.
- Manage guest information and billing.
- Track services associated with each booking.
- Real-time room availability tracking.
- Clean and user-friendly Windows Forms interface.

## 🛠️ Technologies Used

- **Language:** C#
- **Framework:** .NET (Windows Forms)
- **Database:** SQL Server
- **IDE:** Visual Studio

## 🚀 How to Run

1. Clone the repository:
   ```bash
   git clone https://github.com/YourUsername/hotel-reservation-system.git
2. Open the `.sln` file in **Visual Studio**.  
3. Ensure **SQL Server** is running and restore the database using the provided `.sql` file.  
4. Update the **database connection string** in the project if needed.  
5. Build and run the project.

## 🗃️ Database Structure

- `Guests` – stores guest details.
- `Rooms` – stores room details and availability.
- `Bookings` – manages reservation data.
- `Billing` – tracks payment history.
- `Services` – optional services provided by the hotel.
- `booking_services` – many-to-many mapping between bookings and services.

## 📌 Concepts Demonstrated

- SQL CRUD operations and query optimization.
- Relational database design with foreign key constraints.
- Form validation, event-driven programming, and clean UI layout in C#.

## 👨‍💻 Author

**Ahmed Mohammed**  
[GitHub](https://github.com/Ahmedx-x)  
[LinkedIn](https://linkedin.com/in/ahmed-mohamed-26b147263)
