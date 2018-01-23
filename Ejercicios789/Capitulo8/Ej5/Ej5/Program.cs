using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej5
{
    class Program
    {
        static string[] Ordernar(string[] cadenas)
        {
            return (from c in cadenas orderby c select c).ToArray<string>();
        }

        static void Main()
        {
            string[] cadenas = { "zapato", "ave", "honor", "programacion" };

            Console.WriteLine("\t \t Palabras desordenadas:");
            foreach (string s in cadenas)
            Console.WriteLine(s);

            cadenas = Ordernar(cadenas);

            Console.WriteLine("\n  \t \t Palabras ordenadas:");
            foreach (string s in cadenas)
            Console.WriteLine(s);

            Console.ReadKey();
        }
    }
}

