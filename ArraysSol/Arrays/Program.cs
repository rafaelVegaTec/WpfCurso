namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaracion de arregls 1
            Console.ForegroundColor = ConsoleColor.Red;
            int[] array1 = new int[3];
            array1[0] = 100;
            array1[1] = 200;
            Console.WriteLine($"array1[0] = {array1[0]} y array[1] = {array1[1]}");
            Console.ReadKey();

            //Declaracion de arreglos 2
            Console.ForegroundColor = ConsoleColor.Green;
            int[] array2 = { 1, 3, 5, 7 };
            string[] array3 = { "Lin", "Mar", "Mie", "Jue", "Vie" };
            Console.WriteLine($"array2[2] = {array2[2]}, array2[3] = {array2[3]}, array3[1] = {array3[1]}");
            Console.ReadKey();

            //Declaracion de arreglos 3
            Console.ForegroundColor = ConsoleColor.Yellow;
            double[] array4;
            array4 = new double[] { 1.1, 2.2, 3.3, 4.4 };
            Console.WriteLine($"array4[1] = {array4[1]} y array4[3] = {array4[3]}");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Blue;
            foreach (int i in array1)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Magenta;
            int[][] arrayOfArrays = new int[2][];
            arrayOfArrays[0] = new int[] { 1 };
            arrayOfArrays[1] = new int[] { 2, 3, 4 };
            foreach (var item in arrayOfArrays)
            {
                foreach (var subitem in item)
                {
                    Console.WriteLine(subitem);
                }
            }
            Console.ReadKey();

            ///Numero de elementos
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine($"array1 tiene {array1.Length} elementos");
            Console.WriteLine($"array1 tiene {array2.Length} elementos");
            Console.WriteLine($"array1 tiene {array3.Length} elementos");
            Console.WriteLine($"array1 tiene {array4.Length} elementos");
            Console.WriteLine($"array1 tiene {arrayOfArrays.Length} elementos");
            Console.ReadKey();

            //Numero de dimensiones
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine($"array1 tiene {array1.Rank} Dimensiones");
            Console.WriteLine($"array1 tiene {array2.Rank} Dimensiones");
            Console.WriteLine($"array1 tiene {array3.Rank} Dimensiones");
            Console.WriteLine($"array1 tiene {array4.Rank} Dimensiones");
            Console.WriteLine($"array1 tiene {arrayOfArrays.Rank} Dimensiones");
            Console.ReadKey();

            //Arreglos de 2 dimensiones
            Console.ForegroundColor = ConsoleColor.Gray;
            int[,] studentScores = new int[2, 2];
            studentScores[0, 0] = 10;
            studentScores[0, 1] = 9;
            studentScores[1, 0] = 8;
            studentScores[1, 1] = 10;
            
            Console.WriteLine($"El estudiante 1 del grupo 1 tiene una nota de {studentScores[0, 1]}");
            Console.WriteLine($"El estudiante 1 del grupo 2 tiene una nota de {studentScores[1, 0]}");
            Console.WriteLine($"array1 tiene {studentScores.Rank} Dimensiones");
            Console.ReadKey();
        }
    }
}