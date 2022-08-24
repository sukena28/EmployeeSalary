using System.Diagnostics;
using ILogger = Serilog.ILogger;

namespace MainProject.Common.Extensions
{
    public static class LoggerExtensions
    {
        public static ILogger LogException(this ILogger logger, HttpContext context, Exception exception)
        {
            var stackTrace = new StackTrace(exception, true);
            var currentFile = stackTrace.GetFrame(0)?.GetFileName();
            var currentLine = stackTrace.GetFrame(0)!.GetFileLineNumber();
            var description = exception.Message;
            var type = exception.GetType().ToString();
            var path = context.Request.Path.ToString();
            var method = context.Request.Method;

            var loggerMessage = "\n" + $"[Path]: {path}\n " + $"[Method]: {method}\n " + $"[Class]: {currentFile}\n " +
                                $"[Line]: {currentLine}\n " + $"[Exception Type]: {type}\n" +
                                $"[Message]: {description}\n " + $"[StackTrace]: {stackTrace}\n";

            logger.Information(loggerMessage);
            logger.Error(loggerMessage);
            logger.Debug(loggerMessage);
            return logger;
        }

      
    }
}