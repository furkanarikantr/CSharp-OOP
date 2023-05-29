using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP3
{
    internal class DatabaseLoggerManager : ILoggerManager
    {
        public void Log()
        {
            Console.WriteLine("Database Logged!");
        }
    }
}
