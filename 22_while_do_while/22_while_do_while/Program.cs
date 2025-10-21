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

            //Diferencia entre while y do-while
            /*Haga un programa que pregunte al usuario N cantidad de numeros
             positivos. El programa va a terminar cuando se digite un numero
            negativo.*/
            //USANDO WHILE:
            //si usa while la variable(s) de control debe inicializarse
            float numero = 0;
            Console.WriteLine("WHILE --------------------------------------");
            while( numero >= 0 )
            {
                Console.Write("Digite numero positivo: ");
                numero = float.Parse(Console.ReadLine());
            }

            //USANDO DO-WHILE
            Console.WriteLine("DO-WHILE -------------------------------------");
            double valor;
            do
            {
                Console.Write("Digite numero positivo: ");
                valor = double.Parse(Console.ReadLine());
            } while (valor >= 0);
            //Observe que valor no esta inicializado porque tomara su
            //primer numero en la primera iteracion la cual siempre va
            //a suceder ya que do-while hace al menos una iteracion siempre.
        }
    }
}
