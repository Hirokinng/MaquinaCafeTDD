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
    public class VasoTests
    {
        [TestMethod]
        public void DeberiaDevolverVerdaderoSiExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(2, 10);

            bool resultado = vasosPequenos.HasVasos(1);

            Assert.IsTrue(resultado);
        }

        [TestMethod]
        public void DeberiaDevolverFalsoSiNoExistenVasos()
        {
            Vaso vasosPequenos = new Vaso(1, 10);

            bool resultado = vasosPequenos.HasVasos(2);

            Assert.IsFalse(resultado);
        }

        [TestMethod]
        public void DeberiaRestarCantidadDeVasos()
        {
            Vaso vasosPequenos = new Vaso(5, 10);

            vasosPequenos.GiveVasos(1);

            Assert.AreEqual(4, vasosPequenos.CantidadVasos);
        }
    }
}
