using Domain.Entities;

namespace Book_Service
{
    public interface IBookService
    {
        void Add(Book book);
        Book GetByName(string name);
        List<Book> GetAll();

    }
}
