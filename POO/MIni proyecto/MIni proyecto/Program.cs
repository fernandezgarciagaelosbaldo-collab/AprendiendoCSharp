using System.Security.Principal;

namespace MIni_proyecto
{
    internal class Program
    {
        static void Main(string[] args)
        {
         List<Proveedor> listprovedores = new List<Proveedor>();
            //comida
         List<Producto> productos1= new List<Producto>();
            productos1.Add(new(1,"Papa",23,100));
            productos1.Add(new(2,"Arroz",12,200));
            productos1.Add(new(3,"Pollo",200,1000));
            productos1.Add(new(4,"Aguacate",23,123));
            listprovedores.Add(new(1,"Gael",productos1));
       
            //utlies escolares
            List<Producto> productos2= new List<Producto>();
            productos2.Add(new(1,"Borrador",12,120));
            productos2.Add(new(2, "Lapiz", 30, 120));
            productos2.Add(new(3, "Pluma", 42, 120));
            productos2.Add(new(4, "Plumon", 42, 120));
            productos2.Add(new(5, "Lapicero", 34, 120));
            listprovedores.Add(new(2,"Alan",productos2));
            //productos de mercado libre
            List<Producto> productos3= new List<Producto>();
            productos3.Add(new(1, "celular", 6400, 20));
            productos3.Add(new(2, "tablet", 9400, 20));
            productos3.Add(new(1, "laptop", 16400, 20));
            productos3.Add(new(1, "televicion", 6400, 20));
            productos3.Add(new(1, "cuchillo de cocina", 400, 200));
            listprovedores.Add(new(3,"Alejandro",productos3));



            //Usuario
            Console.WriteLine("Quieres entrar como comprador , o como comprador de empresa?");
            string Rol=Convert.ToString(Console.ReadLine());
            if (Rol == "comprador")
            {
                while (true)
                {
                    Console.WriteLine("Mira estas son las opciones que puedes comprar");
                    foreach(Proveedor proveedor in listprovedores)
                    {
                        proveedor.MostrarProvedor();
                    }
                    Console.WriteLine("Perfecto elije el ID de el proveedor al que le quieres comprar");
                    int provedor=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine($"Perfecto ahora dime el ID de el producto {listprovedores[provedor-1]} ");
                    int producto=Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Perfecto , ahora cuanta cantidad quieres comprar ?");
                    int cantidad=Convert.ToInt32(Console.ReadLine()); 
                    listprovedores[provedor - 1].Productos[producto - 1].QuitarStock(cantidad);
                    listprovedores[provedor - 1].Productos[producto - 1].mostrarinfo();


                }

            }
            else 
            {
                if (Rol == "empresa")
                {
                    while (true) { 

                    }

                }
                else
                {
                    Console.WriteLine("Opcion no valida");
                }



            }
        }

    }
}
