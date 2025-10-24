namespace Domain.Entities
{
 
        public class Book
        {
            public int Id;
            public string Genre { get; set; }
            public string Name { get; set; }
            public string Author { get; set; }
            public string Publication { get; set; }
            public string State { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nAuthor: {Author}\nGenre: {Genre}\nPublication: {Publication}\n";
        }


        }

        public class Author
        {
            public string Name { get; set; }
            public List<Book> Books { get; set; }
        //public DateTime Birthday { get; set; }
        //public string Nationality { get; set; }
        public override string ToString()
        {
            return $"Authors Name : {Name}\nAuthors Books : {Books}";
        }
        }
}
