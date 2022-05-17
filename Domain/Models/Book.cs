namespace Domain.Models
{
    public class Book : BaseModel<int>
    {
        public Book(string title, int year)
        {
            Title = title;
            Year = year;
        }
        public string Title { get; set; }
        public int Year { get; set; }
    }
}
