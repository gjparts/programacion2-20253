namespace _40_String08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Método indexOf
             Devuelve un numero entero el cual indica la posicion en que se encontró la primera
            coincidencia para String dentro de otro.
            -> no ignora mayusculas/minusculas
            -> no altera al String
            -> si no encuentra nada devuelve -1
            -> Si encuentra algo devuelve un entero >= 0
            -> cuenta con un segundo parametro opcional para indicar a partir de donde
               vamos a comenzar nuestra busqueda.*/
            String str = "El carro es blanco con gris. El carro esta matriculado. El carro es caro.";
            Console.WriteLine(str);
            Console.WriteLine("Posiciones donde se encontraro lo siguiente:");
            Console.WriteLine($"gris: {str.IndexOf("gris")}");
            Console.WriteLine($"matric: {str.IndexOf("matric")}");
            Console.WriteLine($"llanta: {str.IndexOf("llanta")}");
            Console.WriteLine($"BLANCO: {str.IndexOf("BLANCO")}");
            Console.WriteLine($"BLANCO: (ignorando casing) {str.ToUpper().IndexOf("BLANCO")}");


        }
    }
}
