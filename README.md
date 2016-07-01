# Address Book Webpage

#### Web Apps with Nancy Independent Project for Epicodus, 07/01/2016

#### By Shradha Pulla

## Description

This program is a basic web application designed to allow a user to create multiple new contacts and view them in a list form. Some more functions include being able to delete a singular contact, as well as the entire address book. This software serves as practice to understand basic looping and path creation in C#.

## Setup/Installation Requirements

This program can only be accessed on a PC with Windows 10, and with git and atom installed.

* Clone this repository
* Type following command into the Windows PowerShell > dnu restore
* Type following command into PowerShell > dnx kestrel
* Open Chrome and type in the following address: "localhost:5004"

## Known Bugs

No known bugs.

## Specifications

The program should ... | Example Input | Example Output
----- | ----- | -----
Input new contact information from a form and display it on contact_created.cshtml | "Create a New Contact", First Name: Jane, Last Name: Doe, submit form | "You created a Contact", Name: Jane Doe
List all new created contacts in list form on contacts.cshtml | "You Created a Contact", Name: Jane Doe | "Address Book - All Contacts", Name: Jane Doe, ... Name: Judy Cane
Identify what number contact a contact entry is, and show the number in the url path | "You Created a Contact", Name: Spain, 5th contact in address book | http://localhost:5004/contacts/5
Delete all contacts listed on contacts.cshtml and show contacts_deleted.cshtml when the "Delete Entire Address Book" button is clicked on contacts.cshtml | "Address Book - All Contacts", clicked delete all button | "You deleted all your contacts!"

## Future Features

HTML | CSS | C#
----- | ----- | -----
----- | ----- | -----

## Support and Contact Details

Contact Epicodus for support in running this program.

## Technologies Used

* HTML
* CSS
* Bootstrap
* C#

## Links

Git Hub Repository: https://github.com/pullashradha/AddressBook

### License

*This software is licensed under the Microsoft ASP.NET license.*

Copyright (c) 2016 Shradha Pulla
