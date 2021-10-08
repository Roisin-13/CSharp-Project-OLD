# **CSharp-Project**

##	Project Overview
You are tasked with creating a sales report console application which an end user can interact with via C sharp. A relational database (MySQL) should be used to store and persist the sales data.
* Database Requirements
Your MySQL database requires a single Sales table containing the following fields:
-	SaleID (INT) – Primary Key
-	Product Name (VARCHAR)
-	Quantity (INT)
-	Price (FLOAT/DECIMAL)
-	SaleDate (DATE) – Should automatically default to the days date
Ensure the database and its table are created with the appropriate names, data types and constraints.
* Project Requirements
The following requirements are must haves:
-	Upon starting the application, the user must be presented with the following two options at a minimum:
o	Data Entry
o	Reports
-	If the user selects Data Entry, they must be able to add a new sales record to the sales table in the database.
-	If the user selects Reports, they must be presented with the following four options at a minimum:
o	Sales by Year (e.g. List of all sales in the year 2020 printed to the console)
o	Sales by Month and Year (e.g. List of all sales in January of 2020 printed to the console)
o	Total Sales by Year (e.g. The total amount of sales for 2021, i.e. the sum of all the sales)
o	Total Sales by Year and Month (e.g. The total amount of sales for January of 2021)
-	MySQL queries are required for each of the Reports options, your program will run these against the database and retrieve the data to build the relevant report for the end user.
**IMPORTANT**: 	Some reports would be filtered by the year the user enters, other reports require user to enter a month AND year to filter the reports.

o	Why are we doing this project?
o	How I expected the challenge to go
o	What went well?
o	What did not go as planned?
o	Possible improvements for the future
o	Notable Mentions (i.e. anyone that may have helped/produced valuable input to your project)
