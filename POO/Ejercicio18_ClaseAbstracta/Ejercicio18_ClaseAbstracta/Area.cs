using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio18_ClaseAbstracta
{
    public abstract class Area
    {
        public abstract double CalcularArea();
    }

    public class Tringulo : Area { 
     public double Base {  get; set; }
        public double Altura {  get; set; }
        public Tringulo(double basee,double altura)
        {
            Base=basee;
            Altura=altura;

        }
        public override double CalcularArea() {
            return (Base * Altura) / 2;
        }
    }
    public class Reactangulo:Area
    {
        public double Base { get; set; }
        public double Altura { get; set; }
        public Reactangulo(double basee,double altura)
        {
            Base=basee;
            Altura=altura;
        }
        public override double CalcularArea()
        {
            return (Base * Altura);
        }

    }
    public class Cuadrado:Area
    {
        public double Lado { get; set; }
        public Cuadrado(double lado) 
        {
        Lado=lado;
        }
        public override double CalcularArea()
        {
            return Lado*Lado;
        }
    }
}
