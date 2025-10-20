namespace _21_for4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que pida 5 numeros al usuario,
            al finalizar muestre el promedio de esos numeros,
            cuantos fueron pares, cuantos fueron impares,
            cual es el menor y cual es el mayor.
            -> Debe funcionar con positivos y negativos.*/
            try
            {
                int n; //variable temporal para leer numeros
                int suma = 0; //variable acumulador
                int pares = 0, impares = 0; //variables contador
                int mayor = int.MinValue, menor = int.MaxValue;

                for (int i = 1; i <= 5; i++)
                {
                    Console.Write("Digite un numero entero: ");
                    n = int.Parse(Console.ReadLine());

                    suma += n;
                    if (n % 2 == 0)
                        pares++;
                    else
                        impares++;

                    if (n > mayor) mayor = n;
                    if (n < menor) menor = n;
                }
                Console.WriteLine($"El promedio es: {suma/5.0}");
                Console.WriteLine($"Pares: {pares}");
                Console.WriteLine($"Impares: {impares}");
                Console.WriteLine($"Mayor: {mayor}");
                Console.WriteLine($"Menor: {menor}");
            }
            catch (Exception)
            {
                Console.WriteLine("Debe digitar solo numeros enteros.");
            }
        }
    }
}
