# ✈️ LOPY - Flight Booking Backend with AI Price Prediction

**LOPY** is a backend system for managing flight bookings, enhanced with AI-powered insights to help users find the best times to book cheaper flights.

This repository contains only the **backend**, developed using **.NET Web API**. It connects with a free API provided by **Amadeus** for flight data, and integrates with an external AI model to offer price predictions.

> ⚠️ **This project is currently under active development.** Expect frequent changes and new features coming soon!

---

## 📌 Features

- ✈️ Search and book flights using Amadeus API
- 🧠 AI model integration for predicting the best time to book
- 📅 Suggests whether to book now or wait
- 🔄 Full CRUD support for managing bookings
- 🔐 Clean and secure API structure
- ⚙️ Built using modern .NET technologies

---

## 🛠️ Tech Stack

- [.NET 9 Web API](https://learn.microsoft.com/en-us/aspnet/core/web-api/)
- **Entity Framework Core**
- **LINQ**
- **C#**
- **Amadeus Self-Service APIs (Free Tier)** for flight data

---

## 🧠 AI Model

The system is designed to connect with an AI model (external to this repo) that:
- Predicts price trends for flights
- Recommends the best booking window

> *Note: The AI model itself is not included in this repository. However, API endpoints are ready to receive predictions and respond accordingly.*

---


  LOPY - Backend Setup (.NET 9)
==

⚙️ Environment Setup:

1. Install Prerequisites:
   - .NET 9 SDK: https://dotnet.microsoft.com/en-us/download/dotnet/9.0
   - IDE (VS 2022+, Rider, or VS Code)
   - Optional: Postman Or Swagger
   - Amadeus Developer Account (for API credentials)

--------------------------------

2. Clone the repository:
   git clone https://github.com/A7medhanysadek/Lopy.git
   cd LOPY

--------------------------------

3. Restore dependencies:
   dotnet restore

--------------------------------

4. Set up environment config:
   - Open the file named: appsettings.json
   - Change the following:

{
  "Amadeus": {
    "ClientId": "YOUR_CLIENT_ID",
    "ClientSecret": "YOUR_CLIENT_SECRET"
  },
  "ConnectionStrings": {
    "DefaultConnection": "Your SQL Server connection string here"
  }
}

--------------------------------

5. Run the application:
   dotnet run

--------------------------------

✅ You’re now ready to start working with the LOPY backend!

