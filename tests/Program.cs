using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
/*using System.Threading;*/
using System.Threading.Tasks;
/*using System.Net;
using System.Net.Sockets;*/

namespace FRoGCreator.Server.Console.Authentication
{
    class Program
    {
        // private static ManualResetEvent _Valider = new ManualResetEvent(false);
        static void Main(string[] args)
        {
            /*try
            {
                Socket Listener = new Socket(
                    AddressFamily.InterNetwork,
                    SocketType.Stream, 
                    ProtocolType.Tcp);
                Listener.Bind(new IPEndPoint(Configs.IPALLOWED, Configs.PORT));
                Listener.Listen(Configs.WAITLENGHT);
                
                while(true)
                {
                    _Valider.Reset();
                    Listener.BeginAccept(new AsyncCallback(AsyncAccept), Listener);
                    _Valider.WaitOne();
                }
            }
            catch(Exception ex)
            {
                return; // Display Error
            }*/
        }
        
        /*public static void AsyncAccept(IAsyncResult Result_)
        {
            try
            {
                _Valider.Set();
                Socket Client = ((Socket)Result_.AsyncState).EndAccept(Result_);
                //Add Client in Dict 
                //       ...         
                //NetworkPath Client >> Client.RemoteEndPoint();     
            }
            catch (Exception ex)
            {
                return; // Display Error
            }
        }*/
    }
}
