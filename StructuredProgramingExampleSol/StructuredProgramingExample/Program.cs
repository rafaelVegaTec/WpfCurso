namespace StructuredProgramingExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int operation;
            int firstData;
            int secondData;

            Console.WriteLine("!Bienvenido a tu calculadora¡");
            Console.WriteLine("1. suma");
            Console.WriteLine("2. resta");
            operation = GetIntegerDataFromUser("Proporciona la operacion que desea ejecutar: ");

            switch (operation)
            {
                case 1:
                    firstData = GetIntegerDataFromUser("Proporcion el primer operando, debe ser entero: ");
                    secondData = GetIntegerDataFromUser("Proporciona el segundo operando, debe ser entero: ");
                    Console.WriteLine($"El resultado de {firstData} + {secondData} = {firstData + secondData}");
                    break;
                case 2:
                    firstData = GetIntegerDataFromUser("Proporcion el primer operando, debe ser entero: ");
                    secondData = GetIntegerDataFromUser("Proporciona el segundo operando, debe ser entero: ");
                    Console.WriteLine($"El resultado de {firstData} - {secondData} = {firstData - secondData}");
                    break;
            }

            Console.WriteLine("Presione cualquier tecla para salir...");
            Console.ReadKey();
        }

        private static int GetIntegerDataFromUser(string message)
        {
            string userData;
            int data = 0;
            bool isDataValid = false;
            while (!isDataValid)
            {
                Console.WriteLine(message);
                userData = Console.ReadLine();
                if (!int.TryParse(userData, out data))
                {
                    Console.WriteLine("El dato que proporcoionastes no es valido. Vuelva a intentarlo");
                }
                else
                {
                    isDataValid = true;
                }
            }
            return data;
        }
    }
}