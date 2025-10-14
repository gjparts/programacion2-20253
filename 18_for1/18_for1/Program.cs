namespace _18_for1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) imprimir los numeros del 1 al 10 de uno en uno
            //10 iteraciones
            for( int i = 1; i <= 10; i++ )
                Console.WriteLine(i); //no use llaves porque solo repetire una instruc.
            //10 iteraciones
            for (int i = 1; i < 11; i++)
                Console.WriteLine(i);
            //10 iteraciones
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i+1);

            Console.WriteLine("******************************");
            //2) imprimir los numeros del 0 al 50 de dos en dos
            //26 iteraciones
            for (int i = 0; i <= 50; i+=2)
                Console.WriteLine(i);
            //51 iteraciones
            Console.WriteLine("******************************");
            for (int i = 0; i <= 50; i++)
            {
                if(i%2 == 0)
                    Console.WriteLine(i); //imprime i solo si es par
            }
            //26 iteraciones
            Console.WriteLine("******************************");
            for (int i = 0; i <= 50; i = i+2)
                Console.WriteLine(i);

            //3) imprimir los numeros del 0 al 50 de cinco en cinco
            //11 iteraciones
            Console.WriteLine("******************************");
            for (int i = 0; i <= 10; i++)
                Console.WriteLine(i*5);
            //11 iteraciones
            Console.WriteLine("******************************");
            for(int i = 0; i <= 50;i+=5)
                Console.WriteLine(i);


        }
    }
}
