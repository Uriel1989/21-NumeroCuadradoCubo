using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21_NumeroCuadradoCubo
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, numero, cuadrado, cubo;

            Console.WriteLine("Ingrese un numero para desarrollar su tabla o presione cero para cerrar el programa: ");
            n = Convert.ToInt32(Console.ReadLine());

            while (n != 0)
            {


                numero = n;
                cuadrado = n * n;
                cubo = n * n * n;

                Console.WriteLine("En Numero es: " + numero);
                Console.WriteLine("El Cuadrado es: " + cuadrado);
                Console.WriteLine("El Cubo es: " + cubo);

                Console.WriteLine("Ingrese un numero para desarrollar su tabla o presione cero para cerrar el programa: ");
                n = Convert.ToInt32(Console.ReadLine());

            }

            Console.ReadLine();
        }
    }
}
