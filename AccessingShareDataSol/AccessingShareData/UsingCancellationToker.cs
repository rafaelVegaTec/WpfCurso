using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessingShareData
{
    internal class UsingCancellationToker
    {
        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            CancellationToken token = cts.Token;
            Task task = Task.Run(() =>
            {
                while (!token.IsCancellationRequested)
                {
                    Console.WriteLine("*");
                    Thread.Sleep(1000);
                }
            }, token);

            Console.WriteLine("Presiona ENTER para cancelar la tarea.");
            Console.ReadLine();
            cts.Cancel();
            Console.WriteLine("Presiona ENTER para terminar la aplicacion");
            Console.ReadKey();
        }
    }
}
