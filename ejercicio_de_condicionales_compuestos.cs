using System;
using System.Diagnostics.Eventing.Reader;


namespace _3.CondicionalesDoblesCompuestos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Crear un algoritmo que permita ingresar el nombre y el sueldo de una persona, si el sueldo 
              supera los 3000 pesos mostrar el mensaje en pantalla con el nombre de la persona, indicando
              que debe abonar impuestos. De lo contrario mostrar el mensaje "persona excenta de pagar 
              impuestos*/
            /*string nombre = "";
            float sueldo = 0;
            Console.WriteLine("ingrese el nombre del usuario");
            nombre = Console.ReadLine();
            Console.WriteLine("ingrese el valor del sueldo");
            sueldo = Single.Parse(Console.ReadLine());

            if (sueldo >= 3000)
            {
                //si la condicion es verdadera
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else
            {
                //si la condicion es falsa
                Console.WriteLine("La persona esta excenta de pagar impuestos");*/

            //*Crear un algoritmo que permita ingresar 2 numeros, si el primer numero es mayor al segundo numero informar su suma y diferencia,
            //en caso contrario informar el producto y la division del primer umero respecto al segundo.*/

            float num1 = 0;
            float num2 = 0;
            Console.WriteLine("ingrese el primer numero");
            num1 = Single.Parse (Console.ReadLine());
            Console.WriteLine("ingrese num 2");
            num2 = Single.Parse (Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine($"la suma de los numeros es: {num1 + num2}");
            }
            else
            {
                Console.WriteLine($"la division es: {num1 / num2}");
            }
        }
    }
}
