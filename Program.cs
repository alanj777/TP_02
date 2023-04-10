namespace TP02_Jolodovsky;
class Program
{
    static void Main(string[] args)
    {
       List<Persona> listaPersonas = new List<Persona>();
       int Opcion = 0;
       int contador = 0;
       while (Opcion != 5){
        Console.WriteLine("1- Cargar Nueva Persona \n 2- Obtener Estadísticas del Censo \n 3- Buscar Persona \n 4- Modificar Mail de una Persona. \n 5- Salir");
        Opcion = IngresarInt("Ingrese la opción");
       switch(Opcion){
        case 1:
       string nombre = IngresarString("Ingresá tu nombre");
       string apellido = IngresarString("Ingresá tu apellido");
       int dni = IngresarInt("Ingresá tu DNI");
       string email = IngresarString("Ingrese su email");
       DateTime fechanacimiento = IngresarDateTime("Ingresá tu fecha de nacimiento");
       Persona Persona1 = new Persona(dni, apellido, nombre, email, fechanacimiento);
       Console.WriteLine("La Persona con los datos ordenados en Dni, apellido, nombre, email y fecha de nacimiento: " + Persona1.DNI + " " + Persona1.Apellido + " " + Persona1.Nombre + " " + Persona1.Email + " " + Persona1.FechaNacimiento +", Ha sido agregado/a a la lista");
       contador ++;
       listaPersonas.Add(Persona1);
       break;
       case 2:
       Console.WriteLine("Estadísticas del censo: \n Cantidad de Personas: " + contador + " \n Cantidad de Personas habilitadas para votar: " + " \n Promedio de Edad: ");
       break;
       case 3:
       break;
       case 4:
       break;
        }
        }
        Console.Write("Shutting down Censo.System");
        System.Threading.Thread.Sleep(1000);
        Console.Write(".");
        System.Threading.Thread.Sleep(1000);
        Console.Write(".");
        System.Threading.Thread.Sleep(1000);
        Console.Write(".");
        System.Threading.Thread.Sleep(1000);
        Console.Clear();
    }
    static string IngresarString(string mensaje){
        Console.WriteLine(mensaje);
     string devolver;
     devolver = Console.ReadLine();
        return devolver;
    }
    static int IngresarInt(string mensaje){
        Console.WriteLine(mensaje);
     int devolver;
     devolver = int.Parse(Console.ReadLine());
        return devolver;
    }
    static DateTime IngresarDateTime(string mensaje){
      DateTime num;
      Console.WriteLine(mensaje);
      num = DateTime.Parse(Console.ReadLine());
      return num;
      }
}
