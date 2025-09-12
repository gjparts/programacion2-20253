namespace _01_Fechas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Para manejar fechas vamos a usar el tipo de dato DateTime
            //el cual permite manejar fecha y hora.
            //A partir de .Net 6 existen tambien los tipos DateOnly y TimeOnly
            //que solo manejan fecha y hora respectivamente.
            DateTime hoy = DateTime.Now;
            Console.WriteLine(hoy);

            //las variable de tipo DateTime no aceptan valores null
            //hoy = null;

            //uso de TimeOnly: solo la hora
            TimeOnly hora = TimeOnly.FromDateTime(DateTime.Now);
            Console.WriteLine(hora);

            //uso de DateOnly: solo la fecha
            DateOnly Solofecha = DateOnly.FromDateTime(DateTime.Now);

            //establecer una fecha/hora fijas
            DateTime fecha1 = new DateTime(1982, 10, 15, 17, 33, 24);
            Console.WriteLine(fecha1);

            //fecha fija en DateOnly
            DateOnly fecha2 = new DateOnly(1983, 12, 21);
            Console.WriteLine(fecha2);

            //hora fija en TimeOnly
            TimeOnly hora2 = new TimeOnly(16, 45, 21);
            Console.WriteLine(hora2);

            //convertir fecha a String usando formatos predefinidos
            Console.WriteLine("Fecha corta: "+hoy.ToShortDateString());
            Console.WriteLine("Fecha larga: " + hoy.ToLongDateString());

            //convertir a formato personalizado
            Console.WriteLine("Fecha con formato: "+hoy.ToString("yyyy/MM/dd hh:mm:ss tt"));
        }
    }
}
