namespace _06_Captura5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En una tienda se da un descuento de acuerdo al monto vendido.
            Si el monto es mayor que 10000 entonces damos un descuento del 20% sobre
            el valor de la venta de lo contrario no damos descuento.
            Capturar el monto vendido e imprimir el valor del descuento y el valor final a pagar.
            ejemplos:
            Digitar monto vendido: 15000
            El descuento es: 3000
            El valor a pagar es: 12000

            otro ejemplo:
            Digitar monto vendido: 10000
            El descuento es: 0
            El valor a pagar es: 10000

            otro ejemplo:
            Digitar monto vendido: 5000
            El descuento es: 0
            El valor a pagar es: 5000*/
            try
            {
                //Hay muchas formas de resolver este problema, yo usare solo una de ellas
                float venta, descuento = 0, pagar;

                Console.Write("Digitar monto vendido: ");
                venta = float.Parse(Console.ReadLine());

                //como solo es una instruccion la que he condicionado
                //entonces se puede quedar en el mismo
                //renglon de if (c++, c#, JAVA, Javascript, dart, PHP)
                if (venta > 10000) descuento = venta * 0.20f;
                
                pagar = venta - descuento;

                Console.WriteLine($"El descuento es: {descuento}");
                Console.WriteLine($"El valor a pagar es: {pagar}");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Solo se admite valores numericos");
            }            
        }
    }
}
