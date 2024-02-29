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

        public Book(int id, string author, string title, int publish_year, int page_count)
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
        public int Publish_year { get => publish_year; set => publish_year = value; }
        public string Title { get => title; set => title = value; }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
