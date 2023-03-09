internal class Square : Shape
{
    private double Side { get; set; }
    public Square(string color, double side) : base(color, "Square")
    {
        Side = side;
    }
    public override double GetArea()
    {
        return Side * Side;
    }
}