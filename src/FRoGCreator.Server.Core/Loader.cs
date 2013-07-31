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
        private static ILog _logger;

        public static void InitializeServer()
        {
            Console.WriteLine("Initialisation du serveur ...");
            InitLogger();
            InitConfig();
            Console.WriteLine("Initialisation terminée");
        }

        static void InitLogger()
        {
            log4net.Config.BasicConfigurator.Configure();
            _logger = LogManager.GetLogger("MainLogger");
            TinyIoCContainer.Current.Register(_logger);
        }

        static void InitConfig()
        {
            _logger.Info("Config: OK");
        }
    }
}
