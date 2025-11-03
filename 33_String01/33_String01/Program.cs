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

            //en C#: cada caracter en un String puede ser accedido algo similar
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

            //en C#, no es posible modificar un char dentro de un String usando []
            //esto se debe a que en C# lo char en cada String son inmutables.
            //comida[1] = 'X';

            //Transformaciones de String
            /*Obtener la version en mayusculas ó en minusculas de un String*/
            String ciudad = "San Pedro Sula";
            Console.WriteLine($"ciudad en mayusculas: {ciudad.ToUpper()}");
            Console.WriteLine($"ciudad en minusculas: {ciudad.ToLower()}");
            Console.WriteLine($"ciudad, String original: {ciudad}");
            //ToUpper y ToLower son metodos que no alterar el String original sino que
            //devuelven un String que es una version en mayusc./minusc. del String original

            //Si desea alterar el String original; entonces lo que debe hacer es sobre escribir
            //la variable con su version en mayusculas ó en minusculas:
            ciudad = ciudad.ToUpper();
            Console.WriteLine($"ciudad, String original: {ciudad}");

            ciudad = ciudad.ToLower();
            Console.WriteLine($"ciudad, String original: {ciudad}");

            /*método Trim
            develve una versión del String; pero sin los espacios iniciales y finales que tambien
            les conocemos como espacios de relleno.
            -> Este metodo no afecta al String original.*/
            String juguete = "         Figura de Accion                   ";
            Console.WriteLine($"juguete, String original: {juguete}.");
            Console.WriteLine($"Longitud de juguete: {juguete.Length}");
            //impresion aplicando Trim
            Console.WriteLine($"juguete, aplicando Trim: {juguete.Trim()}.");
            Console.WriteLine($"Longitud de juguete: {juguete.Trim().Length}");
            //habrá afectado al String original?
            Console.WriteLine($"juguete, String original: {juguete}.");
            //si quiere que Trim afecte al String original:
            juguete = juguete.Trim();
            Console.WriteLine($"juguete, String original: {juguete}.");

            String platillo = "      Pizza Super Suprema            ";
            /*Ejerjcio: imprima la variable platillo; pero sin relleno de espacios toda en mayusculas
             y sin alterar a la variable original usando una sola instruccion.*/
            Console.WriteLine(platillo.ToUpper().Trim()); //forma 1
            Console.WriteLine(platillo.Trim().ToUpper()); //forma 2

            //Concatenar valores char a un String
            String carro = "Honda CRV 2016";
            //concatenar char sin afectar la variable original
            Console.WriteLine(carro+'X');
            Console.WriteLine($"carro, String original: {carro}");
            //concatenar char afectando la variable original:
            carro = carro + 'X';
            Console.WriteLine($"carro, String original: {carro}");

            //concatenar varios char a un String afectando al original
            String cliente = "Filomeno Colinas";
            cliente = cliente + 'A' + 'B' + 'C';
            Console.WriteLine($"cliente (original): {cliente}");

            //pero si va a concatenar varios char, sigue siendo mas practico concantenar
            //un String con esos char.
            String estudiante = "Estebancito Maravilla";
            estudiante = estudiante + "ABC";
            Console.WriteLine($"estudiante (original): {estudiante}");

            //hay situaciones donde puede tener un char en una variable separada:
            char equis = 'X';
            String proveedor = "Kurco Bain";
            proveedor = proveedor + equis;
            Console.WriteLine($"proveedor (proveedor): {proveedor}");

            //Que no se recomienda hacer!!!!
            String mascota = "Firulais";
            mascota += 'Z'; //eso si se puede, es lo mismo que decir: mascota = mascota + 'Z'
            Console.WriteLine($"mascota: {mascota}");

            //no concatener varios char usando el operador de incremento:
            String fruta = "Sandia";
            fruta += 'Q' + 'W' + 'E'; //esto no funciona bien, suma los valores ASCCI de cada char
            Console.WriteLine($"fruta: {fruta}");

            String persona = "Gerardo Josue Portillo";
            /*Ejercicio: genere una nueva variable String que sea una copia de la variable persona;
             pero reemplace cada espacio en blanco por un guion bajo en la copia, sin utilizar
            el metodo replace. Imprima la copia.*/

        }
    }
}
