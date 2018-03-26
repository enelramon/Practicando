using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Practicando.Entidades;
using Practicando.BLL;

namespace Practicando.Registro
{
    public partial class FormAddPersonas : Form
    {
        public FormAddPersonas()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxNumero.Text == string.Empty)
            {
                MessageBox.Show("Falta el numero telefono!");
            }
            else
            {
                int Telefono = Convert.ToInt32(textBoxNumero.Text);
                string Tipo = comboBoxTipo.Text;

                dataGridViewTelefonos.Rows.Add(Tipo, Telefono);
            }
        }

        private void buttonGuardar_Click(object sender, EventArgs e)
        {
            if (PersonaBLL.Guardar(LlenaClase())== true) {
                MessageBox.Show("Guardo con exito");
            } else {
                MessageBox.Show("No Guardo");
            } 
        }

        private Personas LlenaClase()
        {
            Personas persona = new Personas();
            persona.Nombres = textBoxNombre.Text;
            int rows = dataGridViewTelefonos.RowCount - 1;
            for (int i = 0; i < rows; i++)
            {
               persona.TelefonosPersona.Add(new PersonasTelefonos(0,dataGridViewTelefonos.Rows[i].Cells[0].Value.ToString(), (int)dataGridViewTelefonos.Rows[i].Cells[1].Value,0));

            }

            return persona;
        }
    }
}
