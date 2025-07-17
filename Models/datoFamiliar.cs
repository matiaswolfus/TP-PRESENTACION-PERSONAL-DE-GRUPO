namespace TP03;
using Newtonsoft.Json;

public class datoFamiliar
{
    [JsonProperty("idDatoFamiliar")]
    public int idDatoFamiliar { get; private set; }

    [JsonProperty("idUsuario")]
    public int idUsuario { get; private set; }

    [JsonProperty("nombre")]
    public string nombre { get; private set; }

    [JsonProperty("apellido")]
    public string apellido { get; private set; }

    [JsonProperty("parentesco")]
    public string parentesco { get; private set; }

    [JsonProperty("descripcion")]
    public string descrpcion { get; private set; }


    public datoFamiliar(int idDatoFamiliar, int idUsuario, string nombre, string apellido, string parentesco, string descripcion)
    {
        this.idDatoFamiliar = idDatoFamiliar;
        this.idUsuario = idUsuario;
        this.nombre = nombre;
        this.apellido = apellido;
        this.descrpcion = descripcion;
        this.parentesco = parentesco;
    }
    public datoFamiliar()
    {
        
    }
}