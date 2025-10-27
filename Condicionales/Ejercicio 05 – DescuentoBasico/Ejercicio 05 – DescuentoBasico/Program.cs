namespace Ejercicio_05___DescuentoBasico
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Pide el monto total de una compra.
            Si el total supera $100, aplica un 10% de descuento y muestra el nuevo total.
            Si no, muestra el mismo total sin descuento.*/
            Console.Write("Ingresa el monto total de tu compra :");
            double compra = Convert.ToDouble(Console.ReadLine());
            double total;
            if (compra > 100)
            {
                total = compra - (compra * 0.1);
                Console.WriteLine("La compro fue de " + compra + " pero tuvo el descuento de %10 y el precio final es $" + total);


            }
            else {

                Console.WriteLine("no tienes descuento y te costara $" + compra);
            }
        }
    }
}
