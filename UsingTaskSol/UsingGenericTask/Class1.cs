namespace UsingGenericTask
{
    public class Class1
    {
        static void Main(string[] args)
        {
            Task<int> t = Task.Run(() =>
            {
                return 22;
            });
            Console.WriteLine(t.Result);
            Console.ReadKey();
        }
    }
}