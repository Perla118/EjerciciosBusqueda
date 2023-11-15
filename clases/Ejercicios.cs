using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjerciciosBusqueda.clases
{
    internal class Ejercicios
    {
        //BUSQUEDA DE TIPO LINEAL
        //Escribe un programa en C# que realice una búsqueda lineal para encontrar un número en una lista de enteros. El programa debe pedir al usuario un número a buscar y luego buscarlo en la matriz. Si el número está en la matriz, el programa debe imprimir su posición, de lo contrario, debe indicar que el número no se encuentra en la matriz.
        public void BuscarNumero(int numero)
        {
            int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            bool encontrado = false;
            int contador = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (numero == arreglo[i])
                {
                    Console.WriteLine($"Se encuentra en la posición {contador}");
                    encontrado = true;
                    break;
                }
                contador++;
            }
            if (!encontrado)
            {
                Console.WriteLine("No se encuentra en la matriz");
            }
        }
        //Crea un programa en C# que realice una búsqueda lineal para encontrar una cadena en un arreglo de cadenas. El programa debe solicitar al usuario una cadena y buscarla en una matriz. Si la cadena se encuentra en la matriz, se debe mostrar su índice; de lo contrario, se debe indicar que la cadena no está presente.
        public void BuscarCadena(string cadena)
        {
            string[] arreglo = { "Clase", "EDA", "Perla" };
            bool encontrado = false;
            int contador = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (cadena == arreglo[i])
                {
                    Console.WriteLine($"Se encuentra en la posición {contador}");
                    encontrado = true;
                    break;
                }

                contador++;
            }
            if (!encontrado)
            {
                Console.WriteLine("La cadena no esta presente");
            }
        }
        //Escribe un programa en C# que realice una búsqueda lineal para encontrar un número par en un arreglo de números enteros. El programa debe imprimir la primera posición en la que se encuentra un número par en el arreglo.
        public void BuscarNumeroPar()
        {
            int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            bool encontrado = false;
            int contador = 0;

            for (int i = 0; i < arreglo.Length; i++)
            {
                if (arreglo[i] % 2 == 0)
                {
                    Console.WriteLine($"El primer número par se encuentra en la posición {contador}");
                    encontrado = true;
                    break;
                }

                contador++;
            }

            if (!encontrado)
            {
                Console.WriteLine("No hay números pares");
            }
        }
        //Escribe un programa en C# que realice una búsqueda lineal para encontrar todos los números pares en una matriz de números enteros. El programa debe imprimir todas las posiciones en las que se encuentran los números pares en la matriz.
        public void BusquedaNumerosPares2()
        {
            int[] array1 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

            Console.WriteLine("Posiciones de los numeros pares en el arreglo:");

            for (int i = 0; i < array1.Length; i++)
            {
                if (array1[i] % 2 == 0)
                {
                    Console.WriteLine($"Posicíon: {i}");
                }
            }
        }
        //BUSQUEDA DE TIPO BINARIA
        //Escribe un programa en C# que realice una búsqueda binaria para encontrar un número en un arreglo de enteros ordenado de menor a mayor. El programa debe solicitar al usuario un número a buscar y luego buscarlo en el arreglo. Si el número se encuentra, debe imprimir su posición; de lo contrario, debe indicar que el número no está en el arreglo.
        public void BuscarNumeroBinaria()
        {
            int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12 };

            Console.Write("Pon el numero a buscar: ");
            int numero = int.Parse(Console.ReadLine());

            int inicio = 0;
            int final = arreglo.Length - 1;
            int posicion = -1;

            while (inicio <= final)
            {
                int medio = (inicio + final) / 2;

                if (arreglo[medio] == numero)
                {
                    posicion = medio;
                    break;
                }
                else if (arreglo[medio] < numero)
                {
                    inicio = medio + 1;
                }
                else
                {
                    final = medio - 1;
                }
            }
            if (posicion != -1)
            {
                Console.WriteLine($"El número {numero} se encuentra en la posición {posicion}");
            }
            else
            {
                Console.WriteLine($"El número {numero} no esta");
            }
        }
        //Crea un programa en C# que realice una búsqueda binaria para encontrar una cadena en un arreglo de cadenas ordenado alfabéticamente. El programa debe solicitar al usuario una cadena a buscar y buscarla en el arreglo. Si la cadena se encuentra, debe mostrar su posición; de lo contrario, debe indicar que la cadena no está en el arreglo.Nota: utilice el método string.Compare() para comparar las palabras.

        public void BuscarCadenaBinaria()
        {
            string[] frutas = { "hola","queso","clase" };

            Console.Write("Pon la cadena que deseas buscar: ");
            string cadena = Console.ReadLine().ToLower();

            int inicio = 0;
            int final = frutas.Length - 1;
            int posicion = -1;

            while (inicio <= final)
            {
                int medio = (inicio + final) / 2;
                string cadenaMedia = frutas[medio].ToLower();

                int comparacion = string.Compare(cadenaMedia, cadena);

                if (comparacion == 0)
                {
                    posicion = medio;
                    break;
                }
                else if (comparacion < 0)
                {
                    inicio = medio + 1;
                }
                else
                {
                    final = medio - 1;
                }
            }

            if (posicion != -1)
            {
                Console.WriteLine($"La cadena '{cadena}' se encuentra en la posición {posicion}");
            }
            else
            {
                Console.WriteLine($"La cadena '{cadena}' no está");
            }
        }

        //Escribe un programa en C# que realice una búsqueda binaria para encontrar un número par en un arreglo de números enteros ordenado de menor a mayor. El programa debe imprimir la posición del primer número par encontrado en el arreglo.

        public void BuscarNumeroParBinaria()
        {
            int[] arreglo = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            bool encontrado = false;
            int inicio = 0;
            int fin = arreglo.Length - 1;
            int posicion = -1;

            while (inicio <= fin)
            {
                int medio = inicio + (fin - inicio) / 2;

                if (arreglo[medio] % 2 == 0)
                {
                    encontrado = true;
                    posicion = medio;
                    fin = medio - 1; // Buscar en la mitad izquierda para encontrar el primer número par
                }
                else
                {
                    inicio = medio + 1;
                }
            }

            if (encontrado)
            {
                Console.WriteLine($"El primer número par se encuentra en la posición {posicion}");
            }
            else
            {
                Console.WriteLine("No se encontró ningún número par");
            }
        }
    }
}
