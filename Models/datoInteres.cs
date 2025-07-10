namespace TP03;
public class datoInteres
{
    public int idDatoInteres{get;private set;}
    public int idUsuario {get; private set;}

    public int tipoInteres{get; private set;}

    public string interes {get; private set;}

    public datoInteres(int idDatoInteres, int idUsuario, int tipoInteres, string interes)
    {
        this.idDatoInteres = idDatoInteres;
        this.idUsuario = idUsuario;
        this.tipoInteres = tipoInteres;
        this.interes = interes;
    }
    public datoInteres()
    {
        
    }
}