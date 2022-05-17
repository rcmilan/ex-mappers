namespace automapper.tests
{
    internal class PersonTests
    {
        private readonly IMapper _mapper;

        public PersonTests()
        {
            var config = new MapperConfiguration(cfg => cfg.AddProfile<PersonProfile>());
            _mapper = config.CreateMapper();
        }

        [Test]
        public void ShouldMapToExistingPerson()
        {
            // Arrange
            var source = new Person
            {
                Address = new Address
                {
                    Id = Guid.NewGuid(),
                    Street = "Rua 123",
                    District = "Bairro 123",
                    Number = "123A"
                }
            };

            var result = new Person
            {
                Id = 1000,
                Name = "Pessoa ABC",
                Phone = "Phone-123",
            };

            // Act
            _mapper.Map(source, result);

            // Assert
            Assert.That(result.Id, Is.EqualTo(1000));
            Assert.That(result.Address.Id, Is.EqualTo(source.Address.Id));
        }
    }
}
