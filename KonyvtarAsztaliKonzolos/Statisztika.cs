using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarAsztaliKonzolos
{
    internal class Statisztika
    {
        public List<Book> books = new List<Book>();
        public Statisztika()
        {
            DB db = new DB();
            db.sql.CommandText = "SELECT * FROM books";

            try
            {
                db.kapcsolatNyit();
                using (MySqlDataReader dr = db.sql.ExecuteReader())
                {
                while (dr.Read())
                    { 
                        int id = (int)dr.GetInt64("id");
                        string title = dr.GetString("title");
                        string author = dr.GetString("author");
                        int publish_year = dr.GetInt32("publish_year");
                        int page_count = dr.GetInt32("page_count");
                        books.Add(new Book(id, author, title, publish_year, page_count));
                       // Console.Write($"{title}\n");
                }

            }
        } catch (MySqlException e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                db.kapcsolatZar();
            }
        }
        public static void Szamolo()
        {
            Statisztika statisztika = new Statisztika();
            int szamlalo = 0;
            int regi = 0;
            Book leghosszabb = statisztika.books[0];

            foreach (Book book in statisztika.books)
            {
                if(book.Page_count > leghosszabb.Page_count)
                {
                    leghosszabb = book;
                }
                if (book.Publish_year < 1950)
                {
                    regi ++ ;
                }
                if (book.Page_count > 500 )
                {
                    
                    szamlalo++;
                }
            }

            Console.WriteLine($"A 500 oldalnál hosszabb könyvek száma: {szamlalo}");
            
                Console.WriteLine($"{regi} db könyv jelent meg 1950 előtt ");
            
            Console.WriteLine($"A leghosszabb könyv adatai:Cím: {leghosszabb.Title}\nSzerző: {leghosszabb.Author} \nKiadás éve: {leghosszabb.Publish_year}\nOldalszám: {leghosszabb.Page_count}");

            Dictionary<string, int> szerzoKonyvekSzama = new Dictionary<string, int>();

            foreach (Book book in statisztika.books)
            {
                if (szerzoKonyvekSzama.ContainsKey(book.Author))
                {
                    szerzoKonyvekSzama[book.Author]++;
                }
                else
                {
                    szerzoKonyvekSzama[book.Author] = 1;
                }
            }
            string legtobbKonyvvelRendelkezoSzerzo = "";
            int legtobbKonyvSzam = 0;
            foreach (var konyvszam in szerzoKonyvekSzama)
            {
                if (konyvszam.Value > legtobbKonyvSzam)
                {
                    legtobbKonyvvelRendelkezoSzerzo = konyvszam.Key;
                    legtobbKonyvSzam = konyvszam.Value;
                }
            }
            Console.WriteLine($"A legtöbb könyvvel rendelkező szerző: {legtobbKonyvvelRendelkezoSzerzo}, könyvek száma: {legtobbKonyvSzam}");

            Console.Write("Add meg a könvy címét: ");
            string konyvcim = Console.ReadLine();
            bool van = false;
            foreach(Book book in statisztika.books)
            {
                if (book.Title == konyvcim)
                {
                    Console.WriteLine($"A könyv adatai: Szerző: {book.Author}, Oldalszám: {book.Page_count}, Kiadás éve: {book.Publish_year}");
                    van = true;
                }
            }
            if(!van)
            {
                Console.WriteLine("Nincs ilyen könyv a listában");
            }
        }

    }

}
