using System;
using Domain.Entities;


namespace Service.Entities
{
    public class ServiceManegment : IBookMethods
    {
        private IBookMethods repo;     //??
        public ServiceManegment(IBookMethods repository)   //??
        {
            repo = repository;    //??
        }
        void IBookMethods.AddBook(Book book)
        {
            repo.AddBook(book);   //?
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
