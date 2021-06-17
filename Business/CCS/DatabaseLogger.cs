using System;

namespace LayeredArchitectureExample.Business.CCS
{
    public class DatabaseLogger : ILogger
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}