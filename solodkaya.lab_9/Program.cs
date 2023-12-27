class Point2D
{
    private double x, y;

    public Point2D(double x, double y)
    {
        this.x = x;
        this.y = y;
    }

    public double CalculateRectanglePerimeter()
    {
        double rectangleWidth = Math.Abs(x);
        double rectangleHeight = Math.Abs(y);
        double perimeter = 2 * (rectangleWidth + rectangleHeight);
        return perimeter;
    }
}

class Program
{
    static void Main()
    {
        Point2D point = new Point2D(-3, 4);
        double rectanglePerimeter = point.CalculateRectanglePerimeter();

        Console.WriteLine("Периметр прямоугольника: " + rectanglePerimeter);
    }
}


