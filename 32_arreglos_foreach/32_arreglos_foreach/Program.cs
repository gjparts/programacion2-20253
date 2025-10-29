namespace _32_arreglos_foreach
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Consideraciones respecto al uso de for-each y arreglos
            //como vimos anteriormente los arreglos se pueden recorrer con
            //for tradicional o por medio de for-each.
            //recuerden que foreach no da acceso al numero de elemento en el arreglo.
            //lo que deben siempre recordar es que for-each no permite modificar
            //el elemento en el arreglo, solo se usa para lectura.
            //en cambio un for tradicional si permite escribir el elemento en el arreglo
            //ejemplo:

            double[] numeros = { 2.2, 1.5, 4.8, 100, 1.45, 3.1416 };
            //modifique el arreglo anterior multiplicando por 2 cada elemento.
            for(int i = 0; i < numeros.Length; i++)
            {
                numeros[i] = numeros[i] * 2;
                Console.WriteLine(numeros[i]);
            }

            Console.WriteLine("*****************************************************");
            float[] cifras = { 2.2f, 5, 2.5f, 10.1f, 1.1f, 100 };
            //modifique el arreglo anterior multiplicando por 10 cada elemento.
            //con for-each no se puede resolver, cada elemento es de solo lectura:
            /*foreach(float elemento in cifras)
            {
                elemento = elemento * 10;
            }*/
            //hasta este momento solo lo podemos resolver con for tradicional:
            for (int i = 0; i < cifras.Length; i++)
            {
                cifras[i] = cifras[i] * 10;
                Console.WriteLine(cifras[i]);
            }
        }
    }
}
