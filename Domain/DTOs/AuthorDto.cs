namespace Domain.DTOs
{
    public class AuthorDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public IEnumerable<BookDto> Books { get; set; }
    }
}
