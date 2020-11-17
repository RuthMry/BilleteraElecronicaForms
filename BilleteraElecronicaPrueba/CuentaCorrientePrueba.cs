using System;
using BilleteraElecronicaLibreria;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BilleteraElecronicaPrueba
{
    [TestClass]
    public class CuentaCorrientePrueba
    {
        [TestMethod]
        public void cuentaCorriente_aperturaCuentaConSaldoCero_saldoIgualCero()
        {
            //Arrange
            String numeroCuenta = "44445";
            String DNI = "4567578";
            Decimal saldoInicialEsperado = 0; 
            Decimal saldoInicialActual;
            
            //Do
            CuentaCorriente cuenta = new CuentaCorriente(numeroCuenta, DNI, 0);
            saldoInicialActual = cuenta.Saldo;
            //Assert
            Assert.AreEqual(saldoInicialEsperado, saldoInicialActual,"Error: El saldo no es cero");
        }
    }
}
