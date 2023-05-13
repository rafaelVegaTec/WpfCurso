﻿namespace RecordTypeExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Pet myDog = new Pet("Firulais", 3);
            Pet yourDog = myDog with { Age = 7 };
            Console.WriteLine($"¿Mi perro es tu perro? {myDog == yourDog}");
            Console.WriteLine(myDog);
            Console.ReadKey();
        }

        public record struct Pet //Record nos permite acceder a los valores establecidos para una instancia
        {
            public string Name { get; set; }
            public int Age { get; set; }

            public Pet(string name, int age)
            {
                Name = name;
                Age = age;
            }
        }
    }
}