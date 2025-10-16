namespace _19_for2
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
            double mayor = double.MinValue; //variable bandera (flag) va cambiando de acuerdo al flujo del programa
            //observe que la inicializamos con el valor mas pequeño soportado por double para
            //que cualquier valor leido le supere
            //no lo inicialice en CERO porque los negativos siempre son menores a cero.

            for( int i = 1; i <= 10; i++)
            {
                Console.Write("Digite un numero: ");
                n = double.Parse(Console.ReadLine());
                suma += n;

                //si el numero leido supera al numero mas grande leido pues el nuevo mayor es ese numero
                if (n > mayor) mayor = n;
            }
            Console.WriteLine($"Suma de numeros: {suma}");
            Console.WriteLine($"El mayor es: {mayor}");
        }
    }
}
