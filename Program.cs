using Forma_Johan_German;
//Johan German 2023-1391

public class Program
{
    public static void Main()
    {
        Shape[] shapes = new Shape[]
        {
            new Rectangle(5, 10),
            new Triangle(4, 7),
            new Circle(3)
        };

        double[] areas = new double[shapes.Length];

        for (int i = 0; i < shapes.Length; i++)
        {
            areas[i] = shapes[i].CalculateSurface();
            Console.WriteLine($"Área de la forma {i + 1}: {areas[i]:F2}");
        }
    }
}
