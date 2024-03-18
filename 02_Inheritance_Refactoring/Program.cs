// Наслідування 

// Вирішення (створити базовий класс -  Employee, куди винести
// юазовий функціонал для співробітників, після чого доповнити кожний
// класс спеціалізованним кодом)

Developer developer = new Developer() { Name = "Alex", Age = 30 };
developer.DrinkСoffee();
developer.WriteСode();

Manager manager = new Manager() { Name = "Peta", Age = 20 };
manager.DrinkСoffee();
manager.ConductMeeting();

class Employee
{
    public string? Name { get; set; }

    public int Age { get; set; }

    public void DrinkСoffee()
    {
        Console.WriteLine("DrinkСoffee");
    }
}

class Developer: Employee
{
    public void WriteСode()
    {
        Console.WriteLine("WriteСode");
    }
}

class Manager: Employee
{
    public void ConductMeeting()
    {
        Console.WriteLine("ConductMeeting");
    }
}