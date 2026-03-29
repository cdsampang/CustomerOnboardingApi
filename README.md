# Run Backend

cd src/
dotnet restore
dotnet build
dotnet run

# Run Frontend

cd frontend
npm install
npm start

# Folder Structure

CustomerOnboardingApi/
│
├── src/ # Backend (.NET Core API)
│ ├── Api/ # Web API project (controllers, Program.cs)
│ ├── Application/ # Business logic, validators, services
│ ├── Domain/ # Entities (Customer, etc.)
│ ├── Infrastructure/ # EF Core, migrations, DB context
│ └── Tests/ # NUnit test project
│
├── frontend/ # React app (customer onboarding form + list)
│ ├── src/ # React components, pages, services
│ └── package.json
│
└── README.md # Documentation (run instructions, setup)

# Notes

- Frontend: .env file should contain your API URL, e.g.:
  REACT_APP_API_URL=https://localhost:5206/api
- Tests: Run from root with:
  dotnet test src/CustomerOnboardingApi.Sln
