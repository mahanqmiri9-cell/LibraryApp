namespace Domain.Entities
{
 
        public class Book
        {
            public int Id;
            public string Name { get; set; }
            public string Author { get; set; }
            public string Genre { get; set; }
            public string Publication { get; set; }
            public string State { get; set; }


        }

        public interface IBookMethods
        {
             public void AddBook(Book book);
            public Book GetBookByName(string name);
            public List<Book> GetAllBooks(string name);
            
        }

}
