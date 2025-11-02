using System;

namespace ConsoleApp42
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("", 1);
            Console.Write("Введите название книги: ");
            string titleInput = Console.ReadLine();
            book.Title = titleInput;

            Console.Write("Введите количество страниц: ");
            int pagesInput;
            if (int.TryParse(Console.ReadLine(), out pagesInput))
            {
                book.Pages = pagesInput;
            }
            else
            {
                Console.WriteLine("Некорректный ввод страниц, установлено 0.");
            }

            book.UpdateIsLong();

            book.Info();
        }
    }

    class Book
    {
        private string title;
        private int pages;
        private bool islong;

        public Book(string BookTitle, int BookPages)
        {
            title = BookTitle;
            pages = BookPages;
            UpdateIsLong();
        }

        public string Title
        {
            set 
            { 
                title = value; 
            }
            get 
            { 
                return title; 
            }
        }

        public int Pages
        {
            set
            {
                pages = value;
                UpdateIsLong();
            }
            get 
            { 
                return pages; 
            }
        }

        public bool IsLong
        {
            get 
            { 
                return islong; 
            }
        }
        public void UpdateIsLong()
        {
            islong = pages >= 300;
        }

        public void Info()
        {
            Console.WriteLine($"Книга: {title}, страниц: {pages}, длинна: {islong}");
        }
    }
}