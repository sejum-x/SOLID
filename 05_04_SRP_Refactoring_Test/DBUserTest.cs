using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_04_SRP_Refactoring_Test
{
    [TestClass]
    public class DBUserTest
    {
        public readonly User user;

        public DBUserTest()
        {
            user = new User
            {
                FirstName = "John",
                LastName = "Doe",
                Email = "john.doe@example.com",
                SubscriptionType = SubscriptionTypes.Premium,
                SubscriptionExpirationDate = DateTime.Now.AddDays(30)
            };
        }

        [TestMethod]
        public void AddUser_WritesToCorrectFile()
        {
            // Act
            DBUser.AddUser(user);

            // Assert
            string[] lines = File.ReadAllLines("test.txt");
            string expectedLine = $"John-Doe-john.doe@example.com-Premium-{user.SubscriptionExpirationDate}";

            CollectionAssert.Contains(lines, expectedLine);
        }
    }
}
