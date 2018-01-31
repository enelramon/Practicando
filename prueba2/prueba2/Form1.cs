using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using prueba2.Entidad;
using prueba2.DAL;
using System.Data.Entity;

namespace prueba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            TiposTelefonosDB db = new TiposTelefonosDB();

            TiposTelefonos tipoTelefonos = new TiposTelefonos();

            //llena clase 

            tipoTelefonos.TipoId = 0;
            tipoTelefonos.TipoNumero = textBoxTipoTelefono.Text;
            tipoTelefonos.Descripcion = textBoxDescripcion.Text;

            db.TipTelefonos.Add(tipoTelefonos);
            db.SaveChanges();
            MessageBox.Show("Se agrego el registro de telefono");

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            TiposTelefonosDB db = new TiposTelefonosDB();
            
            
            int TipoId = 0;
            int.TryParse(textBoxId.Text, out TipoId);

            TiposTelefonos tiposTelefonos = new TiposTelefonos();

            tiposTelefonos = db.TipTelefonos.Find(TipoId);
            if (tiposTelefonos == null)
            {
                MessageBox.Show("Id no encontado");
            }
            else
            {
                textBoxTipoTelefono.Text = tiposTelefonos.TipoNumero;   
                textBoxDescripcion.Text = tiposTelefonos.Descripcion;
            }
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            TiposTelefonosDB db = new TiposTelefonosDB();

            int TipoId = 0;
            int.TryParse(textBoxId.Text, out TipoId);

            var tiposTelefonos = db.TipTelefonos.Find(TipoId);

            tiposTelefonos.TipoNumero = textBoxTipoTelefono.Text;
            tiposTelefonos.Descripcion = textBoxDescripcion.Text;

            db.Entry(tiposTelefonos).State = EntityState.Modified;
            db.SaveChanges();
            MessageBox.Show("Cambios correctos");

        }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            TiposTelefonosDB db = new TiposTelefonosDB();

            int TipoId = 0;
            int.TryParse(textBoxId.Text, out TipoId);
            var tiposTelefonos = db.TipTelefonos.Find(TipoId);

            db.TipTelefonos.Remove(tiposTelefonos);
            db.SaveChanges();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBoxComentario_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            textBoxTipoTelefono.Text = String.Empty;
           textBoxDescripcion.Text= String.Empty;
        }
    }
}
