namespace OtherCollections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //HashSet no acepta objetos repetidos
            Console.ForegroundColor = ConsoleColor.Red;
            HashSet<string> hashset = new HashSet<string>();
            hashset.Add("a");
            hashset.Add("b");
            hashset.Add("c");
            hashset.Add("a");
            foreach (var item in hashset)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            //SortedSet organiza una lista ascendentemente
            Console.ForegroundColor = ConsoleColor.Green;
            SortedSet<string> sortedset = new SortedSet<string>();
            sortedset.Add("d");
            sortedset.Add("c");
            sortedset.Add("a");
            sortedset.Add("b");
            foreach (var item in sortedset)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            //Dictionary es una lista de llaves/valor
            Console.ForegroundColor = ConsoleColor.Yellow;
            Dictionary<string, double> fruitCost = new Dictionary<string, double>();
            fruitCost.Add("Mango", 60);
            fruitCost.Add("Pera", 30.50);
            fruitCost.Add("Manzana", 2);
            Console.WriteLine($"El mango cuesta {fruitCost["Mango"]}");
            Console.ReadKey();

            foreach (KeyValuePair<string, double> item in fruitCost)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            //SortedList es un Dictionary pero ordenado
            Console.ForegroundColor = ConsoleColor.Blue;
            SortedList<string, double> fruitCostSorted = new SortedList<string, double>();
            fruitCostSorted.Add("Mango", 60);
            fruitCostSorted.Add("Pera", 30.50);
            fruitCostSorted.Add("Manzana", 2);

            foreach (var item in fruitCostSorted)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
        }
    }
}