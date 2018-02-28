using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Articulo.Entidades;
using Articulo.DAL;
using System.Data.Entity;
using System.Linq.Expressions;

namespace Articulo.BLL
{
   public class ArticuloBLL
    {
        public static bool Guardar(Articulos articulos)
        {
            bool estado = false;
            try
            {
               Context context = new Context();
                context.articulo.Add(articulos);
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {

                throw;
            }
            return estado;
        }

        public static Articulos Buscar(int Id)
        {
            Articulos articulos = new Articulos();
            try
            {
                Context context = new Context();
                articulos = context.articulo.Find(Id);

            }
            catch (Exception)
            {
                throw;
            }

            return articulos;

        }
        public static bool Editar(Articulos articulos)
        {
            bool estado = false;

            try
            {
                Context context = new Context();
                context.Entry(articulos).State = EntityState.Modified;
                context.SaveChanges();
                estado = true;

            }
            catch (Exception)
            {
                throw;
            }

            return estado;

        }

        public static bool eliminar(int Id)
        {
            Articulos articulos = null;
            bool estado = false;
            try
            {
                Context context = new Context();
                articulos = context.articulo.Find(Id);
                context.articulo.Remove(articulos);
                context.SaveChanges();

                estado = true;

            }
            catch (Exception)
            {
                throw;


            }
            return estado;
        }

        public static List<Articulos> Consulta(Expression<Func<Articulos, bool>> filter)
        {
            List<Articulos> lista = null;

            Articulos articulos = new Articulos();
            try
            {
                Context context = new Context();
                lista = context.articulo.Where(filter).ToList();

            }
            catch (Exception)
            {
                throw;
            }

            return lista;

        }
    }
}

