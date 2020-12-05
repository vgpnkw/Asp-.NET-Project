using System;
using Microsoft.Extensions.Logging;

namespace WikiPedia.logs
{
    public static class FileLoggerExtensions
    {
        public static ILoggerFactory AddFile(this ILoggerFactory factory, string allLogPath, string errorLogPath)
        {
            factory.AddProvider(new FileLoggerProvider(allLogPath, errorLogPath));
            return factory;
        }
    }
}
