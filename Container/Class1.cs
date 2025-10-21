using Service.Entities;
using Persistance;
using Book_Service;


namespace ContainerApp
{
    public class Container
    {
        public BookService CreatBookService()
        {
            var bookRepository = new BookRepository();
            var bookService = new BookService(bookRepository);

                return bookService;
        }
    }
}
