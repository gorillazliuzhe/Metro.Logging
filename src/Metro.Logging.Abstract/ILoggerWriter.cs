using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Text;

namespace Metro.Logging.Abstract
{
    public interface ILoggerWriter
    {
        void WriteLog(LogLevel level, string message, string name, Exception exception, EventId eventId);
    }
}
