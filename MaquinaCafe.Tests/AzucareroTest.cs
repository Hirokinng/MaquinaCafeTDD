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
    public class AzucareroTests
    {
        private Azucarero azucarero;

        [TestInitialize]
        public void SetUp()
        {
            azucarero = new Azucarero(10);
        }

        [TestMethod]
        public void DeberiaDevolverVerdaderoSiHaySuficienteAzucar()
        {
            bool resultado = azucarero.HasAzucar(5);
            Assert.IsTrue(resultado);

            resultado = azucarero.HasAzucar(10);
            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFalsoPorqueNoHaySuficienteAzucar()
        {
            bool resultado = azucarero.HasAzucar(15);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void DeberiaRestarAzucarAlAzucarero()
        {
            azucarero.GiveAzucar(5);
            Assert.AreEqual(5, azucarero.CantidadAzucar);

            azucarero.GiveAzucar(2);
            Assert.AreEqual(3, azucarero.CantidadAzucar);
        }
    }
}
