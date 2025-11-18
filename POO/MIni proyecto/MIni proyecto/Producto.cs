using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIni_proyecto
{
    public class Producto
    {
        public int ID { get; set; }
        public string Nombre { get; set; }
        public double Precio { get; set; }
        private int _stock;
        public int Stock
        {
            get { return _stock; }
            set { if (value > 0) { _stock = value; } 
            }
        }
        public Producto(int id,string nombre,double precio,int stock) {
            ID = id;
            Nombre = nombre;
            Precio = precio;
            Stock = stock;
        }
        public void Agregarstock(int cantidad)
        {
            if (cantidad > 0)
            {
                Stock = Stock+ cantidad;
            }
            else
            {
                Console.WriteLine("No se pueden agregar cantidades menores o iguales a 0");
            }

        }
        public void QuitarStock(int cantidad) 
        {
            if (cantidad > 0) {

                if (Stock >= cantidad && cantidad > 0)
                {
                    Stock = Stock - cantidad;
                }
                else
                {
                    Console.WriteLine("No tienes suficiente Stock");
                }
            }
            else
            {
                Console.WriteLine("No puedes ingresar cantidades menores o iguales a 0");
                   
             }
        }
        public void mostrarinfo()
        {
            Console.WriteLine($"ID [{ID}]| {Nombre} : , ${Precio} y en stock tenemos {Stock}");
        }
    }
}
