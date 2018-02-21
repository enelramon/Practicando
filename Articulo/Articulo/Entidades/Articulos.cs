using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Articulo.Entidades
{
    class Articulos
    {
        [Key]
        public int ArticuloId { get; set; }
        public string Descripcion { get; set; }
        public float Precio { get; set; }


        public Articulos()
        {
            this.ArticuloId = 0;
            this.Descripcion = String.Empty;
            this.Precio = 0;
        }

        public Articulos(int articuloId, string descripcion, float precio)
        {
            this.ArticuloId = articuloId;
            this.Descripcion = descripcion;
            this.Precio = precio;
        }


    }
}
