using System.Text.RegularExpressions;

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

            //los replace se pueden ejecutar en cascada o en cadena en una sola instruccion
            String str2 = "La sandia es una gran fruta, el jugo de sandia es mejor que el de noni.";
            //reemplazar sandia por naranja y noni por anona afectando al String original
            str2 = str2.Replace("sandia", "naranja").Replace("noni","anona");
            Console.WriteLine(str2);

            //reemplazar en un String ignorando mayusculas/minusculas en la busqueda
            //sin necesidad de usar ToUpper ó ToLower.
            String str3 = "Rojo ROJO ROjo RoJo VERDE verde Verde VeRdE AZUL azul AzuL azUL AZul";
            //reemplazar verde por amarillo en str3, ignorando mayusculas y minusculas y alterando
            //el string original.
            //para ello vamos usar una clase conocida como Regex que permite realizar operaciones
            //por medio de expresiones regulares ahorrandonos la complejidad de dichas expresiones.
            //para poder usar Regex debera importar el paquete System.Text.RegularExpressions.
            //dicha importancion se hace en las primeras lineas de este archivo.
            str3 = Regex.Replace(str3, "verde", "amarillo", RegexOptions.IgnoreCase);
            Console.WriteLine(str3);

            //hacer una pausa
            Console.WriteLine("Pausa...");
            Console.ReadKey(true);

            //Limpiar la pantalla
            Console.Clear();

            /*Pregunte un String al usuario y dentro de dicho String el programa va a reemplazar
             todos los espacios en blanco por guiones bajos, todas las letras A por 4 y todas las
            letras E por 3 y todas las letras I por 1. Alterando sl String original. Ignorando
            mayusculas/minusculas.*/
            //forma 1:
            Console.Write("Digite un String:");
            String x = Console.ReadLine();
            
            x = Regex.Replace(Regex.Replace(Regex.Replace(Regex.Replace(x, " ", "_"), "A", "4", RegexOptions.IgnoreCase), "E", "3", RegexOptions.IgnoreCase), "I", "1", RegexOptions.IgnoreCase);
            Console.WriteLine(x);

            //forma 2:
            Console.Write("Digite un String:");
            x = Console.ReadLine();

            x = x.Replace(" ", "_");
            x = Regex.Replace(x, "A", "4", RegexOptions.IgnoreCase);
            x = Regex.Replace(x, "E", "3", RegexOptions.IgnoreCase);
            x = Regex.Replace(x, "I", "1", RegexOptions.IgnoreCase);
            Console.WriteLine(x);
        }
    }
}
