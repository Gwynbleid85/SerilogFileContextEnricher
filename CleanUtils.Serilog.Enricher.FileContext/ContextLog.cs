public static class ContextLog
{
    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(0)]
    public static void Information(
        
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
            Serilog.Log.Logger.Information(messageTemplate);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(1)]
    public static void Information<T0>(
        
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
            Serilog.Log.Logger.Information(messageTemplate, propertyValue0);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(2)]
    public static void Information<T0, T1>(
        
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
            Serilog.Log.Logger.Information(messageTemplate, propertyValue0, propertyValue1);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(3)]
    public static void Information<T0, T1, T2>(
        
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
            Serilog.Log.Logger.Information(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(4)]
    public static void Information<T0, T1, T2, T3>(
        
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
            Serilog.Log.Logger.Information(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(5)]
    public static void Information<T0, T1, T2, T3, T4>(
        
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
            Serilog.Log.Logger.Information(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3, propertyValue4);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(0)]
    public static void Warning(
        
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
            Serilog.Log.Logger.Warning(messageTemplate);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(1)]
    public static void Warning<T0>(
        
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
            Serilog.Log.Logger.Warning(messageTemplate, propertyValue0);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(2)]
    public static void Warning<T0, T1>(
        
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
            Serilog.Log.Logger.Warning(messageTemplate, propertyValue0, propertyValue1);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(3)]
    public static void Warning<T0, T1, T2>(
        
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
            Serilog.Log.Logger.Warning(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(4)]
    public static void Warning<T0, T1, T2, T3>(
        
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
            Serilog.Log.Logger.Warning(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(5)]
    public static void Warning<T0, T1, T2, T3, T4>(
        
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
            Serilog.Log.Logger.Warning(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3, propertyValue4);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(0)]
    public static void Error(
        
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
            Serilog.Log.Logger.Error(messageTemplate);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(1)]
    public static void Error<T0>(
        
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
            Serilog.Log.Logger.Error(messageTemplate, propertyValue0);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(2)]
    public static void Error<T0, T1>(
        
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
            Serilog.Log.Logger.Error(messageTemplate, propertyValue0, propertyValue1);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(3)]
    public static void Error<T0, T1, T2>(
        
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
            Serilog.Log.Logger.Error(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(4)]
    public static void Error<T0, T1, T2, T3>(
        
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
            Serilog.Log.Logger.Error(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(5)]
    public static void Error<T0, T1, T2, T3, T4>(
        
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
            Serilog.Log.Logger.Error(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3, propertyValue4);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(0)]
    public static void Debug(
        
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
            Serilog.Log.Logger.Debug(messageTemplate);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(1)]
    public static void Debug<T0>(
        
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
            Serilog.Log.Logger.Debug(messageTemplate, propertyValue0);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(2)]
    public static void Debug<T0, T1>(
        
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
            Serilog.Log.Logger.Debug(messageTemplate, propertyValue0, propertyValue1);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(3)]
    public static void Debug<T0, T1, T2>(
        
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
            Serilog.Log.Logger.Debug(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(4)]
    public static void Debug<T0, T1, T2, T3>(
        
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
            Serilog.Log.Logger.Debug(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(5)]
    public static void Debug<T0, T1, T2, T3, T4>(
        
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
            Serilog.Log.Logger.Debug(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3, propertyValue4);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(0)]
    public static void Verbose(
        
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
            Serilog.Log.Logger.Verbose(messageTemplate);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(1)]
    public static void Verbose<T0>(
        
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
            Serilog.Log.Logger.Verbose(messageTemplate, propertyValue0);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(2)]
    public static void Verbose<T0, T1>(
        
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
            Serilog.Log.Logger.Verbose(messageTemplate, propertyValue0, propertyValue1);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(3)]
    public static void Verbose<T0, T1, T2>(
        
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
            Serilog.Log.Logger.Verbose(messageTemplate, propertyValue0, propertyValue1, propertyValue2);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(4)]
    public static void Verbose<T0, T1, T2, T3>(
        
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
            Serilog.Log.Logger.Verbose(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3);
        }

    }

    [Serilog.Core.MessageTemplateFormatMethod("messageTemplate")]
    [System.Runtime.CompilerServices.OverloadResolutionPriority(5)]
    public static void Verbose<T0, T1, T2, T3, T4>(
        
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
            Serilog.Log.Logger.Verbose(messageTemplate, propertyValue0, propertyValue1, propertyValue2, propertyValue3, propertyValue4);
        }

    }


}