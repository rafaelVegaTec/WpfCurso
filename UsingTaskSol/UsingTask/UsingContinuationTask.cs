using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingTask
{
    internal class UsingContinuationTask
    {
        //static void Main(string[] args)
        //{
        //    Task<int> t = Task.Run(() =>
        //    {
        //        return 22;
        //    });

        //    t.ContinueWith((i) =>
        //    {
        //        Console.WriteLine("CANCELADO");
        //    }, TaskContinuationOptions.OnlyOnCanceled);

        //    t.ContinueWith((i) =>
        //    {
        //        Console.WriteLine("FALLADO");
        //    }, TaskContinuationOptions.OnlyOnFaulted);

        //    var completedTask = t.ContinueWith((i) =>
        //    {
        //        Console.WriteLine("COMPLETADO");
        //    }, TaskContinuationOptions.OnlyOnRanToCompletion);

        //    completedTask.Wait();

        //    //Continuacion de Task
        //    //Task<int> t = Task.Run(() =>
        //    //{
        //    //    return 11;
        //    //}).ContinueWith((i) =>
        //    //{
        //    //    return i.Result * 2;
        //    //});

        //    //Console.WriteLine(t.Result);
        //    Console.ReadKey();
        //}
    }
}
