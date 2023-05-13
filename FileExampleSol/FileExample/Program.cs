namespace FileExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\rafae\OneDrive\Documentos\Wpf Curso\FileExampleSol\FileExample\MyTest.txt";
            if(!File.Exists(path))
            {
                using(StreamWriter sw = File.CreateText(path))
                {
                    sw.WriteLine("Hello");
                    sw.WriteLine("And");
                    sw.WriteLine("Welcome");
                }
            }

            //Abriendo el archivo a leer de
            using(StreamReader sr = File.OpenText(path))
            {
                string s;
                while((s = sr.ReadLine()) != null)
                {
                    Console.WriteLine(s);
                }
            }

           Console.ReadKey();

            //nos permite agregar todo el texto de una sola vez
            File.WriteAllText(path, " Contenido desde WriteTextAll.");
            string allText = File.ReadAllText(path);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(allText);
            Console.ReadKey();

            //nos permite agregar Texto sobre una archivo que ya previamente tenga valores
            File.AppendAllText(path, " Contenido agregado.");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(allText);
            Console.ReadKey();
        }
    }
}