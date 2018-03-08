using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Examen2.Entidades;
using Examen2.BLL;

namespace Examen2.Registro
{
    public partial class ClientesForm : Form
    {
        List<Telefono_detalles> detalle = new List<Telefono_detalles>();
        public ClientesForm()
        {
            InitializeComponent();
        }

        private void Addbutton_Click(object sender, EventArgs e)
        {
            if (TelefonotextBox.Text == string.Empty)
            {
                MessageBox.Show("Falta el telefono!");
            }
            else
            {

               
               
                int telefono = Convert.ToInt32(TelefonotextBox.Text);
                string tipo = TipocomboBox.Text;
                
                TelefonodataGridView.Rows.Add(tipo,telefono);

              
                

            }
        }

        public Clientes Llenaclase()
        {
            Clientes clientes = new Clientes();
            clientes.Nombre = NombretextBox.Text;
            clientes.Fecha = FechadateTimePicker.Value;
            for (int i = 0; i >= TelefonodataGridView.RowCount; i++)
            {
                clientes.Telefonos_Detalles.Add(new Telefono_detalles (TelefonodataGridView.Rows[i].Cells[0].Value.ToString(),(int)TelefonodataGridView.Rows[i].Cells[1].Value));

            }

            return clientes;

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (ClientesBLL.Guardar(Llenaclase()))
            {
                MessageBox.Show("Guardo");
            }
            else
            {
                MessageBox.Show("no Guardo");
            }
        }
    }
}
