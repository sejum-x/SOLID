// Принцип відкритості/закритості

public class Employee
{
    public int Salary { get; set; }
}

interface IEmployeeTax
{
    double CalculateTax(Employee em);
}

public class EmployeeTaxFOP : IEmployeeTax
{
    public double CalculateTax(Employee em)
    {
        return em.Salary * 0.5;
    }
}

class EmployeeTaxCompanyEmployee : IEmployeeTax
{
    public double CalculateTax(Employee em)
    {
        return em.Salary * 0.2;
    }
}