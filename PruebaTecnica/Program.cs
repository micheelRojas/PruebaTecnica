using System;

namespace PruebaTecnica
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            //Console.WriteLine(CalcularDivicion(1, 4));
            //PositivoPerfecto(7);
            FizzBuzz();
        }
       
        /*Realice un algoritmo que reciba como parámetro dos números enteros y retorne la
          división de ambos números.*/
        public static decimal CalcularDivicion(int dividendo, int divisor)
        {
            return Convert.ToDecimal(dividendo) / Convert.ToDecimal(divisor);

        }
        /*
         * 3- Un entero positivo se llama perfecto si éste es igual a la suma de todos sus divisores
            diferentes de él. Por ejemplo:
            6 es perfecto porque 6 = 1 + 2 + 3.
            28 es perfecto porque 28 = 1 + 2 + 4 + 7 + 14
            Escriba un programa que reciba como entrada n números enteros positivos, y por cada uno
            de ellos imprima sus divisores e indique si es perfecto o no.

         */
        public static void PositivoPerfecto(int n)
        {
            if (n > 0)
            {
                int suma = 0;
                for (int i = 1; i < n; i++)
                {
                    if (n % i == 0)
                    {
                        Console.WriteLine($"divisor: {i}");
                        suma += i;
                    }
                }
                if (suma.Equals(n))
                {
                    Console.WriteLine($"El numero {n} es perfecto");
                }
                else
                {
                    Console.WriteLine($"El numero {n} es no perfecto");

                }
            }
            else
            {
                Console.WriteLine("El numero debe ser positivo");
            }
        }
        /*
             * 4- Escriba un algoritmo que imprima los números del 1 al 100. Pero para los múltiplos
                de 3 imprima "Fizz" en lugar del número y para los múltiplos de 5 imprima "Buzz". Para los
                números que son múltiplos de ambos imprima "FizzBuzz".
         */
        public static void FizzBuzz() {

            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0) {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0) {
                    Console.WriteLine("Buzz");
                }
                else {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
