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
        static string TITLE = "Server Caption";
        static int PORT = 5555,
             WAITLENGHT = 99;
        static IPAddress IPALLOWED = IPAddress.Any;
        
        Public static void Initialize()
        {
            Console.Title = TITLE;
        }
    }
}
