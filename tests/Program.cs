using System;
using System.Threading;
using System.Net;
using System.Net.Sockets;
using NLog;

/*Accès libre sans test et cryptage*/

namespace FRoGCreator.Server.Console.Authentication
{
    class Program
    {
        private static ManualResetEvent _Valider = new ManualResetEvent(false);
        private static Logger _Log = LogManager.GetCurrentClassLogger();
        
        static void Main(string[] args)
        {
            try
            {
                Socket Listener = new Socket(
                    AddressFamily.InterNetwork,
                    SocketType.Stream, 
                    ProtocolType.Tcp);
                Listener.Bind(new IPEndPoint(Configs.IPALLOWED, Configs.PORT));
                Listener.Listen(Configs.WAITLENGHT);
                
                // Un peu de renseignements pour l'utilisateur
                _Log.Info("Lecture des demandes clientes sur le port {0}", Configs.PORT.ToString());
                
                while(true)
                {
                    _Valider.Reset();
                    Listener.BeginAccept(new AsyncCallback(AsyncAccept), Listener);
                    _Valider.WaitOne();
                }
            }
            catch(Exception ex)
            {
                _Log.Error(ex.Message);
            }
        }
        
        public static void AsyncAccept(IAsyncResult Result_)
        {
            try
            {
                _Valider.Set();
                Socket Client = ((Socket)Result_.AsyncState).EndAccept(Result_);
                //Add Client in Dict 
                //       ...         
                
                // Un peu de renseignements pour l'utilisateur
                _Log.Trace("Nouveau client accepté depuis {0}", Client.RemoteEndPoint.ToString());
            }
            catch (Exception ex)
            {
                _Log.Error(ex.Message);
            }
        }
    }
}
