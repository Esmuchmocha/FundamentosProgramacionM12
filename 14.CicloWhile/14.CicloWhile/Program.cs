using System;
using System.Diagnostics.CodeAnalysis;
namespace _14.CicloWhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*14.Crear un algoritmo que permita calcular y mostrar por pantalla los numeros primos hasta el numero 100*/

            /*int contadorNumeros = 1; 
            int contador = 1;
            int contadorDivisores = 0;

            do
            {
                do 
                { 
                    if (contadorNumeros%contador==0)
                    {
                        contadorDivisores++;
                    }
                    contador++;
                  
                } while (contador<=contadorNumeros);

                contador = 1;

                if (contadorDivisores==2)
                {
                    Console.WriteLine(contadorNumeros);
                }
                contadorDivisores = 0;
                contadorNumeros++;


              contadorNumeros++;
            } while (contadorNumeros <=100);*/

            /*15.Escribe un algoritmo que actue como una calculadora basica. El algoritmo le debe permitir al usuario elegir una operacion, 
             * (suma, resta, multiplicacion, division), y luego ingresar 2 numeros. El ciclo debe continuar permitiendo al usuario realizar 
             * mas calculos hasta que elijar salir.*/

            /*float numero1 = 0;
            float numero2 = 0;
            string operacion = "";

            do
            {
                Console.WriteLine("Ingrese numero 1 por favor");
                numero1= Single.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese numero 2 por favor");
                numero2 = Single.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese S para sumar, R para restar, M para multiplicar, D para dividir, A para salir");
                operacion= Console.ReadLine();
            

                switch (operacion)
                {

                    case "S":
                        Console.WriteLine($"{numero1 + numero2}");

                        break;

                    case "R":
                        Console.WriteLine($"{numero1 - numero2}");
                        break;

                    case "M":
                        Console.WriteLine($"{numero1 * numero2}");
                        break;

                    case "D":
                        Console.WriteLine($"{numero1 / numero2}");
                        break;

                    case "A":
                        operacion = "A";
                        break;
                    
                }
             } while (operacion!= "A");*/

            /*Crear un algoritmo que permita ingresar numeros y:
             * contar cuantos son pares y cuantos impares 
             * calcular el promedio de todos los numeros ingresados 
             * terminar cuando el usuario lo indique*/
            
            /*Crear un algoritmo que: 
             * Permita al usuario ingresar una contraseña
             * Se repita hasta que ingrese la contraseña correcta, (Por ejemplo: 1234)
             * Mostrar cuantos intentos realizo*/


        }
    }
}
