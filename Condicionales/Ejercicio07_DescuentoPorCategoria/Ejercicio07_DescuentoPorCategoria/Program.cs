namespace Ejercicio07_DescuentoPorCategoria
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Pedir categoría (A, B o C) y aplicar un descuento distinto (A=15%, B=10%, C=5%).
            Console.Write("Ingresa la categoria :");
            string categoria =Console.ReadLine();
            if (categoria == "A")
            {
                Console.WriteLine("Elegiste la categoria A y tienes un descuento de" + " 15%");
            }
            else if (categoria == "B")
            {
                Console.WriteLine("Elegiste la categoria B y tienes un descuento de" + " 10%");
            }
            else if (categoria == "C")
            {
                Console.WriteLine("Elegiste la categoria C y tienes un descuento de " + "5%");
            }
            else {
                Console.WriteLine("Categoria invalida");
            }


        }
    }
}
