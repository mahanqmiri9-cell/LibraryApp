using System.Collections.Generic;
using Domain.Entities;
using Book_Service;
using Service.Entities;
using Persistance;
using System.Security.Cryptography.X509Certificates;
using Book_Repository;

namespace UI_Console_
{
    internal class Program
    {
        private readonly IBookService _bookService;
        public Program(IBookService bookService)
        {
            _bookService = bookService;
        }

        static void Main(string[] args)
        {
            IBookRepository bookRepository = new BookRepository();

            IBookService bookService = new BookService(bookRepository);

            Program program = new Program(bookService);
            program.Run();
        }

        public void Run()
        {
            Console.WriteLine("Wellcome to LibraryApp");
            while (true)
            {
                Console.WriteLine("Please enter (Add) to Add book, (Search) to Search book by name, (Get) to get list of all books or (Exit) to exit the app here  ");
                string UserInput = Console.ReadLine();

                if (UserInput.ToLower() == "add")
                {

                    while (true)
                    {
                        Book book = new Book();

                        Console.WriteLine("\nPlease enter your books genre here\n");
                        book.Genre = Console.ReadLine();

                        Console.WriteLine("\nPlease enter your books name here\n");
                        book.Name = Console.ReadLine();

                        Console.WriteLine("\nPlease enter your books author name here\n");
                        book.Author = Console.ReadLine();

                        Console.WriteLine("\nPlease enter your books publication here\n");
                        book.Publication = Console.ReadLine();

                        _bookService.Add(book);



                        Console.WriteLine("Do you want to add a new book? if yes enter else enter (Exit) ");
                        string UserInput2 = Console.ReadLine();
                        if (UserInput2.ToLower() == "exit")
                        {
                            break;
                        }

                        else;
                        {
                            continue;
                        }


                    }
                }

                if (UserInput.ToLower() == "search")
                {
                    Console.WriteLine("\nEnter the name of a book, I search it ");
                    string name = Console.ReadLine();
                    Book FoundBook = _bookService.GetByName(name);

                    if (FoundBook != null)
                    {
                        Console.WriteLine($"\nI found it\n\n{FoundBook}");
                    }
                    else
                    {
                        Console.WriteLine("\nNot found!");
                    }
                }

                if (UserInput.ToLower() == "get")
                {
                    List<Book> books = _bookService.GetAll();
                }
                
                if (UserInput.ToLower() == "exit")
                {
                    Console.WriteLine("Exit");
                    break;
                }

                else
                {
                    continue;
                }

            }
        }

            
        
        
    }   
}
