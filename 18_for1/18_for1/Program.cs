namespace _18_for1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1) imprimir los numeros del 1 al 10 de uno en uno
            //10 iteraciones
            for (int i = 1; i <= 10; i++)
                Console.WriteLine(i); //no use llaves porque solo repetire una instruc.
            //10 iteraciones
            for (int i = 1; i < 11; i++)
                Console.WriteLine(i);
            //10 iteraciones
            for (int i = 0; i < 10; i++)
                Console.WriteLine(i + 1);

            Console.WriteLine("******************************");
            //2) imprimir los numeros del 0 al 50 de dos en dos
            //26 iteraciones
            for (int i = 0; i <= 50; i += 2)
                Console.WriteLine(i);
            //51 iteraciones
            Console.WriteLine("******************************");
            for (int i = 0; i <= 50; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine(i); //imprime i solo si es par
            }
            //26 iteraciones
            Console.WriteLine("******************************");
            for (int i = 0; i <= 50; i = i + 2)
                Console.WriteLine(i);

            //3) imprimir los numeros del 0 al 50 de cinco en cinco
            //11 iteraciones
            Console.WriteLine("******************************");
            for (int i = 0; i <= 10; i++)
                Console.WriteLine(i * 5);
            //11 iteraciones
            Console.WriteLine("******************************");
            for (int i = 0; i <= 50; i += 5)
                Console.WriteLine(i);

            //4) recorrer los numeros del 1 al 50 pero solo imprima los pares
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0) Console.WriteLine(i);
            }

            //5) imprima los numeros de 1 a 100, coloque un asterisco a la derecha
            //   de aquellos numeros que son multiplos de 8
            //forma 1:
            Console.WriteLine("******************************");
            for (int i = 1; i <= 100; i++)
            {
                if(i%8 == 0)
                    Console.WriteLine(i+"*");
                else
                    Console.WriteLine(i);
            }
            //forma 2:
            Console.WriteLine("******************************");
            for (int i = 1; i <= 100; i++)
            {
                Console.Write(i);
                if (i % 8 == 0) Console.Write("*");
                Console.WriteLine();
            }

            //6) imprimir los numeros del 10 al 1, de forma descendente de uno en uno
            Console.WriteLine("******************************");
            for (int i = 10; i >= 1; i--)
                Console.WriteLine(i);

            Console.WriteLine("******************************");
            for( int i = 0; i < 10; i++ )
                Console.WriteLine(10-i);

            //7) imprimir los numeros del 10 al 0 de forma descendente de dos en dos
            Console.WriteLine("******************************");
            for( int i = 10; i >= 0; i -= 2 )
                Console.WriteLine(i);

            //8) imprimir los numeros del 100 al 0 de forma descendente de 10 en 10
            Console.WriteLine("******************************");
            for (int i = 100; i >= 0; i -= 10)
                Console.WriteLine(i);

            //La estructura de repericion for permite usar decimales en la variable de control
            //imprima los numeros de 0 a 10 en saltos de 0.25 ascendentemente
            Console.WriteLine("******************************");
            for( double i = 0; i <= 10; i += 0.25 )
                Console.WriteLine(i);
        }
    }
}
