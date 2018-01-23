using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicada1_1.Entidades
{
    class Estudiantes
    {
        public int EstudiantesId { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direccion { get; set; }
        public string Email { get; set; }
        public int Telefono { get; set; }
        public string Carrera { get; set; }


        public Estudiantes()
        {
            this.EstudiantesId = 0;
            this.Nombre = string.Empty;
            this.Apellido  = string.Empty;
            this.Direccion = string.Empty;
            this.Email = string.Empty;
            this.Telefono = 0;
            this.Carrera = string.Empty;

        }

        public Estudiantes(int estudianteId, string nombre, string apellido, string direccion, string email, int telefono, string carrera)
        {
            this.EstudiantesId = estudianteId;
            this.Nombre = nombre;
            this.Apellido = apellido;
            this.Direccion = direccion;
            this.Email = email;
            this.Telefono = telefono;
            this.Carrera = carrera;
        }
    }

    
}
