using Microsoft.Extensions.Logging;

namespace Tasks
{
    /// <summary>
    /// для записи логов в файл
    /// </summary>
    public class FileLogger : ILogger
    {
        private readonly string _logFilePath;

        public FileLogger(string logFilePath)
        {
            _logFilePath = logFilePath;
            Directory.CreateDirectory(Path.GetDirectoryName(_logFilePath)!);
        }

        /// <summary>
        /// Проверяет, включено ли логирование для указанного уровня
        /// </summary>
        public bool IsEnabled(LogLevel logLevel) => true;

        /// <summary>
        /// записывает сообщение в лог-файл
        /// </summary>
        public void Log<TState>(LogLevel logLevel, EventId eventId, TState state, Exception exception, Func<TState, Exception, string> formatter)
        {
            string message = $"{DateTime.Now:yyyy-MM-dd HH:mm:ss} [{logLevel}] {formatter(state, exception)}";
            File.AppendAllText(_logFilePath, message + Environment.NewLine);
        }

        /// <summary>
        /// начинает новую область логирования
        /// </summary>
        public IDisposable BeginScope<TState>(TState state) => null;
    }
}
