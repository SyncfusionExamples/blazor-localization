# Blazor Localization Examples

Localization examples demonstrating how to localize [Syncfusion<sup style="font-size:70%">&reg;</sup> Blazor UI components](https://www.syncfusion.com/blazor-components) across different Blazor hosting models and .NET versions.

## Overview

This repository contains localization examples for the following configurations:

| Directory | .NET Version | Hosting Model | Localization Type |
|-----------|:-------------:|:-------------:|:------------------:|
| `.NET5 Blazor Server App` | .NET 5 | Server | Static & Dynamic |
| `.NET5 Blazor WASM App` | .NET 5 | WebAssembly | Dynamic |
| `.NET6 Blazor Server App` | .NET 6 | Server | Static & Dynamic |
| `.NET6 Blazor WASM App` | .NET 6 | WebAssembly | Dynamic |
| `.NET 8 Blazor Web App` | .NET 8 | Web App (Auto) | Static & Dynamic |
| `.NET8 MAUI Blazor App` | .NET 8 | MAUI | Static |

### Localization Approaches

- **Static Culture** — Culture is set at application `Startup.cs`/`Program.cs` and remains fixed during the session.
- **Dynamic Culture** — Users can switch cultures at runtime, with the UI updating accordingly.

## Prerequisites

- [Visual Studio 2022](https://visualstudio.microsoft.com/vs/) or later
- [Visual Studio Code](https://code.visualstudio.com/)
- [.NET SDK](https://dotnet.microsoft.com/en-us/download/dotnet)

## Getting Started

### Clone the repository

```bash
git clone https://github.com/SyncfusionExamples/blazor-localization.git
cd <project_folder_path..>
```

### Run with Visual Studio

1. Open the solution file using Visual Studio 2022 or later.
2. Restore NuGet packages by rebuilding the solution.
3. Build the project to ensure there are no compilation errors
4. Run the project

## References

- [Blazor Localization Documentation](https://blazor.syncfusion.com/documentation/common/localization/)
- [GitHub: blazor-locale](https://github.com/syncfusion/blazor-locale) — Latest translation resource files
