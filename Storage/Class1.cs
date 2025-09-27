using Domain.Entities;
using System.Collections.Generic;
using System.Xml.Linq;


namespace Storage
{
    public class BookMemory : IBookMethods
    {
        public List<Book> MemoryList = new List<Book>();

        public void AddBook(Book book)
        {
            MemoryList.Add(book);
        }

        public Book GetBookByName(string name)
        {
            return MemoryList.FirstOrDefault(b => b.Name == name);
        }

        public List<Book> GetAllBooks(string)
        {
            return MemoryList;
        }
    }
}
