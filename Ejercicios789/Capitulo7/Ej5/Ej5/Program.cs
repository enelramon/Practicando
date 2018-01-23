
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace Ej5
{
    class Program
    {
        static void Main()
        {

           Queue agenda = new Queue();
            string cel;
            string nombre;
                int lista = 1;
                while (lista == 1)
                {

                Console.WriteLine("Ingrese nombre de persona que desea agregar a contactos ");
               nombre= Console.ReadLine();
                agenda.Enqueue(nombre);
                Console.WriteLine("ingrese tlf ");
               cel = Console.ReadLine();
                 agenda.Enqueue(cel);

                    Console.WriteLine("Coloque 0 si no ingresaran mas personas de lo contrario ingrese 1 ");
                    lista = int.Parse(Console.ReadLine());


                }
                while (agenda.Count > 0)
                    // Thread.Sleep(2000);
                    Console.WriteLine("Persona: {0} :: Numero {1}" , agenda.Dequeue(), agenda.Dequeue());
                

            Console.ReadKey();
        }
    }
}







