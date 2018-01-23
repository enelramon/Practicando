using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un valor numerico:");
            int valor = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Ingrese un valor numerico2:");
            int valor2 = Convert.ToInt32(Console.ReadLine());

            int suma = valor+ valor2;

            if (suma < 0)
            {
                Console.WriteLine("Suma es " + "(" + suma + ")");
            } else
            {
                Console.WriteLine("Suma es "+ suma);
            }
            


           
            Console.ReadKey();
        }


    }
}
