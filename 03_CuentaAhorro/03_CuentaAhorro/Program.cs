namespace _03_CuentaAhorro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                CuentaAhorro c1 = new CuentaAhorro("Gerardo", "1234567890");
                Console.WriteLine(c1.Saldo);
                //como Saldo usa private set no se puede setear con =
                //c1.Saldo = 1000;
                c1.Depositar(500);
                Console.WriteLine(c1.Saldo);
                //c1.Depositar(-1000);
                c1.Depositar(1000);
                Console.WriteLine(c1.Saldo);
                c1.Retirar(800);
                Console.WriteLine(c1.Saldo);
                c1.Retirar(5000); //Fondos insuficientes
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }
}
