using System;
using System.Diagnostics.CodeAnalysis;
namespace _14.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
           int numero = 0;
           int contador_a_favor = 0;
           int contador_en_contra = 0;
           int contador_no_respondio = 0;

            Console.WriteLine("Ingrese el numero de personas que va a votar por favor");
            numero = Convert.ToInt32(Console.ReadLine());

            int contador = 1;
            for (contador = 1; contador <= numero; contador++)
            {
                Console.WriteLine("Ingrese la opcion de votacion por favor, 1.a favor, 2.en contra, 3.no responde");
                int opcion = Convert.ToInt32(Console.ReadLine());

                if (opcion == 1)
                {
                    contador_a_favor++;
                }

                if (opcion == 2)
                {
                    contador_en_contra++;
                }

                if (opcion == 3)
                {
                    contador_no_respondio++;
                }

               
            }
            Console.WriteLine($"El porcentaje de personas a favor es: {contador_a_favor * 100.0 / numero}");
            Console.WriteLine($"El porcentaje de personas en contra es: {contador_en_contra * 100.0 / numero}");
            Console.WriteLine($"El porcentaje de personas que no responde es es: {contador_no_respondio * 100.0 / numero}"); 







        }
    }
}












