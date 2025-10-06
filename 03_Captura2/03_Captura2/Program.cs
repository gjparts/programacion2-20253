namespace _03_Captura2
{
    internal class Program
    {
        static void Main(string[] args)
        {
			try
			{
                //Codigo que puede salir mal
                double a, b, c;
                Console.Write("Digite a: ");
                a = Double.Parse( Console.ReadLine() );
                Console.Write("Digite b: ");
                b = Double.Parse(Console.ReadLine());
                Console.Write("Digite c: ");
                c = Double.Parse(Console.ReadLine());
                //siempre hay mas de una forma de hacer un programa
                //Forma 1: hacer el calculo directamente a la hora de imprimir
                Console.WriteLine($"El resultado es {(a+b)/(a-c)}");
                //Forma 2: resolverlo por partes
                double numerador = a + b, denominador = a - c;
                Console.WriteLine($"El resultado es {numerador/denominador}");
                //Forma 3: guardar la solucion en una variable
                double resultado = numerador / denominador;
                Console.WriteLine($"El resultado es {resultado}");
                //Forma 4: resolver todo y almacenarlo en una variable
                double r = (a + b) / (a - c);
                Console.WriteLine($"El resultado es {r}");
            }
            catch (Exception ex)
			{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Debe digitar solo numeros");
			}
        }
    }
}
