namespace Labb_3_Polymorphism
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            Square square = new Square();
            Circle circle = new Circle();

            Geometri[] geometris = {rectangle,square,circle};

            foreach (Geometri geometri in geometris)
            {
                Console.WriteLine($"The area of the {geometri.GetType().Name} is: {geometri.Area()}");
            }

            Console.ReadKey();
        }
    }


    public class Geometri
    {
        public virtual double Area()
        {
            return 0.0;
        }
    }

    public class Rectangle : Geometri
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle()
        {
            Width = 4;
            Height = 6;
        }

        public override double Area()
        {
            return Width * Height;
        }
    }


    public class Square : Geometri
    {
        public double Side { get; set; }

        public Square()
        {
            Side = 4;
        }

        public override double Area()
        {
            return Side * Side;
        }
    }

    public class Circle : Geometri
    {
        public double Radius { get; set; }

        public Circle()
        {
            Radius = 4;
        }

        public override double Area()
        {
            return Math.PI * Radius * Radius;
        }
    }
}