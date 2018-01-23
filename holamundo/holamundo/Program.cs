
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace holamundo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("escriba su nombre y pulse enter:");
            string nombre = Console.ReadLine();
            Console.WriteLine("escriba su edad y pulse enter:");
            int edad = int.Parse(Console.ReadLine());
            if (edad >= 18)
            {
                Console.WriteLine("tu nombre es "+ nombre + " y legalmente eres mayor de edad");
            }else{
                Console.WriteLine("tu nombre es " + nombre + " y legalmente no eres mayor de edad");
            }

        }
    }
}
