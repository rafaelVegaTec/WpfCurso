namespace UsingDelegatesEasy
{
    internal class Program
    {
        //DELEGADOS CON LAMBDA
        public static void Main(string[] args)
        {
            List<int> list = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                list.Add(i);
            }

            List<int> result = list.FindAll(i => i % 2 == 0);

            foreach (int i in result)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }

        //MANEJO DE DELEGADOS EN FUNCIONES LIST
        //public static void Main(string[] args)
        //{
        //    List<int> list = new List<int>();

        //    for (int i = 1; i <= 100; i++)
        //    {
        //        list.Add(i);
        //    }

        //    List<int> result = list.FindAll(
        //        delegate (int no)
        //        {
        //            return (no % 2 == 0);
        //        }
        //    );

        //    foreach (int i in result)
        //    {
        //        Console.WriteLine(i);
        //    }
        //    Console.ReadKey();
        //}

        //FUNC
        //static string ReverseString(string s)
        //{
        //    return new string(s.Reverse().ToArray());
        //}

        //static void Main(string[] args)
        //{
        //    Func<string, string> rev = ReverseString;
        //    Console.WriteLine(rev("Una Cadena Cualquiera."));
        //    Console.ReadKey();
        //}

        //DELEGADOS
        //public delegate string Reverse(string s);

        //static string ReverseString(string s)
        //{
        //    return new string(s.Reverse().ToArray());
        //}

        //static void Main(string[] args)
        //{
        //    Reverse rev = ReverseString;
        //    Console.WriteLine(rev("Una cadena cualquiera."));
        //    Console.ReadKey();
        //}
    }
}