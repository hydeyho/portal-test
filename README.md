# Portal Test

## Introduction

A basic portal has been created for internal use but it still needs some work.

## Tasks

* Demostrate your UI/frontend skills and show us how you would layout the site
* The delivery date on the machine details needs displaying in the standard UK format (dd/mm/yyyy)
* Add some error handling if a user attempts to navigate to a customer or machine that doesn't exist e.g. /customers/XYZ123
* Machines need servicing just like cars; add a new property to the `Machine` class for the next service date
  * Update view to display this new property
* Extend the system to handle `Location` data (classes already exist in the *Models* folder)
  * Include new C# API endpoint (use the `CustomersController` and `MachinesController` as a basis for your `LocationsController`)
  * Create the relevant front end code to retrieve and display the new API data
