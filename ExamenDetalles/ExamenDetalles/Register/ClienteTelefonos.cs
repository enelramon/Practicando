using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExamenDetalles.BLL;
using ExamenDetalles.Entidades;

namespace ExamenDetalles.Register
{
    public partial class ClienteTelefonos : Form
    {
        public ClienteTelefonos()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (NumerotextBox.Text == string.Empty)
            {
                MessageBox.Show("Falta el telefono!");
            }
            else
            {



                int telefono = Convert.ToInt32(NumerotextBox.Text);
                string tipo = TiposcomboBox.Text;

                NumerosdataGridView.Rows.Add(tipo, telefono);




            }
        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (ClienteBLL.Guardar(Llenaclase()))
            {
                MessageBox.Show("Guardo");
            }
            else
            {
                MessageBox.Show("no Guardo");
            }
        }

        private Clientes Llenaclase()
        {
            Clientes clientes = new Clientes();
            clientes.Nombre = NombretextBox.Text;
            clientes.Fecha = FechadateTimePicker.Value;
            int rows = NumerosdataGridView.RowCount - 1;
            for (int i = 0; i < rows; i++)
            {
                Telefono_Detalles telefono_Detalles = new Telefono_Detalles();
                telefono_Detalles.Tipo_telefono = NumerosdataGridView.Rows[i].Cells[0].Value.ToString();
                telefono_Detalles.Numero = (int)NumerosdataGridView.Rows[i].Cells[1].Value;
                clientes.Telefonos_Detalles.Add(telefono_Detalles);
            }

            return clientes;
        }
    }
}
