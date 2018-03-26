using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Practicando.Entidades;
using Practicando.DAL;

namespace Practicando.BLL
{
    class PersonaBLL
    {
        public static bool Guardar(Personas personas)
        {
            bool Estado = false;

            try
            {
                Context db = new Context();
                db.PersonaContext.Add(personas);
                foreach (PersonasTelefonos PersonaTelefonos in personas.TelefonosPersona)
                {
                    db.TelefonoContext.Add(PersonaTelefonos);
                }

                db.SaveChanges();

                Estado = true;
            }
            catch (Exception)
            {
                throw;
            }

            return Estado;
        }
    }
}
