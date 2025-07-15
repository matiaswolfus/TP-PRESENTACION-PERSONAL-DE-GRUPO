namespace TP03;
using Newtonsoft.Json;

public class datoInteres
{
    [JsonProperty ("idDatoInteres")]
    public int idDatoInteres{get;private set;}
    [JsonProperty ("idUsuario")]
    public int idUsuario {get; private set;}
    [JsonProperty ("tipoInteres")]
    public int tipoInteres{get; private set;}
    [JsonProperty ("interes")]
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