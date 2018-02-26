using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulo.Entidades
{
    public class Cotizaciones_detalles
    {
        [Key]
        public int IdCotizaciones_detalles {get; set;}
        public int CotizacionesId {get; set;}
        public int ArticuloId {get; set;}
        public int Cantidad  {get; set;}
        public int Precio {get; set;}

    public Cotizaciones_detalles()
        {
            this.IdCotizaciones_detalles = 0;
            this.CotizacionesId = 0;
            this.ArticuloId = 0;
            this.Cantidad = 0;
            this.Precio = 0;

        }

        public Cotizaciones_detalles(int idCotizaciones_Detalles, int cotizacionId, int articuloid, int cantidad, int precio)
        {
            this.IdCotizaciones_detalles = idCotizaciones_Detalles;
            this.CotizacionesId = cotizacionId;
            this.ArticuloId = articuloid;
            this.Cantidad = cantidad;
            this.Precio = precio;
        }
    }
}
