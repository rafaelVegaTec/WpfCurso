namespace CircleAreaCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            const double PI = 3.1416;
            string userData;
            double radius;
            double circleArea;

            Console.WriteLine("Proporcion el radio de tu circulo por favor:");
            userData = Console.ReadLine();

            if (double.TryParse(userData, out radius))
            {
                circleArea = PI * Math.Pow(radius, 2);
                Console.WriteLine($"el area de tu circulo es: {circleArea}");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("Los datos proporcionados son incorrectos.");
                Console.ReadKey();
                Console.WriteLine("Los datos proporcionados son incorrectos.");
            }

        }
    }
}