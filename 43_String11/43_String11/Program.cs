namespace _43_String11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Método Split
            Devuelve un arraeglo de elementos String el cual es el resultado de dividir en partes
            a otro String utilizando como separador a un String conocido como Token.*/
            String str = "rojo,verde,azul,blanco,negro,gris,amarillo";
            String[] arr1; //arreglo de destino (sin inicializar)

            arr1 = str.Split(",");
            //recorrer e imprimir el arreglo:
            for( int i = 0; i < arr1.Length; i++ )
                Console.WriteLine(arr1[i] );

            Console.WriteLine("-------------------------------------------------------");
            str = "ToyotaSEPARADORCorollaSEPARADOR2012SEPARADORAzulSEPARADORImportado";
            String[] arr2 = str.Split("SEPARADOR");

            for (int i = 0; i < arr2.Length; i++)
                Console.WriteLine(arr2[i]);

            Console.WriteLine("-------------------------------------------------------");
            //Si desea utilizar caracteres de escape \ como separador debera ponerlo dos veces
            str = "fresa\\naranja\\mandarina\\sandia";
            String[] arr3 = str.Split("\\");

            for (int i = 0; i < arr3.Length; i++)
                Console.WriteLine(arr3[i]);

            /*Uso del segundo parametro con el modificador: RemoveEmptyEntries
            Ejemplo:
            Haga un programa que pregunte un String al usuario, el programa debe decir
            cuantas palabras tiene dicho String.*/
            Console.Write("Digite un String: ");
            str = Console.ReadLine();

            //String[] arr4 = str.Split(" "); //si usa este split va a tener problemas con multiples espacios vacios
            String[] arr4 = str.Split(" ",StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine($"Número de palabras: {arr4.Length}");

            //forma 2: sin tener que declarar un arreglo:
            Console.WriteLine($"Número de palabras: {str.Split(" ", StringSplitOptions.RemoveEmptyEntries).Length}");
        }
    }
}
