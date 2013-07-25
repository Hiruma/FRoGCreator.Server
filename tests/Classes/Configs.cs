using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

namespace AuthServer.Classes
{
    class Configs
    {    
        public static string TITLE = "Server Caption";
        public static int PORT = 5555, WAITLENGHT = 99;
        public static IPAddress IPALLOWED = IPAddress.Any;
        
        public static void Initialize()
        {
            Console.Title = TITLE;
        }
    }
}
