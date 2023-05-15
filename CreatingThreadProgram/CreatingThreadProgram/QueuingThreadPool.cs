using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingThreadProgram
{
    internal class QueuingThreadPool
    {
        public static void Main()
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Trabajando un hilo desde ThreadPool");
            });
            
            Console.ReadKey();
        }
    }
}
