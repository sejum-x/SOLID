//  В мові програмування C# використовуються терміни "upcasting"
//  та "downcasting" для опису двох операцій, пов'язаних з
//  успадкуванням в об'єктно-орієнтованому програмуванні.

// Upcasting відбувається, коли об'єкт приводиться до більш загального
// типу в ієрархії успадкування.
// Downcasting відбувається, коли об'єкт приводиться до більш
// конкретного типу в ієрархії успадкування.

Developer developer = new Developer() { Name = "Alex", Age = 30 };
developer.DrinkСoffee();
developer.WriteСode();

Manager manager = new Manager() { Name = "Peta", Age = 20 };
manager.DrinkСoffee();
manager.ConductMeeting();

// Upcat
EmployeeStartWork(developer);
EmployeeStartWork(manager);

static void EmployeeStartWork(Employee employee)
{
    Console.WriteLine($"{employee.Name} - start Work");

    //DownCast
    if (employee is Manager)
    {
        Manager? manager = employee as Manager;
        manager?.ConductMeeting();
    }
    else if (employee is Developer)
    {
        Developer? developer = employee as Developer;
        developer?.WriteСode();
    }
}

class Employee
{
    public string? Name { get; set; }

    public int Age { get; set; }

    public void DrinkСoffee()
    {
        Console.WriteLine("DrinkСoffee");
    }
}

class Developer : Employee
{
    public void WriteСode()
    {
        Console.WriteLine("WriteСode");
    }
}

class Manager : Employee
{
    public void ConductMeeting()
    {
        Console.WriteLine("ConductMeeting");
    }
}