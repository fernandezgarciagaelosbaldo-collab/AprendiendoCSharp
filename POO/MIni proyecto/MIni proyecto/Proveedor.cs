using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIni_proyecto
{
  public class Proveedor
    {
        public int ID {  get; set; }
        public string NombreProveedor { get; set; }
        public List<Producto> Productos { get; set; }
        public Proveedor(int id ,string nombre,List<Producto>productos) {
            ID = id;
            NombreProveedor = nombre;
            Productos = productos;
        }
        public void AgregarProductos(Producto producto) {
            bool repetido = false;
            foreach (Producto p in Productos) {
                if (p.ID == producto.ID)
                {
                    repetido = true;
                }
            }
            if (repetido == false)
            {
                Productos.Add(producto);
            }
            else
            {
                Console.WriteLine("Ese producto ya existe");
            }
        }
        public  void MostrarProvedor() 
        {
            Console.WriteLine( $"[{ID}]|Provedor{NombreProveedor}");
            foreach (Producto p in Productos)
            {
                p.mostrarinfo();
            }

        }
    }
}
