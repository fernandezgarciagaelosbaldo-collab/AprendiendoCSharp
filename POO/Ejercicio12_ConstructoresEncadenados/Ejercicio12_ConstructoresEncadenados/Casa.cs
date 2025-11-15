using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio12_ConstructoresEncadenados
{
    public class Casa
    {
        public string Color {  get; set; }
        public int Numero { get; set; }
        public double Valor {  get; set; }
        public string Dueno { get; set; } 
        public Casa(string dueno,string color ,int numero, double valor ) {
         Dueno = dueno;
            Color = color;
            Numero = numero;
            Valor = valor;
        }
        public Casa(string dueno,string color,int numero):this(dueno,color,numero,1000000) {
        }
        public Casa(string dueno, string color) : this(dueno, color, 123)
        {
        }
        public Casa(string dueno):this(dueno,"Rojo") { }
        public Casa():this("Gael") { }
        public void Mostrar()
        {
            Console.WriteLine($"Dueño: {Dueno}, Color: {Color}, Número: {Numero}, Valor: {Valor}");
        }

    }
}
