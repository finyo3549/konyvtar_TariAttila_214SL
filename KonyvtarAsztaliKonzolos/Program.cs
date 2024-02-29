using KonyvtarAsztaliKonzolos;

internal class Program
{
    static void Main(string[] args)
    {
       // Kiiras();
        Statisztika.Szamolo();
        void Kiiras()
        {
            Statisztika statisztika = new Statisztika();
            foreach (Book book in statisztika.books)
            {
                Console.WriteLine($"ID: {book.Id}, Title: {book.Title}, Author: {book.Author}, Publish Year: {book.Publish_year}, Page Count: {book.Page_count}");

            }

        }

        Console.ReadKey();
    }

}
 
