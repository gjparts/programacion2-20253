namespace _07_Captura6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se da un descuento por venta, se captura el monto de la venta.
            Si la venta es mayor o igual a 2000 se da un 10% de descuento
            Si la venta es mayor o igual a 5000 se da un 20% de descuento
            Si la venta es mayor o igual a 10000 se da un 30% de descuento
            Si la venta es mayor o igual a 20000 se da un 50% de descuento
            Hacer un programa que imprima el valor del descuento y el valor a pagar*/

            //El problema se puede resolver de varias formas
            //Forma 1: estructurar el problema por medio de if-else
            float venta, descuento;
            Console.Write("Digite el monto de la venta: ");
            venta = float.Parse(Console.ReadLine());

            //cuando decide resolverlo usando una estructura if-else debe comenzar por evaluar desde el mayor hasta el menor
            if (venta >= 20000)
                descuento = venta * 0.50f;
            else
                if (venta >= 10000)
                    descuento = venta * 0.30f;
                else
                    if (venta >= 5000)
                        descuento = venta * 0.20f;
                    else
                        if (venta >= 2000)
                            descuento = venta * 0.10f;
                        else
                            descuento = 0;

            Console.WriteLine($"El descuento es: {descuento}");
            Console.WriteLine($"El valor a pagar es: {venta-descuento}");
        }
    }
}
