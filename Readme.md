# Project Name
Settings
## Introduction

This project is about creating a notification system for a web application. The system allows users to manage their notification preferences for email, push notifications, and SMS.

## Technologies

- .NET 8
- Entity Framework Core 8.0
- SQL Server

## Setup

To run this project, you need to:

1. Clone the repository: `git clone https://github.com/KabiriAbolfazl/SettingsModule.git`
2. Navigate to the project directory: `cd SettingApi`
3. Install dependencies: `dotnet restore`
4. Run the project: `dotnet run`

## Features

- Users can manage their notification preferences.
- Supports email, push notifications, and SMS.
- Uses Entity Framework Core for data access.
- Uses the Table-Per-Concrete class (TPC) inheritance pattern.

## Configuration

The project uses the `appsettings.json` file for configuration. Make sure to update this file with your database connection string and other settings.

## Database Migrations

To create a new migration, use the following command: `Add-Migration InitialCreate`
To update the database, use the following command: `Update-Database`

## Contact

If you have any questions, feel free to contact me at Abolfazl_Kabiri@Outlook.com
