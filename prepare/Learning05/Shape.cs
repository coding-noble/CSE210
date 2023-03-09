public abstract class Shape
{
    protected string Color { get; set; }
    protected string ShapeType { get; set; }
    public Shape(string color, string shapeType)
    {
        Color = color;
        ShapeType = shapeType;
    }
    public string GetColor()
    {
        return Color;
    }
    public string WriteShapeType()
    {
        return ShapeType;
    }
    public abstract double GetArea();
}