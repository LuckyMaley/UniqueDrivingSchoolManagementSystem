# Unique Driving School Management System

This is the Front-End System used by Admins and Managers to book and manage bookings of driving lesson. The system is built on the vb.net programming language

**Transaction Processing requirements**	

The main purpose of the system is to successfully capture a customer and create   a time table afterwards, this feature was successfully implemented also accounting for other basic functionalities such as creation or registration of instructors, customers and other admin stuff. Deletion and updating of user details was implemented as well.

**Usability**	

The interface was made in such a way that the most important tasks that the user may want to perform are easy to access, understand, and use.  A help sub-system was successfully integrated.

**Minimisation of errors**	

Error handling and validation was heavily implemented to make sure that errors are easily identified. This includes the use of try catch statements, string formatting and setting textboxes to allow numbers for the relevant textbox.

**Learning the system**
	
The system has a friendly uncluttered, user interface and every link has a tooltip explaining a task that will be executed. We designed a help system that is easy to comprehend even for the inexperienced users thus lowering the learning curve. The user interface was made to conform to most of user interface design standards set by other large companies therefore the system almost behave like any other system which makes it easy to predict.

# Guidelines
![Static Badge](https://img.shields.io/badge/Visual%20Studio-2010%20or%20later-green) ![Static Badge](https://img.shields.io/badge/.Net%20Framework-4-purple)

# Project Structure

- This project is separated into 3 sub-systems:
  - Unique Driving School Management System ([Current project](/))
  - Unique Driving School Reporting System ([click here to visit](/../../../UniqueDrivingSchoolReportingSystem))
  - Unique Driving School Website ([click here to visit](/../../../UniqueDrivingSchoolWebsite))
- A User Story System was built for the aforementioned subsystems to keep track of the progress of the user stories and test cases during development  ([click here to visit](/../../../UserStoryApp)).

# Config

- Clone the project
- To open the project solution just double click on [UniqueDrivingSchoolManagementSystem.sln](/UniqueDrivingSchoolManagementSystem.sln) 

- (re)build application
> (re)building the application will install the required ASP.NET packages from NuGet
![Screenshot (4084)](https://github.com/LuckyMaley/UniqueDrivingSchoolManagementSystem/assets/58641501/dad9c19e-f9be-41e7-8889-7d269d6604f3)

- Database Setup
> **NOTE:** If you want to change the connection string to a live or production-ready database just go to the [App.config](/UniqueDrivingSchoolManagementSystem/App.config) file and change the existing one to your database. Example of connection string below:

 ```<add name="UniqueDrivingSchoolManagementSystem.My.MySettings.ist3bbConnectionString" connectionString="Data Source= DatabaseServerName; Integrated Security=true;Initial Catalog=UniqueDrivingSchoolDB; uid=YourUserName; Password=yourpassword; " providerName="System.Data.SqlClient" />``` 
 
 > **NOTE:** You need to also right-click the project name on the solution explorer > click properties > then go to settings, and when a pop-up message appears, click "yes" to confirm the changed connection string.

- A sql query with the relevant database tables has already been created, you just need to initialize it. There are two SQL queries
  - The first one creates a database. [Click here](/UniqueDrivingSchoolManagementSystem/SQLQueryCreateUniqueDrivingSchoolDB.sql) to go to the file called SQLQueryCreateUniqueDrivingSchoolDB.sql.
  - The second uses the database you created in the previous point to initialize the database tables. [Click here](/UniqueDrivingSchoolManagementSystem/SQLQueryUniqueDrivingSchoolDB.sql) to go to the file called SQLQueryUniqueDrivingSchoolDB.sql.

> **NOTE:** You need to make sure that the initial catalog in your connection string is the same as the database where these db tables are created or located.

- You can now run and test the system.

# Noticable improvements for future work

- The Main Menu objects can be hidden if not logged in and only appear when a user has logged in.
- Cars can be added without having an instructor assigned to them for stock-keeping.
- The system can be updated to use an API for database interactivity so users created on this system can also be accessible on the website.

# Screenshots

![1  Introduction](https://github.com/LuckyMaley/UniqueDrivingSchoolManagementSystem/assets/58641501/71d04fa8-75c9-4acd-83ce-7517d1272675)

![2  Login](https://github.com/LuckyMaley/UniqueDrivingSchoolManagementSystem/assets/58641501/708abbe5-c461-4bed-84c7-0505aa2b0a48)

![3  home](https://github.com/LuckyMaley/UniqueDrivingSchoolManagementSystem/assets/58641501/b3882dbc-95c1-41e8-8fc4-2c74f692a7b1)

![4  Book Customer](https://github.com/LuckyMaley/UniqueDrivingSchoolManagementSystem/assets/58641501/102f99f9-3fcc-4c76-8d8d-36a2da7fd0f4)

![5  Edit Customers](https://github.com/LuckyMaley/UniqueDrivingSchoolManagementSystem/assets/58641501/506d82c9-a8f8-4353-a215-dd2fff91c4cc)

![6  Timetable](https://github.com/LuckyMaley/UniqueDrivingSchoolManagementSystem/assets/58641501/2c01cfe9-85c1-48e5-a4a9-d1f8d7a01abf)

![7  Instructor](https://github.com/LuckyMaley/UniqueDrivingSchoolManagementSystem/assets/58641501/7c7d7eb5-6264-4542-8f1c-8038de75163b)

![8  DailySchedule](https://github.com/LuckyMaley/UniqueDrivingSchoolManagementSystem/assets/58641501/b5529665-47a1-43f7-ace5-666da72a09f4)

![9  Manager](https://github.com/LuckyMaley/UniqueDrivingSchoolManagementSystem/assets/58641501/60984d82-1af1-45cf-90ef-4fbb83d7c6c7)

![10  Cars](https://github.com/LuckyMaley/UniqueDrivingSchoolManagementSystem/assets/58641501/a820d555-e027-412c-9b30-8909767b4771)

[click here to visit related project](/../../../UniqueDrivingSchoolReportingSystem)


