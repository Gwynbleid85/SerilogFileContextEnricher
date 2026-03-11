![SerilogFileContextEnricher - Add file name, method name and line number to your logs](https://raw.githubusercontent.com/Gwynbleid85/SerilogFileContextEnricher/main/docs/github-header-banner.png)

[![NuGet](https://img.shields.io/nuget/v/CleanUtils.Serilog.Enricher.FileContext.svg)](https://www.nuget.org/packages/CleanUtils.Serilog.Enricher.FileContext)
[![NuGet Downloads](https://img.shields.io/nuget/dt/CleanUtils.Serilog.Enricher.FileContext.svg)](https://www.nuget.org/packages/CleanUtils.Serilog.Enricher.FileContext)
[![License](https://img.shields.io/github/license/Gwynbleid85/SerilogFileContextEnricher.svg)](https://github.com/Gwynbleid85/SerilogFileContextEnricher/blob/main/LICENSE)

<p align="center">
  Automatically enrich your Serilog logs with <strong>file name</strong>, <strong>method name</strong>, and <strong>line number</strong> — zero configuration, zero runtime overhead.
</p>

---

## Why?

Ever stared at a log line wondering *where* it came from? This library uses C# compiler attributes to capture caller information at **compile time** and push it into Serilog's `LogContext`. No reflection, no stack traces, no performance penalty.

**Before:**
```
[2026-03-10 14:23:01 INF] Order processed successfully
```

**After:**
```
[2026-03-10 14:23:01 INF OrderService.cs/ProcessOrder:42] Order processed successfully
```

## Installation

```bash
dotnet add package CleanUtils.Serilog.Enricher.FileContext
```

> Targets **.NET 9.0** and **.NET 10.0**

## Quick Start

### 1. Configure Serilog

Add `.Enrich.FromLogContext()` and include the context properties in your output template:

```csharp
using System.Globalization;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .Enrich.FromLogContext()
    .WriteTo.Console(
        outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3} {CallerFileName}/{CallerMemberName}:{CallerLineNumber}] {Message:lj}{NewLine}{Exception}",
        formatProvider: CultureInfo.InvariantCulture
    )
    .CreateLogger();
```

### 2. Log with context

Pick the style that fits your codebase — all three produce identical output:

```csharp
using Serilog;
using CleanUtils.Serilog.Enricher.FileContext;

// Style 1: Extension methods on ILogger
Log.Logger.InformationWithContext("Order processed successfully");


// Style 2: Static ContextLog class
ContextLog.Information("Order processed successfully");
```

That's it. Every log entry now carries its source location automatically.

## Enriched Properties

Each log call adds four properties to the log context:

| Property | Example | Description |
|---|---|---|
| `CallerFilePath` | `/src/Services/OrderService.cs` | Full path to the source file |
| `CallerFileName` | `OrderService.cs` | File name only |
| `CallerMemberName` | `ProcessOrder` | Method or property name |
| `CallerLineNumber` | `42` | Line number of the log call |

## Usage Examples

### Structured logging with properties

All styles support Serilog's standard message template syntax with up to 5 typed parameters:

```csharp
// With structured properties
Log.Logger.InformationWithContext(
    "Processing order {@OrderId} for {@Customer}",
    orderId,
    customerName
);

ContextLog.Error(
    "Failed to process payment {@PaymentId}: {Reason}",
    paymentId,
    error.Message
);
```

### All log levels

Every log level is supported across all three styles:

```csharp
ContextLog.Verbose("Entering method with param {Param}", value);
ContextLog.Debug("Cache lookup for key {Key}", cacheKey);
ContextLog.Information("User {UserId} logged in", userId);
ContextLog.Warning("Rate limit approaching: {Current}/{Max}", current, max);
ContextLog.Error("Unhandled exception in {Operation}", operationName);
```

### Using with dependency-injected ILogger

The extension methods work naturally with DI:

```csharp
public class OrderService
{
    private readonly ILogger _logger;

    public OrderService(ILogger logger)
    {
        _logger = logger;
    }

    public void ProcessOrder(Order order)
    {
        _logger.InformationWithContext("Processing order {@OrderId}", order.Id);
        // Log output: [... INF OrderService/ProcessOrder:15] Processing order "ORD-123"
    }
}
```

### Custom output templates

Use any combination of the enriched properties in your template:

```csharp
// Compact — just file and line
outputTemplate: "[{Level:u3} {CallerFileName}:{CallerLineNumber}] {Message:lj}{NewLine}{Exception}"
// Output: [INF OrderService.cs:42] Order processed successfully

// Detailed — full path
outputTemplate: "[{Level:u3} {CallerFilePath}:{CallerLineNumber} ({CallerMemberName})] {Message:lj}{NewLine}{Exception}"
// Output: [INF /src/Services/OrderService.cs:42 (ProcessOrder)] Order processed successfully

// Method-focused
outputTemplate: "[{Timestamp:HH:mm:ss} {Level:u3}] {CallerMemberName}: {Message:lj}{NewLine}{Exception}"
// Output: [14:23:01 INF] ProcessOrder: Order processed successfully
```

## API Reference

### Extension Methods (`ILogger`)

| Method | Description |
|---|---|
| `InformationWithContext(...)` | Log at Information level with context |
| `WarningWithContext(...)` | Log at Warning level with context |
| `ErrorWithContext(...)` | Log at Error level with context |
| `DebugWithContext(...)` | Log at Debug level with context |
| `VerboseWithContext(...)` | Log at Verbose level with context |

### Static Classes (`Logger` / `ContextLog`)

| Method | Description |
|---|---|
| `Information(...)` | Log at Information level with context |
| `Warning(...)` | Log at Warning level with context |
| `Error(...)` | Log at Error level with context |
| `Debug(...)` | Log at Debug level with context |
| `Verbose(...)` | Log at Verbose level with context |

All methods support 0–5 typed parameters following Serilog's message template syntax.

## Requirements

- **.NET 9.0** or **.NET 10.0**
- **Serilog** 4.2.0+
- `.Enrich.FromLogContext()` must be enabled in your Serilog configuration

## Contributing

Contributions are welcome! Please feel free to submit a Pull Request.

## License

This project is licensed under the MIT License — see the [LICENSE](LICENSE) file for details.

## Author

Gwynbleid85 ([@Gwynbleid85](https://github.com/Gwynbleid85))
