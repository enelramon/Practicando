using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class Program
    {
        static void Main(string[] args)
        {
            LibrosValoraciones valoracion = new LibrosValoraciones();
            valoracion.AgregarValoraciones(2.4f);
            valoracion.AgregarValoraciones(3f);
            valoracion.AgregarValoraciones(2.4f);
            valoracion.AgregarValoraciones(4.2f);
            valoracion.AgregarValoraciones(2.5f);
            valoracion.AgregarValoraciones(1f);

            CalcularValoracion publicar = valoracion.PublicarValoracion();
            Console.WriteLine("Este es el promedio de valoracion "+ publicar.promedioValoracion);
            Console.WriteLine("Este es el valor maximo " + publicar.valoracionMax);
            Console.WriteLine("Este es el valor minimo " + publicar.valoracionMin);

        }
    }
}
