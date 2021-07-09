using System;

namespace Eje171819
{
    class MainClass
    {
        public static void Main(string[] args)
        {
             /************
            * Ejercicio 17
            * **********/

            Console.WriteLine("Numeros del 1 al 100, bucle while");
            int k = 1;
            while (k <= 100)
            {
                Console.Write(k+" ");
                k++;
            }
            /************
            * Ejercicio 18
            * **********/

            Console.WriteLine("\nNumeros del 1 al 100, bucle for");
            for (int g = 1; g <= 100; g++)
            {
                Console.Write(g+" ");
            }

            /************
            * Ejercicio 19
            * **********/

            Console.WriteLine("\nNumeros del 1 al 100, divisibles entre 2 y 3");
            for (int h = 1; h <= 100; h++)
            {
                if (h % 2 == 0 && h % 3 == 0)
                    Console.Write(h+" ");
            }
        }
    }
}
