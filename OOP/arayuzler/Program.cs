using System;

namespace arayuzler
{
    class Program
    {
        static void Main(string[] args)
        {
            FileLogger fileLogger = new FileLogger();
            fileLogger.writeLog();

            DatabaseLogger databaseLogger = new DatabaseLogger();
            databaseLogger.writeLog();

            SmsLogger smsLogger = new SmsLogger();
            smsLogger.writeLog();

            LogManager logManager = new LogManager(new SmsLogger());
            logManager.writeLog();
        }
    }
}
