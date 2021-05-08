using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ResturanteUnitTest
{
    [TestClass]
    public class UnitTest2
    {
        [TestMethod]
        public void Venta_Total_Mayor_Que_Cero()
        {
            //Arrange
            decimal venta = 10M;
            decimal propina = 10M;

            //Act
            decimal ventaTotal = Proyecto_Final_Periodo3.ventanas.ventanasOrdenes.ventanaOrden.Venta(venta, propina);
            

            //Act
            try
            {
                Proyecto_Final_Periodo3.ventanas.ventanasOrdenes.ventanaOrden.Venta(venta, propina);
            }
            catch (ArgumentOutOfRangeException e)
            {
                // Assert
                StringAssert.Contains(e.Message, Proyecto_Final_Periodo3.ventanas.ventanasOrdenes.ventanaOrden.TotalMenorDeCeroMessage);
            }
        }
    }
}
