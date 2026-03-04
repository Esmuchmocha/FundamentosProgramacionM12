using System;
using System.Diagnostics.Tracing;

namespace _8.TallerDeCondicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*1.Crear un algoritmo que permita leer 3 valores distintos y almacenarlos en las variables
             numero 1, numero 2 y numero 3 respectivamente. El algoritmo debe comprobar si son diferentes,
            si lo son, imprimir cual es el numero mayor, y mostrar en la pantalla los numeros de mayor a 
            menor. Si hay numeros iguales, el algoritmo debe mostrar un mensaje indicando que deben poner 
            numeros diferentes.*/

            float num1 = 0;
            float num2 = 0;
            float num3 = 0;
            float mayor = 0;
            float medio = 0;
            float menor = 0;

            Console.WriteLine("Ingrese numero 1");
            num1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2");
            num2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 3");
            num3 = Single.Parse(Console.ReadLine());



            if (num1!=num2 && num1!=num3 & num2!=num3)
            {
                if (num1>num2)
                {
                    if (num1>num3)
                    {
                        mayor = num1;
                        if (num2>num3)
                        {
                            medio = num2;
                            menor = num3;
                        }
                        else
                        {
                            medio = num3;
                            menor = num2;
                        }
                    }

                }

                if (num2 > num1)
                {
                    if (num2 > num3)
                    {
                        mayor = num2;
                        if (num1 > num3)
                        {
                            medio = num1;
                            menor = num3;
                        }
                        else
                        {
                            medio = num3;
                            menor = num1;
                        }
                    }

                }

                if (num3 > num2)
                {
                    if (num3 > num1)
                    {
                        mayor = num3;
                        if (num2 > num1)
                        {
                            medio = num2;
                            menor = num1;
                        }
                        else
                        {
                            medio = num1;
                            menor = num2;
                        }
                    }

                }

                Console.WriteLine($"El numero mayor es {mayor}, el del medio es {medio} y el menor es {menor}");
            }
            else
            {
                Console.WriteLine("Por favor ingresar numeros diferentes en cada casilla");
            }
        }
    }
}