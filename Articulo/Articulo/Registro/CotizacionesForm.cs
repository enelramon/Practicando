using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Articulo.Entidades;
using Articulo.BLL;

namespace Articulo.Registro
{
    public partial class CotizacionesForm : Form
    {
        public CotizacionesForm()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            agregarMenu((int)numericUpDownIdArticulo.Value);
        }

        private void agregarMenu(int id)
        {
            Articulos articulos = ArticuloBLL.Buscar(id);
           if(ArticuloBLL.Buscar(id) == null)
            {
                MessageBox.Show("El articulo que busca no se encontro");
            }
            else
            {
                labelArticulo.Text = articulos.Descripcion;
                textBoxPrecio.Text = Convert.ToString(articulos.Precio);
            }
        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            if(textBoxCantidad.Text == string.Empty)
            {
                MessageBox.Show("Falta la cantidad!");
            }
            else
            {
                
                //validar el descuento
                //agregando las row al datagrid
                Articulos articulos = ArticuloBLL.Buscar((int)numericUpDownIdArticulo.Value);
                int cantidad = Convert.ToInt32(textBoxCantidad.Text);
                float descuento = float.Parse(textBoxDescuento.Text);
                float total = articulos.Precio * cantidad - descuento;
                dataGridViewArticulos.Rows.Add(articulos.ArticuloId,articulos.Descripcion, cantidad, articulos.Precio,textBoxDescuento.Text, total);

                // Sumando el total de la venta 
                 int row = 0;
                 int countData = dataGridViewArticulos.RowCount - 1;
                 float totalCotizacion = 0;
                 while (row < countData)
                 {
                     totalCotizacion += (float) dataGridViewArticulos.Rows[row].Cells[5].Value;
                     row++;
                 }
              
                //asignando el total al textbox
                textBoxTotal.Text = Convert.ToString(totalCotizacion);
                
            }
        }

        public Cotizaciones llenaClaseCotizaciones()
        {
            Cotizaciones cotizaciones = new Cotizaciones();
            cotizaciones.Monto = float.Parse(textBoxTotal.Text);
            cotizaciones.Fecha = dateTimePickerFecha.Value;
            cotizaciones.Comentario = textBoxObservaciones.Text;
            
            return cotizaciones;
        }

        public Cotizaciones_detalles[] llenaClaseCotizaciones_detalles()
        {
            int countData = dataGridViewArticulos.RowCount - 1;
            Cotizaciones_detalles[] Arreglo_detalles = new Cotizaciones_detalles[countData];
           
            int row = 0;
           
            while (row < countData)
            {
                Cotizaciones_detalles cotizaciones_Detalles = new Cotizaciones_detalles();
                cotizaciones_Detalles.ArticuloId = (int)dataGridViewArticulos.Rows[row].Cells[0].Value;
                cotizaciones_Detalles.Precio = (float)dataGridViewArticulos.Rows[row].Cells[3].Value;
                cotizaciones_Detalles.Total = (float)dataGridViewArticulos.Rows[row].Cells[5].Value;
                cotizaciones_Detalles.Cantidad = (int) dataGridViewArticulos.Rows[row].Cells[2].Value;

                Arreglo_detalles[row] = cotizaciones_Detalles;
                row++;
            }


            return Arreglo_detalles;
        }



        private void CotizacionesForm_Load(object sender, EventArgs e)
        {

        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (CotizacionBLL.Guardar(llenaClaseCotizaciones(),llenaClaseCotizaciones_detalles()) == true)
            {
                MessageBox.Show("Guardo con exito");
            }
            else
            {
                MessageBox.Show("Error, al guardar!");
            }
        }

        private void buttonBuscarCotizacion_Click(object sender, EventArgs e)
        {
           
            dataGridViewArticulos.DataSource = CotizacionBLL.BuscarDetallesCotizacion(i => i.CotizacionesId == (int)IdCotizacionnumericUpDown.Value);
            LimpiardataGridViewArticulos();
        }

        public void LimpiardataGridViewArticulos()
        {
            dataGridViewArticulos.Columns.Remove("ColumnArticuloId");
            dataGridViewArticulos.Columns.Remove("ColumnNombre");
            dataGridViewArticulos.Columns.Remove("ColumnCantidad");
            dataGridViewArticulos.Columns.Remove("ColumnPrecios");
            dataGridViewArticulos.Columns.Remove("ColumnDesc");
            dataGridViewArticulos.Columns.Remove("ColumnTotal");
            
        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (CotizacionBLL.Eliminar((int)IdCotizacionnumericUpDown.Value) == true)
            {
                MessageBox.Show("Se elimino la cotizacion");
                
            }
            else
            {
                MessageBox.Show("No se pudo eliminar la cotizacion");
            }
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
           
        }
    }
}
