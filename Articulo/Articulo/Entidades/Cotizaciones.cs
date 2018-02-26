using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulo.Entidades
{
    public class Cotizaciones
    {
        public int CotizacionesId { get; set; }
        public DateTime? Fecha { get; set; }
        public float Monto { get; set; }
        public string Comentario { get; set; }

        public Cotizaciones()
        {
            this.CotizacionesId = 0;
            this.Fecha = null;
            this.Monto = 0;
            this.Comentario = string.Empty;
        }

        public Cotizaciones(int cotizacionesId, DateTime fecha, float monto, string comentario)
        {
            this.CotizacionesId = cotizacionesId;
            this.Fecha = fecha;
            this.Monto = monto;
            this.Comentario = comentario;
        }
    }
}
