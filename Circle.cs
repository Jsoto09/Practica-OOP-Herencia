//Johan German 2023-1391

namespace Forma_Johan_German
{
    public class Circle : Shape
    {
        public Circle(double radius) : base(radius, radius) { }

        public override double CalculateSurface()
        {
            return Math.PI * Math.Pow(Width, 2);
        }
    }
}
