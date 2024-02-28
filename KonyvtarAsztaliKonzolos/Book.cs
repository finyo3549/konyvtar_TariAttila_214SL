using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonyvtarAsztaliKonzolos
{
    internal class Book
    {
        private string author;
        private int id;
        private int page_count;
        private string title;
        private int publish_year;

        public Book(string Author, int Id, int Page_count, string Title, int Publish_year)
        {
            Author = author;
            Id = id;
            Page_count = page_count;
            Title = title;
            Publish_year = publish_year;
        }

        public string Author { get => author; set => author = value; }
        public int Id { get => id; set => id = value; }
        public int Page_count { get => page_count; set => page_count = value; }
        public string Title { get => title; set => title = value; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
