﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace UsingTask
{
    internal class UsingChildTask
    {
        //static void Main(string[] args)
        //{
        //    //Creando Task Hijos con Factory
        //    Task<int[]> parent = Task.Run(() =>
        //    {
        //        var results = new int[3];
        //        TaskFactory tf = new TaskFactory(TaskCreationOptions.AttachedToParent, TaskContinuationOptions.ExecuteSynchronously);
        //        tf.StartNew(() => results[0] = 0);
        //        tf.StartNew(() => results[1] = 1);
        //        tf.StartNew(() => results[2] = 2);

        //        return results;
        //    });

        //    //Creando Task Hijos
        //    //Task<int[]> parent = Task.Run(() =>
        //    //{
        //    //    int[] results = new int[3];

        //    //    new Task(() => results[0] = 0, TaskCreationOptions.AttachedToParent).Start();
        //    //    new Task(() => results[1] = 1, TaskCreationOptions.AttachedToParent).Start();
        //    //    new Task(() => results[2] = 2, TaskCreationOptions.AttachedToParent).Start();

        //    //    return results;
        //    //});

        //    Task finalTash = parent.ContinueWith(parentTask =>
        //    {
        //        foreach (int i in parentTask.Result)
        //        {
        //            Console.WriteLine(i);
        //        }
        //    });

        //    finalTash.Wait();
        //    Console.ReadKey();
        //}
    }
}
