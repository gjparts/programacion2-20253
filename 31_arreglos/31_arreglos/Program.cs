namespace _31_arreglos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa donde esté declarado un arreglo unidimensional de numeros enteros
            de tamaño 10, en cada uno de los elementos de dicho arreglo
            deberá colocar un número al azar entre 8 y 76 no importa que se repitan.
            Por ultimo imprima el contenido de dicho arreglo.*/
            int[] arreglo = new int[10];
            Random r = new Random();

            for(int i = 0; i < arreglo.Length; i++)
            {
                arreglo[i] = r.Next(8,77); //asignar el numero al azar a la i-esima posicion del arreglo
                Console.WriteLine(arreglo[i]);
            }
            /*Cree un nuevo areglo que sea una copia del arreglo anterior; pero
             en la copia van a modificar cada elemento elevandolo al cubo.
            Imprimir el contenido del arreglo copia.*/
            Console.WriteLine("********************************");
            int[] copia = new int[10];
            for(int i = 0;i < arreglo.Length; i++)
            {
                //copia[i] = arreglo[i]*arreglo[i]*arreglo[i]; //salida mas facil
                //copia[i] = (int)Math.Pow(arreglo[i], 3); //metodo 1

                //metodo 2: convertir a entero de 32 bit que es lo mismo que int
                copia[i] = Convert.ToInt32(Math.Pow(arreglo[i], 3));
                
                Console.WriteLine(copia[i]);
            }
        }
    }
}
