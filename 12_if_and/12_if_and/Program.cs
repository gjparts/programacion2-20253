namespace _12_if_and
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Hacer un programa que pregunte al usuario por su salario mensual y su antiguedad en años.
            El programa va a imprimir cuanto le toca de bonificacion,
            la cual se calcula de la siguiente manera:

            Multiplique el salario mensual por un % de acuerdo a su antiguedad
            basado en la siguiente tabla:

            Antiguedad		 % bono
            menos de 5 años		 10%
            de 5 a menos de 10 años	 15%
            de 10 a menos de 20 años 20%
            de 20 años o más	 25%*/
            try
            {
                float salario, antiguedad, bono = 0;
                Console.Write("Digite su salario mensual: ");
                salario = float.Parse(Console.ReadLine());
                Console.Write("Digite sus años de antiguedad: ");
                antiguedad = float.Parse(Console.ReadLine());

                if (antiguedad < 5) bono = salario * 0.10f;
                if (antiguedad >= 5 && antiguedad < 10) bono = salario * 0.15f;
                if (antiguedad >= 10 && antiguedad < 20) bono = salario * 0.20f;
                if (antiguedad >= 20) bono = salario * 0.25f;
                Console.WriteLine($"La bonificacion es: {bono}");
            }
            catch (Exception)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Debe digitar solo numeros.");
            }
            
        }
    }
}
