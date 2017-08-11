using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.Delegate_Chaining
{
    public delegate void LogEventHandler(LogEvent logEvent);
    class Program
    {
        static void Main(string[] args)
        {
            LogEventHandler logHandlers = LogToConsole;
            logHandlers += LogToFile;
            logHandlers(new LogEvent("Message"));
        }

        public static void LogToConsole(LogEvent logEvent)
        {
            Console.WriteLine(logEvent.Text);
        }

        public static void LogToFile(LogEvent logEvent)
        {
            File.AppendAllText(@"C:\Users\martin\Desktop\log.txt", logEvent.Text + "\n");
        }
    }
}
