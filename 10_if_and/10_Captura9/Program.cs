namespace _10_Captura9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Operador Logico AND
            Hace obligatorio el cumlimiento de una o varias condiciones.
            En C, C++, C#, JAVA, Javascript, Dart se representa con un doble ampersand: &&
            Ejemplo:
            Solicite al usuario que digite los valores enteros para a,b,c.
            Si a es mayor a 7 Y b es menor a 12 Y c es igual a 11 entonces mostrará el
            mensaje: COMBINACION CORRECTA de lo contrario mostrar ACCESO NO VALIDO.
            -> Resolverlo usando operadores logicos*/
            int a, b, c;
            Console.Write("Digite a: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Digite b: ");
            b = int.Parse(Console.ReadLine());
            Console.Write("Digite c: ");
            c = int.Parse(Console.ReadLine());

            if (a > 7 && b < 12 && c == 11)
                Console.WriteLine("COMBINACION CORRECTA");
            else
                Console.WriteLine("ACCESO NO VALIDO");
        }
    }
}
