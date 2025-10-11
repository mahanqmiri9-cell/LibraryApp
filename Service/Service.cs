using System;
using Book_Service;
using Book_Repository;
using Domain.Entities;


namespace Service.Entities
{
    public class BookService : IBookService
    {
        private readonly IBookRepository _repo;     //??
        public BookService(IBookRepository repository)   //??
        {
            _repo = repository;    //??
        }
        public void Add(Book book)
        {
            _repo.Add(book);   //?
        }
        public Book GetByName(string name)
        {
            return _repo.GetByName(name);
        }
        public List<Book> GetAll()
        {
            return _repo.GetAll();
        }
    }
}
