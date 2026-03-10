# CLAUDE.md

This file provides guidance to Claude Code (claude.ai/code) when working with code in this repository.

## Project Overview

CleanUtils.Serilog.Enricher.FileContext is a .NET library that provides automatic context enrichment for Serilog logging. The solution contains two main projects:

- **CleanUtils.Serilog.Enricher.FileContext** - Core library implementing Serilog enrichers
- **CleanUtils.Serilog.Enricher.FileContext.Tests** - Unit tests using xUnit

## Development Commands

### Build and Test
```bash
# Build the entire solution
dotnet build CleanUtils.Serilog.Enricher.FileContext.sln

# Run tests
dotnet test CleanUtils.Serilog.Enricher.FileContext.Tests/CleanUtils.Serilog.Enricher.FileContext.Tests.csproj

# Build specific project
dotnet build CleanUtils.Serilog.Enricher.FileContext/CleanUtils.Serilog.Enricher.FileContext.csproj

# Build in release mode (generates NuGet packages)
dotnet build -c Release
```

### Package Management
```bash
# Restore NuGet packages
dotnet restore

# Pack for NuGet
dotnet pack CleanUtils.Serilog.Enricher.FileContext/CleanUtils.Serilog.Enricher.FileContext.csproj -c Release
```

## Architecture

### Core Functionality
The library implements Serilog's `ILogEventEnricher` interface to add contextual information to log entries automatically.

### Key Features
- Automatic enrichment of log events with contextual data
- Easy integration with existing Serilog configurations
- Support for multiple .NET versions (8.0, 9.0, 10.0)

### Project Structure
- Uses semantic versioning (currently 0.1.0)
- Auto-generates NuGet packages on build (`GeneratePackageOnBuild = true`)
- Includes nullable reference types and implicit usings
- Targets .NET 8.0, 9.0, and 10.0

### Testing Strategy
- Uses xUnit testing framework
- Tests cover enricher functionality and integration scenarios

## Integration Patterns

### Basic Usage
```csharp
// TODO: Add integration examples
```

## Dependencies
- Serilog (4.2.0)
- xUnit for testing
