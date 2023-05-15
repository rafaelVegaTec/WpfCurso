using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreatingThreadProgram
{
    //internal class UsingThreadLocal
    //{
    //    public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
    //    {
    //        return Thread.CurrentThread.ManagedThreadId;
    //    });

    //    public static void Main()
    //    {
    //        new Thread(() =>
    //        {
    //            for (int i = 0; i < _field.Value; i++)
    //            {
    //                Console.WriteLine($"Hilo A: {i}");
    //            }
    //        }).Start();

    //        new Thread(() =>
    //        {
    //            for (int i = 0; i < _field.Value; i++)
    //            {
    //                Console.WriteLine($"Hilo B: {i}");
    //            }
    //        }).Start();

    //        Console.ReadKey();
    //    }
    //}
}
