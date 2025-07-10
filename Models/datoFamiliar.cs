namespace TP03;
public class datoFamiliar
{
    public int idDatoFamiliar {get; private set;}

    public int idUsuario {get; private set;}

    public string nombre {get; private set;}

    public string apellido {get; private set;}

    public string parentesco{get; private set;}

    public string descripcion {get; private set;}


    public datoFamiliar(int idDatoFamiliar, int idUsuario, string nombre, string apellido, string parentesco, string descripcion)
    {
        this.idDatoFamiliar = idDatoFamiliar;
        this.idUsuario = idUsuario;
        this.nombre = nombre;
        this.apellido = apellido;
        this.descripcion = descripcion;
        this.parentesco = parentesco;
    }
    public datoFamiliar()
    {
        
    }
}