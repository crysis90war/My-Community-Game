using MCG_Library.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCG_Library
{
    public static class GlobalConfig
    {
        public const string GamesFiles = "Games.csv";

        public static IDataConnection Connection { get; private set; }

        public static void InitializeConnection(ConnectionType DB)
        {
            if (DB == ConnectionType.MySql)
            {
                MySqlConnector mySql = new MySqlConnector();
                Connection = mySql;
            }
            //else if (DB == ConnectionType.TextFile)
            //{
            //    TextConnector text = new TextConnector();
            //    Connection = text;
            //}
        }

        public static string CnnString()
        {
            string _serverAddressPublic = "htsv.ddns.net";
            string _serverAddressPrivate = "192.168.1.100";
            string _serverAddressWamp = "127.0.0.1";
            string _databaseName = "db_mcg";
            string _username = "u_mcg";
            string _password = "eice2019PAC";
            int _port = 3307;
            int _portWamp = 3306;

            return $"SERVER={_serverAddressPrivate};DATABASE={_databaseName};UID={_username};PASSWORD={_password};PORT={_port};";
        }
    }
}
