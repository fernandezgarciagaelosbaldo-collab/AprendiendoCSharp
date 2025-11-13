using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10_ContadorObjetos
{
    public class Usuario
    {
        //Clase Usuario con campo estático para contar cuántos objetos se crean.
        public string Nombre;
        public int Edad;
        public static int contador;
        public Usuario(string nombre, int edad)
        {
            Nombre = nombre;
            Edad = edad;
            contador++;
        }
        public void mostrarcontador()
        {
            Console.WriteLine(contador);
        }


    }
}
