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

            //Tipo de dato char: almacena un caracter
            //su tamaño es de 1 byte (8 bit)
            char c1 = 'g';
            char c2 = '/';
            //si usa caracter slash inverso debe ponerlo doble; pero solo se almacena uno
            char c3 = '\\';
            Console.WriteLine("El valor de c1 es "+c1);
            Console.WriteLine($"El valor de c2 es {c2}");
            Console.WriteLine($"El valor de c3 es {c3}");

            //Tipo de dato bool (Boolean en honor a George Boole)
            //su tamaño es de 1 bit (true = 1, false = 0)
            bool respuesta = true;
            Console.WriteLine($"La respuesta es {respuesta}");
            respuesta = false;
            Console.WriteLine($"La respuesta es {respuesta}");

            //una expresion de comparacion puede devolver un valor booleano
            bool evaluacion;
            int e1 = 3, e2 = 9;
            evaluacion = e1 > e2;
            Console.WriteLine($"El valor de evaluacion es {evaluacion}");

            /*Ley de precedencia de operadores
             Las expresiones deben de evaluarse de izquierda a derecha dando prioridad
            a las operaciones de acuerdo a la tabla siguiente:
            1) Parentesis ()
            2) Exponentes Math.Pow
            3) Multiplicaciones y Divisiones * /
            4) Sumas y Restas + -
            5) Operador logico NOT !
            6) Operador logico AND &&
            7) Operador logico OR  ||  (caracter 124)
             */
            double d1 = 5, d2 = 9, d3 = 2, d4 = 10;
            Console.WriteLine(d1+d2/d3);
            Console.WriteLine((d1+d2)/d3);
            Console.WriteLine((d1-d2)/(d3+d4)*d1);

            //Concatenacion: unir dos elementos y transformarlos en un solo String
            //el operador para concatenar es el operador +
            //el cual esta sobrecargado, o sea cumple una doble funcion
            //-> si suma dos valores numericos entonces el resultado va a ser
            //   la operacion aritmetica suma.
            //-> si suma un String con otro valor entonces el resultado va a ser
            //   la operacion de concatenar.
            //Concatenar los valores de las variables con String
            int mes = 9;
            //Concatenar usando el operador de suma
            Console.WriteLine("El mes es " + mes);
            //Concatenar usando interpolacion de cadenas
            Console.WriteLine($"El mes es {mes}");

            int entero1 = 2, entero2 = 4;
            Console.WriteLine("La suma de entero1 y entero2 es " + entero1 + entero2);
            //dos soluciones:
            Console.WriteLine("La suma de entero1 y entero2 es " + (entero1 + entero2));
            Console.WriteLine($"La suma de entero1 y entero2 es {entero1 + entero2}");

            //Comportamiento con el tipo char
            char char1 = 'A', char2 = 'B';
            Console.WriteLine(char1+char2);
            //deberia imprimir AB pero en su lugar imprimio 131, porque?
            //cuando suma dos elementos char lo que se toma es el valor numerico
            //de cada caracter, en Windows los caracteres toman su numero de una
            //tabla conocida como ASCII (American Standard Code for Information Interchange)
            //en ASCII la A vale 65 y la B vale 66 su suma es 131.
            //Para evitar que se sumen los valores de los char puede hacer lo siguiente:
            Console.WriteLine(""+char1+char2); //forma 1
            Console.WriteLine($"{char1}{char2}"); //forma 2

            //No olviden que el operador SUMA esta sobrecargado en aquellos
            //lenguajes basados en C:
            //String+valor = String
            //valor+String = String
            //valor+valor = valor
            float ff1 = 4, ff2 = 3;
            Console.WriteLine("La suma de "+ff1+" mas "+ff2+" es "+ff1+ff2);
            //se evita usando parentesis en la operacion:
            Console.WriteLine("La suma de " + ff1 + " mas " + ff2 + " es " + (ff1 + ff2));
            //que pasa con otras operaciones? Debe de poner la operacion en parenteis
            Console.WriteLine("La resta de " + ff1 + " menos " + ff2 + " es " + (ff1 - ff2));
            //lo mejor es usar interpolacion de cadenas:
            Console.WriteLine($"La suma de {ff1} mas {ff2} es {ff1+ff2}");
            Console.WriteLine($"La resta de {ff1} menos {ff2} es {ff1 - ff2}");

            //funciones matematicas en C#
            //C# incluye una clase estatica llamada Math que tiene metodos similares a los de la clase cmath de C++
            
            //Sqrt: Square root, devuelve la raiz cuadrada de un numero
            double valor1 = 25;
            Console.WriteLine($"La raiz cuadrada de {valor1} es {Math.Sqrt(valor1)}");
            valor1 = Math.Sqrt(89);
            Console.WriteLine(valor1);

            //Pow: eleva un numero base a determinado exponente.
            double valor2 = 9;
            Console.WriteLine($"{valor2} elevado al cuadrado es {Math.Pow(valor2,2)}");
            double potencia = Math.Pow(2,5); // 2 elevado a la quinta potencia
            Console.WriteLine(potencia);

            //Puede usar Pow para calcular raices
            //Raiz cubica de 27:
            double valor3 = 27;
            potencia = Math.Pow(valor3, 1.0/3.0);
            //Importante: elevar a una fraccion produce una raiz; pero esta fraccion
            //debe estar representada en numeros double, para ello en lugar de colocar 1/3
            //se debe colocar 1.0/3.0 para no perder precision, puesto que 1/3 es division entera
            //en cambio 1.0/3.0 es division de doubles en C#, Java y C++
            Console.WriteLine($"Raiz cubica de {valor3} es {potencia}");
            Console.WriteLine($"La division entera de 1/3 es {1/3}"); //0
            Console.WriteLine($"La division de 1.0/3.0 es {1.0/3.0}"); //0.33333333

            //Math ofreece algunas constantes populares:
            Console.WriteLine($"El valor de pi es {Math.PI}");
            Console.WriteLine($"El valor de E es {Math.E}");

            //Calculo de logaritmos
            double valor4 = 2;
            Console.WriteLine($"El logaritmo natural de {valor4} es {Math.Log(valor4)}");
            Console.WriteLine($"El logaritmo base 10 de {valor4} es {Math.Log10(valor4)}");

            //Round: permite redondear un numero
            double valor5 = 3.32, valor6 = 7.5, valor7 = 4.000005, valor8 = 6, valor9 = 2.78;
            //si no le pone un segundo parametro redondea al entero proximo si la parte decimal
            //es >= 0.5
            Console.WriteLine($"Round de {valor5} es {Math.Round(valor5)}");
            Console.WriteLine($"Round de {valor6} es {Math.Round(valor6)}");
            Console.WriteLine($"Round de {valor7} es {Math.Round(valor7)}");
            Console.WriteLine($"Round de {valor8} es {Math.Round(valor8)}");
            Console.WriteLine($"Round de {valor9} es {Math.Round(valor9)}");

            //se puede agregar un segundo parametro a Round
            //para determinar los decimales de precision en el redondeo
            double valor10 = 3.45356745;
            Console.WriteLine($"Round de {valor10} a 2 decimales es {Math.Round(valor10,2)}");
            Console.WriteLine($"Round de {valor10} a 4 decimales es {Math.Round(valor10, 4)}");
            Console.WriteLine($"Round de {valor10} a 1 decimal es {Math.Round(valor10, 1)}");
            Console.WriteLine($"Round de {valor10} a 6 decimales es {Math.Round(valor10, 6)}");

            //Ceiling: devuelve el proximo entero del valor enviado aunque no cumpla
            //con las reglas de redondeo.
            Console.WriteLine($"Ceiling de {valor5} es {Math.Ceiling(valor5)}");
            Console.WriteLine($"Ceiling de {valor6} es {Math.Ceiling(valor6)}");
            Console.WriteLine($"Ceiling de {valor7} es {Math.Ceiling(valor7)}");
            Console.WriteLine($"Ceiling de {valor8} es {Math.Ceiling(valor8)}");
            Console.WriteLine($"Ceiling de {valor9} es {Math.Ceiling(valor9)}");

            //Floor: devuelve la parte entera de un numero
            Console.WriteLine($"Floor de {valor5} es {Math.Floor(valor5)}");
            Console.WriteLine($"Floor de {valor6} es {Math.Floor(valor6)}");
            Console.WriteLine($"Floor de {valor7} es {Math.Floor(valor7)}");
            Console.WriteLine($"Floor de {valor8} es {Math.Floor(valor8)}");
            Console.WriteLine($"Floor de {valor9} es {Math.Floor(valor9)}");

            //ejemplo:
            Console.WriteLine($"La parte decimal de {valor5} es {Math.Round(valor5-Math.Floor(valor5),2)}");

            //Conversiones
            //para guardar texto se usa el tipo de dato String
            String str = "Honduras";
            //en C# String puede escribirse tambien en minuscula: string
            string str2 = "SPS";

            //Si en un String hay numeros, estos pueden convertirse a su tipo primitivo
            String str1 = "123";
            int entero = int.Parse(str1);
            Console.WriteLine(str1);
            Console.WriteLine(entero);

            //otras conversiones
            double dd1;
            String str3 = "3.1416";
            dd1 = double.Parse(str3);
            Console.WriteLine(dd1);

            float fl1;
            String str4 = "2.24";
            fl1 = float.Parse(str4);
            Console.WriteLine(fl1);

            //cualquier dato numerico a String
            int entero11 = 78;
            double dd2 = 56.7887654;
            float fl2 = 7.676f;
            String str5;
            str5 = entero11.ToString();
            Console.WriteLine(str5);
            Console.WriteLine(dd2.ToString());
            String str6 = fl2.ToString();
            Console.WriteLine(fl2);

            //Constantes: es un valor almacenado en la memoria que permanece inalterable
            const long velocidadLuz = 299792458;
            //velocidadLuz = 5; //esto no se puede
            Console.WriteLine($"La velocidad de la luz es {velocidadLuz}");

            const double gravedadTierra = 9.8;
            double masa = 90; //Kg
            Console.WriteLine($"Mi peso es {masa*gravedadTierra} Newton");

            //tipo de dato Variant
            /*Permite declarar una variable que va a adoptar el tipo de dato
             de acuerdo al valor que le asignemos en su inializacion.
            IMPORTANTE:
            1) Es considerado una mala practica; pero hay personas que lo usan
            2) Debe de inicializarse en la declaracion de la variable*/
            var algo = 8.8;
            Console.WriteLine($"El tipo de dato de algo es {algo.GetType()}");
            var otro = "Gerardo";
            Console.WriteLine($"El tipo de dato de otro es {otro.GetType()}");
            //una vez inicializado un tipo Variant no puede cambiarse a otro tipo
            var pais = "Honduras";
            //pais = 123; //esto no se puede
        }
    }
}
