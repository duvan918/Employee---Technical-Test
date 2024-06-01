# Employee---Technical-Test
This is a repository created to resolve a requested technical test.
This is a simple ASP.NET Core MVC application to manage employee information. It consumes external APIs to fetch employee data, calculates the annual salary, and displays the information using Angular for the frontend.

## Requirements

- .NET 6 SDK or later
- Node.js and npm
- Angular CLI

## Setup

1. **Clone the repository:**
    ```bash
    git clone https://github.com/duvan918/Employee---Technical-Test.git
    cd Employee---Technical-Test
    ```

2. **Restore .NET dependencies:**
    Inside /EmployeesManagementApp/EmployeesManagementApp folder
    ```bash
    dotnet restore
    ```

3. **Install Angular CLI globally (if not already installed):**
    ```bash
    npm install -g @angular/cli
    ```

4. **Navigate to the Angular project directory and install dependencies:**
   Inside /EmployeeApp folder
    ```bash
    npm install
    ```

## Running the Application

1. **Start the ASP.NET Core backend:**
    Inside /EmployeesManagementApp/EmployeesManagementApp folder
    ```bash
    dotnet run
    ```

2. **Start the Angular frontend:**
   Inside /EmployeeApp folder
    ```bash
    ng serve
    ```

3. **Open your browser and navigate to:**
    ```
    http://localhost:4200
    ```

## Testing

1. **Run unit tests for the Business Logic Layer:**
   Inside /EmployeesManagementApp/EmployeesManagementApp folder
    ```bash
    dotnet test
    ```

## Project Structure

- **EmployeesManagementApp**: ASP.NET Core MVC backend
- **EmployeeApp**: Angular frontend

## Authors

- Yeison Franco
