using System;

namespace _9.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*int contador = 1;
            int acumulador = 0;

            while (contador <= 5)
            {
                acumulador += contador;
                Console.WriteLine($"Contador:{contador} - acumulador: {acumulador}");
                contador++;
            }
            Console.WriteLine($"La suma de los cinco primeros numeros enteros es: {acumulador}");*/

            /*Crear un algoritmo que permita calcular la factorial de un numero dado por el usuario.
             (5!= 1 * 2 * 3 * 4 * 5)*/

            int contador = 1;
            int acumulador = 0;
            int numero = 0;

            Console.WriteLine("Ingrese por favor un numero");
            Console.ReadLine();

            while (contador <= numero)
            {
                acumulador += contador;
                Console.WriteLine($"Contador: {contador} - Acumulador: {acumulador}");
                contador++;
            }
                
        }
    }
}
