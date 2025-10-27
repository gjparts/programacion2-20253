namespace _28_Control_de_flujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*ejemplo de uso de break
             Termina con la estructura de repetición.
             Haga una estructura de repeticion for que lea 50 numeros long positivos.
            ->Si durante la digitacion se ingresa un numero negativo; entonces debera
              terminar con la lectura de los numeros.
            ->al finalizar debe mostrar la suma de los numeros positivos leidos.
             */
            long numero, suma = 0;
            for( int i = 1; i <= 50; i++)
            {
                Console.Write("Digite un numero entero positivo:");
                numero = long.Parse(Console.ReadLine());
                if (numero < 0) break; //terminar con la estructura for
                suma += numero;
            }
            Console.WriteLine($"La suma de los numeros positivos es: {suma}");
        }
    }
}
