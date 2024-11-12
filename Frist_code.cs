using System;

namespace Ejemplos
{
    class Program
    {
        static void Main(string[] args)
        {

            // Llamada al método para sumar dos números
            SumarNumeros();
        }

        // Método para imprimir "Hola Mundo"
        static void HolaMundo()
        {
            Console.WriteLine("Hola, Mundo!");
        }

        // Método para pedir dos números y mostrar su suma
        static void SumarNumeros()
        {
            // Solicita el primer número
            Console.WriteLine("Ingresa el primer número:");
            string input1 = Console.ReadLine();
            int numero1 = Convert.ToInt32(input1); // Convierte la entrada a entero

            // Solicita el segundo número
            Console.WriteLine("Ingresa el segundo número:");
            string input2 = Console.ReadLine();
            int numero2 = Convert.ToInt32(input2); // Convierte la entrada a entero

            // Suma los números
            int resultado = numero1 + numero2;

            // Muestra el resultado
            Console.WriteLine("La suma es: " + resultado);
        }
    }
}