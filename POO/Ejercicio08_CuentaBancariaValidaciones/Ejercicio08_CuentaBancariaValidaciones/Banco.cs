using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio08_CuentaBancariaValidaciones
{
    //Ampliar CuentaBancaria: agregar Depositar, Retirar, y mostrar mensajes de error si no hay saldo.
    class cuentaBancaria
    {
        private double montoTotal=0;
        public double MontoTotal
        {
            get { return montoTotal; }
             private set
            {
                if (value >= 0) { montoTotal = value; }
                else { Console.WriteLine("el numero no puede ser 0 "); }
            }
        }
        public void Depositar(double Monto) {
           
            MontoTotal += Monto;
            Console.WriteLine($"Listo se agregaron {Monto} y ahora tienes un total de {MontoTotal}");
        }
        public void Retirar(double Retirar)
        {
            if (MontoTotal >= Retirar) {
                MontoTotal -= Retirar;
                Console.WriteLine("Perfecto , ahora solo tienes " + MontoTotal+" pesos");
            }
            else { Console.WriteLine("No tienes suficientes fondos en la cuenta "); }
        }
        
    }
}