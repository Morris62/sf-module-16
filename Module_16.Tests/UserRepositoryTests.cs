using Module_16.Users;
using Moq;

namespace Module_16.Tests;

[TestFixture]
public class UserRepositoryTests
{
    [Test]
    public void FindAllMustReturnNotNullValue()
    {
        var list = new List<User>
        {
            new("Антон"),
            new("Иван"),
            new("Алексей")
        };

        var mockUserRepository = new Mock<IUserRepository>();
        mockUserRepository.Setup(p => p.FindAll()).Returns(list);

        Assert.That(mockUserRepository.Object.FindAll().Any(user => user.Name == "Антон"));
        Assert.That(mockUserRepository.Object.FindAll().Any(user => user.Name == "Иван"));
        Assert.That(mockUserRepository.Object.FindAll().Any(user => user.Name == "Алексей"));
    }
}