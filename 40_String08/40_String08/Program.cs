using System.Text.RegularExpressions;

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

            /*IndexOf tiene una version que admite dos parametros:
             1) el primer parametro es lo que deseamos buscar
             2) el segundo parametro es a partir de que posicion vamos a empezar a buscar.
            Observe que carro esta tres veces dentro de str, vamos a obtener esas 3 posiciones.*/
            Console.WriteLine($"Primer coincidencia de carro: {str.IndexOf("carro",0)}");
            //se encontro carro en la posicion 3, mi siguiente busqueda va a ser a partir de la posicion 4:
            Console.WriteLine($"Segunda coincidencia de carro: {str.IndexOf("carro", 4)}");
            //se encontro carro en la posicion 32, mi siguiente busqueda va a ser a partir de la posicion 33:
            Console.WriteLine($"Tercer coincidencia de carro: {str.IndexOf("carro", 33)}");
            //se encontro carro en la posicion 59, mi siguiente busqueda va a ser a partir de la posicion 60:
            Console.WriteLine($"Cuarta coincidencia de carro: {str.IndexOf("carro", 60)}");

            //Algoritmo de busqueda por fuerza bruta
            String frutas = "manzana uva pera PERA MANZANA UVA kiwi toronja KIWI Manzana Uva";
            /*Haga un programa que le pregunta una fruta al usuario. El programa va a imprimir cuantas
             veces fue encontrada la fruta dentro del String llamado frutas.
            El programa debe ignorar mayusculas/minusculas. Ejemplo:
            Fruta a buscar: uva
            Veces que se ha encontrado: 3*/
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine(frutas);
            Console.Write("Fruta a buscar: ");
            String buscar = Console.ReadLine();
            int ultimaPosicion = 0; //variable bandera (flag)
            int contador = 0; //variable para contar coincidencias

            while( ultimaPosicion >= 0)
            {
                ultimaPosicion = frutas.ToLower().IndexOf(buscar.ToLower(),ultimaPosicion);
                //si ultimaPosicion es >= 0 significa que encontramos algo:
                if( ultimaPosicion >= 0)
                {
                    contador++; //suma 1 al contador
                    ultimaPosicion++; //sumar 1 a la ultima posicion para que continue la busqueda
                }
            }
            Console.WriteLine($"Veces que se ha encontrado: {contador}");

            //forma de buscar coincidencias en C# que es mas corta y facil, ademas de que permite
            //ignorar mayusculas y minusculas.
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine("Busqueda usando expresiones regulares:");
            int veces = Regex.Matches(frutas, buscar, RegexOptions.IgnoreCase).Count;
            Console.WriteLine($"Veces que se ha encontrado: {veces}");
        }
    }
}
