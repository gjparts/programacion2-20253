namespace _42_String10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Lea un numero de DNI de Honduras.
            -> El programa deberá eliminar los espacios de relleno, guiones, guiones bajos y espacios
               en blanco del String digitado.
            -> El programa debe validar que el DNI digitado sea de 13 caracteres luego de eliminar los caracteres
               de basura. Muestre un mensaje de error en caso de no cumplir esta regla. 
            -> Luego va a presentar la informacion del DNI leido de la siguiente forma:
            Digitar DNI: 1401-1982-01055
            Resultado:
            Departamento: 14
            Municipio: 01
            Año de asentamiento: 1982
            Correlativo: 01055
            */
            Console.Write("Digitar DNI: ");
            String dni = Console.ReadLine();
            //sanitizar el String
            dni = dni.Trim().Replace("-", "").Replace("_", "").Replace(" ", "");
            //validar que el String tenga 13 caracteres
            if( dni.Length == 13)
            {
                Console.WriteLine($"Departamento: {dni.Substring(0,2)}");
                Console.WriteLine($"Municipio: {dni.Substring(2, 2)}");
                Console.WriteLine($"Año de asentamiento: {dni.Substring(4, 4)}");
                Console.WriteLine($"Correlativo: {dni.Substring(8)}");
            }
            else
                Console.WriteLine("DNI debe de ser de 13 caracteres.");
        }
    }
}
