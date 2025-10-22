namespace _26_for_anidado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructura anidada
             Es aquella donde hay una estructura dentro de otra.*/
            /*Ejemplo de for anidado:
             Haga un programa que pregunte al usuarios dos numeros enteros
             uno para el ancho y otro para el largo.
             Luego imprima un rectangulo hecho de asteriscos basados en el largo
             y ancho proporcionados.*/
            int alto, ancho;
            Console.Write("Alto: ");
            alto = int.Parse(Console.ReadLine());
            Console.Write("Ancho: ");
            ancho = int.Parse(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Yellow;
            for( int i = 1; i <= alto; i++) //estructura primaria
            {
                //se va a ejecutar una estructura secundaria por cada iteracion
                //en la estructura primaria
                for( int j = 1; j <= ancho; j++) //estructura secundaria
                {
                    Console.Write("*"); //imprimir asterisco sin pasar de renglon
                }
                Console.WriteLine(); //pasar a la linea siguiente
            }
        }
    }
}
