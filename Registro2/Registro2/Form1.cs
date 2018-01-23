using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Registro2.DAL;
using Registro2.ENTIDADES;
    

namespace Registro2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                PersonaDB db = new PersonaDB();
                Personas persona = new Personas();
                persona.PersonaId = 15;
                persona.Nombre = "Lewis gabin";

                db.Persona.Add(persona);
                db.SaveChanges();
                MessageBox.Show("se guardo");
           
        }
    }
}
