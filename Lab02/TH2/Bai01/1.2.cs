public class Point
{
    //Fields
    private double x;
    private double y;
    // Properties
    public double X{
        get{ return x;}
        set{ x = value;}
    }

    public double Y{
        get{ return x;}
        set{ x = value;}
    }

    public Point(){
        this.x = 0;
        this.y = 0;
    }

    public Point(double x1, double y1){
        this.x = x1;
        this.y = y1;
    }

    public void Input()
    {
        Console.Write("Nhap x: ");
        x = double.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine($"Da nhap x = {x}");
        Console.Write("Nhap y: ");
        y = double.Parse(Console.ReadLine() ?? string.Empty);
        Console.WriteLine($"Da nhap y = {y}");
    }

    public void Output()
    {
        Console.WriteLine("(" + x + ", " + y + ")");
    }
    // OPERATOR OVERLOADING
    // plus
    public static Point operator + (Point p1, Point p2){
        return new Point(p1.x+p2.x, p1.y+p2.y);
    }
    //minus
    public static Point operator - (Point p1, Point p2){
        return new Point(p1.x-p2.x, p1.y-p2.y);
    }
    //unary minus
    public static Point operator - (Point p2){
        return new Point(-p2.x, -p2.y);
    }

    //Distance Methods
    //static
    public static double dis(Point p1, Point p2){
        return Math.Sqrt(Math.Pow(p2.x-p1.x, 2)+Math.Pow(p2.y-p1.y,2));
    }

    //instance
    public double DistanceTo(Point p1, Point p2){
        return Math.Sqrt(Math.Pow(p2.x-p1.x, 2)+Math.Pow(p2.y-p1.y,2));
    }

    //MIDPOINT METHODs
    //static
    public static Point mid(Point p1, Point p2){
        return new Point((p1.x+p2.x)/2, (p1.y+p2.y)/2);
    }

    //instance
    public Point MidpointTo(Point p1, Point p2){
        return new Point((p1.x+p2.x)/2, (p1.y+p2.y)/2);
    }
}