using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegates
{
    //internal class CustomEventAccessor
    //{
    //    static void Main(string[] args)
    //    {
    //        Pub p = new Pub();
    //        p.OnChange += (sender, e) => Console.WriteLine($"Event raised: {e.Value}");
    //        p.Raise();
    //        Console.ReadKey();
    //    }
    //}

    //public class Pub
    //{
    //    private event EventHandler<MyArgs> Onchange = delegate { };
    //    public event EventHandler<MyArgs> OnChange
    //    {
    //        add
    //        {
    //            lock (Onchange)
    //            {
    //                Onchange += value;
    //            }
    //        }
    //        remove
    //        {
    //            lock (Onchange)
    //            {
    //                Onchange -= value;
    //            }
    //        }
    //    }

    //    public void Raise()
    //    {
    //        Onchange(this, new MyArgs(42));
    //    }
    //}

    public class MyArgs : EventArgs
    {
        public MyArgs(int value)
        {
            Value = value;
        }
        public int Value { get; set; }
    }


}
