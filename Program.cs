namespace PassingValue
{
    public struct Rectangle
    {
        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Width { get; set; }
        public double Height { get; set; }
    }

    public class MethodParameters
    {
        
        public static void ChangeHeight() 
        { 
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
        
                rectangle.Height = 500;
                var rect = new Rectangle(200, 300);

                Console.WriteLine($"rect height: {rect.Height}");


                Console.WriteLine($"rectangle height in Method: {rectangle.Height}");
            }
    }
}