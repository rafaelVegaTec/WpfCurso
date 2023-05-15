using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegates
{
    internal class ExeptionRaisingEvent
    {
        static void Main(string[] args)
        {
            Pub p = new Pub();
            p.Onchange += (sender, e) => Console.WriteLine("Suscriber 1 called");
            p.Onchange += (sender, e) => { throw new Exception(); };
            p.Onchange += (sender, e) => Console.WriteLine("Suscriber 3 called");
            p.Raise();
            Console.ReadKey();
        }
    }

    public class Pub
    {
        public event EventHandler Onchange = delegate { };

        public void Raise()
        {
            Onchange(this, EventArgs.Empty);
        }
    }
}
