using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace SistemaUnitTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestVentaTotal()
        {
            //Arrange
            decimal expected = 11M;
            decimal venta = 10M;
            decimal propina = 10M;

            //Act
            decimal ventaTotal = Proyecto_Final_Periodo3.ventanas.ventanasOrdenes.ventanaOrden.Venta(venta, propina);

            //Assert
            Assert.AreEqual(expected, ventaTotal);
        }


    }
}
