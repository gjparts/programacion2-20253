namespace _34_String02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Capturar un String mediante la consola o terminal
            Console.Write("Digite un String: ");
            String str = Console.ReadLine();

            Console.WriteLine($"String leido: {str}");
            Console.WriteLine($"Longitud: {str.Length}");
            Console.WriteLine($"En mayusculas: {str.ToUpper()}");
            Console.WriteLine($"En minusculas: {str.ToLower()}");
            Console.WriteLine($"Sin relleno: {str.Trim()}");
            Console.WriteLine($"Longitud sin relleno: {str.Trim().Length}");

            /*Ejercicio: haga una copia del String recien leido (str) y en dicha copia
             van a reemplazar la letra A por un 4 y la letra I por un 1, ignorando mayusculas
            y minusculas, si usar el metodo replace. Imprima la copia al finalizar.
            Ejemplo:
            Digite un String: GallinA
            Resultado: G4ll1n4
            */
            //forma 1: ignorar mayusculas/minusculas sin usar metodos
            String copia = "";
            for( int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'A' || str[i] == 'a')
                    copia = copia + '4';
                else
                {
                    if (str[i] == 'I' || str[i] == 'i')
                        copia = copia + '1';
                    else
                        copia = copia + str[i];
                }
            }
            Console.WriteLine($"Resultado: {copia}");

            //forma 2: ignorar mayusculas/minusculas sin usar metodos
            copia = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (str.ToUpper()[i] == 'A')
                    copia = copia + '4';
                else
                {
                    if (str.ToUpper()[i] == 'I')
                        copia = copia + '1';
                    else
                        copia = copia + str[i];
                }
            }
            Console.WriteLine($"Resultado: {copia}");
        }
    }
}
