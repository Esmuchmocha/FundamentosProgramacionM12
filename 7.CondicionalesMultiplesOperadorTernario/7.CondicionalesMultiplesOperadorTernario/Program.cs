using System;

namespace _7.CondicionalesMultiplesOperadorTernario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*7.Tiendas La Avenida desea desarrollar un programa que permita ingresar por teclado el monto de compra y el día de la semana, para saber: 
            Si el día es martes o jueves, se realizará un descuento del 15% por la compra.  
            Si el día es lunes o miércoles, se realizará un descuento del 10% por la compra. 
            Si el día es viernes o sábado, se realizará un descuento del 20% por la compra. 
            Si es domingo no se realiza descuento. 
            Visualizar el día, el descuento y el total a pagar por la compra.*/

            /*string diasemana = "";
            float subtotal = 0;
            float descuento = 0;

            Console.WriteLine("Ingrese monto de la compra");
            subtotal = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese dia de la semana");
            diasemana = Console.ReadLine().ToLower();

            switch (diasemana)
            {
                case "Lunes":
                    descuento = subtotal * 0.1f;
                    Console.WriteLine($"Hoy es lunes, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    
                    break;

                case "Martes":
                    descuento = subtotal * 0.15f;
                    Console.WriteLine($"Hoy es martes, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                case "Miercoles":
                    descuento = subtotal * 0.1f;
                    Console.WriteLine($"Hoy es miercoles, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                case "Jueves":
                    descuento = subtotal * 0.15f;
                    Console.WriteLine($"Hoy es Jueves, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                case "Viernes":
                    descuento = subtotal * 0.2f;
                    Console.WriteLine($"Hoy es Viernes, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                case "sabado":
                    descuento = subtotal * 0.2f;
                    Console.WriteLine($"Hoy es sabado, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                case "domingo":
                    descuento = 0;
                    Console.WriteLine($"Hoy es domingo, el descuento es de {descuento}, el valor total a pagar es de {subtotal - descuento}");
                    break;

                default:
                    Console.WriteLine("Por favor ingrese un dia de la semana correcto");
                    break;

            }*/
            /*Diseñar un algoritmo que permita crear una calculadora basica capaz de realizar 
             operaciones aritmeticas entre 2 numeros ingresados por el usuario. Las operaciones disponibles seran: suma, resta, multiplicacion 
            y division, las cuales se ejecutaran segun la opcion seleccionada por el usuario.*/

            float numero1 = 0;
            float numero2 = 0;
            string operacion = "";
            float resultado = 0;

            Console.WriteLine("Ingrese numero 1");
            numero1 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese numero 2");
            numero2 = Single.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese operacion");
            operacion = Console.ReadLine();

            switch (operacion)
            {
                case "suma":
                    resultado = numero1 + numero2;
                    Console.WriteLine($"El resultado es {numero1 + numero2}");

                    break;

                case "resta":
                    resultado = numero1 - numero2;
                    Console.WriteLine($"El resultado es {numero1 - numero2}");

                    break;

                case "multiplicacion":
                    resultado = numero1 * numero2;
                    Console.WriteLine($"El resultado es {numero1 * numero2}");

                    break;

                case "division":
                    resultado = numero1 / numero2;
                    Console.WriteLine($"El resultado es {numero1 / numero2}");

                    break;

                default:
                    Console.WriteLine("Por favor ingrese una operacion correcta");
                    break;






            }


        }
    }
}
