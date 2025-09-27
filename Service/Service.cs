using System;
using Domain.Entities;


namespace Service.Entities
{
    public class ServiceManegment : IBookMethods
    {
        List<Book> ServiceBook = new List<Book>();
        void IBookMethods.AddBook(Book book)
        {
            ServiceBook.Add(book); 
        }
        Book IBookMethods.GetBookByName(string name)
        {
            return ServiceBook.FirstOrDefault(b => b.Name == name); 
        }
        List<Book> IBookMethods.GetAllBooks(string name)
        {
            return ServiceBook;
        }
    }
}
