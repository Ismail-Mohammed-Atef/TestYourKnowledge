# Windows Forms Test Application

## Overview
This Windows Forms application is designed for creating, solving, and tracking tests. It enables users to take tests, receive ratings based on their performance, and view their test history. The application includes authentication and authorization to manage user access and ensure data security.

## Features
- **Test Creation & Solving**: Users can create and take tests.
- **User Authentication & Authorization**: Secure login and role-based access control.
- **User Rating System**: Scores and feedback based on test performance.
- **Test History Tracking**: Stores and displays users' past test results.
- **Windows Forms UI**: Interactive and user-friendly interface.
- **Data Persistence**: Saves test data and user progress.

## Technologies Used
- **Backend**: C# with Windows Forms
- **Database**: SQL Server with Entity Framework
- **Authentication**: Identity-based user authentication & authorization

## Installation
1. Clone the repository.
2. Open the project in Visual Studio.
3. Restore NuGet packages.
4. Configure the database connection in `app.config`:
   ```xml
   <connectionStrings>
       <add name="DefaultConnection"
            connectionString="Server=your-server;Database=your-db;User Id=your-user;Password=your-password;"
            providerName="System.Data.SqlClient" />
   </connectionStrings>
   ```
5. Apply migrations and update the database:
   ```sh
   dotnet ef database update
   ```
6. Build and run the application.

## Usage
1. Register/Login using the authentication system.
2. Create and attempt tests.
3. View scores and ratings after each test.
4. Access test history to track progress.
5. Manage tests as an admin (if authorized).

## Requirements
- **.NET Version**: .NET Framework or .NET Core (latest version recommended)
- **Database**: SQL Server
- **IDE**: Visual Studio


## License
This project is licensed under the MIT License.

## Contact
For support or inquiries, reach out via email at ismail.mohammed.atef@gmail.com.

