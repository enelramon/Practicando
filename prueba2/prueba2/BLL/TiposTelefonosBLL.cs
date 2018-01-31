using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using prueba2.Entidad;
namespace prueba2.BLL
{
    class TiposTelefonosBLL
    {
        public static List<TiposTelefonos> GetList(Expression<Func<TiposTelefonos, bool>> criterioBusqueda)
        {
            List<TiposTelefonos> personas = new List<TiposTelefonos>();
            try
            {
                Contexto contex = new Contexto();
                personas = contex.Persona.Where(criterioBusqueda).ToList();
            }
            catch (Exception)
            {
                throw;
            }

            return personas;
        }
    }
}
