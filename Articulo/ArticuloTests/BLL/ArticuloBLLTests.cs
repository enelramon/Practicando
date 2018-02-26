using Microsoft.VisualStudio.TestTools.UnitTesting;
using Articulo.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Articulo.Entidades;

namespace Articulo.BLL.Tests
{
    [TestClass()]
    public class ArticuloBLLTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Articulos articulo = new Articulos();
            articulo.ArticuloId = 1;
            articulo.Descripcion = "kdfndkfbdfb";
            articulo.Precio = 34;

            //ArticuloBLL.Guardar(articulo);
            bool resultado = ArticuloBLL.Guardar(articulo);
            Assert.AreEqual(resultado,true);
         
        }

        [TestMethod()]
        public void BuscarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void EditarTest()
        {
            Assert.Fail();
        }

        [TestMethod()]
        public void eliminarTest()
        {
            Assert.Fail();
        }
    }
}