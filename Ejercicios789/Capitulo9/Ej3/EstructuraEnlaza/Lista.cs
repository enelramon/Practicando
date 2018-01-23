using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EstructuraEnlaza
{
 public   class Lista
    {
        private Nodo primero;
        private int size;

        public Lista()
        {
            this.primero = null;
            this.size = 0;
            

        }
        public void addNodo(string NombreP, string NombreD)
        {
            Nodo n = new Nodo(NombreD, NombreP);
            n.sigte = primero;
            primero = n;
            size++;


        }

        public int Size()
        {
            return size;

        }

        public void Listar()
        {
            Nodo actual;

           
             actual = primero;
            while(actual!=null)
            {
                MessageBox.Show("Nombre Dueño : " + actual.NombreD + "Mascosta " + actual.NombreP);
                actual = null;

            }


        }

        public  void ListaVacia()
        {
            if (primero == null)
            {
                MessageBox.Show("La lista esta vacia");

            }
            else
            {
                MessageBox.Show("La lista tiene datos");
                


            }
        }


    }
}
