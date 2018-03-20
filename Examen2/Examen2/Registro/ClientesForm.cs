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
            int rows = TelefonodataGridView.RowCount - 1;
            for (int i = 0; i < rows ; i++)
            {
                clientes.Telefonos_Detalles.Add(new Telefono_detalles (TelefonodataGridView.Rows[i].Cells[0].Value.ToString(),(int)TelefonodataGridView.Rows[i].Cells[1].Value));

            }

            return clientes;

        }

        private void Guardarbutton_Click(object sender, EventArgs e)
        {
            if (ClientesBLL.Guardar(Llenaclase()))
            {
                Limpiar();
                MessageBox.Show("Guardo");
            }
            else
            {
                Limpiar();
                MessageBox.Show("no Guardo");
            }
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {

            
            llenaCampo((int)IdnumericUpDownBuscar.Value);

        }

        private Clientes llenaCampo(int id)
        {
            Clientes clientes = new Clientes();
            clientes = ClientesBLL.Buscar(id);
            if (clientes == null)
            {
                MessageBox.Show("no se encontro el cliente");
                Limpiar();

            }
            else
            {
                NombretextBox.Text = clientes.Nombre;
                FechadateTimePicker.Value = clientes.Fecha.Value;
            
                foreach (Telefono_detalles td in clientes.Telefonos_Detalles)
                {
                    TelefonodataGridView.Rows.Add(td.Tipo_telefono, td.Numero);
                   
                    
           
                }
            }

            return clientes;
        }

        private void buttonNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            NombretextBox.Text = String.Empty;
            TelefonotextBox.Text = String.Empty;
            FechadateTimePicker.Value = DateTime.Now;
            TelefonodataGridView.Rows.Clear();

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            if (ClientesBLL.Eliminar((int)IdnumericUpDownBuscar.Value) == true)
            {
                Limpiar();
                MessageBox.Show("No se pudo eliminar");
            }
            else
            {
                Limpiar();
                MessageBox.Show("Se borro con exito!");

            }
        }
    }
}
