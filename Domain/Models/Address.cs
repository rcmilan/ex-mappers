namespace Domain.Models
{
    public class Address : BaseModel<Guid>
    {
        public string Street { get; set; }
        public string District { get; set; }
        public string Number { get; set; }
    }
}