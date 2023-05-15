using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UsingDelegates
{
    //internal class ExposeAnEvent
    //{
    //    static void Main(string[] args)
    //    {
    //        Pub p = new Pub();
    //        p.Onchange += () => Console.WriteLine("Event raised t method 1");
    //        p.Onchange += () => Console.WriteLine("Event raised t method 2");
    //        p.Raise();
    //        Console.ReadKey();

    //    }
    //}

    //public class Pub
    //{
    //    //Mejora de ejecucion de ventos
    //    public event Action Onchange = delegate { };
    //    public void Raise()
    //    {
    //        Onchange();
    //    }

    //    //Forma comun de poder utilizar la ejecucion de eventos
    //    //public Action Onchange { get; set; }
    //    //public void Raise()
    //    //{
    //    //    if (Onchange != null)
    //    //    {
    //    //        Onchange();
    //    //    }
    //    //}
    //}
}
