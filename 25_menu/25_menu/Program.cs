namespace _25_menu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Haga un menú en pantalla que muestre las opciones siguientes:
            ------ MENU ------
            1) Saludame
            2) Dime la fecha y hora
            3) Cuentame un chiste
            4) Reproduce un sonido
            5) Quiero que me ayudes a sumar dos numeros
            6) Salir
            -> Programe algo relacionado para cada acción, el programa no debe terminar hasta
            que elija la opcion 6.
            -> Debe limpiar la pantalla antes de mostrar el menu y antes de ejecutar cada acción.
            -> Debe hacer una pausa despues de mostrar cada acción*/
            int opcion = 777;
            do
            {
                try
                {
                    Console.Clear(); //limpiar la terminal
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("------ MENU ------");
                    Console.WriteLine("1) Saludame");
                    Console.WriteLine("2) Dime la fecha y hora");
                    Console.WriteLine("3) Cuentame una verdad");
                    Console.WriteLine("4) Reproduce un sonido");
                    Console.WriteLine("5) Quiero que me ayudes a sumar dos numeros");
                    Console.WriteLine("6) Salir");
                    Console.Write("Digite el numero de opcion deseado: ");
                    opcion = int.Parse(Console.ReadLine());

                    //acciones:
                    if(opcion == 1) Console.WriteLine("Hola amigo.");
                    if(opcion == 2) Console.WriteLine(DateTime.Now);
                    if(opcion == 3) Console.WriteLine("Existen tres tipos de mentiras: las buenas, las malas y las estadisticas");
                    if(opcion == 4)
                    {
                        Console.Beep(1000, 2000); //sonido a 1000 hertz de dos segundos
                        Console.Beep(500, 1000); //sonido a 500 hertz de un segundo
                    }
                    if(opcion == 5)
                    {
                        double a, b;
                        Console.Write("Digita el primer numero: ");
                        a = double.Parse(Console.ReadLine());
                        Console.Write("Digita el segundo numero: ");
                        b = double.Parse(Console.ReadLine());
                        Console.WriteLine($"La suma de ambos numeros es {a+b}");
                    }
                    if(opcion == 6) Console.WriteLine("Adios.");
                }
                catch (Exception)
                {
                    Console.WriteLine("Debe digitar un numero de opcion");
                }
                //hacer una pausa luego de seleccionar cualquier opcion
                Console.WriteLine("Presione cualquier tecla para continuar");
                Console.ReadKey(true);
            } while (opcion != 6);

            
        }
    }
}
