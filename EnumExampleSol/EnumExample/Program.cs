namespace EnumExample
{
    internal class Program
    {
        public enum Days
        {
            Monday,
            Tuesdar,
            Thursday,
            Wednesday,
            Friday,
            Saturday,
            Sunday
        }

        static void Main(string[] args)
        {
            Days day = Days.Friday;

            if (day == Days.Friday)
            {
                Console.WriteLine("today is party day");
            }
            Console.ReadKey();
        }
    }
}