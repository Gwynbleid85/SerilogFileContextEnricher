public static class loggerWithContext
{
    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(0)]
    public static void InformationWithContext(
        this Serilog.ILogger logger,
        string messageTemplate,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Information(messageTemplate);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(1)]
    public static void InformationWithContext<T0>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Information(messageTemplate, propertyValue0);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(2)]
    public static void InformationWithContext<T0, T1>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Information(messageTemplate, propertyValue0, propertyValue1);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(3)]
    public static void InformationWithContext<T0, T1, T2>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        T2 propertyValue2,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Information(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(4)]
    public static void InformationWithContext<T0, T1, T2, T3>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        T2 propertyValue2,
        T3 propertyValue3,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Information(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(5)]
    public static void InformationWithContext<T0, T1, T2, T3, T4>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        T2 propertyValue2,
        T3 propertyValue3,
        T4 propertyValue4,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Information(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3, propertyValue4);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(0)]
    public static void WarningWithContext(
        this Serilog.ILogger logger,
        string messageTemplate,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Warning(messageTemplate);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(1)]
    public static void WarningWithContext<T0>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Warning(messageTemplate, propertyValue0);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(2)]
    public static void WarningWithContext<T0, T1>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Warning(messageTemplate, propertyValue0, propertyValue1);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(3)]
    public static void WarningWithContext<T0, T1, T2>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        T2 propertyValue2,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Warning(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(4)]
    public static void WarningWithContext<T0, T1, T2, T3>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        T2 propertyValue2,
        T3 propertyValue3,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Warning(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(5)]
    public static void WarningWithContext<T0, T1, T2, T3, T4>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        T2 propertyValue2,
        T3 propertyValue3,
        T4 propertyValue4,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Warning(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3, propertyValue4);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(0)]
    public static void ErrorWithContext(
        this Serilog.ILogger logger,
        string messageTemplate,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Error(messageTemplate);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(1)]
    public static void ErrorWithContext<T0>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Error(messageTemplate, propertyValue0);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(2)]
    public static void ErrorWithContext<T0, T1>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Error(messageTemplate, propertyValue0, propertyValue1);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(3)]
    public static void ErrorWithContext<T0, T1, T2>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        T2 propertyValue2,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Error(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(4)]
    public static void ErrorWithContext<T0, T1, T2, T3>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        T2 propertyValue2,
        T3 propertyValue3,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Error(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(5)]
    public static void ErrorWithContext<T0, T1, T2, T3, T4>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        T2 propertyValue2,
        T3 propertyValue3,
        T4 propertyValue4,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Error(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3, propertyValue4);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(0)]
    public static void DebugWithContext(
        this Serilog.ILogger logger,
        string messageTemplate,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Debug(messageTemplate);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(1)]
    public static void DebugWithContext<T0>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Debug(messageTemplate, propertyValue0);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(2)]
    public static void DebugWithContext<T0, T1>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Debug(messageTemplate, propertyValue0, propertyValue1);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(3)]
    public static void DebugWithContext<T0, T1, T2>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        T2 propertyValue2,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Debug(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(4)]
    public static void DebugWithContext<T0, T1, T2, T3>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        T2 propertyValue2,
        T3 propertyValue3,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Debug(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(5)]
    public static void DebugWithContext<T0, T1, T2, T3, T4>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        T2 propertyValue2,
        T3 propertyValue3,
        T4 propertyValue4,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Debug(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3, propertyValue4);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(0)]
    public static void VerboseWithContext(
        this Serilog.ILogger logger,
        string messageTemplate,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Verbose(messageTemplate);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(1)]
    public static void VerboseWithContext<T0>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Verbose(messageTemplate, propertyValue0);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(2)]
    public static void VerboseWithContext<T0, T1>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Verbose(messageTemplate, propertyValue0, propertyValue1);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(3)]
    public static void VerboseWithContext<T0, T1, T2>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        T2 propertyValue2,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Verbose(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(4)]
    public static void VerboseWithContext<T0, T1, T2, T3>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        T2 propertyValue2,
        T3 propertyValue3,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Verbose(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(5)]
    public static void VerboseWithContext<T0, T1, T2, T3, T4>(
        this Serilog.ILogger logger,
        string messageTemplate,
        T0 propertyValue0,
        T1 propertyValue1,
        T2 propertyValue2,
        T3 propertyValue3,
        T4 propertyValue4,
        [System.Runtime.CompilerServices.CallerMemberName] string memberName = "",
        [System.Runtime.CompilerServices.CallerFilePath] string filePath = "",
        [System.Runtime.CompilerServices.CallerLineNumber] int lineNumber = 0
    )
    {
        using (Serilog.Context.LogContext.PushProperty("CallerFilePath", filePath))
        using (Serilog.Context.LogContext.PushProperty("CallerFileName", Path.GetFileName(filePath)))
        using (Serilog.Context.LogContext.PushProperty("CallerMemberName", memberName))
        using (Serilog.Context.LogContext.PushProperty("CallerLineNumber", lineNumber))
        {
            logger.Verbose(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3, propertyValue4);
        }

    }


}