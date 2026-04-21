using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModbusCleanUp.Logging
{
    public static class LogManager
    {
        public static string Create(string message, string type ="INFO")
        {
            string time = DateTime.Now.ToString("HH:mm:ss");
            return $"[{time}] [{type}] {message}";
        }
    }
}
