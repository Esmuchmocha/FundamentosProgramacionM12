using System;

namespace VariablesConstantesTiposde_datosOperadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //operadores
            //Operadores numericos
            //cambio de signo
            int num1 = 5;
            int num2 = -num1;
            int num3 = -num2;
            Console.Write(num1 + "//" + num2 + "//" + num3);
            //Aritmeticos
            int num4 = 3 + 5;
            int num5 = 12 - 63;
            int num6 = 26 * 14;
            float num7 = 5f / 3f; //5f / 3; //(float) 5 / 3;
            Console.Write("\nSuma: {0}, Resta: {1}, multiplicacion. {2}, division: {3}", num4, num5, num6, num7);
            //incremento y decremento
            num4++;//num=num4+1;
            num5--;//num5=num5-1;
            num6 += 4;//num6=num6+4;
            num4 -= 10;//num4=num4-10;
            num5 *= 3;// num5=num5*3
            num6 /= 2;// num&=num&/2;
            num6 *= num4;//num6=num6*num4;
            //orden de evaluacion de operadores numericos aritmeticos
            int num8 = 4 * 3 / 2;
            int num9 = 4 * (3 / 2);
            int num10 = 4 + 6 * (2 - 1);
            //operadores logicos
            //conjuncion - Y - AND - &&
            Console.WriteLine("\ntabla de verdad conjuncion");
            Console.WriteLine("V Y V: " + (true && true));
            Console.WriteLine("V Y F: " + (true && false));
            Console.WriteLine("F Y V: " + (false && true));
            Console.WriteLine("F Y F: " + (false && false));
            //disyuncion - O - OR - ||
            Console.WriteLine("\ntabla de verdad disyuncion");
            Console.WriteLine("V O V: " + (true || true));
            Console.WriteLine("V O F: " + (true || false));
            Console.WriteLine("F O V: " + (false || true));
            Console.WriteLine("F O F: " + (false || false));

        }
    }
}
