using CleanUtils.Serilog.Enricher.FileContext.Generator;

(string, LoggerAccessMethod)[] configs =
[
    ("loggerWithContext", LoggerAccessMethod.ILogger),
    ("ContextLog", LoggerAccessMethod.StaticClass),
];

foreach (var (name, accessMethod) in configs)
{
    var generatedCode = LogFunctionGenerator.GenerateLogFunction(accessMethod, name);

    // Navigate from bin output (e.g. bin/Debug/net9.0/) up to solution root,
    // then into the sibling core library project
    var outputPath = Path.Combine(
        AppContext.BaseDirectory, "..", "..", "..", "..",
        "CleanUtils.Serilog.Enricher.FileContext",
        $"{name}.cs"
    );
    Console.WriteLine($"Generating to: {outputPath}");
    File.WriteAllText(outputPath, generatedCode);
}
