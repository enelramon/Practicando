using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Articulo.Registro;
using Articulo.Reportes;

namespace Articulo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void crearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ArticulosForm form1 = new ArticulosForm();
            form1.Show();

        }

        private void crearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
           CotizacionesForm form2 = new CotizacionesForm();
            form2.Show();
        }

        private void articuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaArticulosForm form3 = new ConsultaArticulosForm();
            form3.Show();

        }

        private void articulosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ReporteArticulo form4 = new ReporteArticulo();
            form4.Show();
        }
    }
}
