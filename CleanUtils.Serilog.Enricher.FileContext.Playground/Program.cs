using System.Globalization;
using CleanUtils.Serilog.Enricher.FileContext.Playground;
using Serilog;

Log.Logger = new LoggerConfiguration()
    .Enrich.FromLogContext()
    .WriteTo.Console(
        outputTemplate: "[{Timestamp:yyyy-MM-dd HH:mm:ss} {Level:u3} {CallerFilePath}/{CallerMemberName}:{CallerLineNumber}] {Message:lj}{NewLine}{Exception}",
        formatProvider: CultureInfo.InvariantCulture
    )
    .CreateLogger();

RandomClass.DoSomething();
RandomClass.DoSomethingWithProperties();
