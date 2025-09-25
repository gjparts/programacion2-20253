namespace _02_Captura1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //coloque aqui el codigo propenso a fallar
                //Captura de valores usando la consola del sistema.
                int a, b;
                //ReadLine() es un metodo de Console que permite leer entradas desde la
                //consola del sistema, ReadLine() lee todo en tipo String (cadena de texto)
                //Para poder depositar este String en alguna variable de otro tipo
                //hay que convertirlo.
                Console.Write("Digite un numero entero: ");
                a = int.Parse( Console.ReadLine() );
                Console.Write("Digite otro numero entero: ");
                b = int.Parse(Console.ReadLine());

                Console.WriteLine($"La suma de ambos es {a+b}");
            }
            catch (Exception ex) {
                //lo que va a suceder en caso de falla
                Console.WriteLine("ERROR: Digite solo numeros enteros.");
                Console.WriteLine(ex.Message); //extraer mensaje de error original (OPCIONAL)
            }

            
        }
    }
}
