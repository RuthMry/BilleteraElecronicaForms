using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BilleteraElecronicaLibreria
{
    public class CuentaCorriente
    {
        private String numeroCuenta;
        private String DNI;
        private Decimal saldo;

        //ToDo: Revisar si es necesario set
        public decimal Saldo { get => saldo; set => saldo = value; }

        private CuentaCorriente()
        {

        }

        public CuentaCorriente(String numeroCuenta, String DNI, Decimal saldo)
        {
            this.numeroCuenta = numeroCuenta;
            this.DNI = DNI;
            this.saldo = saldo;
        }

    }
}
