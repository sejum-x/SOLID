// Single Responsibility Principle (Принцип єдиної відповідальності)

User user = new User()
{
    FirstName = "Alex",
    LastName = "Shevchenko",
    Email = "test@gmail.com",
    SubscriptionExpirationDate = new DateTime(2024, 12, 30),
    SubscriptionType = SubscriptionTypes.Premium
};

DBUser.AddUser(user);
Console.WriteLine(AccessManager.HasUnlimitedContentAccess(user));

public class User
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string? Email { get; set; }
    public SubscriptionTypes SubscriptionType { get; set; }
    public DateTime SubscriptionExpirationDate { get; set; }
}

public class DBUser
{
    public static void AddUser(User user)
    {
        const string path = "test.txt";

        using (StreamWriter writer = new StreamWriter(path, false))
        {
            writer.WriteLine($"{user.FirstName}-{user.LastName}-{user.Email}-{user.SubscriptionType}-{user.SubscriptionExpirationDate}");
        }
    }
}

public class AccessManager
{
    public static bool HasUnlimitedContentAccess(User user)
    {
        return user.SubscriptionType == SubscriptionTypes.Premium
            && user.SubscriptionExpirationDate > DateTime.Now;
    }

    public static  bool GetBasicContent(User user)
    {
        return user.SubscriptionType == SubscriptionTypes.Premium
            && user.SubscriptionExpirationDate > DateTime.Now;
    }
}

public enum SubscriptionTypes
{
    Basic,
    Standard,
    Premium
}