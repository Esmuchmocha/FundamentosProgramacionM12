using System;
using System.Diagnostics.CodeAnalysis;
using System.Threading;
using System.Xml;
namespace _21.Modular1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*21. Algoritmo que muestre un menú con operaciones (+,-,*,/) y permita realizar la operación que el usuario ingrese por teclado. 
             *Si es suma o multiplicación, permitirle al usuario realizar estas operaciones con la cantidad de números que el desee ingresar.
             *Si es división o resta solo dejar realizar la operación con dos números.*/

            Mostrar_Menu(); 
            int opcion= Capturar_opcion();
        }

        static void Mostrar_Menu()
        {
            Console.WriteLine("-----------------MENU------------------");
            Console.WriteLine("1.Suma,             2.resta");
            Console.WriteLine("3.Multiplicacion,   4.Division");
            Console.WriteLine("---------------------------------------");
        }

        static int Capturar_opcion()
        {
            Console.WriteLine("Ingrese una opcion del menu:");
            return int.Parse(Console.ReadLine());
        }

        static void Realizar_Operacion(int opcion)
        {
            switch (opcion)
            {
                case 1:
                    Suma();
                    break;
                case 2:
                    Resta();
                    break;
                case 3:
                    Multiplicacion();
                    break;
                case 4:
                    Division();
                    break;
                    
                default:
                    Console.WriteLine("Ingrese una opcion valida del menu, por favor");
                    break;
            }      
        }
        static void Suma()
        {
            Console.WriteLine("Usted va a sumar");
        }

        static void Resta()
        {
            Console.WriteLine("Usted va a restar");
        }

        static void Multiplicacion()
        {
            Console.WriteLine("Usted va a multiplicar");
        }

        static void Division()
        {
            Console.WriteLine("Usted va a dividir");
        }

    }
}
