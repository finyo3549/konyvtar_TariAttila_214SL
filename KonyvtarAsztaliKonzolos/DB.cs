using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KonyvtarAsztaliKonzolos
{

    internal class DB
    {
        MySqlConnection conn;
        public MySqlCommand sql { get; private set; }

        public DB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "192.168.1.58";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "konyvek";
            builder.CharacterSet = "UTF8";
            conn = new MySqlConnection(builder.ConnectionString);
            sql = conn.CreateCommand();
            try
            {
                kapcsolatNyit();
            }
            catch (MySqlException e)
            {
                Console.WriteLine   (e.Message);
                Environment.Exit(0);
            }
            finally
            {
                kapcsolatZar();
            }
            
        }
        public void kapcsolatZar()
        {
            if (conn.State == System.Data.ConnectionState.Open) conn.Close();
        }

        public void kapcsolatNyit()
        {
            if (conn.State != System.Data.ConnectionState.Open) conn.Open();
        }
    }

 }

