namespace GA_Constructors_Hafsa
{
    //Hafsa Mohamed
    internal class Program
    {
        static void Main(string[] args)
        {
            Book newBook = new Book(); //this is calling a constructor the default one in this case

            Book bookAuthorAndName = new Book("Night Watch", "Terry Pratchett", "Jaden Smith"); //this is calling the custom contstructor

            Book bookNameOnly = new Book("Wyrd Sisters"); //this is overloading your constructor

            Book book1 = new Book("1984", "George Orwell", "Hafsa");
            Book book2 = new Book("The Hobbit");

            Console.WriteLine(bookNameOnly.Author);
            // Prints No Author Given

            // Displaying initialized values
            Console.WriteLine($"Book with Author and Title: Title - {bookAuthorAndName.Title}, Author - {bookAuthorAndName.Author}, Illustrator - {bookAuthorAndName.Illustrator}");
            Console.WriteLine($"Book with Title Only: Title - {bookNameOnly.Title}, Author - {bookNameOnly.Author}");
            Console.WriteLine($"Book 1: Title - {book1.Title}, Author - {book1.Author}, Illustrator - {book1.Illustrator}");
            Console.WriteLine($"Book 2: Title - {book2.Title}");
        }
    }
}