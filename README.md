# ED9ACS_HFT_2022232

A **.NET 6 solution** for managing fans, artists, reservations, and services.  
The system provides a RESTful API, business logic layer, repository layer, console client, unit tests, and real-time updates with SignalR.

---

## Features

- **RESTful API:** CRUD operations for Fans, Artists, Reservations, and Services.
- **Business Logic Layer:** Encapsulates all core operations and validation.
- **Repository Layer:** Abstracts data access for easy swapping of storage backends.
- **Console Client:** Interact with the API from the command line.
- **Unit Tests:** Ensures reliability and correctness of business logic.
- **Real-Time Notifications:** SignalR hub for client updates.
- **Non-CRUD Endpoints:** Custom queries for analytics (e.g., best/worst fans, artist earnings).

---

## Project Structure

```
ED9ACS_HFT_2022232.sln
├── ED9ACS_HFT_2022232 Endpoint/      # ASP.NET Core Web API (REST endpoints, SignalR)
├── ED9ACS_HFT_2022232 Logic/         # Business logic layer (interfaces, implementations)
├── ED9ACS_HFT_2022232 Models/        # Entity/data models (Fans, Artists, etc.)
├── ED9ACS_HFT_2022232 Repository/    # Data access/repository layer
├── ED9ACS_HFT_2022232 Test/          # Unit tests (xUnit/NUnit/MSTest)
└── ED9ACS_HFT_2022232.Client/        # Console client application
```

---

## Getting Started

### Build the Solution

```sh
dotnet build ED9ACS_HFT_2022232.sln
```

### Run the Web API

```sh
cd "ED9ACS_HFT_2022232 Endpoint"
dotnet run
```
API will be available at: [http://localhost:23079](http://localhost:23079)

### Run the Console Client

```sh
cd ../ED9ACS_HFT_2022232.Client
dotnet run
```

### Run Unit Tests

```sh
cd ../ED9ACS_HFT_2022232\ Test
dotnet test
```

---

## API Endpoints

### CRUD

- `GET /Fans`, `POST /Fans`, `PUT /Fans/{id}`, `DELETE /Fans/{id}`
- `GET /Artists`, `POST /Artists`, etc.
- `GET /Reservations`, `GET /Services`, etc.

### Non-CRUD

- `GET /Noncrudfan/ReservationNUM/{id}` — Number of reservations for a fan
- `GET /Noncrudfan/BestFans` — List of best fans
- `GET /Noncrudfan/WorstFans` — List of worst fans
- `GET /Noncrudartist/ArtistEarnings` — Earnings per artist
- `GET /Noncrudartist/MostPaidArtist` — Most paid artist(s)
- `GET /Noncrudartist/LessPaidArtist` — Least paid artist(s)

### Real-Time

- SignalR hub at `/hub` for notifications

---

## Technologies Used

- C#, .NET 6
- ASP.NET Core Web API
- SignalR
- xUnit/NUnit/MSTest for testing
- REST client (HttpClient) in console app

---

**Quick Links:**  
- [ED9ACS_HFT_2022232 Endpoint](ED9ACS_HFT_2022232%20Endpoint/)
- [ED9ACS_HFT_2022232 Logic](ED9ACS_HFT_2022232%20Logic/)
- [ED9ACS_HFT_2022232 Models](ED9ACS_HFT_2022232%20Models/)
- [ED9ACS_HFT_2022232 Repository](ED9ACS_HFT_2022232%20Repository/)
- [ED9ACS_HFT_2022232 Test](ED9ACS_HFT_2022232%20Test/)
- [ED9ACS_HFT_2022232.Client](ED9ACS_HFT_2022232.Client/)
