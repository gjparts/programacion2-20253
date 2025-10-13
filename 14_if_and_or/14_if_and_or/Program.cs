namespace _14_if_and_or
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En una ferreteria se da un descuento del 10% a las
            personas con edades entre 18 y 24 ó entre 40 y 60.

            Pregunte el monto de lo vendido y la edad, y luego imprima
            el monto el descuento otorgado y el total a pagar.

            -> Resuelvalo utilizando operadores logicos (AND,OR)*/
            float venta, descuento = 0;
            int edad;
            Console.Write("Digite el monto de lo vendido: ");
            venta = float.Parse(Console.ReadLine());
            Console.Write("Digite la edad del cliente: ");
            edad = int.Parse(Console.ReadLine());

            if (edad >= 18 && edad <= 24 || edad >= 40 && edad <= 60)
                descuento = venta * 0.10f;

            Console.WriteLine($"Descuento: {descuento}");
            Console.WriteLine($"Total a pagar: {venta-descuento}");
        }
    }
}
