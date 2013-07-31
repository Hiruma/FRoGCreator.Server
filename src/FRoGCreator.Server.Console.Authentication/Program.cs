using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FRoGCreator.Server.Core;

namespace FRoGCreator.Server.Console.Authentication
{
    class Program
    {
        static void Main(string[] args)
        {
            Loader.InitializeServer();
            System.Console.ReadLine();
        }
    }
}
