using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegates
{
    //internal class CustomEventArguments
    //{
    //    static void Main(string[] args)
    //    {
    //        Pub p = new Pub();
    //        p.Onchange += (sender, e) => Console.WriteLine($"Event raised: {e.Value}");
    //        p.Raise();
    //        Console.ReadKey();
    //    }
    //}

    //public class MyArgs : EventArgs
    //{
    //    public MyArgs(int value)
    //    {
    //        Value = value;
    //    }
    //    public int Value { get; set; }
    //}

    //public class Pub
    //{
    //    public event EventHandler<MyArgs> Onchange = delegate { };
    //    public void Raise()
    //    {
    //        Onchange(this, new MyArgs(42));
    //    }
    //}
}
