using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity
{
    abstract public class Cuenta
    {
        public List<Movimiento> Movimientos { get; set; }
        public string Cliente { get; set; }
        public string Numero { get; set; }
        public string Tipo { get; set; }
        public decimal Saldo { get; set; }


        public Cuenta(decimal saldo)
        {
            Saldo = saldo;
            Movimientos = new List<Movimiento>();
         
        }


        public abstract string Consignar(decimal valor);
        public abstract string Retirar(decimal valor);

        public void RegistrarMovimientos(decimal valor, string tipo)
        {
            Movimiento movimiento = new Movimiento();
            movimiento.Tipo = tipo;
            movimiento.Fecha = DateTime.Now;
            movimiento.Saldo = Saldo;
            movimiento.Valor = valor;
            Movimientos.Add(movimiento);
        }
    }

}
