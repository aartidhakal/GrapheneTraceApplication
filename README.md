# GrapheneTraceApp

GrapheneTrace is a prototype medical technology platform for analysing pressure sensor data to help prevent pressure ulcers. It processes thirty two by thirty two pressure frames, detects high pressure regions, calculates risk measurements, and provides dashboards for patients, clinicians, and administrators.

## Features

### Clinician Dashboard
- **Patient Management**: View all assigned patients with their current risk levels
- **Risk Monitoring**: Color-coded risk levels (Low, Moderate, High, Critical)
- **Pressure Data Analysis**: View and analyze 32x32 pressure sensor readings
- **Alert System**: Receive and acknowledge patient alerts with severity filtering
- **Communication**: Comment system with threaded replies for patient communication
- **Trend Analysis**: Historical data visualization with customizable date ranges
- **Role-Based Access**: Secure access restricted to clinicians only

## Technology Stack

- **Framework**: ASP.NET Core MVC 8.0
- **Database**: SQLite with Entity Framework Core
- **Authentication**: ASP.NET Core Identity with role-based authorization
- **UI Framework**: Bootstrap 5
- **Architecture**: Model-View-Controller (MVC) with ViewModels

## Getting Started

### Prerequisites
- .NET 8.0 SDK or later
- Visual Studio 2022, VS Code, or any C# IDE

### Installation

1. Clone the repository:
```bash
git clone https://github.com/aartidhakal/GrapheneTraceApp.git
cd GrapheneTraceApp
```

2. Navigate to the application directory:
```bash
cd GrapheneTraceApp
```

3. Restore dependencies:
```bash
dotnet restore
```

4. Run database migrations:
```bash
dotnet ef database update
```

5. Run the application:
```bash
dotnet run
```

6. Open your browser and navigate to: `http://localhost:5000`

### Test Credentials

For testing purposes, a default clinician account is created:

- **Email**: clinician@graphenetrace.com
- **Password**: Clinician123!

## Project Structure

```
GrapheneTraceApp/
├── Controllers/          # MVC Controllers
│   ├── ClinicianController.cs
│   └── HomeController.cs
├── Models/              # Domain Models
│   ├── Patient.cs
│   ├── Clinician.cs
│   ├── PressureData.cs
│   ├── Alert.cs
│   ├── Comment.cs
│   └── RiskLevel.cs
├── ViewModels/          # View Models
│   ├── PatientListViewModel.cs
│   ├── PatientDetailsViewModel.cs
│   ├── PressureDataViewModel.cs
│   ├── AlertsViewModel.cs
│   ├── CommentsViewModel.cs
│   └── TrendsViewModel.cs
├── Views/               # Razor Views
│   ├── Clinician/
│   ├── Home/
│   └── Shared/
├── Data/                # Database Context & Migrations
│   ├── ApplicationDbContext.cs
│   └── Migrations/
└── Services/            # Application Services
    └── DatabaseSeeder.cs
```

## Key Features Explained

### 1. Patient Dashboard
- Lists all patients assigned to the logged-in clinician
- Displays risk level, alerts, and recent activity
- Quick access to patient details and actions

### 2. Patient Details
- Comprehensive patient overview
- Medical record information
- Summary statistics (alerts, comments, readings)
- Quick action buttons for common tasks

### 3. Pressure Data Viewer
- View historical pressure readings
- Detailed metrics (max pressure, average, high-pressure regions)
- Support for 32x32 pressure frame data

### 4. Alert Management
- View all patient alerts
- Filter by severity level
- Acknowledge alerts
- Track resolution status

### 5. Communication System
- Post comments to patient records
- Reply to patient comments
- Threaded conversation view
- Role identification (Clinician/Patient)

### 6. Trend Analysis
- Historical trend visualization
- Date range filtering
- Multiple data metrics (risk level, pressure, regions)

## Database Schema

### Main Entities
- **Patients**: Patient demographic and medical information
- **Clinicians**: Clinician professional information
- **PressureData**: 32x32 pressure sensor readings
- **Alerts**: Risk alerts and notifications
- **Comments**: Communication threads

### Relationships
- Patient → Clinician (Many-to-One)
- Patient → PressureData (One-to-Many)
- Patient → Alerts (One-to-Many)
- Patient → Comments (One-to-Many)
- Comment → Comment (Self-referencing for replies)

## Security

- **Authentication**: ASP.NET Core Identity
- **Authorization**: Role-based access control
- **Data Protection**: Anti-forgery tokens on all forms
- **Access Control**: Clinicians can only access their assigned patients

## Development

### Running Tests
```bash
dotnet test
```

### Building for Production
```bash
dotnet publish -c Release
```

### Database Migrations
Create a new migration:
```bash
dotnet ef migrations add MigrationName
```

Apply migrations:
```bash
dotnet ef database update
```

## Contributing

This is a prototype application for educational and demonstration purposes.

## License

This project is licensed under the MIT License.

## Contact

For questions or support, please contact the repository owner.
