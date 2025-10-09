namespace _11_if_and
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un programa que pregunte la edad de una persona, luego van a
             * imprimir a que grupo de edad pertenece de acuerdo a la tabla siguiente:
            Rango			    Grupo
            de 0 a menos de 18	Menor de edad
            entre 18 y 20		Mayor de edad
            entre 21 y 59		Adulto
            de 60 en adelante	Tercera Edad*/
            try
            {
                int edad;
                Console.Write("Digite su edad: ");
                edad = int.Parse(Console.ReadLine());

                if(edad >= 0 && edad < 18) Console.WriteLine("Menor de edad");
                if(edad >= 18 && edad <= 20) Console.WriteLine("Mayor de edad");
                if(edad >= 21 && edad <= 59) Console.WriteLine("Adulto");
                if(edad >= 60) Console.WriteLine("Tercera edad");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Debe digitar un numero entero.");
            }            
        }
    }
}
