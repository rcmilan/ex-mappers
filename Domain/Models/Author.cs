namespace Domain.Models
{
    public class Author : BaseModel<int>
    {
        public Author(string name, IEnumerable<Book> books)
        {
            Name = name;
            Books = books;
        }

        public string Name { get; set; }
        public IEnumerable<Book> Books { get; set; }
    }
}
