namespace _16_random
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //generar un numero al azar entre 11 y 53
            //instanciar un nuevo objeto de la clase Random
            Random r = new Random();
            int azar = r.Next(11,54);
            /*¿Por qué 54?
             porque el segundo parametro es excluyente,
            por lo tanto se le debe sumar 1 al segundo parametro
            que es el numero maximo que se puede obtener. 53+1=54*/
            Console.WriteLine($"Numero generado: {azar}");
        }
    }
}
