using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ejemploCuenta
{
    class Cuenta
    {
       private double saldo = 0.0;
        private int cOperaciones = 0;
        private int nroCuenta;
       
        public Cuenta(int cuenta,double monto)
        {
            saldo = monto;
            nroCuenta = cuenta;
        }
         
        public double Saldo
        {
            get
            {
                //coperaciones = 0; 
                return saldo;
            }
            set
            {
                saldo = value;
            }
        }
        public bool Extraccion(double monto)
        {
         bool exito= false;
        
         if (monto<=saldo-1.5)
            {
                cOperaciones++;
                if (cOperaciones >5)
                  {
                   saldo -= 1.5;
                  }
                saldo = saldo - monto;
                exito = true;
            }
         return exito; 
        }
        public void Deposito(double monto)
        {
           cOperaciones++;
           if (cOperaciones > 5)
            {
                saldo -= 1.5;
            }
            saldo = saldo + monto;
        }
        public int Operaciones()
        {
            return cOperaciones;
        } 
    }
}
