using _03_CuentaAhorro.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_CuentaAhorro
{
    public class CuentaAhorro
    {
        //Uso de PRIVATE SET
        //Propiedades
        public String NombreCliente { get; set; }
        public String NumeroCuenta { get; set; }
        public float Saldo { get; private set; }
        /*Importante: observe que en lugar de set pusimos private set, esto quiere
         decir que Saldo va a escribirse desde metodos set que nosotros vamos a crear
        dentro de la clase. Por lo tanto si va a usar private set ya no sera necesario
        crear un campo private para controlar lo que entra a Saldo.*/
        public TipoCuenta Tipo {  get; set; }
        //Constructores
        public CuentaAhorro(String nombreCliente, String numeroCuenta)
        {
            this.NombreCliente = nombreCliente;
            this.NumeroCuenta = numeroCuenta;
            this.Saldo = 0.00f;
            this.Tipo = TipoCuenta.Ahorro;
        }
        //Metodos
        public void Depositar(float monto)
        {
            if (monto < 0) throw new ArgumentException("Monto a depositar no debe ser negativo.");
            this.Saldo += monto;
        }
        public void Retirar(float monto)
        {
            if (monto < 0) throw new ArgumentException("Monto a retirar no debe ser negativo.");
            if( monto > this.Saldo ) throw new ArgumentException("Fondos insuficientes.");
            this.Saldo -= monto;
        }
        //Observe que no hubo necesidad de hacer campo privado para Saldo
    }
}
