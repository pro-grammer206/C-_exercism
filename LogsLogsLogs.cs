static class LogLine
{
    public static LogLevel ParseLogLevel(string logLine)
    {
        string log = logLine.Substring(1, 3);
        Console.WriteLine(log);
        LogLevel logLevel = LogLevel.Trace;
        switch (log)
        {
            case "INF":
                logLevel = LogLevel.Info;
                break;
            case "TRC":
                logLevel = LogLevel.Trace;
                break;
            case "DBG":
                logLevel = LogLevel.Debug;
                break;
            case "WRN":
                logLevel = LogLevel.Warning;
                break;
            case "ERR":
                logLevel = LogLevel.Error;
                break;
            case "FTL":
                logLevel = LogLevel.Fatal;
                break;
            default:
                logLevel = LogLevel.Unknown;
                break;
        }
        return logLevel;
    }
    public static string OutputForShortLog(LogLevel logLevel, string message)
    {
        return $"{(int)logLevel}:{message}";
    }
}

public enum LogLevel
{
    Unknown = 0,
    Trace = 1,
    Debug = 2,
    Info = 4,
    Warning = 5,
    Error = 6,
    Fatal = 42,
}
