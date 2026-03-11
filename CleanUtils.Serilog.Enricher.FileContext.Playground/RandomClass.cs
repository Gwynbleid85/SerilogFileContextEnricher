using Serilog;

namespace CleanUtils.Serilog.Enricher.FileContext.Playground;

public class RandomClass
{
    public static void DoSomething()
    {
        Log.Logger.InformationWithContext("Logging some information");

        ContextLog.Information("Logging some information");
    }

    public static void DoSomethingWithProperties()
    {
        Log.Logger.InformationWithContext(
            "Doing something in RandomClass.DoSomethingWithProperties with properties {@Property1} and {@Property2}",
            "Value1",
            123
        );
        ContextLog.Information(
            "Doing something in RandomClass.DoSomethingWithProperties with properties {@Property1} and {@Property2}",
            "Value1",
            123
        );
    }
}
