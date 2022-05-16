namespace Domain.Models
{
    public class Person : BaseModel<long>
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
    }
}
