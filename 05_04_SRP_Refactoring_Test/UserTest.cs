namespace _05_04_SRP_Refactoring_Test
{
    [TestClass]
    public class UserTest
    {
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