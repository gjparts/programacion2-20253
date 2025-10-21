namespace _23_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que lea N cantidad de numeros positivos.
            La lectura de los numeros va a terminar cuando se digite
            un numero menor o igual a cero.
            Una vez termine de leer los numeros va a imprimir la suma
            de todos los numeros positivos leidos.
            Debe usar while o do-while.*/
            double n = 777; //variable temporal
            double suma = 0.00; //variable acumuladora

            //Usare while
            while( n > 0 )
            {
                Console.Write("Digite un numero positivo: ");
                n = double.Parse( Console.ReadLine() );
                if( n > 0 ) suma += n; //sumar solo positivos
            }
            Console.WriteLine($"Suma de los positivos: {suma}");
        }
    }
}
