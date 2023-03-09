internal class Circle : Shape
{
    private double Radius { get; set; }
    public Circle(string color, double radius) : base(color, "Circle")
    {
        Radius = radius;
    }
    public override double GetArea()
    {
        return Radius * Radius * Math.PI;
    }
}