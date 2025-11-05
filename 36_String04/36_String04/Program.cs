namespace _36_String04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Lea un String y luego lo imprime; pero dejando tres
             espacios entre cada caracter SIN afectar al String original y sin necesidad
             de sacarle una copia.
             Tambien deberán imprimir cuantas veces encontró la letra n dentro del
             String leido ignorando mayusculas y minusculas.*/
            String str;
            int contador = 0;
            Console.Write("Digite un String: ");
            str = Console.ReadLine();
            for(int i = 0; i < str.Length; i++)
            {
                Console.Write(str[i]+"   ");
                if (str.ToUpper()[i] == 'N') contador++;
            }
            Console.WriteLine($"\nLetras N encontradas: {contador}");
        }
    }
}
