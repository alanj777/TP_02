class Persona{
    public int DNI {get ; set;}
    public string Apellido {get ; set;}
    public string Nombre {get ; set;}
    public string Email {get ; set;}
    public DateTime FechaNacimiento{get ; set;}
  public Persona(int dni, string apellido, string nombre, string email, DateTime fechanacimiento){
   DNI = dni;
   Apellido = apellido;
   Nombre = nombre;
   Email = email;
   FechaNacimiento = fechanacimiento;
  } 
  public int ObtenerEdad(DateTime fechanacimiento){
   int calculo = 2023 - fechanacimiento.Year;
   return calculo;

  }
}
