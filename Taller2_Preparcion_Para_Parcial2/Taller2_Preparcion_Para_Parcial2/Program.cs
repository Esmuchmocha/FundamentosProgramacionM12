using System;

namespace Taller2_Preparcion_Para_Parcial2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Cree un algoritmo que permita calcular el promedio de unas calificaciones, el algoritmo 
             *le permitira el usuario introducir tantas calificaciones como asi desee, en el 
             *momento que desee no seguir ingresando calificaciones, y al final el algoritmo debe 
             *mostrar el promedio de todas las calificaciones ingresadas anteriormente*/

            double suma = 0;
            int contador = 0;
            string respuesta = "si";

            while (respuesta.ToLower() == "si")

            {
                Console.WriteLine("Ingrese una calificacion");
                double calificacion = Convert.ToDouble(Console.ReadLine());

                suma += calificacion;
                contador++;

                Console.WriteLine("¿desea ingresar otra calificacion?, (si/no)");
                respuesta = Console.ReadLine();
            } 

            if (contador > 0)
            {
                double promedio = suma / contador;
                Console.WriteLine($"El promedio es: {promedio}");
            }
            else
            {
                Console.WriteLine("No se ingresaron calificaciones.");
            }
        }
    }
}
