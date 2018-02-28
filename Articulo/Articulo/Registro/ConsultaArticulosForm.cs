using Articulo.Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Articulo.BLL;

namespace Articulo.Registro
{
    public partial class ConsultaArticulosForm : Form
    {
        public ConsultaArticulosForm()
        {
            InitializeComponent();
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            Expression<Func<Articulos, bool>> filter = i=> true;
            int datos = 0;
            int.TryParse(textBoxBusqueda.Text, out datos);

            switch (comboBoxFiltro.SelectedIndex)
            {
                case 0:
                    filter = i => i.ArticuloId == datos;
                    break;
                case 1:
                    filter = i => i.Descripcion.Contains(textBoxBusqueda.Text);
                    break;


                default:
                    MessageBox.Show("Selecione un campo para filtrar");
                    break;
            }
            dataGridViewArticulos.DataSource = ArticuloBLL.Consulta(filter);
        }
    }
}
