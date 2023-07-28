using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeGymOnline_TicTacToe_Modified
{
    public class Logger
    {
        
        private string logFilePath;
        public Logger(string FilePath)
        { 
            
            logFilePath= FilePath;
        }

        public void Log(string message)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(logFilePath, true))
                {
                    string logEntry = $"{DateTime.Now.ToString()} - {message}";
                    sw.WriteLine(logEntry);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error writing to log file: {ex.Message}");
            }
        }
    }
}
