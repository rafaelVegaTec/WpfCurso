using System.Collections;
using System.Dynamic;

namespace StackAndQueues
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            //Pilas
            string word;
            int counter;
            Stack greetingStack; //Stack es una coleccion que usa el metodo primero que ingresa ultimo que sale

            //Usando Push y Pop
            Console.ForegroundColor = ConsoleColor.Green;
            greetingStack = new Stack();
            greetingStack.Push("Hola");
            greetingStack.Push("buenos");
            greetingStack.Push("días");

            counter = greetingStack.Count;
            Console.WriteLine($"Hay {counter} elementos en la pila.");
            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingStack.Pop();
                Console.WriteLine($"Pop: {word}");
            }
            Console.WriteLine($"Hay {counter} elementos en la pila.");
            Console.ReadKey();

            //Usando Peek
            Console.ForegroundColor = ConsoleColor.Yellow;
            greetingStack = new Stack();
            greetingStack.Push("Hola");
            greetingStack.Push("buenos");
            greetingStack.Push("días");

            counter = greetingStack.Count;
            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingStack.Peek();
                Console.WriteLine($"Siguiente palabra en la pila: {word}");

                word = (string)greetingStack.Pop();
                Console.WriteLine($"Pop: {word}");
            }
            Console.ReadKey();

            //Usando Contains y Clear
            Console.ForegroundColor = ConsoleColor.White;
            greetingStack = new Stack();
            greetingStack.Push("Hola");
            greetingStack.Push("buenos");
            greetingStack.Push("días");

            if (greetingStack.Contains("días"))
            {
                greetingStack.Clear();
            }
            Console.WriteLine($"La pila greetingStack contiene {greetingStack.Count} elementos despues de ejecutar");
            Console.ReadKey();

            //Colas
            Console.ForegroundColor= ConsoleColor.Cyan;
            Queue greetingsQueue = new Queue();
            greetingsQueue.Enqueue("Hola");
            greetingsQueue.Enqueue("buenos");
            greetingsQueue.Enqueue("días");

            counter = greetingsQueue.Count;
            Console.WriteLine($"Hay {greetingsQueue.Count} elementos en la cola.");
            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingsQueue.Peek();
                Console.WriteLine($"El siguiente elemento en la cola es {word}");

                word = (string)greetingsQueue.Dequeue();
                Console.WriteLine($"Dequeue {word}");
            }
            Console.WriteLine($"Hay {greetingsQueue.Count} elementos en la cola");
            Console.ReadKey();

            //Usando Contains y Clear
            Console.ForegroundColor = ConsoleColor.Gray;
            greetingStack = new Stack();
            greetingStack.Push("Hola");
            greetingStack.Push("buenos");
            greetingStack.Push("días");

            if (greetingsQueue.Contains("días"))
            {
                greetingsQueue.Clear();
            }
            Console.WriteLine($"La pila greetingQueue contiene {greetingsQueue.Count} elementos despues de ejecutar");
            Console.ReadKey();
        }
    }
}