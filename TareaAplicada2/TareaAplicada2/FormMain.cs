using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;
using System.Windows.Forms;
using TareaAplicada2.DAL;
using TareaAplicada2.Entidades;

namespace TareaAplicada2
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //creo la instacia para que cree la tabla oh se conecte a la bd
            EstudiantesDB db = new EstudiantesDB();

          //creo un nuevo estudiante
            Entidades.Estudiantes estudiante = new Estudiantes();

            //llena clase 
            estudiante.EstudiantesId = 15;
            estudiante.Nombre = "Error de validación";
            estudiante.Apellido = "Error de validación";
            estudiante.Direccion = "Error de validación";
            estudiante.Carrera = "Error de validación";
            estudiante.Email = "Error de validación";
            estudiante.Telefono = 809234233;

            db.Estudiante.Add(estudiante);
            db.SaveChanges();
            MessageBox.Show("No puede dejar las clave vacias", "Error de validación");


        }
    }
}
