using Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BancoUI
{
    class Program
    {
        static void Main(string[] args)
        {
            string mensaje;
            Cuenta cuentaAhorro = new CuentaAhorro(100000);

            mensaje = cuentaAhorro.Consignar(-200000);
            Console.WriteLine(mensaje);

            mensaje = cuentaAhorro.Consignar(100000);
            Console.WriteLine(mensaje);

            mensaje = cuentaAhorro.Retirar(190000);
            Console.WriteLine(mensaje);

            Cuenta cuentaCorriente = new CuentaCorriente(0);

            mensaje = cuentaCorriente.Consignar(100000);
            Console.WriteLine(mensaje);

            mensaje = cuentaCorriente.Retirar(30000);
            Console.WriteLine(mensaje);

            mensaje = cuentaCorriente.Retirar(50000);
            Console.WriteLine(mensaje);

            mensaje = cuentaCorriente.Consignar(30000);
            Console.WriteLine(mensaje);

            Console.ReadKey();
        }
    }
}
