using KonyvtarAsztaliKonzolos;

namespace GrafikusKonyvtar
{
    internal static class Program
    {
        public static List<Book> books = new List<Book>();
        public static DB db = new DB();
        public static Statisztika statisztika = new Statisztika();
        
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            
            Statisztika statisztika = new Statisztika();
            books = statisztika.books;
            Application.Run(new Form1());
        }
    }
}