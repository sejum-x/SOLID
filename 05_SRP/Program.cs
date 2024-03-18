// Single Responsibility Principle (Принцип єдиної відповідальності)
// є одним з принципів SOLID, який рекомендує, щоб клас мав лише
// одну причину для зміни. Це означає, що клас повинен виконувати лише
// одну роботу або мати лише одну область відповідальності.
// Якщо клас відповідає за кілька аспектів, то зміни в одному аспекті
// можуть призвести до внесення змін у іншому, і це може збільшити
// слабкість коду та його важкість у розумінні, розвитку та підтримці.

User user = new User()
{
    FirstName = "Alex",
    LastName = "Shevchenko",
    Email = "test@gmail.com",
    SubscriptionExpirationDate = new DateTime(2024, 12, 30),
    SubscriptionType = SubscriptionTypes.Premium
};

user.AddUser();
Console.WriteLine(user.HasUnlimitedContentAccess());

public class User
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public SubscriptionTypes SubscriptionType { get; set; }
    public DateTime SubscriptionExpirationDate { get; set; }

    public void AddUser()
    {
        const string path = "test.txt";
        
        using (StreamWriter writer = new StreamWriter(path, false))
        {
            writer.WriteLine($"{FirstName}-{LastName}-{Email}-{SubscriptionType}-{SubscriptionExpirationDate}");
        }
    }

    public bool HasUnlimitedContentAccess()
    {
        return SubscriptionType == SubscriptionTypes.Premium 
            && SubscriptionExpirationDate > DateTime.Now;
    }
}

public enum SubscriptionTypes
{
    Basic,
    Standard,
    Premium
}
