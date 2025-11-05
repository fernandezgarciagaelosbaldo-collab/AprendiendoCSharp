using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio06_Control_de_propiedades
{
    public class CuentaBancaria
    {
        /*Un campo privado saldo.
         Una propiedad pública Saldo que:
         Solo permita modificar el saldo si el nuevo valor es mayor o igual que 0.
         Si intentan poner un valor negativo, simplemente no cambia y muestra un mensaje de advertencia.
         Un método público Depositar(double cantidad) que aumente el saldo si cantidad > 0.
         Un método público Retirar(double cantidad) que reste del saldo si hay suficiente dinero.*/
        private double saldo;
        public double Saldo { get { return saldo; } private set { if (value >= 0) { saldo = value; } 
                else { Console.WriteLine("No la puedes cambiar por nuemeros negativos"); } } }

        public void  Depositar (double cantidad) {
            if (cantidad > 0)
            {
                saldo += cantidad;
            }
            else { Console.WriteLine("No puedes depositar numeros negativos"); }
        }
        public void Retirar(double cantidad)
        {
            if (cantidad < saldo)
            {
                saldo -= cantidad;

            }
            else { Console.WriteLine("No tienes suficientes fondos"); }
        }
    }
}
