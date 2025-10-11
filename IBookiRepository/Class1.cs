using Domain.Entities
    ;
namespace Book_Repository
{
    public interface IBookRepository
    {
        void Add(Book book);
        Book GetByName(string name);
        List<Book> GetAll();

    }


}
