using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOAnalysOODesign
{
    internal class Database
    {
        private MySqlConnection conn;

        private string server;

        private string database;

        private string user;

        private string password;

        public Database()
        {

            server = "localhost";
            database = "bussappDB";
            user = "root";
            password = "EttSuperHemligtLösenord123!";

            string connString = $"SERVER={server};DATABASE={database};UID={user};PASSWORD={password};";

            conn = new MySqlConnection(connString);

        }
        

        public MySqlConnection GetConnection()
        {
            return conn;
        }

        public bool OpenConnection()
        {
            try
            {
                conn.Open();
                return true;

            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        break;
                    case 1045:
                        break;
                }

                return false;
            }


        }

        public bool CloseConnection()
        {
            try
            {
                conn.Close();
                return true;

            }
            catch (MySqlException e)
            {
                switch (e.Number)
                {
                    case 0:
                        break;
                    case 1045:
                        break;
                }

                return false;
            }

        }


    }
}
