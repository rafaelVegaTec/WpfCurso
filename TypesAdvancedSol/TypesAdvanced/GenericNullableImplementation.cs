using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypesAdvanced
{
    //internal class GenericNullableImplementation
    //{
    //    static void Main(string[] args)
    //    {
    //        Nullable<int> intergetNullable = new Nullable<int>();
    //        Console.WriteLine(intergetNullable.Value);
    //        Console.ReadKey();
    //    }
    //}

    //struct nullable<T> where T : struct
    //{
    //    private bool hasValue;
    //    private T value;
    //    public nullable(T value)
    //    {
    //        this.hasValue = true;
    //        this.value = value;
    //    }
    //    public bool HasValue { get { return this.hasValue; } }
    //    public T Value
    //    {
    //        get
    //        {
    //            if (!this.hasValue) throw new ArgumentException();
    //            return this.value;
    //        }
    //    }
    //    public T GetValueDefault()
    //    {
    //        return this.value;
    //    }
    //}
}
