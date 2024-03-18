// Принцип відкритості/закритості
// Класи мають бути відкриті до розширення, але закриті для змін.
// Якщо є клас, функціонал якого передбачає чимало розгалужень або
// багато послідовних кроків, і є великий потенціал,
// що їх кількість буде збільшуватись, то потрібно спроєктувати клас таким чином,
// щоб нові розгалуження або кроки не призводили до його модифікації.

Square square = new Square() { Side = 10 };
Circle circle = new Circle() { Radius = 10 };
Rectangle rectangle = new Rectangle() { Height = 5, Width = 10};

Object[] objects = new Object[] { square, circle, rectangle };

AreaCalculator areaCalculator = new AreaCalculator();
double res = areaCalculator.CalculateTotalArea(objects);

Console.WriteLine(res);

class Square
{
    public int Side { get; set; }
}

class Circle
{
    public int Radius { get; set; }
}

public class Rectangle
{
    public int Width { get; set; }
    public int Height { get; set; }
}

public class AreaCalculator
{
    public double CalculateTotalArea(Object[] rectangles)
    {
        double results = 0;

        foreach (var figure in rectangles)
        {
            if (figure is Square)
            {
                Square square = (Square)figure;
                results += Math.Pow(square.Side,2);
            }
            else if (figure is Circle)
            {
                Circle circle = (Circle)figure;
                results += Math.Pow(circle.Radius, 2) * Math.PI;

            }
            else if (figure is Rectangle)
            {
                Rectangle rectangle = (Rectangle)figure;
                results += rectangle.Height * rectangle.Width;
            }
        }

        return results;
    }
}
