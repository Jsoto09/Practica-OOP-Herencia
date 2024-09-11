//Johan German 2023-1391


namespace Forma_Johan_German
{
    public abstract class Shape
    {
        public double Height { get; set; }
        public double Width { get; set; }

        public Shape(double height, double width) 
        {
            Width = width;
            Height = height;
        }
        public abstract double CalculateSurface();
    }
}
