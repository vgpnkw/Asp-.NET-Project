using System;
using Microsoft.Extensions.Logging;

namespace WikiPedia.logs
{
    public class FileLoggerProvider : ILoggerProvider
    {
        private string allLogPath;
        private string errorLogPath;
        public FileLoggerProvider(string allLogPath, string errorLogPath)
        {
            this.allLogPath = allLogPath;
            this.errorLogPath = errorLogPath;
        }
        public ILogger CreateLogger(string categoryName)
        {
            return new FileLogger(allLogPath, errorLogPath);
        }

        public void Dispose()
        {
        }
    }
}
