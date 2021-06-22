using System;

namespace arayuzler
{
    public class LogManager : ILogger{
        public ILogger _logger;
        public LogManager(ILogger logger){
            _logger = logger;
        }

        public void writeLog()
        {
            _logger.writeLog();
        }
    }
}