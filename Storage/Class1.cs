using Domain.Entities;
using Book_Repository;
using System.Collections.Generic;
using System.Xml.Linq;


namespace Persistance
{
    public class BookRepository : IBookRepository
    {
        public List<Book> MemoryList = new List<Book>();

        public void Add(Book book)
        {
            MemoryList.Add(book);
            Console.WriteLine(book);
        }

        public Book GetByName(string name)
        {
            Book  book1 = new Book();

            foreach (var book in MemoryList)
            {
                if (book.Name == name)
                {
                    book1 = book;
                    break;
                }
                else
                {
                    book1 = null;
                }

            }
            return book1;
        }

        public List<Book> GetAll()
        {
            return MemoryList;
        }
    }
}
