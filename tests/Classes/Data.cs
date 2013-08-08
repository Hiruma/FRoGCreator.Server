/* BROUILLON DATA.CS @\CLASSES*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Security.Cryptography;

namespace FRoGCreator.Server.Core.Classes
{
    public class Data
    {
        private SQLiteConnection SQL;

        private string _FilePath, _Password;

        public Data(string FilePath, string Password)
        {
            _FilePath = FilePath;
            _Password = Password;
        }

        public bool Connect()
        {
            try
            {
                SQL = new SQLiteConnection("Data Source=" + _FilePath);
                SQL.Open();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public void Disconnect()
        {
            try
            {
                SQL.Dispose();
            }
            catch { }
        }

        public string HashPassword(string Password)
        {
            MD5 Hasher_ = new MD5CryptoServiceProvider();
            byte[] bHash = Hasher_.ComputeHash(Encoding.Default.GetBytes(Classes.Configs.HASHPASS + Password));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < bHash.Length; i++)
            {
                sBuilder.Append(bHash[i].ToString("x2"));
            }
            return sBuilder.ToString();
        }

        public string ReadPassword(string Name)
        {
            string Command = "SELECT Password FROM Accounts WHERE Account='" + Name + "'";
            SQLiteDataReader Reader_ = new SQLiteCommand(Command, SQL).ExecuteReader();
            Reader_.Read(); return Reader_[0].ToString();
        }

        public string ReadIP(string Name)
        {
            string Command = "SELECT IP FROM Accounts WHERE Account='" + Name + "'";
            SQLiteDataReader Reader_ = new SQLiteCommand(Command, SQL).ExecuteReader();
            Reader_.Read(); return Reader_[0].ToString();
        }

        public void AccountCreate(string IP, string Name, string Password)
        {
            string Command = "INSERT INTO Accounts (IP, Account, Password) VALUES" +
            "('" + IP + "','" + Name + "','" + Password + "')";
            int result = new SQLiteCommand(Command, SQL).ExecuteNonQuery();

            if (result > 0)
            {
                //SEND PACKET : ACCOUNT CREATED
            }
        }
    }
}
