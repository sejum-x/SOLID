// Принцип відкритості/закритості

Square square = new Square() { Side = 10 };
Circle circle = new Circle() { Radius = 10 };
Rectangle rectangle = new Rectangle() { Height = 5, Width = 10 };

IShape[] objects = new IShape[] { square, circle, rectangle };

AreaCalculator areaCalculator = new AreaCalculator();
double res = areaCalculator.CalculateTotalArea(objects);

Console.WriteLine(res);

public interface IShape
{
    double CalculateArea();
}

class Square: IShape
{
    public int Side { get; set; }

    public double CalculateArea()
    {
        return Math.Pow(Side, 2);
    }
}

class Circle: IShape
{
    public int Radius { get; set; }

    public double CalculateArea()
    {
        return Math.Pow(Radius, 2) * Math.PI;
    }
}

public class Rectangle: IShape
{
    public int Width { get; set; }
    public int Height { get; set; }

    public double CalculateArea()
    {
        return Width * Height;
    }
}

public class AreaCalculator
{
    public double CalculateTotalArea(IShape[] rectangles)
    {
        double results = 0;

        foreach (var figure in rectangles)
        {
            results += figure.CalculateArea();
        }

        return results;
    }
}