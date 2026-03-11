# EinvoiceDesign

## Overview
EinvoiceDesign is a .NET 6 web application for electronic invoice management and design. It includes features for invoice creation, preview, and document viewing, with modern frontend assets and DevExtreme integration.

## Features
- Invoice creation and management
- Invoice preview and printing
- Custom web document viewer
- Modern UI with DevExtreme Combos
## Project Structure
- `EInvoiceProject/` — Main application source
  - `Controllers/` — MVC controllers
  - `Models/` — Data models
  - `Views/` — Razor views for UI
  - `wwwroot/` — Static assets (CSS, JS, images)
    - `designer_file/` — Third-party and custom JS/CSS
    - `package.json` — Frontend dependencies
    - `package-lock.json` — Dependency lock file
    - `favicon.ico` — Site icon
- `EInvoiceProject.sln` — Solution file

## Getting Started

### Prerequisites
- .NET 6 SDK
- Node.js (for frontend assets, if needed)

### Setup
1. Clone the repository:
   ```
   git clone https://github.com/amanTesfa/EinvoiceDesign.git
   ```
2. Restore .NET dependencies:
   ```
   dotnet restore
   ```
3. (Optional) Install frontend dependencies:
   ```
   cd EInvoiceProject/wwwroot
   npm install
   ```
4. Build and run the project:
   ```
   dotnet run --project EInvoiceProject/EInvoiceProject.csproj
   ```

**Technologies Used**
  
- HTML, CSS, Javascript, Jquery, Bootstrap, Devextreme controls
- C# MVC with razor pages
- Devexpress report designer
