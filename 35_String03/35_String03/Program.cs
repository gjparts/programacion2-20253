namespace _35_String03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Comparar dos String
            String a, b;
            Console.Write("Digite String a: ");
            a = Console.ReadLine();
            Console.Write("Digite String b: ");
            b = Console.ReadLine();

            if( a == b )
                Console.WriteLine("a y b son iguales");
            else
                Console.WriteLine("a y b NO son iguales");

            //comparar con == dos String no ignora mayusculas/minusculas
            //como podemos comparar con == ignorando mayusculas/minusculas?
            if( a.ToUpper() == b.ToUpper() )
                Console.WriteLine("a y b son iguales ignorando el casing");
            else
                Console.WriteLine("a y b NO son iguales");
        }
    }
}
