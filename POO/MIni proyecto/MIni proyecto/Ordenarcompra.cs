using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MIni_proyecto
{
    public class Ordenarcompra
    {
        Producto Productoo { get; set; }
        Proveedor Proveedoor { get; set; }
        public int Cantidad { get; set; }
        public DateTime Fecha { get; }

        public double Total
        {
            get
            {
                return Productoo.Precio * Cantidad;
            }
        }
        public Ordenarcompra(Producto p, Proveedor prov, int cantidad)
        {
            Productoo = p;
            Proveedoor = prov;
            Cantidad = cantidad;
            Fecha = DateTime.Now;
        }

        public void procesar()
        {
            Productoo.Agregarstock(Cantidad);
        }

        public void MostrarResumen()
        {
            Console.WriteLine(
                $"Compra realizada a {Proveedoor.NombreProveedor}: {Productoo.Nombre} x{Cantidad} " +
                $"| Total: ${Total} | Fecha: {Fecha}"
            );
        }

    }
}
