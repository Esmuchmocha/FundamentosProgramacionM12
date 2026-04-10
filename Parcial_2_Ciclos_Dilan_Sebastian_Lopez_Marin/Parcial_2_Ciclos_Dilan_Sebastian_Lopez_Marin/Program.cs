using System;

namespace Parcial_2_Ciclos_Dilan_Sebastian_Lopez_Marin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cantidad_de_estudiantes = 18;
            int contador_de_aprobados = 0;
            int contador_de_reprobados = 0;
            int promedio_de_notas = 0;
            int nota_mas_alta = 0;
            int nota_mas_baja = 0;

            int contador = 1;


            for (contador = 1; contador <= cantidad_de_estudiantes; contador++)
            {
                int opcion = 0;

                Console.WriteLine("ingrese una nota por favor");
               opcion = Convert.ToInt32(Console.ReadLine());
                if (opcion < 0 && opcion > 10)
                {
                    Console.WriteLine("ingrese un numero valido por favor");
                    contador--;
                    continue;
                }

                if (opcion > nota_mas_alta)
                {
                    nota_mas_alta = opcion;
                }

                if (opcion < nota_mas_baja)
                {
                    nota_mas_baja = opcion;
                }


                    if (opcion < 5.9)
                {
                    contador_de_reprobados++;
                    promedio_de_notas += opcion;
                }

                if (opcion >= 6.0 && opcion <= 10)
                {
                    contador_de_aprobados++;
                    promedio_de_notas += opcion;
                }


                promedio_de_notas = promedio_de_notas + contador; 
            }

            Console.WriteLine($"El promedio de todas las notas es: {promedio_de_notas / cantidad_de_estudiantes}");
            Console.WriteLine($"La cantidad de aprobados es: {contador_de_aprobados}");
            Console.WriteLine($"La nota mas alta es: {nota_mas_alta}");
            Console.WriteLine($"La nota mas baja es: {nota_mas_baja}");
        }
    }
}
