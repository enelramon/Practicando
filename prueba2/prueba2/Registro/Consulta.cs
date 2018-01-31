using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace prueba2.Registro
{
    public partial class Consulta : Form
    {
        public Consulta()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBoxFiltrar.SelectedIndex == 0) {
                int tipoId = 0;
                int.TryParse(textBoxBusqueda.Text, out tipoId);
                dataGridViewMostrar.DataSource = TiposTelefonosBLL.GetList(es => es.TipoId == tipoId);



            }

            if(comboBoxFiltrar.SelectedIndex == 1)
            {


            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
