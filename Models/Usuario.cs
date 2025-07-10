namespace TP03;
public class Usuario 
{
    public int idUsuario{get; private set;}

    public string nombre{get; private set;}

    public string apellido{get; private set;}

    public string mail {get; private set;}

    public DateTime fechaNacimiento{get; private set;}

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


}