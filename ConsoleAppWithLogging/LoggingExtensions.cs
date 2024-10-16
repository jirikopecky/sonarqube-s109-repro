using Microsoft.Extensions.Logging;

namespace ConsoleAppWithLogging;

public static partial class LoggingExtensions
{
    [LoggerMessage(101, LogLevel.Information, "The program is starting")]
    public static partial void ProgramStarting(this ILogger logger);


    [LoggerMessage(102, LogLevel.Information, "The program is stopping")]
    public static partial void ProgramStopping(this ILogger logger);
}