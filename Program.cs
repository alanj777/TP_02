namespace TP02_Jolodovsky;
class Program
{
    static void Main(string[] args)
    {
       List<int> listaDNI = new List<int>();
       List<Persona> listaPersonas = new List<Persona>();
       int Opcion = 0;
       int contador = 0;
       int calculo;
       int contador2 = 0;
       bool Vota;
       int suma = 0;
       int ABuscar;
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
       calculo = Persona1.ObtenerEdad(fechanacimiento);
       Vota = Persona1.PuedeVotar(calculo);
       int edad = Persona1.ObtenerEdad(fechanacimiento);
       suma = suma + edad;
       if (Vota = true){
       contador2 ++;
       }
       listaDNI.Add(Persona1.DNI);
       break;
       case 2:
       double Promedio = suma / contador;
       Console.WriteLine("Estadísticas del censo: \n Cantidad de Personas: " + contador + " \n Cantidad de Personas habilitadas para votar: "+ contador2 + " \n Promedio de Edad: " + Promedio);
       break;
       case 3:
       ABuscar = IngresarInt("Ingrese un DNI para buscar: ");
       int posicion = listaDNI.IndexOf(ABuscar);
       if(posicion > -1){
         Console.WriteLine("La persona con el dni " + ABuscar + " está registrada como: " + listaPersonas[posicion].Nombre + " " + listaPersonas[posicion].Apellido + " " + listaPersonas[posicion].DNI +" "+ listaPersonas[posicion].Email+" " +listaPersonas[posicion].FechaNacimiento);
         calculo = listaPersonas[posicion].ObtenerEdad(listaPersonas[posicion].FechaNacimiento);
         Vota = listaPersonas[posicion].PuedeVotar(calculo);
         if (Vota = true){
            Console.WriteLine("Puede votar");
         }
         else{
            Console.WriteLine("No puede votar aún");
         }
       }
       else{
        Console.WriteLine("No se encontró al individuo, por favor ingreselo en la opción 1 del menú");
         Console.Write("Restarting menu below an critical error");
        System.Threading.Thread.Sleep(1000);
        Console.Write(".");
        System.Threading.Thread.Sleep(1000);
        Console.Write(".");
        System.Threading.Thread.Sleep(1000);
        Console.Write(".");
        System.Threading.Thread.Sleep(1000);
        Console.Clear();
       }
       break;
       case 4:
        ABuscar = IngresarInt("Ingrese un DNI para buscar y lograr modificar el mail: ");
        Console.Write("Buscando DNI");
        System.Threading.Thread.Sleep(1000);
        Console.Write(".");
        System.Threading.Thread.Sleep(1500);
        Console.Write(".");
        System.Threading.Thread.Sleep(1200);
        Console.Write(".");
        System.Threading.Thread.Sleep(2000);
        Console.Clear();
        posicion = listaDNI.IndexOf(ABuscar);
        if(posicion > -1){
          Console.WriteLine("La persona con el dni " + ABuscar + " Tiene el mail: " + listaPersonas[posicion].Email);
          string newMail = IngresarString("Ingresá el nuevo mail: ");
          listaPersonas[posicion].Email = newMail;
        }
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
