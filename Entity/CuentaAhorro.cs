using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
   public class CuentaAhorro : Cuenta
    {
        const decimal TOPE = 10000;
        public CuentaAhorro(decimal saldo):base(saldo)
        {

        }

        public override string Consignar(decimal valor)
        {
            
            if (valor>0)
            {
                Saldo += valor;
                RegistrarMovimientos(valor,"Consignar");
                return $"Se consignó el Valor {valor} su nuevo saldo es {Saldo}";

            }

            return $"No es posible consignar valores negativos";
        }

        

        public override string Retirar(decimal valor)
        {
            if ((Saldo-valor)>=TOPE)
            {
                Saldo -= valor;
                RegistrarMovimientos(valor, "Retirar");
                return $"Se retiró el Valor {valor} su nuevo saldo es {Saldo}";
            }
            return $"Saldo Insuficiente. No es posible realizar el retiro su saldo es {Saldo}";
        }
    }
}
