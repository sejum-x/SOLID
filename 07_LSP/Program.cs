// Принцип заміщення Лісков.
// Якщо об’єкт базового класу замінити об’єктом його похідного класу,
// то програма має продовжувати працювати коректно.

SeniorDev senior = new SeniorDev();
JuniorDev junior = new JuniorDev();

Developer[] developers = new Developer[] { senior, junior };
DevStartWork(developers);

static void DevStartWork(Developer[] developers)
{
    foreach (Developer dev in developers)
    {
        dev.WriteCode();
        dev.MeetWithClient();
    }
}

public abstract class Developer
{
    public virtual void WriteCode()
    {
        Console.WriteLine("WriteCode");
    }

    public virtual void MeetWithClient()
    {
        Console.WriteLine("MeetWithClient");
    }
}

public class SeniorDev: Developer
{
    public override void WriteCode()
    {
        Console.WriteLine("SeniorDev write code");
    }

    public override void MeetWithClient()
    {
        Console.WriteLine("SeniorDev meet with client");
    }
}

public class JuniorDev: Developer
{
    public override void WriteCode()
    {
        Console.WriteLine("JuniorDev write code");
    }

    public override void MeetWithClient()
    {
        throw new NotImplementedException("Junior does not hold meetings with the customer!");
    }
}
