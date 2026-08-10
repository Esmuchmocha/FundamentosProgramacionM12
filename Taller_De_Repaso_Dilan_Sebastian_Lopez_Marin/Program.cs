using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Xml.Linq;

namespace Taller_De_Repaso_Dilan_Sebastian_Lopez_Marin
{
    internal class Program
    {
        static void Main(string[] args)


        {
            // 1) Condicionales


            // 1.1 Triangulos


            // AQUI ESTA LA SOLUCION 

            /*Dado los 3 lados de un triangulo elabore que determine si esos 3 lados forman o no un triangulo, 
             * (la suma de 2 de sus lados deben ser mayor que el tercero). Si el triangulo es valido, indicar si es isoceles, 
             * rectangulo o equilatero.*/


            // Aqui esta la solucion
            /*Console.Write("Ingrese el valor del lado numero 1 por favor.");
            int lado1 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor del lado numero 2 por favor.");
            int lado2 = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el valor del lado numero 3 por favor.");
            int lado3 = int.Parse(Console.ReadLine());

            if (lado1 + lado2 > lado3 &&
                lado1 + lado3 > lado2 &&
                lado2 + lado3 > lado1)
            {
                Console.WriteLine("Los lados forman un triangulo.");

                if (lado1 == lado2 && lado2 == lado3)
                {
                    Console.WriteLine("Es equilatero.");
                }
                else if (lado1 * lado1 + lado2 * lado2 == lado3 * lado3 ||
                         lado1 * lado1 + lado3 * lado3 == lado2 * lado2 ||
                         lado2 * lado2 + lado3 * lado3 == lado1 * lado1)
                {
                    Console.WriteLine("Es rectangulo.");
                }
                else if (lado1 == lado2 ||
                         lado1 == lado3 ||
                         lado2 == lado3)
                {
                    Console.WriteLine("Es isosceles.");
                }
                else
                {
                    Console.WriteLine("Es escaleno.");
                }
            }
            else
            {
                Console.WriteLine("Los lados no forman un triangulo.");
            }*/


            // 1.2 Indice de masa corporal 

            /*Dado el peso (en kg) y la estatura (en m) de una persona, calcule su Índice de Masa Corporal,
              considerando:
              IMC = peso / estatura2
              Con el resultado, clasifique a la persona así:
              • Bajo peso: IMC menor a 18.5
              • Normal: IMC entre 18.5 y 25
              • Sobrepeso: IMC entre 25 y 30
              • Obesidad: IMC mayor a 30*/


            // AQUI ESTA LA SOLUCION 

            /*Console.Write("Ingrese su peso en kg: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Ingrese su estatura en metros: ");
            double estatura = double.Parse(Console.ReadLine());

            double imc = peso / (estatura * estatura);

            Console.WriteLine("Su IMC es: " + imc);

            if (imc < 18.5)
            {
                Console.WriteLine("Bajo peso");
            }
            else if (imc >= 18.5 && imc < 25)
            {
                Console.WriteLine("Normal");
            }
            else if (imc >= 25 && imc <= 30)
            {
                Console.WriteLine("Sobrepeso");
            }
            else
            {
                Console.WriteLine("Obesidad");
            }*/


            // 2) Ciclos 

            // 2.1 Numeros primos 

            /*Observa alguno de los videos sugeridos, comprende el concepto de número primo, 
            y luego utilizandoel concepto de ciclo, elabore un algoritmo que genere la serie 
            de números primos comprendidos entre 2 y 1000.*/


            // AQI ESTA LA SOLUCION 
            /*for (int numero = 2; numero <= 1000; numero++)
            {
                bool esPrimo = true;

                for (int divisor = 2; divisor < numero; divisor++)
                {
                    if (numero % divisor == 0)
                    {
                        esPrimo = false;
                    }
                }

                if (esPrimo)
                {
                    Console.WriteLine(numero);
                }
            }*/

            // 2.2 Ciclos anidados 

            /*Utilizando ciclos anidados, elabore un algoritmo que genere la siguiente pirámide de números:
            1
            1 2
            1 2 3
            1 2 3 4
            1 2 3 4 5*/


            // AQUI ESTA LA SOLUCION
            /*for (int fila = 1; fila <= 5; fila++)
            {
                for (int numero = 1; numero <= fila; numero++)
                {
                    Console.Write(numero + " ");
                }

                Console.WriteLine();
            }*/

            // 2.3 Conteo por condicion 

            /* Elabore un algoritmo que muestre y cuente todos los números múltiplos de 
            7 comprendidos entre 50 y 300.*/

            // Aqui esta la respuesta 

            /*int contador = 0;

            for (int numero = 50; numero <= 300; numero++)
            {
                if (numero % 7 == 0)
                {
                    Console.WriteLine(numero);
                    contador++;
                }
            }

            Console.WriteLine("Cantidad de multiplos de 7: " + contador);
            */

            // 3) Vectores 

            /*Diseñar e implementar un programa(interfaz por consola) que permita:
             • Permitir que el usuario ingrese datos a un vector.
             • Ordenar un vector por medio del método de "burbuja" en forma ascendente y descendente.
             • Buscar un número en el vector y retornar la posición del mismo.
             • Reemplazar un elemento del vector.
             Como condición se tiene que el vector debe contener siempre números enteros positivos.*/


            // AQUI ESTA LA SOLUCION 
            /*Console.Write("¿Cuántos números desea ingresar?: ");
            int cantidad = int.Parse(Console.ReadLine());

            int[] vector = new int[cantidad];

            // Ingresar números positivos
            for (int i = 0; i < cantidad; i++)
            {
                Console.Write("Ingrese un número positivo: ");
                int numero = int.Parse(Console.ReadLine());

                while (numero <= 0)
                {
                    Console.Write("El número debe ser positivo. Ingrese otro: ");
                    numero = int.Parse(Console.ReadLine());
                }

                vector[i] = numero;
            }

            // Mostrar vector
            Console.WriteLine("\nVector:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }

            Console.WriteLine();

            // Ordenar ascendente
            for (int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = 0; j < vector.Length - 1 - i; j++)
                {
                    if (vector[j] > vector[j + 1])
                    {
                        int temporal = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = temporal;
                    }
                }
            }

            Console.WriteLine("\nVector ascendente:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }

            Console.WriteLine();

            // Ordenar descendente
            for (int i = 0; i < vector.Length - 1; i++)
            {
                for (int j = 0; j < vector.Length - 1 - i; j++)
                {
                    if (vector[j] < vector[j + 1])
                    {
                        int temporal = vector[j];
                        vector[j] = vector[j + 1];
                        vector[j + 1] = temporal;
                    }
                }
            }

            Console.WriteLine("\nVector descendente:");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }

            Console.WriteLine();

            // Buscar número
            Console.Write("\nIngrese el número que desea buscar: ");
            int buscar = int.Parse(Console.ReadLine());

            bool encontrado = false;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == buscar)
                {
                    Console.WriteLine("El número está en la posición: " + i);
                    encontrado = true;
                }
            }

            if (!encontrado)
            {
                Console.WriteLine("El número no se encuentra en el vector.");
            }

            // Reemplazar elemento
            Console.Write("\nIngrese el número que desea reemplazar: ");
            int viejo = int.Parse(Console.ReadLine());

            Console.Write("Ingrese el nuevo número positivo: ");
            int nuevo = int.Parse(Console.ReadLine());

            while (nuevo <= 0)
            {
                Console.Write("El número debe ser positivo. Ingrese otro: ");
                nuevo = int.Parse(Console.ReadLine());
            }

            bool reemplazado = false;

            for (int i = 0; i < vector.Length; i++)
            {
                if (vector[i] == viejo)
                {
                    vector[i] = nuevo;
                    reemplazado = true;
                }
            }

            if (reemplazado)
            {
                Console.WriteLine("Elemento reemplazado correctamente.");
            }
            else
            {
                Console.WriteLine("El número no se encuentra en el vector.");
            }

            // Mostrar vector final
            Console.WriteLine("\nVector final:");

            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write(vector[i] + " ");
            }*/


            // 4) Operaciones con matrices 

            // 4.1 Diagonales y simetria 

            /* Diseñar e implementar un programa (interfaz por consola) que, dada una matriz cuadrada de n x n,
               permita calcular la suma de la diagonal principal y de la diagonal secundaria, y determine 
               si la matriz es simétrica.*/


            // AQUI ESTA LA SOLUCION 
            /*Console.Write("Ingrese el tamaño de la matriz: ");
            int n = int.Parse(Console.ReadLine());

            int[,] matriz = new int[n, n];

            // Llenar la matriz
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("Ingrese un número: ");
                    matriz[i, j] = int.Parse(Console.ReadLine());
                }
            }

            // Sumar diagonal principal
            int sumaPrincipal = 0;

            for (int i = 0; i < n; i++)
            {
                sumaPrincipal = sumaPrincipal + matriz[i, i];
            }

            // Sumar diagonal secundaria
            int sumaSecundaria = 0;

            for (int i = 0; i < n; i++)
            {
                sumaSecundaria = sumaSecundaria + matriz[i, n - 1 - i];
            }

            // Mostrar las sumas
            Console.WriteLine("Suma diagonal principal: " + sumaPrincipal);
            Console.WriteLine("Suma diagonal secundaria: " + sumaSecundaria);

            // Comprobar si es simétrica
            bool simetrica = true;

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matriz[i, j] != matriz[j, i])
                    {
                        simetrica = false;
                    }
                }
            }

            if (simetrica)
            {
                Console.WriteLine("La matriz es simetrica.");
            }
            else
            {
                Console.WriteLine("La matriz no es simetrica.");
            }*/


            // 4.2 Registro de temperaturas 

            /* Se tiene una matriz de m filas y n columnas donde cada elemento de la matriz representa la
            temperatura registrada por cada una de las m estaciones climáticas, para cada uno de los n días de
            medición. Elabore un programa que construya dos vectores así: uno con el promedio de temperatura
            de cada estación en los n días, y el otro con el promedio de temperatura registrado cada día entre las
            m estaciones. La construcción de los vectores la debe efectuar con funciones que usted debe
            elaborar e invocar desde el algoritmo principal. Luego con los vectores construidos, determine la
            estación que mayor temperatura promedio ha registrado y el día en que menos se registró
            temperatura. Haga estas últimas dos operaciones con funciones que usted elabore.*/



            // AQUI ESTA LA SOLUCION 
            /*{
                Console.Write("Ingrese el número de estaciones: ");
                int m = int.Parse(Console.ReadLine());

                Console.Write("Ingrese el número de días: ");
                int n = int.Parse(Console.ReadLine());

                double[,] temperaturas = new double[m, n];

                // Llenar la matriz
                for (int i = 0; i < m; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        Console.Write("Ingrese la temperatura de la estación " + (i + 1) + " en el día " + (j + 1) + ": ");
                        temperaturas[i, j] = double.Parse(Console.ReadLine());
                    }
                }

                // Calcular promedios
                double[] promedioEstaciones = PromedioEstaciones(temperaturas);
                double[] promedioDias = PromedioDias(temperaturas);

                // Buscar estación con mayor promedio
                int estacionMayor = EstacionMayorTemperatura(promedioEstaciones);

                // Buscar día con menor promedio
                int diaMenor = DiaMenorTemperatura(promedioDias);

                // Mostrar promedios de las estaciones
                Console.WriteLine("\nPromedio de cada estación:");

                for (int i = 0; i < promedioEstaciones.Length; i++)
                {
                    Console.WriteLine("Estación " + (i + 1) + ": " + promedioEstaciones[i]);
                }

                // Mostrar promedios de los días
                Console.WriteLine("\nPromedio de cada día:");

                for (int i = 0; i < promedioDias.Length; i++)
                {
                    Console.WriteLine("Día " + (i + 1) + ": " + promedioDias[i]);
                }

                // Mostrar resultados
                Console.WriteLine("\nLa estación con mayor temperatura promedio es la estación " + (estacionMayor + 1));

                Console.WriteLine("El día con menor temperatura promedio es el día " + (diaMenor + 1));


                // FUNCIÓN PARA CALCULAR EL PROMEDIO DE CADA ESTACIÓN
                double[] PromedioEstaciones(double[,] matriz)
                {
                    int estaciones = matriz.GetLength(0);
                    int dias = matriz.GetLength(1);

                    double[] promedios = new double[estaciones];

                    for (int i = 0; i < estaciones; i++)
                    {
                        double suma = 0;

                        for (int j = 0; j < dias; j++)
                        {
                            suma = suma + matriz[i, j];
                        }

                        promedios[i] = suma / dias;
                    }

                    return promedios;
                }


                // FUNCIÓN PARA CALCULAR EL PROMEDIO DE CADA DÍA
                double[] PromedioDias(double[,] matriz)
                {
                    int estaciones = matriz.GetLength(0);
                    int dias = matriz.GetLength(1);

                    double[] promedios = new double[dias];

                    for (int j = 0; j < dias; j++)
                    {
                        double suma = 0;

                        for (int i = 0; i < estaciones; i++)
                        {
                            suma = suma + matriz[i, j];
                        }

                        promedios[j] = suma / estaciones;
                    }

                    return promedios;
                }


                // FUNCIÓN PARA ENCONTRAR LA ESTACIÓN CON MAYOR PROMEDIO
                int EstacionMayorTemperatura(double[] promedios)
                {
                    int posicionMayor = 0;

                    for (int i = 1; i < promedios.Length; i++)
                    {
                        if (promedios[i] > promedios[posicionMayor])
                        {
                            posicionMayor = i;
                        }
                    }

                    return posicionMayor;
                }


                // FUNCIÓN PARA ENCONTRAR EL DÍA CON MENOR PROMEDIO
                int DiaMenorTemperatura(double[] promedios)
                {
                    int posicionMenor = 0;

                    for (int i = 1; i < promedios.Length; i++)
                    {
                        if (promedios[i] < promedios[posicionMenor])
                        {
                            posicionMenor = i;
                        }
                    }

                    return posicionMenor;
                }*/

            // 5) Lista de canciones 

            /* Diseñar e implementar un programa (interfaz por consola) que permita manipular una lista de
            canciones. Específicamente que permita:
            • Adicionar nuevas canciones
            • No permita adicionar canciones repetidas
            • Mostrar la lista de canciones de forma ascendentemente.
            • Mostrar la lista de canciones de forma descendentemente.
            • Eliminar elementos de la lista.
            • Actualizar nombres de las canciones.
            • Escribir la lista de canciones en un archivo de texto plano.
            • Cargar una lista de canciones de un archivo de texto plano.*/


            // AQUI ESTA LA SOLUCION
            /*List<string> canciones = new List<string>();

            int opcion = 0;

            do
            {
                Console.Clear();

                Console.WriteLine("===== LISTA DE CANCIONES =====");
                Console.WriteLine("1. Adicionar canción");
                Console.WriteLine("2. Mostrar canciones ascendentemente");
                Console.WriteLine("3. Mostrar canciones descendentemente");
                Console.WriteLine("4. Eliminar canción");
                Console.WriteLine("5. Actualizar nombre de canción");
                Console.WriteLine("6. Guardar canciones en archivo");
                Console.WriteLine("7. Cargar canciones desde archivo");
                Console.WriteLine("8. Salir");

                Console.Write("\nSeleccione una opción: ");

                if (!int.TryParse(Console.ReadLine(), out opcion))
                {
                    Console.WriteLine("Debe ingresar un número del 1 al 8.");
                    Console.ReadKey();
                    continue;
                }

                Console.Clear();

                switch (opcion)
                {
                    case 1:

                        Console.WriteLine("===== ADICIONAR CANCIÓN =====\n");

                        Console.Write("Ingrese el nombre de la canción: ");
                        string nuevaCancion = Console.ReadLine();

                        if (canciones.Contains(nuevaCancion))
                        {
                            Console.WriteLine("\nLa canción ya existe.");
                        }
                        else
                        {
                            canciones.Add(nuevaCancion);
                            Console.WriteLine("\nCanción agregada correctamente.");
                        }

                        break;


                    case 2:

                        Console.WriteLine("===== CANCIONES ASCENDENTES =====\n");

                        if (canciones.Count == 0)
                        {
                            Console.WriteLine("La lista está vacía.");
                        }
                        else
                        {
                            canciones.Sort();

                            for (int i = 0; i < canciones.Count; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + canciones[i]);
                            }
                        }

                        break;


                    case 3:

                        Console.WriteLine("===== CANCIONES DESCENDENTES =====\n");

                        if (canciones.Count == 0)
                        {
                            Console.WriteLine("La lista está vacía.");
                        }
                        else
                        {
                            canciones.Sort();
                            canciones.Reverse();

                            for (int i = 0; i < canciones.Count; i++)
                            {
                                Console.WriteLine((i + 1) + ". " + canciones[i]);
                            }
                        }

                        break;


                    case 4:

                        Console.WriteLine("===== ELIMINAR CANCIÓN =====\n");

                        if (canciones.Count == 0)
                        {
                            Console.WriteLine("La lista está vacía.");
                        }
                        else
                        {
                            Console.Write("Ingrese el nombre de la canción que desea eliminar: ");
                            string cancionEliminar = Console.ReadLine();

                            if (canciones.Contains(cancionEliminar))
                            {
                                canciones.Remove(cancionEliminar);
                                Console.WriteLine("\nCanción eliminada correctamente.");
                            }
                            else
                            {
                                Console.WriteLine("\nLa canción no existe.");
                            }
                        }

                        break;


                    case 5:

                        Console.WriteLine("===== ACTUALIZAR CANCIÓN =====\n");

                        if (canciones.Count == 0)
                        {
                            Console.WriteLine("La lista está vacía.");
                        }
                        else
                        {
                            Console.Write("Ingrese el nombre de la canción que desea actualizar: ");
                            string cancionAnterior = Console.ReadLine();

                            if (canciones.Contains(cancionAnterior))
                            {
                                Console.Write("Ingrese el nuevo nombre: ");
                                string cancionNueva = Console.ReadLine();

                                if (canciones.Contains(cancionNueva))
                                {
                                    Console.WriteLine("\nYa existe una canción con ese nombre.");
                                }
                                else
                                {
                                    int posicion = canciones.IndexOf(cancionAnterior);

                                    canciones[posicion] = cancionNueva;

                                    Console.WriteLine("\nCanción actualizada correctamente.");
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nLa canción no existe.");
                            }
                        }

                        break;


                    case 6:

                        Console.WriteLine("===== GUARDAR CANCIONES =====\n");

                        Console.Write("Ingrese el nombre del archivo: ");
                        string archivoGuardar = Console.ReadLine();

                        System.IO.File.WriteAllLines(archivoGuardar, canciones);

                        Console.WriteLine("\nLista guardada correctamente.");

                        break;


                    case 7:

                        Console.WriteLine("===== CARGAR CANCIONES =====\n");

                        Console.Write("Ingrese el nombre del archivo: ");
                        string archivoCargar = Console.ReadLine();

                        if (System.IO.File.Exists(archivoCargar))
                        {
                            string[] cancionesArchivo = System.IO.File.ReadAllLines(archivoCargar);

                            canciones.Clear();

                            for (int i = 0; i < cancionesArchivo.Length; i++)
                            {
                                if (!canciones.Contains(cancionesArchivo[i]))
                                {
                                    canciones.Add(cancionesArchivo[i]);
                                }
                            }

                            Console.WriteLine("\nLista cargada correctamente.");
                        }
                        else
                        {
                            Console.WriteLine("\nEl archivo no existe.");
                        }

                        break;


                    case 8:

                        Console.WriteLine("===== SALIR =====\n");
                        Console.WriteLine("Programa finalizado.");

                        break;


                    default:

                        Console.WriteLine("===== ERROR =====\n");
                        Console.WriteLine("Debe seleccionar una opción del 1 al 8.");

                        break;
                }

                if (opcion != 8)
                {
                    Console.WriteLine("\nPresione cualquier tecla para volver al menú...");
                    Console.ReadKey();
                }

            }
            while (opcion != 8);
        }*/ 
    }
}

