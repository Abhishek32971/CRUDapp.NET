# CRUDapp
## CRUD Application for MySQL Database

This is a C# application demonstrating basic CRUD (Create, Read, Update, Delete) operations on a MySQL database.

**Requirements:**

-   .NET Framework (or compatible)
-   MySQL Server
-   Visual Studio (or any other C# development environment)
-   MySQL Connector/NET (add reference during project setup)

**Features:**
   - Check Connection
     > Checks connection to the database.
![Screenshot 2024-06-12 171913](https://github.com/Abhishek32971/CRUDapp.NET/assets/97088891/8d38850f-8b4f-4c0d-bd8a-8108c2112b82)

   - Insert operation
    
  >  Performs data insertion into a table using user input.


![Screenshot 2024-06-12 171950](https://github.com/Abhishek32971/CRUDapp.NET/assets/97088891/ba07e117-6cca-4331-a60e-02119fc2ca11)


   - Read operation
    
   > Retrieves and displays data from the database table in a DataGridView control.


 - Update operation
    
 > Allows updating existing data based on the selected row in the DataGridView.

![Screenshot 2024-06-12 172013](https://github.com/Abhishek32971/CRUDapp.NET/assets/97088891/306813ae-e21f-46bd-88c7-6cb997b59732)

    
   - Delete operation
    
   >Deletes a selected row from the database table.
Uses DataAdapters and DataTables for data manipulation.
 Handles basic error scenarios with message boxes.


![Screenshot 2024-06-12 172036](https://github.com/Abhishek32971/CRUDapp.NET/assets/97088891/2def2fbd-1569-4fa2-9d2d-1aedb2a67147)

**Instructions:**

1.  Replace the placeholder connection string in the code with your actual MySQL server details (server, username, password, database name).
2.  Ensure you have the necessary permissions to access the database and perform CRUD operations.
3.  Open the solution in your development environment and build/run the application.
4.  Use the provided functionalities to interact with the database.

**Note:**

-   This is a basic example and can be extended to include features like data validation, error handling with logging, and more robust UI elements.
-   Consider implementing prepared statements to prevent SQL injection vulnerabilities.

**Technology Stack:**

-   C#
-   MySQL
-   Windows Forms (potentially adaptable to other UI frameworks)

**Further Enhancements:**

-   Implement user authentication for secure access to the application.
-   Add data validation checks to ensure valid user input.
-   Improve the UI design for better user experience.
-   Enhance error handling with logging capabilities.

This code provides a starting point for building CRUD applications that interact with MySQL databases using C#. With further customization and extensions, you can create a robust and user-friendly data management tool.
