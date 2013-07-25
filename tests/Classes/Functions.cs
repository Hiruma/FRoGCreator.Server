using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using Classes.Configs; // Mauvais path

namespace Classes // Mauvais namespace
{
    public class Functions
    {
        public void ConsoleWriter(uint MessageLevel_, string Message_, ConsoleColor MessageColor_)
        {
            switch (MessageLevel_)
            {
                case 0:
                    Console.Write("\t\t\t");
                    break;
                case 1:
                    Console.ForegroundColor = DoneColor;
                    Console.Write("  VALIDE    ");
                    break;
                case 2:
                Console.ForegroundColor = WaitColor;
                    Console.Write("  ATTENTE   ");
                    break;
                case 3:
                    Console.ForegroundColor = ErrorColor;
                    Console.Write("  ERREUR    ");
                    break;
                default:
                    Console.ForegroundColor = UnknowColor;
                    Console.Write("  INCONNUE  ");
                    break;
            }
            
            Console.ForegroundColor = MessageColor_;
            Console.Write(Message_ + "\n");
            Console.ResetColor();
        }
    }
}
