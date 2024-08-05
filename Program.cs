using System;

class Program
{
    static void Main()
    {
        bool continuar = true;

        while (continuar)
        {
            Console.WriteLine("Menú Interactivo:");
            Console.WriteLine("1. Suma");
            Console.WriteLine("2. Resta");
            Console.WriteLine("3. Multiplicación");
            Console.WriteLine("4. División");
            Console.WriteLine("5. Salir");
            Console.Write("Elige una opción: ");
            string opcion = Console.ReadLine();

            switch (opcion)
            {
                case "1":
                    RealizarOperacion("suma");
                    break;
                case "2":
                    RealizarOperacion("resta");
                    break;
                case "3":
                    RealizarOperacion("multiplicación");
                    break;
                case "4":
                    RealizarOperacion("división");
                    break;
                case "5":
                    continuar = false;
                    Console.WriteLine("Saliendo del programa...");
                    break;
                default:
                    Console.WriteLine("Opción no válida. Por favor, elige una opción del 1 al 5.");
                    break;
            }

            Console.WriteLine(); // Agrega una línea en blanco para la siguiente iteración
        }
    }

    static void RealizarOperacion(string operacion)
    {
        Console.Write("Introduce el primer número: ");
        if (!double.TryParse(Console.ReadLine(), out double numero1))
        {
            Console.WriteLine("Entrada no válida.");
            return;
        }

        Console.Write("Introduce el segundo número: ");
        if (!double.TryParse(Console.ReadLine(), out double numero2))
        {
            Console.WriteLine("Entrada no válida.");
            return;
        }

        double resultado = 0;

        switch (operacion)
        {
            case "suma":
                resultado = numero1 + numero2;
                break;
            case "resta":
                resultado = numero1 - numero2;
                break;
            case "multiplicación":
                resultado = numero1 * numero2;
                break;
            case "división":
                if (numero2 != 0)
                {
                    resultado = numero1 / numero2;
                }
                else
                {
                    Console.WriteLine("Error: División por cero no es permitida.");
                    return;
                }
                break;
        }

        Console.WriteLine($"El resultado de la {operacion} es: {resultado}");
    }
}
