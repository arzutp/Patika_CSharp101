using System;

namespace arayuzler
{
    public class DatabaseLogger : ILogger
    {
        public void writeLog()
        {
            Console.WriteLine("Database e loglandı");
        }
    }
}