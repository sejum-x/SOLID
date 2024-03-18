// Наслідування — це принцип, який дозволяє створювати нові класи
// на основі наявних (батьківських класів), з можливістю
// перевизначення або доповнення їх властивостей та методів. 

// Проблема (дуюлювання коду => можливість тиражування помилок,
// більше часу на тестування коду...)

Developer developer = new Developer() { Name = "Alex", Age = 30 };
developer.DrinkСoffee();
developer.WriteСode();

Manager manager = new Manager() { Name = "Peta", Age = 20 };
manager.DrinkСoffee();
manager.ConductMeeting();

internal class Developer
{
    public string? Name { get; set; }

    public int Age { get; set; }

    public void DrinkСoffee()
    {
        Console.WriteLine("DrinkСoffee");
    }

    public void WriteСode()
    {
        Console.WriteLine("WriteСode");
    }
}

internal class Manager
{
    public string? Name { get; set; }

    public int Age { get; set; }

    public void DrinkСoffee()
    {
        Console.WriteLine("DrinkСoffee");
    }
    
    public void ConductMeeting()
    {
        Console.WriteLine("ConductMeeting");
    }
}