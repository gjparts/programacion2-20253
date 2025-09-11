using System.Threading;

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

            //Colorear el texto en pantalla
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Texto Amarillo");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Texto Rojo");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Texto Azul");

            //color de fondo y color de texto
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Texto Amarillo con fondo morado.");

            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Texto verde con fondo azul oscuro.");

            //reestablecer los colores a su valor predefinido
            Console.ResetColor();

            //es posible usar varios colores por linea
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("Fresa");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Naranja");
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("Uva");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Sandia");
            Console.WriteLine();
            Console.ResetColor();

            //para imprimir un solo String conformado por varios renglones
            //puede anteponer el caracter @ antes del String, este caracter en C#
            //permite ignorar los saltos de linea y los caracteres de escape.
            Console.WriteLine(@"Primera linea

Segunda Linea \
Tercera Linea \n\n\n\n

\tCuarta Linea


Ultima Linea
");
            Console.ForegroundColor= ConsoleColor.DarkYellow;
            Console.WriteLine(@"
 /\_/\
( o.o )
 > ^ <
");
            Console.ResetColor();

            //hacer una pausa
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //true evita que se imprima la tecla presionada

            //Limpiar la pantalla
            Console.Clear();

            //Establecer la posicion del cursor de impresion en la consola
            Console.SetCursorPosition(70, 3);
            Console.WriteLine("Texto en columna 70, linea 3");

            Console.SetCursorPosition(15, 0);
            Console.WriteLine("Texto en columna 15, linea 0");

            //Importante: el programa continuara imprimiendo a partir
            //de la ultima linea donde dejo el cursor.

            Console.SetCursorPosition(10, 20);
            Console.WriteLine("Texto en columna 10, linea 20");

            //hacer una pausa
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //true evita que se imprima la tecla presionada

            //Limpiar la pantalla
            Console.Clear();

            //Pausas con tiempo
            //es necesario importar el namespace llamado System.Threading
            Console.WriteLine("Haciendo una pausa por 2 segundos...");
            Thread.Sleep(2000);
            Console.WriteLine("Listo!");

            Console.WriteLine("Haciendo una pausa por medio segundo...");
            Thread.Sleep(500);
            Console.WriteLine("Listo!");

            Console.WriteLine("Haciendo una pausa por 1 segundo...");
            Thread.Sleep(1000);
            Console.WriteLine("Listo!");

            //hacer una pausa
            Console.WriteLine("Presione cualquier tecla para continuar...");
            Console.ReadKey(true); //true evita que se imprima la tecla presionada

            //Limpiar la pantalla
            Console.Clear();

            Console.ForegroundColor = ConsoleColor.Green;
            //podemos ir limpiando la pantalla en cada iteracion y simular algo que se mueve
            for(int i = 0; i < 50; i++)
            {
                Console.Clear(); //limpiar pantalla

                Console.SetCursorPosition(i, 10);
                Console.WriteLine("><>");
                Console.SetCursorPosition(i + 10, 5);
                Console.WriteLine("><>");
                Console.SetCursorPosition(i + 20, 12);
                Console.WriteLine("><>");

                Thread.Sleep(50); //hacer una pausa de tiempo entre cada iteracion
            }
            Console.ResetColor();
        }
    }
}
