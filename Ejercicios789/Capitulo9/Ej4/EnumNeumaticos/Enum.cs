using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnumNeumaticos
{
   public class Enum
    {
        public enum Neumaticos
        {
            Neumatico=1,Numatico2,Neumatico3,Neumatico4,Numatico5
            
        }
        public void mostrar(int neumatico)
        {
            Neumaticos n = (Neumaticos)neumatico;

            MessageBox.Show("Seleciono el tipo " +n);



        }
    }
}
