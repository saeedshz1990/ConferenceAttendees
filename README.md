\# ConferenceAttendees



A simple ASP.NET Core Web API for managing conference attendees and related reference data.



This project demonstrates a straightforward CRUD-based REST API using ASP.NET Core, Entity Framework Core, SQL Server, Serilog, and Docker.



\## Features



\- Manage conference attendees

\- Manage genders

\- Manage job roles

\- Manage referral sources

\- RESTful CRUD endpoints

\- Entity Framework Core persistence

\- SQL Server database

\- Structured logging with Serilog

\- Swagger / OpenAPI documentation

\- Docker support



\## Technologies



\- ASP.NET Core Web API

\- C#

\- Entity Framework Core

\- SQL Server

\- Serilog

\- Swagger / OpenAPI

\- Docker



\## Main Entities



The application contains the following main entities:



\- `Attendee`

\- `Gender`

\- `JobRole`

\- `ReferralSource`



`Attendee` represents the primary entity, while the other entities provide supporting reference data.



\## API Endpoints



The API exposes CRUD operations for:



```text

/api/Attendees

/api/Genders

/api/JobRoles

/api/ReferralSources

```



Typical operations include:



```http

GET    /api/Attendees

GET    /api/Attendees/{id}

POST   /api/Attendees

PUT    /api/Attendees/{id}

DELETE /api/Attendees/{id}

```



The same CRUD pattern is available for genders, job roles, and referral sources.



\## Getting Started



\### Prerequisites



\- .NET SDK

\- SQL Server



\### Configuration



Configure the database connection string using local configuration, environment variables, or .NET User Secrets.



Example:



```json

{

&#x20; "ConnectionStrings": {

&#x20;   "ConferenceAttendeeDatabaseConnection": "Server=localhost;Database=ConferenceAttendeeDb;User Id=YOUR\_USER;Password=YOUR\_PASSWORD;TrustServerCertificate=true;"

&#x20; }

}

```



Do not commit real database credentials to source control.



\## Build



From the solution directory:



```bash

dotnet restore

dotnet build

```



\## Run



Run the API with:



```bash

dotnet run --project ConferenceAttendees.API

```



When running in the Development environment, Swagger UI is available for exploring and testing the API.



\## Project Structure



```text

ConferenceAttendees/

└── ConferenceAttendees.API/

&#x20;   ├── Controllers/

&#x20;   ├── Data/

&#x20;   │   └── Configuration/

&#x20;   ├── Migrations/

&#x20;   ├── Program.cs

&#x20;   └── appsettings.json

```



\## Logging



Serilog is configured for structured application logging.



The project supports console logging and centralized logging through Seq when configured.



\## Purpose



This project is a lightweight example of building a CRUD-based REST API with ASP.NET Core and Entity Framework Core.



It is intentionally kept simple and focuses on core Web API, persistence, logging, and containerization concepts.

