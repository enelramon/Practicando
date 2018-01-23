using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnumeracionEstre
{
   public class ENUN
    {
        public enum Neumaticos
        {
            Estrella = 1, Estrella2, Estrella3, Estrella4, Estrella5

        }
        public void mostrar(int neumatico)
        {
            Neumaticos n = (Neumaticos)neumatico;

            MessageBox.Show("Seleciono el tipo " + n);



        }
    }
}

