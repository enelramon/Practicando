using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Articulo.BLL;
using Articulo.Entidades;

namespace Articulo.Registro
{
    public partial class ArticulosForm : Form
    {
        public ArticulosForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ArticuloBLL.Buscar((int)IdAnumericUpDown.Value) == null)
            {
                if (ArticuloBLL.Guardar(llenaClase()) == true)
                {
                    Limpiar();
                    MessageBox.Show("Se guardo con exito");
                }

                else
                {
                    MessageBox.Show("Error, no pudo guardar, intentelo de nuevo!");
                }



            }
            else
            {
                Articulos articulo = ArticuloBLL.Buscar((int)IdAnumericUpDown.Value);
                articulo.Descripcion = DescrpciontextBox.Text;
                articulo.Precio = float.Parse(PreciotextBox.Text);
                if (ArticuloBLL.Editar(articulo) == true)
                {
                    Limpiar();
                    MessageBox.Show("Se edito con exito!");

                }
                else
                {
                    MessageBox.Show("Error, tiene problema para editar!");
                }

            }

        }

        public Articulos llenaClase()
        {
            Articulos articulo = new Articulos();
            articulo.Descripcion = DescrpciontextBox.Text;
            articulo.Precio = float.Parse(PreciotextBox.Text);

            return articulo;

        }
       

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            llenaCampo((int)IdAnumericUpDown.Value);
        }

        public Articulos llenaCampo(int id)
        {
            Articulos articulo = new Articulos();
            articulo = ArticuloBLL.Buscar(id);
            if (articulo == null)
            {
                Limpiar();
                MessageBox.Show("No se encontro el articulo");
            }
            else
            {
                DescrpciontextBox.Text = articulo.Descripcion;
                PreciotextBox.Text = Convert.ToString(articulo.Precio);
            }


            return articulo;

        }

        private void Nuevobutton_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        public void Limpiar()
        {
            DescrpciontextBox.Text = string.Empty;
            PreciotextBox.Text = string.Empty;
            IdAnumericUpDown.Value = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (ArticuloBLL.eliminar((int) IdAnumericUpDown.Value) == true)
            {
                Limpiar();
                MessageBox.Show("Se elimino correctamente");

            }
            else
            {
                Limpiar();
                MessageBox.Show("Error, no se puedo eliminar");
            }
        }
    }
}
