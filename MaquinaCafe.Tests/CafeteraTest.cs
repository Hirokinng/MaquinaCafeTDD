using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualStudio.TestTools.UnitTesting;
using MaquinaCafe;

namespace MaquinaCafe.Tests
{
    [TestClass]
    public class CafeteraTests
    {
        [TestMethod]
        public void DeberiaDevolverVerdaderoSiExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.HasCafe(5);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFalsoSiNoExisteCafe()
        {
            Cafetera cafetera = new Cafetera(10);

            bool resultado = cafetera.HasCafe(11);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void DeberiaRestarCafeALaCafetera()
        {
            Cafetera cafetera = new Cafetera(10);

            cafetera.GiveCafe(7);

            Assert.AreEqual(3, cafetera.CantidadCafe);
        }
    }
}
