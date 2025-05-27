create database Hotel_Reservation_System;
 
create table Guests(
	Guest_Id int primary key identity(1,1),
	First_Name varchar(50) not null,
	Last_Name varchar(50) not null,
	Address varchar(50) not null,
	Phone varchar(50) not null unique
);

create table Rooms(
	Room_Id int primary key identity(1,1),
	Room_Number int unique not null,
	Room_type varchar(25) check (Room_type in ('Single', 'Double')) not null,
	Price_Per_Night numeric check (Price_Per_Night > 0),
	Availability_Status varchar(50) check (Availability_Status in ('Available', 'Booked')) not null
);

create table Bookings(
	Booking_Id int primary key identity(1,1),
	Guest_Id int references Guests(Guest_Id),
	Room_Id int references Rooms(Room_Id),
	Chick_in_Date date not null,
	Chick_out_Date date not null,
	Booking_Status varchar(50) check (Booking_Status in ('Confirmed', 'Cancelled')) not null
);


create table Billings(
	Billing_Id int primary key identity(1,1),
	Booking_Id int references Bookings(Booking_Id),
	Total_amount numeric check (Total_amount >= 0),
	Payment_status varchar(50) check (Payment_status in ('Paid', 'Pending'))
);

create table Services(
	Service_id int primary key identity(1,1),
	Service_name varchar(50) not null,
	Service_price numeric check (Service_price >= 0) not null
);

create table booking_services(
	booking_id int references Bookings(Booking_Id) not null,
	service_id int references Services(Service_Id) not null,
	primary key(booking_id, service_id)
);

insert into Guests
values('Ahmed', 'mohamed', 'Menofia', '01229910788');

insert into Guests
values('Fares', 'mahmod', 'Menofia', '01223439603');


insert into Rooms
values(13, 'Single', 100, 'Available');

insert into Rooms
values(3, 'Double', 200, 'Available');

insert into Rooms
values(21, 'Double', 200, 'Available');

insert into Rooms
values(25, 'Single', 100, 'Available')


INSERT INTO Bookings
VALUES (1, 1, '2024-12-01', '2024-12-03', 'Confirmed');

INSERT INTO Bookings
VALUES (2, 4, '2024-01-02', '2024-01-03', 'Cancelled');

INSERT INTO Bookings
VALUES (1, 2, '2024-12-18', '2024-12-25', 'Confirmed');


INSERT INTO Billings
values(1, 150, 'Paid');

INSERT INTO Billings
values(3, 250, 'Pending');

INSERT INTO Services
values('Breakfast', 50);

INSERT INTO Services
values('Diner', 70);

INSERT INTO booking_services
VALUES(1, 1);

INSERT INTO booking_services
VALUES(1, 2);

INSERT INTO booking_services
VALUES(3, 1);

select * from Guests
select * from Rooms
select * from Bookings
select * from Billings
select * from Services
select * from booking_services