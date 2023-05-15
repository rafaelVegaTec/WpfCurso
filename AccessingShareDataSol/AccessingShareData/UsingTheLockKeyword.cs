using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccessingShareData
{
    internal class UsingTheLockKeyword
    {
        //static void Main(string[] args)
        //{
        //    //Nos permie sincronizar una tarea mediante un bloqueo
        //    int n = 0;
        //    object _lock = new object();
        //    var up = Task.Run(() =>
        //    {
        //        for (int i = 0; i < 1000000; i++)
        //        {
        //            lock (_lock)
        //                n++;
        //        }
        //    });

        //    for (int i = 0; i < 1000000; i++)
        //    {
        //        lock (_lock)
        //            n--;
        //    }
        //    up.Wait();
        //    Console.WriteLine(n);
        //    Console.ReadKey();
        //}
    }
}
