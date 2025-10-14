namespace _17_random_switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que genere un numero
            al azar entre 4 y 9.
            Dependiendo del numero generado debera
            imprimir el nombre de un color, estos pueden ser:
            4 = Verde
            5 = Azul
            6 = Rojo
            7 = Gris
            8 = Amarillo
            9 = Blanco
            Evalue el numero al azar utilizando una
            estructura de seleccion switch.*/
            Random r = new Random();
            int n = r.Next(4, 10);
            switch (n)
            {
                case 4: Console.WriteLine("Verde"); break;
                case 5: Console.WriteLine("Azul"); break;
                case 6: Console.WriteLine("Rojo"); break;
                case 7: Console.WriteLine("Gris"); break;
                case 8: Console.WriteLine("Amarillo"); break;
                case 9: Console.WriteLine("Blanco"); break;
            }
            //el case Default es opcional en C#
        }
    }
}
