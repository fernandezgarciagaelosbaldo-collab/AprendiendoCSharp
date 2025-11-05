using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1Ejercicio_07_EncapsulamientoNivelJugador
{
    public class Jugador
    {
        /*Tenga un campo privado nivel (int).
        Una propiedad pública Nivel que:
        Solo permita valores entre 1 y 100.
        Si el valor no está en ese rango, no lo cambia y muestra un mensaje de error.
        Un método SubirNivel(int cantidad) que aumente el nivel (sin pasarse de 100).
        Un método MostrarInfo() que muestre el nombre y nivel actual.*/
        private int nivel;
        public int Nivel
        {
            get { return nivel; }
            private set
            {
                if (value > 0 && value <= 100) { nivel = value; }
                else { Console.WriteLine("El numero esta fuera de rango"); }
            }
        }
        public void SubirNivel(int cantidad)
        {
            if (Nivel + cantidad <= 100)
            {
                Nivel += cantidad;
            }
            else {
                Console.WriteLine("Te pasaste de el limite ");
            }

        }
        public void MostrarInfo()
        {
            Console.WriteLine("Hola Gael eres nivel "+Nivel);
        }
    }
}
