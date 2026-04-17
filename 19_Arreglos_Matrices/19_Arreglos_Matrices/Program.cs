using System;

namespace _19_Arreglos_Matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Declaracion e inicializacion de matrices.
            int[,] numeros = new int[2, 3]; //Rango = numero de filas por el numero de columnas, las filas van primero y las columnas segundas.
            numeros[0, 0] = 13;
            numeros[0, 1] = 65;
            numeros[0, 2] = 0;
            numeros[1, 0] = 45;
            numeros[1, 1] = 100;
            numeros[1, 2] = 29;
            
            
            string[,] nombres =
            {
                {"Ferney", "Juan" },
                { "Maria", "Esteban"},
                { "Alvaro", "Carlos"},
            };
            //Recorrer matriz para llenarla 
            char[,] simbolos = new char[2, 5];

            for (int f = 0; f < 2; f++) //Recorre las filas
            {
                for (int c = 0; c < 5; c++) //Recorre las columnas
                {
                    Console.WriteLine($"Ingrese el valor para la matriz [{f},{c}]");
                    simbolos[f,c]= char.Parse(Console.ReadLine());
                }
            }
            
            
            Console.Clear();
            //Recorrer matriz para recuperar datos 
            for (int f = 0; f < simbolos.GetLength(0); f++) //GetLenght(0) devuelve el numero de las filas.
                //Filas
            {
                for (int c = 0; c < simbolos.GetLength(1); c++) //GetLenght(1) devuelve el numero de columnas 
                {
                    Console.Write($"{simbolos[f,c]} | ");
                }
                Console.WriteLine();
            }*/ 

            /*Escribe un programa que realice la suma de 2 matrices 2X3, con los siguientes requisitos:
             *Solicita al usuario que ingrese los elementos de la primera matriz de 2 filas y 3 columnas.
             *Solicita al usuario que ingrese los elementos de la segunda matriz de las mismas dimensiones (2X3).
             *Calcula la matriz suma, resultado de sumar cada elemento correspondiente de las 2 matrices.
             *Muestra la matriz resultante de la suma en formta de matriz (2 filas, 3 columnas).*/ 

            int [,] numeros = new int[2, 3];

            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"ingrese los datos para ingresar a la variable:"[i]);
                i = Convert.ToInt32(Console.ReadLine());



                for (int j = 0; j < 3; j++)
                {
                    Console.WriteLine($"Ingrese los datos para ingresar a la variable:"[j]);
                    j = Convert.ToInt32(Console.ReadLine());
                }

                
            }
            
            /*Desarrolla un algoritmo que realice las siguientes tareas: 
             *Capturar los nombres de 4 empleados ingresados por el teclado.
             *Para cada empleado, capturar los sueldos recibidos durante los ultimos 3 meses.
             *Calcular y mostrar el total de sueldos que ha recibido vada empleado en ese periodo.
             *Identificar y mostrar el nombre del empleado con el mayor sueldo acumulado, junto con el monto total que recibio.*/

        }
    }
}
