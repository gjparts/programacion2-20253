namespace _15_switch1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructura de seleccion switch
             Permite elegir el camino a seguir de acuerdo
             a la evaluacion del valor de una variable.
             en JAVA la variable debe de ser numero entero
             en C++ la variable puede ser entero o char
             en C# (con .Net Core) y Javascript la varible puede ser de cualquier tipo*/

            /*Haga un programa que solicite digitar mes y año como numeros enteros
             El programa va a imprimir los dias que tiene el mes/año digitados.
            -> mes solo acepta numeros entre 1 y 12.*/
            int m, a;
            Console.Write("Digite el numero de mes: ");
            m = int.Parse(Console.ReadLine());
            Console.Write("Digite el numero de año: ");
            a = int.Parse(Console.ReadLine());

            switch (m)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12:
                    Console.WriteLine("31 dias");
                break; ///////////////////////////////////////////////////
                case 4:
                case 6:
                case 9:
                case 11:
                    Console.WriteLine("30 dias");
                break; ///////////////////////////////////////////////////
                case 2:
                    if (a % 4 == 0)
                        Console.WriteLine("29 dias");
                    else
                        Console.WriteLine("28 dias");
                break;
                default:
                    Console.WriteLine("Mes no valido");
                break; ///////////////////////////////////////////////////
            }
        }
    }
}
