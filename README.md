# ED9ACS_HFT_2022232

A .NET Core solution for managing fans, artists, reservations, and related services, featuring a RESTful API backend, business logic, data models, repository layer, client application, and unit tests.

## Project Structure

```
ED9ACS_HFT_2022232.sln
ED9ACS_HFT_2022232 Endpoint/      # ASP.NET Core Web API (REST endpoint)
ED9ACS_HFT_2022232 Logic/         # Business logic layer
ED9ACS_HFT_2022232 Models/        # Data models/entities
ED9ACS_HFT_2022232 Repository/    # Data access/repository layer
ED9ACS_HFT_2022232 Test/          # Unit tests
ED9ACS_HFT_2022232.Client/        # Console client application
```

### Main Components

- **ED9ACS_HFT_2022232 Endpoint/**  
  ASP.NET Core Web API exposing CRUD and non-CRUD endpoints for fans, artists, reservations, and services.  
  - Controllers: REST endpoints (e.g., [`FansController`](ED9ACS_HFT_2022232%20Endpoint/Controllers/FansController.cs), [`NoncrudfanController`](ED9ACS_HFT_2022232%20Endpoint/Controllers/NoncrudfanController.cs))
  - SignalR support for real-time notifications
  - Configuration: [`Startup.cs`](ED9ACS_HFT_2022232%20Endpoint/Startup.cs), [`Program.cs`](ED9ACS_HFT_2022232%20Endpoint/Program.cs)

- **ED9ACS_HFT_2022232 Logic/**  
  Business logic for handling operations on fans, artists, reservations, and services.  
  - Example: [`FansLogic`](ED9ACS_HFT_2022232%20Logic/FansLogic.cs), [`IArtistsLogic`](ED9ACS_HFT_2022232%20Logic/IArtistsLogic.cs)

- **ED9ACS_HFT_2022232 Models/**  
  Entity classes representing the domain model.

- **ED9ACS_HFT_2022232 Repository/**  
  Repository pattern implementation for data access.

- **ED9ACS_HFT_2022232.Client/**  
  Console application for interacting with the API.  
  - Menus for CRUD and non-CRUD operations (see [`Program.cs`](ED9ACS_HFT_2022232.Client/Program.cs))
  - REST communication via [`RestService`](ED9ACS_HFT_2022232.Client/RestService.cs)

- **ED9ACS_HFT_2022232 Test/**  
  Unit tests for business logic and API endpoints.

## Getting Started

### Prerequisites

- [.NET 6 SDK](https://dotnet.microsoft.com/download)
- (Optional) Docker, if you want to run in a container

### Build the Solution

```sh
dotnet build ED9ACS_HFT_2022232.sln
```

### Run the Web API

```sh
cd "ED9ACS_HFT_2022232 Endpoint"
dotnet run
```

The API will be available at `http://localhost:23079` (see CORS settings in [`Startup.cs`](ED9ACS_HFT_2022232%20Endpoint/Startup.cs)).

### Run the Client Application

```sh
cd "ED9ACS_HFT_2022232.Client"
dotnet run
```

### Run Unit Tests

```sh
cd "ED9ACS_HFT_2022232 Test"
dotnet test
```

## API Overview

- **CRUD endpoints:**  
  `/Fans`, `/Artists`, `/Reservations`, `/Services`  
  (see controllers in [ED9ACS_HFT_2022232 Endpoint/Controllers/](ED9ACS_HFT_2022232%20Endpoint/Controllers/))

- **Non-CRUD endpoints:**  
  `/Noncrudfan/ReservationNUM/{id}` — Number of reservations for a fan  
  `/Noncrudfan/BestFans` — List of best fans  
  `/Noncrudfan/WorstFans` — List of worst fans

## Real-Time Notifications

The API uses SignalR to notify clients about changes (e.g., when a new fan is created). SignalR hub is mapped at `/hub`.

## Configuration

- `appsettings.json` and `appsettings.Development.json` in the Endpoint project for environment-specific settings.

## Contributing

1. Fork the repository
2. Create a feature branch
3. Commit your changes
4. Open a pull request

## License

This project is for educational purposes.

---

**Project folders:**  
- [ED9ACS_HFT_2022232 Endpoint](ED9ACS_HFT_2022232%20Endpoint/)
- [ED9ACS_HFT_2022232 Logic](ED9ACS_HFT_2022232%20Logic/)
- [ED9ACS_HFT_2022232 Models](ED9ACS_HFT_2022232%20Models/)
- [ED9ACS_HFT_2022232 Repository](ED9ACS_HFT_2022232%20Repository/)
- [ED9ACS_HFT_2022232 Test](ED9ACS_HFT_2022232%20Test/)
-
