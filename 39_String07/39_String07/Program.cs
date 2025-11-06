namespace _39_String07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Método Contains
             Indica si un String ha sido encontrado dentro de otro String
            -> no altera nada porque solo busca
            -> no ignora mayusculas/minusculas
            -> no devuelve en que posicion se encontro sino que solo devuelve
            true o false para indicar que fue encontrado.*/
            String str = "Hay una roca junto a la PALMERA que esta a la orilla del mar.";
            Console.WriteLine(str); 
            Console.WriteLine($"str contiene la palabra mar? {str.Contains("mar")}");
            Console.WriteLine($"str contiene la palabra ocenano? {str.Contains("ocenano")}");
            Console.WriteLine($"str contiene la palabra palmera? {str.Contains("palmera")}");
            Console.WriteLine($"str contiene la palabra palmera ignorando casing? {str.ToLower().Contains("palmera")}");

            /*Haga un programa que pregunte un String, el programa va a buscar dicho String
             dentro de str ignorando mayusculas/minusculas.
            Si encuentra algo que muestre el mensaje: TEXTO ENCONTRADO de lo contrario pues que
            muestre el mensaje TEXTO NO ENCONTRADO.*/
            Console.Write("Digite el String a buscar: ");
            String buscar = Console.ReadLine();

            if (str.ToUpper().Contains(buscar.ToUpper()) == true)
                Console.WriteLine("TEXTO ENCONTRADO");
            else
                Console.WriteLine("TEXTO NO ENCONTRADO");
        }
    }
}
