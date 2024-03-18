namespace _05_04_SRP_Refactoring_Test
{
    [TestClass]
    public class AccessManagerTest
    {
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
            bool result = AccessManager.HasUnlimitedContentAccess(user);

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
            bool result = AccessManager.HasUnlimitedContentAccess(user);

            // Assert
            Assert.IsFalse(result);
        }
    }
}
