namespace _13_if_or
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Operador logico OR
             Devuelve true si se cumple al menos una expresion de comparacion
            entre dos o mas expresiones.
            En C#, JAVA y C++ el operador OR se representa con dos barras ||
            El caracter barra se obtiene por medio de ALT+124
            ejemplo:
            Haga un programa que pregunte el mes y el año como numeros enteros.
            El programa va a imprimir la cantidad de dias que tiene el mes/año digitados.
            El mes debe de ser un numero entre 1 y 12 de lo contrario no se aceptará.*/
            try
            {
                int a, m;
                Console.Write("Digite un numero de mes: ");
                m = int.Parse(Console.ReadLine());
                Console.Write("Digite un año: ");
                a = int.Parse(Console.ReadLine());
                if( m >= 1 && m <= 12)
                {
                    if( m == 1 || m == 3 || m == 5 || m == 7 || m == 8 || m == 10 || m == 12  )
                        Console.WriteLine("El mes tiene 31 dias");
                    if (m == 4 || m == 6 || m == 9 || m == 11 )
                        Console.WriteLine("El mes tiene 30 dias");
                    if (m == 2)
                    {
                        if (a%4 == 0)
                            Console.WriteLine("El mes tiene 29 dias");
                        else
                            Console.WriteLine("El mes tiene 28 dias");
                    }
                }
                else
                    Console.WriteLine("El mes debe de estar entre 1 y 12");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Debe digitar solo numeros enteros");
            }
            
            
        }
    }
}
