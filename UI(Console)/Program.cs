using System.Collections.Generic;
using Domain.Entities;
using Service.Entities;

namespace UI_Console_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Wellcome to Library App!\nPlease enter (Add) to Add book, (Search) to Search book by name or (Exit) to exit the app here  ");
                string UserInput = Console.ReadLine();

                if (UserInput.ToLower() == "add")
                {
                    
                    while (true)
                    {
                        Book book = new Book();

                        Console.WriteLine("Please enter your books genre here\n");
                        book.Genre = Console.ReadLine();

                        Console.WriteLine("Please enter your books name here\n");
                        book.Name = Console.ReadLine();

                        Console.WriteLine("Please enter your books author name here\n");
                        book.Author = Console.ReadLine();

                        Console.WriteLine("Please enter your books publication here\n");
                        book.Publication = Console.ReadLine();

                        Console.WriteLine("Do you want to add a new book? if yes enter else enter (Exit) ");
                        string UserInput2 =  Console.ReadLine();
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
                    Console.WriteLine("Search");
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
