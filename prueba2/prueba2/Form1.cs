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
            PersonasDB db = new PersonasDB();

            //creo un nuevo estudiante
            Persona persona = new Persona();

            //llena clase 
            persona.PersonaId = 15;
            persona.Nombres = "Lewis Gabin";
           
            db.per.Add(persona);
            db.SaveChanges();
            MessageBox.Show("No puede dejar las clave vacias", "Error de validación");

        }
    }
}
