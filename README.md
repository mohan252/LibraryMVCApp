LibraryMVCApp
=============

##Scope of the project
# create a home page where I can enter book title
# save book title
# create search page
# search the book title you saved
# display the results
# select one of the result
# and modify and save it

##Create Database Steps
1) Get Oracle XE db
2) create user and grant access using following commands
	* create USER LIBRARY_DATA IDENTIFIED BY d3vdata;
	* grant all privileges to LIBRARY_DATA;

##Command to run migration
1) Go to project packages/tools folder
2) Run following command
	migrate.exe --conn "DATA SOURCE=MOSXE.world;user id=LIBRARY_DATA;password=password" /provider oracle --assembly "C:\Work\WorkOuts\LibraryAppEmpty\LibraryAppEmpty\bin\LibraryAppEmpty.dll"
