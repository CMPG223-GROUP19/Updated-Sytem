USE TAWANDA;
GO

--CREATE LOGIN TABLE
CREATE TABLE LOGIN (
	User_Name		varchar(15),
	User_passwords	varchar(8),
	);

--CREATE CHILD TABLE
CREATE TABLE CHILD(
	Child_ID		int IDENTITY(1,1) PRIMARY KEY,
	Child_LName		varchar(25),
	Child_FName		varchar(25),
	ID_Number		char(13),
	Arrival_Date	date,
	Accepted_YN		bit,
	Departure_Date	date,
	);


--CREATE SPONSOR TABLE
CREATE TABLE SPONSOR(
	Sponsor_ID		int IDENTITY(1,1) PRIMARY KEY,
	Sponsor_LName	varchar(255) NOT NULL,
	Sponsor_FName	varchar(255) NOT NULL,
	Sponsor_EmailAddr	varchar(255) UNIQUE,
	Sponsor_PhoneNo		char(10) UNIQUE,
	);

--CREATE DONATION TABLE
CREATE TABLE DONATION(
	Donation_ID		int IDENTITY(1,1) PRIMARY KEY,
	Sponsor_ID		int,
	Date_Received	date,
	Amount			money,
	Quantity		varchar(10),
	
	CONSTRAINT FK_DONATION_SPONSOR FOREIGN KEY (Sponsor_ID)
	REFERENCES SPONSOR (Sponsor_ID),
	);


--CREATE DONATION_TYPE TABLE
CREATE TABLE DONATION_TYPE(
	DonationT_ID		int IDENTITY(1,1) PRIMARY KEY,
	Description		varchar(50) UNIQUE,
	);

--CREATE DONATION_DETAILS TABLE
CREATE TABLE DONATION_DETAILS(
	Donation_ID		int,
	DonationT_ID		int,

	CONSTRAINT PK_DONATION_DETAILS PRIMARY KEY (Donation_ID, DonationT_ID),

	CONSTRAINT FK_DONATION_DETAILS_DONATION FOREIGN KEY (Donation_ID)
	REFERENCES DONATION (Donation_ID),
	CONSTRAINT FK_DONATION_DETAILS_DONATION_TYPE FOREIGN KEY (DonationT_ID)
	REFERENCES DONATION_TYPE (DonationT_ID),
	);

--INSERT DATA INTO THE DATABASE
--INSERT INTO LOGIN TABLE
INSERT INTO LOGIN (User_Name, User_passwords)
VALUES
	('Linda@03','#Man0003'),
	('Mpho@66', '#Admin66');

--INSERT INTO CHILD TABLE
INSERT INTO CHILD (Child_ID, Child_LName, Child_FName, ID_Number, Arrival_Date, Accepted_YN, Departure_Date)
VALUES
	('0', 'Matlhabane', 'Lerato', '0310310650086', '2018-01-01', 'N', '2022-01-01'),
	('1', 'Kgatlanyane', 'Omphile', '2211057120087', '2018-01-01', 'N', '2022-01-01'),
	('2', 'Black', 'lucas', '2105056244085', '2021-05-19', 'N', '2022-01-01'),
	('3', 'Matlhabane', 'Lerato', '0310310650086', '2018-01-01', 'N', '2022-01-01'),
	('4', 'Matlhabane', 'Lerato', '0310310650086', '2018-01-01', 'N', '2022-01-01'),
	('5', 'Matlhabane', 'Lerato', '0310310650086', '2018-01-01', 'N', '2022-01-01'),
	('6', 'Matlhabane', 'Lerato', '0310310650086', '2018-01-01', 'N', '2022-01-01'),
	('7', 'Matlhabane', 'Lerato', '0310310650086', '2018-01-01', 'N', '2022-01-01'),
	('8', 'Matlhabane', 'Lerato', '0310310650086', '2018-01-01', 'N', '2022-01-01'),
	('9', 'Matlhabane', 'Lerato', '0310310650086', '2018-01-01', 'N', '2022-01-01');

--INSERT INTO SPONSOR TABLE
	('1', 'Shoprite', 'Checkers', 'Shoprite@gmail.ac.za', '0118629531'),
	('2', 'Shoprite', 'Checkers', 'Shoprite@gmail.ac.za', '0118629531'),
	('3', 'Shoprite', 'Checkers', 'Shoprite@gmail.ac.za', '0118629531'),
	('4', 'Shoprite', 'Checkers', 'Shoprite@gmail.ac.za', '0118629531');

--INSERT INTO DONATION TABLE
INSERT INTO DONATION (Donation_ID, Sponsor_ID, Date_Received, Amount, Quantity)
VALUES
	('0', '1', '2023-10-05', 'R13 000', 'NULL'),
	('1', '1', '2023-10-05', 'R13 000', 'NULL'),
	('2', '1', '2023-10-05', 'R13 000', 'NULL'),
	('3', '1', '2023-10-05', 'R13 000', 'NULL'),
	('4', '1', '2023-10-05', 'R13 000', 'NULL'),
	('5', '1', '2023-10-05', 'R13 000', 'NULL');

--INSERT INTO DONATION_TYPE TABLE
INSERT INTO DONATION_TYPE (DonationT_ID, Description)
VALUES
	('0', 'Money'),
	('1', 'Money'),
	('2', 'Money'),
	('3', 'Money'),
	('4', 'Money'),
	('5', 'Money');


--INSERT INTO DONATION_DETAILS TABLE
INSERT INTO DONATION_DETAILS (Donation_ID, DonationT_ID)
VALUES
	('0', '0'),
	('1', '1'),
	('2', '2'),
	('3', '3'),
	('4', '4'),
	('5', '5');