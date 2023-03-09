internal class Rectangle : Shape
{
    private double Length { get; set; }
    private double Width { get; set; }
    public Rectangle(string color, double length, double width) : base(color, "Rectangle")
    {
        Length = length;
        Width = width;
    }
    public override double GetArea()
    {
        return Length * Width;
    }
}