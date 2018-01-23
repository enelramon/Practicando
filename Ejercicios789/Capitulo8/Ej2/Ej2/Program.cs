using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ej2
{
    class Program
    {
        static void Main(string[] args)
        {




          
            Console.WriteLine   ("Ingrese cadena ");
            string caddena = Console.ReadLine();
            Console.WriteLine("Ingrese espacios para justificar ");
            int espacios = int.Parse(Console.ReadLine());
            Console.WriteLine(caddena.PadLeft(espacios, ' '));
            Console.ReadKey();
        }
    }
}