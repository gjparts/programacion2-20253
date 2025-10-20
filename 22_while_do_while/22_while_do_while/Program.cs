namespace _22_while_do_while
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Estructuras de repeticion while y do-while
             1) Normalmente se usan cuando no sabemos en que momento se va a dejar
                de iterar.
             2) Ambas se basan en el cumplimiento de una o mas condiciones
             3) Para su mejor comprension visualicelas como un if iterativo
             4) diferencias:
                a) while: pregunta primero, hace despues
                b) do-while: hace primero, pregunta despues.
             5) while = mientras, do = hacer
             */
            //ejemplos:
            //usando while haga un programa que imprima numeros del 1 al 10, de 1 en 1
            int i = 1; //variable de control
            while (i <= 10)
            {
                Console.WriteLine(i);
                i++;    //importante: hay que actualizar la variable de control
                        //de manera que la condicion(es) de terminacion deje de
                        //cumplirse en algun momento.
            }

            //usando do-while haga un programa que imprima numeros del 1 al 10, de 1 en 1
            int j = 1;
            do
            {
                Console.WriteLine(j);
                j++;
            } while (j <= 10);
        }
    }
}
