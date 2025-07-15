namespace TP03;
using Newtonsoft.Json;

public class Usuario 
{
    [JsonProperty("idUsario")]

    public int idUsuario{get; private set;}
    [JsonProperty("nombre")]
    public string nombre{get; private set;}
    [JsonProperty("apellido")]
    public string apellido{get; private set;}
    [JsonProperty("mail")]
    public string mail {get; private set;}
    [JsonProperty("fechaNacimiento")]
    public DateTime fechaNacimiento{get; private set;}
    [JsonProperty("foto")]
    public string foto {get; private set;}

public Usuario (int idUsuario, string nombre, string apellido, string mail, DateTime fechaNacimiento, string foto)
{
    this.idUsuario = idUsuario;
    this.nombre = nombre;
    this.apellido = apellido;
    this.mail = mail;
    this.fechaNacimiento = fechaNacimiento;
    this.foto = foto;
}
public Usuario()
{
    
}
public int ObtenerEdad()
{
    int edad;
    DateTime hoy = DateTime.Today;
    edad = hoy.Year - this.fechaNacimiento.Year;

    if (this.fechaNacimiento.Date > hoy.AddYears(-edad).Date) // use chat para esto porque no sabia como hacer para los que no cumplieron todavia
        {
            edad--;
        }

    return edad;
}

}