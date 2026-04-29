using System;
namespace Parcial_De_Arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double[,] notas = new double[10, 4]; 
            int contador_notas_para_matematicas = 0;
            int contador_notas_para_fisica = 0;
            int contador_notas_para_ingles = 0;
            int contador_notas_para_sociales = 0;
            int promedio_de_matematicas = 0;
            int promedio_de_fisica = 0;
            int promedio_de_ingles = 0;
            int promedio_de_sociales = 0;
            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    notas = (random.Next(1, 3)); 

                    Console.WriteLine(notas.ToString());

                    Console.ReadLine();

                    /*lo siento profe pero no supe como terminar este ejercicio*/

                }
            }
        }
    }
}
