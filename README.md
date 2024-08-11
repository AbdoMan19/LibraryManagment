# Library Management System

## Overview

The **Library Management System** is a web-based application designed to manage a library's operations, such as managing books, authors, borrowers, and members. It provides an interface for administrators to add, update, delete, and view books, authors, and members. The system is built using the ASP.NET MVC framework with a focus on clean architecture, leveraging a repository pattern for data access and a unit of work pattern for transaction management.

## Features

- **Book Management**: Create, update, delete, and view books.
- **Author Management**: Manage authors associated with books.
- **Member Management**: Manage library members, including their details and borrowing history.
- **Borrowing System**: Track borrowed books and manage returns (if implemented).
- **Search Functionality**: Search for books by title, author, or genre.
- **Validation**: Server-side validation to ensure data integrity.

## Technologies Used

- **Backend**: ASP.NET MVC, C#
- **Frontend**: Razor Views, HTML, CSS, JavaScript
- **Database**: Microsoft SQL Server
- **ORM**: Entity Framework Core
- **Design Patterns**: Repository Pattern, Unit of Work Pattern, Dependency Injection
- **Tools & Libraries**: 
  - **Entity Framework Core**: For database operations.
  - **Microsoft SQL Server**: As the database provider.
  - **ASP.NET Identity**: For user authentication (if implemented).
  - **Bootstrap**: For responsive design (if used).

## Project Structure

- **Models**: Contains the data models like `Book`, `Author`, `Member`, and `Borrow`.
- **Repositories**: Interfaces and implementations for data access.
- **Services**: Business logic layer that interacts with repositories.
- **Controllers**: Manages the flow of the application and handles user requests.
- **Views**: Razor views for displaying data to the user.
- **Unit of Work**: Manages the transaction scope across repositories.

## Getting Started

### Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download)
- [Microsoft SQL Server](https://www.microsoft.com/en-us/sql-server/sql-server-downloads)
- [Visual Studio](https://visualstudio.microsoft.com/) or [Visual Studio Code](https://code.visualstudio.com/)

### Setup Instructions

1. **Clone the repository**:
    ```bash
    git clone https://github.com/your-username/library-management-system.git
    cd library-management-system
    ```

2. **Configure the Database**:
    - Update the `appsettings.json` file with your SQL Server connection string.
    - Run the following commands to apply migrations and create the database:
        ```bash
        dotnet ef database update
        ```

3. **Run the Application**:
    - Start the application using Visual Studio or via the command line:
        ```bash
        dotnet run
        ```
    - The application should now be running at `http://localhost:5000` (or the port specified).

### Usage

- Navigate to `http://localhost:5000/Books` to manage books.
- Navigate to `http://localhost:5000/Authors` to manage authors.
- Navigate to `http://localhost:5000/Members` to manage library members.
- Use the search bar to find specific books, authors, or members.

## Contribution

Contributions are welcome! Please open an issue or submit a pull request if you have any improvements or new features to add.

## License

This project is licensed under the MIT License. See the [LICENSE](LICENSE) file for more details.

## Acknowledgments

- Thanks to [Microsoft](https://www.microsoft.com/) for providing the tools and frameworks that made this project possible.
- Special thanks to the ASP.NET and Entity Framework communities for their extensive documentation and support.
