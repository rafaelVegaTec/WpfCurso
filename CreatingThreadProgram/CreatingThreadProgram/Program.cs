namespace CreatingThreadProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Hilos
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.IsBackground = true;
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Hilo principal: Trabajando...");
                Thread.Sleep(0);
            }
            Console.ReadKey();
        }

        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Proceso de hilo: {i}");
                Thread.Sleep(1000);
            }
        }
    }
}