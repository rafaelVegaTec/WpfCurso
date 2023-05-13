namespace ConsoleIOExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            if(args.Length < 2)
            {
                Console.WriteLine("Favor de ejecutar el programa dela siguiente manera: ConsoleIOExemple entrada.tct saida.text");
                return;
            }

            try
            {
                //Intentamos abrir el archivo de salida para escribir
                using(var writer = new StreamWriter(args[1])) //Using al definirse de esta manera una instancia al salir del su flujo el espacio en memorio ocupado es eliminado
                {                   
                    using(var reader = new StreamReader(args[0]))
                    {
                        //Redireccionamos salida estandar a archivo
                        Console.SetOut(writer);
                        //Redireccionamso entrada estandar a archivo
                        Console.SetIn(reader);
                        string line;
                        while ((line = Console.ReadLine()) != null)
                        {
                            string newLine = line.Replace(" ", "\t");
                            Console.WriteLine(newLine);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                TextWriter erroWriter = Console.Error;
                erroWriter.WriteLine(ex.Message);
                return;
            }

            //Restauramos la salida a pantalla
            var standardOutPut = new StreamWriter(Console.OpenStandardOutput());
            standardOutPut.AutoFlush = true;
            Console.SetOut(standardOutPut);
            Console.WriteLine($"Se han sustituido espacios por tabuladores exitosamente en {args[0]}.");
            return;
        }
    }
}