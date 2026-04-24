using System;

namespace _20.programacion_Modular
{
    internal class Program
    {

        static int año_actual = 2026;

        static void Main(string[] args)
        {
            //Programacion Modular
            string nombre = "ferney";
            string apellidos = "Chica Alvarez";
            Console.WriteLine($"Edad: {Edad_segun_año_de_nacimiento()}");

            Saludo(nombre, apellidos);
            Saludo("Carlos", "Perez Lopez");
            Saludo("Ferney", "Chica Alvarez");
            Console.WriteLine($"Edad: {Edad_segun_año_de_nacimiento(2001)}");
            Console.ReadKey();
            BorrarPantalla();
        }

        static void BorrarPantalla()
        {
            Console.Clear();
        }

        //Procedimientos con parametros 

        static void Saludo(string nombre, string apellidos)
        {
            Console.WriteLine($"Bienvenido {nombre} {apellidos} a la programacion modular");
        }

        //Funciones sin parametros 
        static int Edad_segun_año_de_nacimiento()
        {
            int Año_de_nacimiento = 1999;
            int edad = año_actual - Año_de_nacimiento;
            return edad;
        }

        //Funciones con parametros 

        static int Edad_segun_año_de_nacimiento(int Año_de_nacimiento)
        {
            return año_actual - Año_de_nacimiento;
        }

    }

}
