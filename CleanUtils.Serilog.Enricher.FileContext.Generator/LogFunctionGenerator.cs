using System.Text.Json.Serialization;

namespace CleanUtils.Serilog.Enricher.FileContext.Generator;

[JsonConverter(typeof(JsonStringEnumConverter))]
public enum LogFunctionType
{
    Information,
    Warning,
    Error,
    Debug,
    Verbose,
}

public enum LoggerAccessMethod
{
    ILogger,
    StaticClass,
}

public class LogFunctionGenerator
{
    private static string _className = null!;

    public static string GenerateLogFunction(
        LoggerAccessMethod loggerAccessMethod,
        string className
    )
    {
        _className = className;

        var methods = GenerateLogMethodSet(loggerAccessMethod, 5);

        return WrapIntoClass(methods);
    }

    private static string GenerateLogMethodSet(
        LoggerAccessMethod loggerAccessMethod,
        int maxGenericParameterCount
    )
    {
        LogFunctionType[] logFunctionTypes =
        [
            LogFunctionType.Information,
            LogFunctionType.Warning,
            LogFunctionType.Error,
            LogFunctionType.Debug,
            LogFunctionType.Verbose,
        ];

        var generatedMethods = "";
        foreach (var logFunctionType in logFunctionTypes)
        {
            for (int i = 0; i <= maxGenericParameterCount; i++)
            {
                var logMethodCall = GenerateLogMethodCall(logFunctionType, i, loggerAccessMethod);
                var wrappedLogContext = WrapLogContext(logMethodCall);
                var methodHeader = WrapIntoMethod(
                    logFunctionType,
                    loggerAccessMethod,
                    i,
                    wrappedLogContext
                );
                generatedMethods += methodHeader;
            }
        }
        return generatedMethods;
    }

    private static string WrapLogContext(string LogMethodCall)
    {
        return $@"        using (Serilog.Context.LogContext.PushProperty(""CallerFilePath"", filePath))
        using (Serilog.Context.LogContext.PushProperty(""CallerFileName"", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty(""CallerMemberName"", memberName))
        using (Serilog.Context.LogContext.PushProperty(""CallerLineNumber"", lineNumber))
        {{
            {LogMethodCall}
        }}
";
    }

    private static string WrapIntoMethod(
        LogFunctionType logFunctionType,
        LoggerAccessMethod loggerAccessMethod,
        int genericParameterCount,
        string methodBody
    )
    {
        return $@"    [Serilog.Core.MessageTemplateFormatMethod(""messageTemplate"")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority({genericParameterCount})]
    public static void {logFunctionType}{(loggerAccessMethod == LoggerAccessMethod.ILogger ? "WithContext" : "")}{(genericParameterCount > 0 ? $"<{string.Join(", ", Enumerable.Range(0, genericParameterCount).Select(i => $"T{i}"))}>" : "")}(
        {loggerAccessMethod switch {
            LoggerAccessMethod.ILogger => @"this Serilog.ILogger logger,",
            LoggerAccessMethod.StaticClass => @"",
            _ => throw new ArgumentOutOfRangeException(nameof(loggerAccessMethod), loggerAccessMethod, null) }}
        string messageTemplate,{(genericParameterCount > 0 ? "\n        " + string.Join(",\n        ", Enumerable.Range(0, genericParameterCount).Select(i => $"T{i} propertyValue{i}")) + "," : String.Empty)}
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = """",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = """",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {{
{methodBody}
    }}

";
    }

    private static string GenerateLogMethodCall(
        LogFunctionType logFunctionType,
        int genericParameterCount,
        LoggerAccessMethod loggerAccessMethod
    )
    {
        var loggerExpression = loggerAccessMethod switch
        {
            LoggerAccessMethod.ILogger => "logger",
            LoggerAccessMethod.StaticClass => "Serilog.Log.Logger",
            _ => throw new ArgumentOutOfRangeException(
                nameof(loggerAccessMethod),
                loggerAccessMethod,
                null
            ),
        };
        return $"{loggerExpression}.{logFunctionType}(messageTemplate{(genericParameterCount > 0 ? ", " : "")}{(genericParameterCount > 0 ? string.Join(", ", Enumerable.Range(0, genericParameterCount).Select(i => $"propertyValue{i}")) : "")});";
    }

    private static string WrapIntoClass(string methodCode)
    {
        return $@"public static class {_className}
{{
{methodCode}
}}";
    }
}
