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

}
