using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingTask
{
    //internal class UsingParallelBreak
    //{
    //    static void Main(string[] args)
    //    {
    //        ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
    //        {
    //            if (i == 500)
    //            {
    //                Console.WriteLine("Interrupiendo el bucle...");
    //                loopState.Break();
    //            }
    //            return;
    //        });

    //        Console.WriteLine($"LowetsBreakIteration: {result.LowestBreakIteration}");
    //        Console.WriteLine($"IsCompleted: {result.IsCompleted}");
    //        Console.ReadKey();
    //    }
    //}
}
