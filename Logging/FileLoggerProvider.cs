using Microsoft.Extensions.Logging;

namespace Tasks
{
    public class FileLoggerProvider : ILoggerProvider
    {
        private readonly string _logFilePath;

        public FileLoggerProvider(string logFilePath)
        {
            _logFilePath = logFilePath;
        }

        /// <summary>
        /// Создает новый экземпляр логгера для указанной категории
        /// </summary>
        public ILogger CreateLogger(string categoryName)
        {
            return new FileLogger(_logFilePath);
        }

        /// <summary>
        /// Освобождает ресурсы поставщика логгеров
        /// </summary>
        public void Dispose() { }
    }
}
