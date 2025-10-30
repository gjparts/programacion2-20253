namespace _33_String01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*String (cadena de texto)
            Es una coleccion de elementos char.
            -> en C# es una clase sobre la que creamos objetos.
            -> en C# es un tipo de dato nativo por lo que no necesitamos importar algun paquete.
               Puesto que viene en el paquete conocido como System que ya viene implementado.*/

            //Declarar de objeto String:
            String str1;
            //String es una clase auto-instanciable, porque no necesita de new para crear un nuevo objeto.
            //Importante: si declara un String y no le asigna valor; entonces no se puede usar.
            //Console.WriteLine(str1);

            str1 = "UNAH";
            Console.WriteLine(str1);

            //tambien se puede inicializar en la declaracion:
            String str2 = "San Pedro Sula";
            String str3 = "Honduras", str4 = "Centro America", str5 = "";

            //en C# el tipo de dato String tiene un alias conocido como string
            //esto se hace para mantener la compatibilidad con programas hechos
            //hace mas de 10 años.
            string str6 = "Pollo frito";

            //Concatenar String
            String cadena1 = "Naranja";
            String cadena2 = "Verde";
            //forma 1: por suma de String
            String cadena3 = cadena1 + " " + cadena2;
            Console.WriteLine(cadena3);

            //forma 2: por interpolación
            String cadena4 = $"{cadena1} {cadena2}";
            Console.WriteLine(cadena4);

            //Se puede almacenar numeros en un String?
            //de forma tradicional no se puede:
            //String s1 = 6;
            //usando la ley de precedencia de operadores:
            //concatenele antes del numero, un String en blanco.
            String s1 = "" + 6;
            String s2 = "" + 3.1416;
            String s3 = "" + 2.25f;
            String s4 = "" + 1401198201055L;

            //conocer la longitud de un String
            String s5 = "Ingenieria en Sistemas";
            Console.WriteLine(s5);
            Console.WriteLine($"Longitud de s5: {s5.Length}");

            //cada caracter en un String puede ser accedido algo similar
            //a como se hace en los Array; pero recuerde que un String no es un Array
            //los char dentro de un String se numeran de 0 a Lenght-1 (Zero Indexing)
            //ejemplo:
            String pais = "Honduras";
            Console.WriteLine(pais);
            Console.WriteLine($"Caracter en la posicion 5: {pais[5]}");
            Console.WriteLine($"Caracter en la primer posicion: {pais[0]}");
            Console.WriteLine($"Ultimo caracter: {pais[7]}");
            Console.WriteLine($"Ultimo caracter usando Length: {pais[pais.Length-1]}");
            Console.WriteLine($"Penultimo caracter: {pais[pais.Length - 2]}");

            String comida = "Baleadas";
            //haga un programa que imprima cada caracter del string comida en un renglon diferente.
            for ( int i = 0; i < comida.Length; i++)
            {
                Console.WriteLine(comida[i]);
            }
        }
    }
}
