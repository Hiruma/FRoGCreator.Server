/* BROUILLON ACCOUNT.CS @\CLASSES*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;

namespace FRoGCreator.Server.Core.Classes
{
    public static class Account
    {
        private static Data _Data;

        public static void Initialize()
        {
            _Data = new Data(Configs.DATABASE, Configs.PASSWORD);
            _Data.Connect();
        }

        public static string Password(string Name)
        {
            try    { return _Data.ReadPassword(Name); }
            catch  { return ""; }
        }

        public static string IP(string Name)
        {
            try { return _Data.ReadIP(Name); }
            catch { return ""; }
        }

        public static void Create(string IP, string Name, string Password)
        {
            try    
            {
                string hPass = _Data.HashPassword(Password);
                _Data.AccountCreate(IP, Name, hPass); 
            }
            catch
            {
                //SEND PACKET : ACCOUNT NOT CREATED
            }
        }
    }
}
