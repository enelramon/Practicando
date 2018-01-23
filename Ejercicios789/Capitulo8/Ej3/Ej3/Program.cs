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





            Console.WriteLine(string.Format("{0:hh:mm:ss tt}", DateTime.Now));


            Console.WriteLine(DateTime.Now.ToShortDateString());

            Console.ReadKey();
        }
    }
}

