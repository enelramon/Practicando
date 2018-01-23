using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Aplicada1_1.DAL;


namespace Aplicada1_1.Registros
{
    public partial class MainEstudiantes : Form
    {
        public MainEstudiantes()
        {
            InitializeComponent();
        }

        private void MainEstudiantes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            EstudiantesDB db = new EstudiantesDB();

            //creo un nuevo estudiante
            Entidades.Estudiantes estudiante = new Entidades.Estudiantes();

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
