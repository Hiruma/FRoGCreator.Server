using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace Classes // Mauvais namespace
{
    class Configs
    {    
        public static string TITLE = "Server Caption";
        public static int PORT = 5555, WAITLENGHT = 99;
        public static IPAddress IPALLOWED = IPAddress.Any;
        public ConsoleColor DoneColor   = ConsoleColor.Green,
                            WaitColor   = ConsoleColor.Yellow,
                            ErrorColor  = ConsoleColor.Red,
                            UnknowColor = ConsoleColor.Magenta;
        
        public static void Initialize()
        {
            Console.Title = TITLE;
        }
    }
}
