using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingTask
{
    internal class CatchingAggregateExeption
    {
        //static void Main(string[] args)
        //{
        //    var numbers = Enumerable.Range(0, 20);
        //    try
        //    {
        //        var parallelResult = numbers.AsParallel().Where(i => IsEvent(i));
        //        parallelResult.ForAll(e => Console.WriteLine(e));
        //    }
        //    catch (AggregateException e)
        //    {
        //        Console.WriteLine($"Hay {e.InnerExceptions.Count} exepciones.");
        //    }
        //    finally
        //    {
        //        Console.ReadKey();
        //    }
        //}

        //public static bool IsEvent(int i)
        //{
        //    if (i % 10 == 0)
        //    {
        //        throw new ArgumentException($"{i}");
        //    }

        //    return i % 2 == 0;
        //}
    }
}
