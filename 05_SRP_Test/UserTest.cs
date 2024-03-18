using _05_SRP_Test;

namespace _05_SRP_Test
{
    [TestClass]
    public class UserTest
    {
        [TestMethod]
        public void AddUser_WritesToCorrectFile()
        {
            // Arrange
            var user = new User
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                SubscriptionType = SubscriptionTypes.Premium,
                SubscriptionExpirationDate = DateTime.Now.AddDays(30)
            };

            // Act
            user.AddUser();

            // Assert
            string[] lines = File.ReadAllLines("test.txt");
            string expectedLine = $"John-Doe-john.doe@example.com-Premium-{user.SubscriptionExpirationDate}";

            CollectionAssert.Contains(lines, expectedLine);
        }

        [TestMethod]
        public void HasUnlimitedContentAccess_PremiumSubscriptionNotExpired_ReturnsTrue()
        {
            // Arrange
            var user = new User
            {
                SubscriptionType = SubscriptionTypes.Premium,
                SubscriptionExpirationDate = DateTime.Now.AddDays(5)
            };

            // Act
            bool result = user.HasUnlimitedContentAccess();

            // Assert
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void HasUnlimitedContentAccess_PremiumSubscriptionExpired_ReturnsFalse()
        {
            // Arrange
            var user = new User
            {
                SubscriptionType = SubscriptionTypes.Premium,
                SubscriptionExpirationDate = DateTime.Now.AddDays(-5)
            };

            // Act
            bool result = user.HasUnlimitedContentAccess();

            // Assert
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void FirstName_SetAndGetCorrectly()
        {
            // Arrange
            var user = new User();

            // Act
            user.FirstName = "John";

            // Assert
            Assert.AreEqual("John", user.FirstName);
        }

        [TestMethod]
        public void LastName_SetAndGetCorrectly()
        {
            // Arrange
            var user = new User();

            // Act
            user.LastName = "Doe";

            // Assert
            Assert.AreEqual("Doe", user.LastName);
        }

        [TestMethod]
        public void Email_SetAndGetCorrectly()
        {
            // Arrange
            var user = new User();

            // Act
            user.Email = "john.doe@example.com";

            // Assert
            Assert.AreEqual("john.doe@example.com", user.Email);
        }
    }
}