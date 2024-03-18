// Принцип заміщення Лісков.

SeniorDev senior = new SeniorDev();
JuniorDev junior = new JuniorDev();

ICode[] codes = new ICode[] { senior, junior };
DevStartWriteCode(codes);

IMeet[] meets = new IMeet[] { senior };
DevStartMeet(meets);

static void DevStartWriteCode(ICode[] developers)
{
    foreach (ICode dev in developers)
    {
        dev.WriteCode();
    }
}

static void DevStartMeet(IMeet[] developers)
{
    foreach (IMeet dev in developers)
    {
        dev.MeetWithClient();
    }
}

interface ICode
{
    void WriteCode();
}

interface IMeet
{
    void MeetWithClient();
}

public class SeniorDev : ICode, IMeet
{
    public void WriteCode()
    {
        Console.WriteLine("SeniorDev write code");
    }

    public void MeetWithClient()
    {
        Console.WriteLine("SeniorDev meet with client");
    }
}

public class JuniorDev : ICode
{
    public void WriteCode()
    {
        Console.WriteLine("JuniorDev write code");
    }
}