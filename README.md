# hello-asp-net-developer

## Summary
An ASP.NET Core REST API application to illustrate the use of Minimal APIs.

## Features
The API supports both GET and POST request to generate personalized greeting based on the provided name and lastname.

-**GET /greetings**: Returns a personalized greeting message.
-**POST /greetings**: Returns a personalized greeting message.


## Dependencies
- NET 9 SDK
- Swashbuckle.AspNetCore (for API documentation)

## Getting Started
1. Clone the repository
    ```bash
    git clone <repository-url>
    cd hello-asp-net-developer 
    ```
2. Restore the dependencies
    ```bash
    dotnet restore
    ```
3. Run the application
    ```bash
    dotnet run 
    ```
