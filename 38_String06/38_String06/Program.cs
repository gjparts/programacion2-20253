namespace _38_String06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Metodo Replace
             Devuelve una version del String a la cual se le ha reemplazado
            todas las coincidencias encontradas.
            -> Este metodo NO ignora mayusculas/minusculas.*/
            String str = "Verde es la Manzana, la manzana es verde. Que verde es la manzana!";
            Console.WriteLine($"str: {str}");
            //reemplazar verde por roja SIN alterar al String original:
            Console.WriteLine( str.Replace("verde","roja") );

            Console.WriteLine($"str: {str}");
            //Si quiere afectar el String original, lo sobre-escribe:
            str = str.Replace("verde", "roja");
            Console.WriteLine($"str: {str}");


        }
    }
}
