using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyIoC;
using log4net;
using NHibernate;
using log4net.Appender;

namespace FRoGCreator.Server.Core
{
    public static class Loader
    {
        private static readonly ILog Logger = LogManager.GetLogger(typeof (Loader));

        public static void InitializeServer()
        {
            Console.WriteLine("Initialisation du serveur ...\n");
            InitConfig();
        }

        static void InitConfig()
        {
            try
            {
                //TODO: Load server's config
                Logger.Info("CONFIG OK");
            } 
            catch (Exception e) 
            {
                Logger.Fatal(e);
            }

        }
    }
}
