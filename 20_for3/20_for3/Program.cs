namespace _20_for3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que pida al usuario digitar 10 numeros,
            al finalizar el programa imprimira la suma de
            esos 10 numeros, asi como cual es el mayor de los 10 numeros.

            -> el programa debe funcionar tambien con negativos.
            -> resolverlo usando la estructura de repeticion for*/

            double n; //variable temporal para leer numeros
            double suma = 0; //variable acumulador para sumar numeros
            double mayor = 111122342344;    //aqui no importa el valor de inicio ya que
                                            //mayor sera inicializado en la primera iteracion

            for (int i = 1; i <= 10; i++)
            {
                Console.Write("Digite un numero: ");
                n = double.Parse(Console.ReadLine());

                //si estamos en la primera iteracion, n sera el primer valor
                //para inicializar a mayor
                if (i == 1) mayor = n;

                suma += n;

                //si el numero leido supera al numero mas grande leido pues el nuevo mayor es ese numero
                if (n > mayor) mayor = n;
            }
            Console.WriteLine($"Suma de numeros: {suma}");
            Console.WriteLine($"El mayor es: {mayor}");
        }
    }
}
