using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Net;
using System.Net.Sockets;
using Classes.Functions; // Mauvais path

/*Accès libre sans test et cryptage*/

namespace FRoGCreator.Server.Console.Authentication
{
    class Program
    {
        private static ManualResetEvent _Valider = new ManualResetEvent(false);
        
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
                ConsoleWriter(2, "Lecture des demandes clientes sur le port " + Configs.PORT.ToString());
                
                while(true)
                {
                    _Valider.Reset();
                    Listener.BeginAccept(new AsyncCallback(AsyncAccept), Listener);
                    _Valider.WaitOne();
                }
            }
            catch(Exception ex)
            {
                ConsoleWriter(3, ex.Message);
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
                ConsoleWriter(1, "Nouveau client accepté depuis " + Client.RemoteEndPoint.ToString());
            }
            catch (Exception ex)
            {
                ConsoleWriter(3, ex.Message);
            }
        }
    }
}
