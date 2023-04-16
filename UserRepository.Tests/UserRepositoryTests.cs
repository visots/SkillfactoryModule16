
using Moq;
using NUnit.Framework;

namespace UserRepository.Tests
{
    [TestFixture]
    public class UserRepositoryTests
    {
        [Test]
        public void FindAllMustReturnSmth()
        {
            List<User> users = new List<User>()
            {
                new User(){Name = "Антон"},
                new User(){Name = "Иван"},
                new User(){Name = "Алексей"}
            };

            var mockUserRepository = new Mock <IUserRepository>();
            mockUserRepository.Setup(r=>r.FindAll()).Returns(users);

            Assert.That(mockUserRepository.Object.FindAll().Any(u => u.Name == "Антон"));
            Assert.That(mockUserRepository.Object.FindAll().Any(u => u.Name == "Иван"));
            Assert.That(mockUserRepository.Object.FindAll().Any(u => u.Name == "Алексей"));

        }
    }
}