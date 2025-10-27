namespace _29_Control_de_flujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que tenga una estructura while infinita,
             esta estructura en cada iteracion va a preguntar al usuario
            un numero entero.
            En cada iteracion tambien se va a generar un numero secreto.
            El numero secreto va a ser un entero entre 1 y 10
            El objetivo es que el usuario adivine el numero secreto, si lo adivina
            entonces la estructura de repeticion se va a terminar por medio de break
            y van a imprimir en mensaje: Has logrado escapar.*/
            
            Random r = new Random();
            int numero, secreto;

            while (true)
            {
                try
                {
                    secreto = r.Next(1, 11);
                    Console.Write("Adivine un numero entre 1 y 10 para poder escapar: ");
                    numero = int.Parse(Console.ReadLine());
                    if (numero == secreto) break; //termina la estructura de repeticion
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite solo numeros enteros.");
                }
            }
            Console.WriteLine("Has logrado escapar");
        }
    }
}
