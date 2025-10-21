namespace _24_while
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que capture N cantidad de edades de personas.
            ->  el programa termina cuando se digite una edad menor que cero.
            ->  una vez que termine el programa debe imprimir una tabla que resuma cuantas
                edades se leyeron por grupo de edad de acuerdo al ejemplo siguiente:

            Grupo de Edad	Cantidad	Descripcion
            Menores de edad	XXXX		de 0 a menos de 18 años
            Mayores de edad	XXXX		de 18 a menos de 21 años
            Adultos		    XXXX		de 21 a menos de 60 años
            Tercera edad	XXXX		de 60 años en adelante

            -> La columna de la descripcion no la vaya a imprimir*/
            int edad = 123456; //variable temporal
            int menores = 0, mayores = 0, adultos = 0, tercera = 0; //variables contador
            while(edad >= 0)
            {
                //en caso de fallar la iteracion, la ignora
                try
                {
                    Console.Write("Digite una edad: ");
                    edad = int.Parse(Console.ReadLine());
                    //clasificar la edad leida en cada uno de los contadores
                    if (edad >= 0 && edad < 18) menores++;
                    if (edad >= 18 && edad < 21) mayores++;
                    if (edad >= 21 && edad < 60) adultos++;
                    if (edad >= 60) tercera++;
                }
                catch (Exception)
                {
                    Console.WriteLine("Edad no admitida");
                }
            }
            Console.WriteLine("Grupo de Edad\tCantidad");
            Console.WriteLine($"Menores de edad\t{menores}");
            Console.WriteLine($"Mayores de edad\t{mayores}");
            Console.WriteLine($"Aultos \t{adultos}");
            Console.WriteLine($"Tercera edad\t{tercera}");
        }
    }
}
