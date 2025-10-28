namespace _30_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Arreglo (Array)
             Es una estructura de datos estatica, secuencial y homogénea que permite
            agrupar datos en una colección.
            -> Estatica: porque existe en un espacio reservado de memoria que no puede cambiar
                         su tamaño. (Su opuesto es dinamico)
            -> Secuencial: porque cada uno de sus elementos existe en un espacio consecutivo
                           de memoria o sea un elemento se ubica despues del anterior.
                           (su opuesto es aleatorio)
            -> Homogenea: todos sus elementos son del mismo tipo de dato. (su opuesto es heterogeneo)
            
            En C++, JAVA y C# los item de los arreglos se numeran desde 0 hasta N-1 a esto se le
            conoce como Zero Indexing.
            
            Maneras de declarar arreglos en C#:
            1) declarar el arreglo sin datos
            2) declarar e inicializar el arreglo con datos predeterminados
            3) declarar e inicializar el arreglo prellenado con datos.*/

            //1) Declarar el arreglo sin datos
            int[] arreglo;
            /*El arreglo anterior anterior, esta declarado pero no inicializado; por lo tanto no es
             utilizable; pero en el futuro se puede apuntar a otro arreglo inicializado que ya tenga
             datos.*/
            //lo siguiente da error:
            //arreglo[0] = 7;

            //2) declarar e inicializar el arreglo con datos predeterminados
            int[] arr1 = new int[6];
            //lo anterior crea un objeto de tipo Array unidimensional de 6 numeros enteros.
            //C# cuando se inicializa un Array de numeros coloca como valor predeterminado CERO a cada elemento.
            //a continuacion voy a imprimir cada elemento de arr1:
            Console.WriteLine(arr1[0]);
            Console.WriteLine(arr1[1]);
            Console.WriteLine(arr1[2]);
            Console.WriteLine(arr1[3]);
            Console.WriteLine(arr1[4]);
            Console.WriteLine(arr1[5]);
            //Console.WriteLine(arr1[6]);
            //Si intenta acceder a un item que no existe en la coleccion va a obtener una excepcion
            //de tipo IndexOutOfRangeException.

            //Obtener la longitud de un Array en C#:
            Console.WriteLine($"Longitud de arr1: {arr1.Length}");
            //Lenght lo que hace es devolver un numero int
            int x = arr1.Length; //lo puede guardar en una variable int si gusta.

            //Asignar manualmente valores a determinadas posiciones del Array:
            arr1[2] = 777;
            arr1[1] = 8;
            arr1[5] = -11;

            //Recorrer e imprimir los elementos de un arreglo usando una estructura de repeticion
            for(int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine($"Posicion: {i}\tValor: {arr1[i]}");
            }
            //solo imprimir el valor de i:
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }

            //Imprimir array usando una estructura conocida como for-each la cual nos ahorra
            //tener que decir cual es la longitud de la coleccion.
            Console.WriteLine("******************************************");
            foreach(int elemento in arr1)
            {
                Console.WriteLine(elemento);
            }
            //IMPORTANTE: foreach no da acceso a la posicion de cada item, solo a su valor
            //Si Usted necesita acceso a la posicion de cada elemento mejor use un for tradicional.

            //Imprimir array usando String.Join separando cada elemento con un espacio
            Console.WriteLine(String.Join(" ",arr1));
            //Imprimir array usando String.Join separando cada elemento con una coma y espacio
            Console.WriteLine(String.Join(", ", arr1));
            //Imprimir array usando String.Join separando cada elemento en una nueva linea
            Console.WriteLine(String.Join("\n", arr1));

            Console.WriteLine($"El primer elemento de arr1 es: {arr1[0]}");
            Console.WriteLine($"El ultimo elemento de arr1 es: {arr1[arr1.Length-1]}");
            Console.WriteLine($"El valor mayor en arr1 es: { arr1.Max() }");
            Console.WriteLine($"El valor menor en arr1 es: {arr1.Min()}");

            //3) declarar e inicializar un arreglo prellenado con datos
            double[] arr2 = { 8.1, -5.2, 0, 111, 45, 100.1, 4.5, 333, 2 };

            //Imprimirlo con Join
            Console.WriteLine("******************************");
            Console.WriteLine(String.Join("\n", arr2));

            //Imprimirlo con foreach
            Console.WriteLine("******************************");
            foreach(double elemento in arr2)
            {
                Console.WriteLine(elemento);
            }

            //aplicar ordenamiento Ascendente a un arreglo.
            //se hace mediante el metodo Array.Sort().
            //IMPORTANTE: este metodo aplica los cambios directamente al arreglo.
            Array.Sort(arr2);

            //Imprimirlo con Join
            Console.WriteLine("******************************");
            Console.WriteLine(String.Join("\n", arr2));

            //aplicar ordenamiento Descendente a un arreglo.
            //para ello se usa el Metodo Array.Reverse(); pero antes debe haberle
            //aplicado el Metodo Array.Sort() al arreglo.
            Array.Sort(arr1); //Importante: esto va antes de Reverse
            Array.Reverse(arr1);

            //Imprimirlo con Join
            Console.WriteLine("******************************");
            Console.WriteLine(String.Join("\n", arr1));

            //Recuerdan el arreglo que declaramos arriba? el que se llama arreglo?
            //podemos apuntarlo a un arreglo que tenga datos siempre y cuando sean del mismo tipo:
            arreglo = arr1;
            //lo anterior crea un apuntador de memoria entre arr1 y arreglo
            //cualquier cosa que le hagamos a arr1 afectará a arreglo
            //cualquier cosa que le hagamos a arreglo afectará a arr1

            //Imprimirlo con Join
            Console.WriteLine("******************************");
            Console.WriteLine(String.Join("\n", arreglo));

            //Vamos a imprimir las direccion hash de los arreglos:
            Console.WriteLine($"Direccion hash de arr1: {arr1.GetHashCode()}");
            Console.WriteLine($"Direccion hash de arr2: {arr2.GetHashCode()}");
            Console.WriteLine($"Direccion hash de arreglo: {arreglo.GetHashCode()}");
            //Observe que arr1 y arreglo tienen el mismo hash lo que indica que ambas
            //variables apuntan al mismo objeto.
            //en cambio arr2 tiene un hash diferente porque es otro objeto independiente
            //a la relacion entre arr1 y arreglo se conoce como pase por referencia y
            //es bastante usado en la programacion.
        }
    }
}



