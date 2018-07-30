using Microsoft.Extensions.Logging;
using System;

namespace Metro.Logging.Abstract
{
    public interface ILoggerWriter
    {
        void WriteLog(LogLevel level, string message, string name, Exception exception, EventId eventId);
    }
}