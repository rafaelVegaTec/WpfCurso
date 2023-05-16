using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListingDriverInfo
{
    internal class CreatingNewDirectory
    {
        static void Main(string[] args)
        {
            var directory = Directory.CreateDirectory(@"C:\temp\AprendeProgramarConCsharp\Directory"); //Nos permite crear directamente el directorio carpeta
            var directoryInfo = new DirectoryInfo(@"C:\temp\AprendeProgramarConCsharp\Directory");//necesita del metodo Create para crear un directorio carpeta
            directoryInfo.Create();            
            Console.WriteLine("Termine");
            Console.ReadKey();
        }
    }
}
