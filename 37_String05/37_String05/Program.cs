namespace _37_String05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Arreglo de String
            //forma 1: sin valores de inicio
            String[] arreglo1 = new String[4];
            //forma 2: prellenado
            String[] arreglo2 = { "Rojo", "Amarillo", "Azul", "Verde", "Rosa" };

            //imprimir ambos arreglos usando JOIN
            Console.WriteLine("******************************");
            Console.WriteLine(String.Join("\n", arreglo1));
            Console.WriteLine("******************************");
            Console.WriteLine(String.Join("\n", arreglo2));

            /*Para arreglo2 haga un programa que pregunte un color, el programa debera
             buscar dicho color dentro de arreglo2, si el color es encontrado entonces
            imprima la primera posicion en que se encontró, si no se encuentra nada muestre un mensaje.
            -> Ignore mayusculas y minusculas durante la busqueda.*/
            String buscar;
            Console.Write("Digite un color a buscar: ");
            buscar = Console.ReadLine();
            bool encontrado = false; //variable bandera que indica si encontramos algo
            for( int i = 0; i < arreglo2.Length; i++)
            {
                if (arreglo2[i].ToUpper() == buscar.ToUpper())
                {
                    Console.WriteLine("Encontrado en la posicion "+i);
                    encontrado = true; //cambiar el valor bandera
                    break;  //deja de recorrer
                }
            }
            //si llego aqui y no encontro nada, mostrar un mensaje
            if( encontrado == false ) Console.WriteLine("No se ha encontrado el color.");

            //en C# los arreglos tienen el metodo Contains que indican si algo existe
            //dentro del arreglo; pero no nos dice en que posicion.
            if( arreglo2.Contains( buscar, StringComparer.OrdinalIgnoreCase ) == true )
                Console.WriteLine("El color existe dentro del arreglo; pero no se donde.");
            else
                Console.WriteLine("No se encontró.");

            //en C# usando FindIndex se puede saber en que posicion esta un elemento
            //devuelve -1 si no lo encuentra
            int posicion = Array.FindIndex(arreglo2, n => n.Equals(buscar,StringComparison.OrdinalIgnoreCase) );
            if( posicion >= 0 )
                Console.WriteLine($"Encontrado en la posicion {posicion}");
            else
                Console.WriteLine("No se encontró.");

            /*Imprimir cada color de arreglo2 colocando un asterisco entre cada caracter de cada color.
             Imprima cada color en un nuevo renglon. Sin afectar el arreglo original.*/
            //leer cada color:
            for( int i = 0;i < arreglo2.Length; i++)
            {
                //leer cada char de cada color en el arreglo
                for( int j = 0;j < arreglo2[i].Length; j++)
                {
                    Console.Write(arreglo2[i][j]+"*");
                }
                Console.WriteLine(); //salto de linea
            }
            //IMPORTANTE: Un arreglo de String no es un arreglo bi-dimensional (aunque parezca)

        }
    }
}
