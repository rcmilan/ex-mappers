namespace automapper.tests
{
    public class AuthorTests
    {
        [Test]
        public void ShouldMapAuthorMembers()
        {
            // Arrange
            var config = new MapperConfiguration(cfg => cfg.AddProfile<AuthorProfile>());
            var mapper = config.CreateMapper();

            Author source = new Author("Author", null);

            // Act
            var result = mapper.Map<AuthorDto>(source);

            // Assert
            Assert.IsTrue(result is not null);
            Assert.That(result.Name, Is.EqualTo(source.Name));
        }
    }
}