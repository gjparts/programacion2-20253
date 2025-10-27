namespace _27_Control_de_flujo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*INSTRUCCIONES DE CONTROL DE FLUJO
             Permiten alterar el flujo de las iteraciones en una estructura de repetición, son dos:
            1) continue: termina la iteracion actual y pasa a la siguiente
            2) break: termina con la estructura de repetición.*/

            //Ejemplo de continue
            /*Haga un programa que recorra los numeros del 1 al 100 usando
             una estructura de repeticion for. El programa debera imprimir todos
            aquellos numeros que no sean multiplos de 7.
            RETO: Resolverlo usando al menos una vez la instruccion continue.*/
            for( int i = 1; i <= 100; i++ )
            {
                if (i%7 == 0) continue; //si i es multiplo de 7 entonces saltamos de iteracion
                Console.WriteLine(i);
            }

            //Otro ejemplo
            /*Haga un programa que lea N cantidad de numeros enteros, solo va a sumar
             aquellos numeros que sean positivos.
            Si digita un numero negativo debera saltar esa iteracion.
            El programa termina cuando se digite CERO.
            Al final el programa debera imprimir la suma de los numeros positivos leidos.*/
            double numero, suma = 0;
            do
            {
                Console.Write("Digite un numero (Cero termina con el programa): ");
                numero = double.Parse(Console.ReadLine());
                if (numero < 0) continue; //si el numero leido es negativo se salta la iteracion actual
                suma += numero;
            } while (numero != 0);
            Console.WriteLine($"Suma: {suma}");
        }
    }
}
