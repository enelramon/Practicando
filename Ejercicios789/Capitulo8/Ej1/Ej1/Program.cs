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

            string cadena = "";

            Console.WriteLine("Ingrese palabra ");
            cadena = Console.ReadLine();

            for(int i=0; i<= cadena.Length; i++)
            {
              try
                {
                    Console.WriteLine(cadena[i]);

                }
                catch(Exception error)
                {

                }
            }



            Console.ReadKey();

        }
    }
}


