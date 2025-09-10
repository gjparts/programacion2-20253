namespace _00_PrimerDia
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //comentario de un renglon
            /* comentario
             * de varios
             * renglones
             */
            //imprimir texto en la consola
            //Console.WriteLine: imprime un String en la consola y hace una nueva linea
            Console.WriteLine("Hola UNAH");
            Console.WriteLine("Sistemas");
            Console.WriteLine("Honduras, San Pedro Sula");

            //Console.Write: imprime un String en la consola; pero no salta de linea
            Console.Write("Rojo");
            Console.Write("Verde");
            Console.Write("Azul");
            Console.Write("Amarillo");

            //Uso de caracteres de escape como en C++
            //Nueva linea
            Console.WriteLine("Linea 1\nLinea 2\nLinea 3\nLinea 4");
            //Tabuladores
            Console.WriteLine("Nombre\tEdad\tGenero");
            Console.WriteLine("Gerardo\t42\tMasculino");
            Console.WriteLine("Irene\t41\tFemenino");
            Console.WriteLine("Josue\t13\tMasculino");
            //es posible imprimir un slash inverso?
            Console.WriteLine("Esto es un slash inverso: \\");
            //es posible imprimir una comilla doble?
            Console.WriteLine("Esto es una comilla doble: \"");

            //otras formas de hacer saltos de linea
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("");
            Console.WriteLine("Honduras, Centro America");
            //puede usar \n para hacer varios saltos
            Console.WriteLine("\n\n\n\n\n\n\nSoleado");

            //hacer una pausa
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //true evita que se imprima la tecla presionada

            //Limpiar la pantalla
            Console.Clear();
            Console.WriteLine("Se ha limpiado la pantalla.");
        }
    }
}
