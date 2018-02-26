using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Articulo.Entidades;
using Articulo.DAL;

namespace Articulo.BLL
{
    public class CotizacionBLL
    {
        public static bool Guardar(Cotizaciones cotizaciones, Cotizaciones_detalles cotizaciones_Detalles)
        {
            bool estado = false;
            try
            {
                Context context = new Context();
                context.cotizacion.Add(cotizaciones);
                context.cotizacion_detalles.Add(cotizaciones_Detalles);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }
    }
}
