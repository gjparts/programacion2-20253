namespace _01_Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Variables
            Una variable es un espacio de memoria que es reservado para almacenar un valor.
            Toda variable debe de tener un tipo de dato.
            Los tipos de dato se clasifican en dos grupos:
            1) Tipos de dato primitivos: son los que vienen definidos en el compilador del lenguaje
                Ejemplos en C++: int, long, double, float, bool, char
                Ejemplos en JAVA: int, long, double, float, bool, char
                Ejemplos en C#: int, long, double, float, bool, char
            2) Tipos de dato compuestos o de objeto: estos conformados por combinaciones
               de tipos de dato primitivos.
                Ejemplos en C++: string, fstream
                Ejemplos en JAVA: Scanner, String, Random
                Ejemplos en C#: String, Object, Array, Class, Struct, Enum

            Consideraciones a la hora de nombrar variables:
            1) No utilicen palabras reservadas del lenguaje, por ejemplo: if, for, while, do, etc...
            2) No debe iniciar en numero: 123algo
            3) Dos variables no pueden tener el mismo nombre en el mismo ambito (scope)
            4) No utilice espacios en blanco en los nombres de variable, en su lugar pueden
               utilizar guion bajo: mi_edad, numero_de_unidades (notacion hungara)
               Yo recomiendo no usar guiones porque en algunos lenguajes el guion bajo realiza otra funcion.
               mejor utilice camel Case: miEdad,  numeroDeUnidades
               o utilice: Pascal Case: MiEdad, NumeroDeUnidades
            5) No utilice caracteres especiales como * & () {}
            6) En lenguajes como C++, JAVA o C# recuerde siempre respetar las mayusculas o
               minusculas que le puso a sus variables cuando las vaya a usar.
             */

            int a; //declaracion de variable sin inicializar
            //IMPORTANTE: no se puede leer una variable que no ha sido inicializada.
            //Console.WriteLine(a);
            a = 7;
            Console.WriteLine(a);

            //declarar e inicializar la variable
            int b = 90;
            Console.WriteLine(b);

            //declarar multiples variables del mismo tipo
            int num1, num2, num3;
            //declarar e inicializar multiples variables del mismo tipo
            int cifra1 = 7, cifra2 = 10, cifra3 = -89;
            double v1 = 5.6, v2 = 8.23;

            //en C# las variables float con decimales deben llevar una f al final:
            float f1 = 6.7f;

            Console.WriteLine("numero maximo para int en C# "+int.MaxValue);
            //el tipo de dato int en C# tiene un tamaño de 4 bytes (32 bits)
            //su maximo es 2^31 = 2147483647

            //el tipo de dato long
            //permite almacenar enteros de 8 bytes (64 bits) en C#
            //su maximo valor es 2^63 = 9223372036854775807
            Console.WriteLine("numero maximo para long en C# " + long.MaxValue);
            //declarar variable long:
            long valorx = 1234123412345678912L;
            //debe colocar L al final de un valor Long para que no sea considerado int
            Console.WriteLine(valorx);
        }
    }
}
