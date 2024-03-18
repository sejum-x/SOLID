// Принцип відкритості/закритості
public enum EmployeeType
{
    FOP,
    CompanyEmployee
}

public class Employee
{
    public int Salary { get; set; }
    public EmployeeType EmployeeType { get; set; }
}

public class EmployeeTax
{
    public double CalculateTax(Employee em)
    {
        if (em.EmployeeType == EmployeeType.FOP)
        {
            return em.Salary * 0.5;
        }
        else if (em.EmployeeType == EmployeeType.CompanyEmployee)
        {
            return em.Salary * 0.2;
        }
        else 
        {
            throw new NotImplementedException();
        }
    }
}