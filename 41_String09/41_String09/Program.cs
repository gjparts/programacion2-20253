namespace _41_String09
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Método Substring
            Devuelve un String que esta dentro de otro String, en C# hay dos maneras de usarlo:
            1)  Substring(posicion_inicial)
                Devuelve un String desde la posicion inicial hasta el final del String.
            2)  Substring(posicion_inicial, cantidad de caracteres a extraer)
                Devuelve un String a partir de la posicion inicial de acuerdo al numero de caracteres deseado.
             */
            String str = "El veloz murcielago hindu comia feliz cardillo y kiwi";
            Console.WriteLine(str);
            //Substring de 7 caracteres desde la posicion 0:
            Console.WriteLine(str.Substring(0,7));
            //Substring de 15 caracteres desde la posicion 8:
            Console.WriteLine(str.Substring(8, 15));
            //Substring de 2 caracteres desde la posicion 5
            Console.WriteLine(str.Substring(5, 2));
            //Substring de 1000 caracteres desde la posicion 3
            //Console.WriteLine(str.Substring(3, 1000));
            //Lo anterior va a dar error porque Substring no puede acceder a una posicion que no existe

            //Substring con 1 parametro:
            //Substring desde la posicion 9
            Console.WriteLine(str.Substring(9));
            //Substring desde la posicion 15
            Console.WriteLine(str.Substring(15));
        }
    }
}
