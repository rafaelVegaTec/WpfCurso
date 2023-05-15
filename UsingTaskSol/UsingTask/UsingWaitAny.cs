using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingTask
{
    //internal class UsingWaitAny
    //{
    //    static void Main(string[] args)
    //    {
    //        Task<int>[] taks = new Task<int>[3];
    //        taks[0] = Task.Run(() => { Thread.Sleep(2000); return 1; });
    //        taks[1] = Task.Run(() => { Thread.Sleep(1000); return 2; });
    //        taks[2] = Task.Run(() => { Thread.Sleep(3000); return 3; });
    //        while(taks.Length > 0)
    //        {
    //            int i = Task.WaitAny(taks);
    //            Task<int> completedTask = taks[i];
    //            Console.WriteLine(completedTask.Result);
    //            var temp = taks.ToList();
    //            temp.RemoveAt(i);
    //            taks = temp.ToArray();
    //        }
    //        Console.ReadKey();
    //    }
    //}
}
