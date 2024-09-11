//Johan German 2023-1391


namespace Forma_Johan_German
{
    public class Rectangle : Shape
    {
        
    public Rectangle(double width, double height) : base(width, height) { }

    public override double CalculateSurface()
    {
        return Width * Height;
    }
    }
}
