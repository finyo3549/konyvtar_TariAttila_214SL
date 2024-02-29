using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace KonyvtarAsztaliKonzolos
{

    public class DB
    {
        MySqlConnection conn;
        public MySqlCommand sql { get; private set; }

        public DB()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
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
                Console.WriteLine(e.Message);
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
        public void Patch(Book book)
        {

            sql.CommandText = "UPDATE `books` SET `id`=@id,`title`=@title,`author`=@author,`publish_year`=@publish_year,`page_count`=@page_count WHERE `id`= @id";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@id", book.Id);
            sql.Parameters.AddWithValue("@title", book.Title);
            sql.Parameters.AddWithValue("@author", book.Author);
            sql.Parameters.AddWithValue("@publish_year", book.Publish_year);
            sql.Parameters.AddWithValue("@page_count", book.Page_count);
            try
            {
                kapcsolatNyit();
                sql.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                kapcsolatZar();
            }
        }
        public void Delete(Book book)
        {

            sql.CommandText = "DELETE FROM `books` WHERE `id`= @id";

            try
            {
                kapcsolatNyit();
                sql.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                kapcsolatZar();
            }
        }
        public void Insert(Book book)
        {
            sql.CommandText = "INSERT INTO `books`(`title`, `author`, `publish_year`, `page_count`) VALUES (@title,@author,@publish_year,@page_count)";
            sql.Parameters.Clear();
            sql.Parameters.AddWithValue("@title", book.Title);
            sql.Parameters.AddWithValue("@author", book.Author);
            sql.Parameters.AddWithValue("@publish_year", book.Publish_year);
            sql.Parameters.AddWithValue("@page_count", book.Page_count);
            try
            {
                kapcsolatNyit();
                sql.ExecuteNonQuery();
            }
            catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                kapcsolatZar();
            }
        }   
    }
}



