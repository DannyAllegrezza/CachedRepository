# Cached Repository Demo

This simple example shows how to implement a caching layer in front of your existing repository. 

### Use cases

* Improve response time
* Reduce server load
* Useful for caching resources which have a high access cost, but rarely change

### Demo

This project uses ASP.NET Core 2.1.4 Razor Pages, along with EntityFramework Core, which is the database provider for a SQLite database. 

The sample schema is very simple:

1. `VehicleManufacturer` table
	* `[pk] Id`
	* `Name`
	* `Description`

2. `Models` table
	* `[pk] Id`
	* `Name`
	* `[fk] VehicleManufacturer_Id`

