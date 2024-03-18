﻿// Поліморфізм: це механізм, за допомогою якого об'єкти можуть
// мати різні форми (тобто, один і той же метод може виконуватися різними
// способами залежно від типу об'єкту). В С# поліморфізм можна здійснювати
// за допомогою віртуальних методів, абстрактних класів та інтерфейсів.

// Проблема (невірний розрахунок бюджету, через використання техніки
// заміщення, замість використання поліморфізму).

Developer developer = new Developer() { Name = "Alex", PayPerHour = 10};
Manager manager = new Manager() { Name = "Peta", PayPerHour = 5, Bonus = 15 };

Employee[] employees = { developer, manager };

int budget = CalculateBudget(employees);

Console.WriteLine($"Actual budget is {budget}, expected {615}");

static int CalculateBudget(Employee[] employees)
{
    const int hour = 40; 
    int result = 0;

    for (int i = 0; i < employees.Length; i++)
    {
        result += employees[i].CalculateSalary(hour);
    }

    return result;
}

internal class Developer: Employee { }

internal class Manager: Employee
{
    public int Bonus { get; set; }

    public new int CalculateSalary(int hour)
    {
        int result = PayPerHour * hour + Bonus;
        return result;
    }
}

internal class Employee
{
    public string? Name { get; set; }

    public int PayPerHour { get; set; }

    public int CalculateSalary(int hour)
    {
        int result = PayPerHour * hour;
        return result;
    }
}
