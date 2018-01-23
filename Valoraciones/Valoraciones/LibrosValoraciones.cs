using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Valoraciones
{
    class LibrosValoraciones
    {
        List<float> valoraciones; 

        public LibrosValoraciones()
        {
            valoraciones = new List<float>();
        }

        public CalcularValoracion PublicarValoracion()
        {
            CalcularValoracion calculo = new CalcularValoracion();
            float sumaValoracion = 0;
            foreach (float valoracion in valoraciones)
            {
                calculo.valoracionMax = Math.Max(valoracion, calculo.valoracionMax);
                calculo.valoracionMin = Math.Min(valoracion, calculo.valoracionMin);
                sumaValoracion += valoracion;
            }

            calculo.promedioValoracion = sumaValoracion / valoraciones.Count;

            return calculo;
        }
        public void AgregarValoraciones(float valoracion){
            valoraciones.Add(valoracion);
        }

        
    }
}
