namespace _04_Captura3
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
                a = Double.Parse(Console.ReadLine());
                Console.Write("Digite b: ");
                b = Double.Parse(Console.ReadLine());
                Console.Write("Digite c: ");
                c = Double.Parse(Console.ReadLine());

                //Validacion: Si a es CERO
                if( a == 0)
                {
                    Console.WriteLine("a no puede ser cero.");
                    return; //termina el metodo o funcion actual
                }
                
                //yo lo voy a hacer por partes
                double discriminante, x1, x2;
                discriminante = Math.Pow(b, 2) - 4 * a * c;

                //Validacion: Si discriminante es negativo
                if( discriminante < 0)
                {
                    Console.WriteLine("discriminante negativo, revise sus valores.");
                    return; //termina el metodo o funcion actual
                }

                x1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                x2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
                Console.WriteLine($"x1: {Math.Round(x1, 4)}");
                Console.WriteLine($"x2: {Math.Round(x2, 4)}");
            }
			catch (Exception ex)
			{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Debe digitar solo numeros");
			}
        }
    }
}
