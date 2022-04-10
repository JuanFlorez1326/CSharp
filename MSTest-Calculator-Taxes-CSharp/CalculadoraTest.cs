using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CalculadoraDeImpuestostest
{
    [TestClass]
    public class CalculadoraTest
    {
        [TestMethod]
        public void ImpuestosTest()
        {
            CalculadoraDeImpuestos ci = new CalculadoraDeImpuestos();

            decimal iva = ci.ObtenerIva(1550.00m);
            Assert.AreEqual(294.5m, iva);

            decimal hospedaje = ci.Estatal(1550.00m);
            Assert.AreEqual(46.5m, hospedaje);

            decimal total = ci.Reserva(1550.00m);
            Assert.AreEqual(1891.00m, total);
        }
    }
}