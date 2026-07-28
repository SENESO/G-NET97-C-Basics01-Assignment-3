using System.Text;

namespace G_NET97_C_Basics01_Assignment_3
{
    internal class Program
    {

        static void Main()
        {
            #region Question 01

            string title = "clean code";

            string upperTitle = title.ToUpper();

            Console.WriteLine(title);
            Console.WriteLine(upperTitle);

            #endregion

            #region Question 02

            string text1 = "Clean Code";
            string text2 = "Clean Code";

            bool sameObject = ReferenceEquals(text1, text2);

            Console.WriteLine(sameObject);

            #endregion


            #region Question 03

            StringBuilder bookList = new StringBuilder();

            bookList.Append("Book List");
            bookList.Append(" - Updated");

            Console.WriteLine(bookList);

            #endregion


            #region Question 04

            bookList.Replace("Book List", "Library");

            Console.WriteLine(bookList);

            #endregion

            #region Question 05

            string bookTitle = "Clean Code";
            int pages = 464;

            string result = "Book: " + bookTitle + ", Pages: " + pages;

            Console.WriteLine(result);

            #endregion

            #region Question 06

            string bookTitle2 = "Clean Code";
            int pages2 = 464;

            string result2 = $"Book: {bookTitle2}, Pages: {pages2}";

            Console.WriteLine(result2);

            #endregion


            #region Question 07

            string bookTitle3 = "Clean Code";
            int pages3 = 464;

            string result3 = string.Format(
                "Book: {0}, Pages: {1}",
                bookTitle3,
                pages3
            );

            Console.WriteLine(result3);

            #endregion
            #region Question 08

            int pages4 = 464;

            if (pages4 > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }

            #endregion


            #region Question 09

            int pages5 = 464;
            bool isAvailable = true;

            if (pages5 > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }

            #endregion


            #region Question 10

            string title4 = "Refactoring";

            switch (title4)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;

                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }

            #endregion


            #region Question 11

            int pages6 = 464;

            string sizeLabel = pages6 > 300
                ? "Long Book"
                : "Short Book";

            Console.WriteLine(sizeLabel);

            #endregion


            #region Question 12

            string[] books =
            {
            "Clean Code",
            "The Pragmatic Programmer",
            "Refactoring"
        };

            for (int i = 0; i < books.Length; i++)
            {
                Console.WriteLine($"{i + 1}. {books[i]}");
            }

            #endregion

            #region Question 13

            int index = 0;

            while (index < books.Length)
            {
                Console.WriteLine(books[index]);

                index++;
            }

            #endregion


            #region Question 14

            int counter = 0;

            do
            {
                Console.WriteLine("Checking book...");

                counter++;
            }
            while (counter < 3);

            #endregion


            #region Question 15

            foreach (string book in books)
            {
                Console.WriteLine(book);
            }

            #endregion

            #region Question 16

            foreach (string book in books)
            {
                if (book == "Refactoring")
                {
                    break;
                }

                Console.WriteLine(book);
            }

            #endregion

            #region Question 17

            foreach (string book in books)
            {
                if (book == "The Pragmatic Programmer")
                {
                    continue;
                }

                Console.WriteLine(book);
            }

            #endregion


            #region Question 18

            PrintFirstBook(books);

            #endregion
        }

        #region Question 18 (Method)

        static void PrintFirstBook(string[] books)
        {
            if (books.Length == 0)
            {
                return;
            }

            Console.WriteLine(books[0]);
        }

        #endregion
    }
}