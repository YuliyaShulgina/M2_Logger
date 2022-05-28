using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    partial class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Logger.Run();
        }
        public sealed partial class Logger
        {
            private static readonly Logger instance = new Logger();
            private List<string> _logs = new List<string>();
            static Logger()
            {
            }

            private Logger()
            {
            }

            public static Logger Instance
            {
                get
                {
                    return instance;
                }
            }

            public void Log(DateTime datetime, LogType logType, string message)
            {
                //Console.WriteLine($" {datetime} : {logType} : {message}");
                var fullMessage = $" {datetime} : {logType} : {message}";
                _logs.Add(fullMessage);
                Console.WriteLine(fullMessage);
            }

            public List<string> GetLogs()
            {
                return _logs;
            }
        }
        public class Result
        {
            public bool Status { get; set; }
            public string ErrorMessage { get; set; }
        }
    }
}
