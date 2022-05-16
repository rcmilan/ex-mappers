namespace Domain.DTOs
{
    public class PersonDto
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public Guid AddressId { get; set; }
        public string Street { get; set; }
        public string District { get; set; }
        public string Number { get; set; }
    }
}
