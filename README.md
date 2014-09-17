LibraryMVCApp
=============

##Scope of the project
1. create a home page where I can enter book title
2. save book title
3. create search page
4. search the book title you saved
5. display the results
6. select one of the result
7. and modify and save it

##Create Database Steps
1. Get Oracle XE db
2. create user and grant access using following commands
	- create USER LIBRARY_DATA IDENTIFIED BY password;
	- grant all privileges to LIBRARY_DATA;

##Command to run migration
1. Go to project packages/tools folder
2. Run following command
	- migrate.exe --conn "DATA SOURCE=MOSXE.world;user id=LIBRARY_DATA;password=password" /provider oracle --assembly "C:\Work\WorkOuts\LibraryAppEmpty\LibraryAppEmpty\bin\LibraryAppEmpty.dll"
