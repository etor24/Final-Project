How to setup:

Download the folder with all of its components
Create a database and a table to store notes
Open the .sln file through Visual Studio
Run the program :)

# Summary
This is an app that lets you order tickets for concerts

# Functionalities:
account:
- register
- login
- save user info
- edit user info
concerts:
- search for concerts through filters
- reserve one or multiple tickets with one payment (both with an account and without one)

# sql tables required
UserInfo - used for account creation
ContactInfo - stores the information of the users or the quests
Concert - contains information about the concerts
Ticket - contains information about tickets, each ticket represents a seat
Booking - used to allow multiple ticket reservation
Payment - used to store payment info
