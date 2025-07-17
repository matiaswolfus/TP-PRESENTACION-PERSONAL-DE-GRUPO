namespace TP03;
using Microsoft.Data.SqlClient;
using Dapper;
static public class BD
{
    private static string _connectionString = "Server=localhost;Database=PRESENTACION DE GRUPO;Trusted_Connection=True; TrustServerCertificate=True"; 


    static public int logIn(string mail, string contraseña)
    {
        int idUsuario = -1;
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT idUsuario FROM Usuario WHERE mail = @mail AND contraseña = @contraseña";
            idUsuario = connection.QueryFirstOrDefault <int> (query, new {mail,contraseña});
        }
        return idUsuario;
    }

    static public Usuario GetUsuario(int idUsuario)
    {
        Usuario usuario = new Usuario();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT usuario.nombre, usuario.apellido, usuario.mail, usuario.contraseña, usuario.fechaNacimiento, usuario.foto FROM Usuario WHERE idUsuario = @idUsuario";
            usuario = connection.QueryFirstOrDefault <Usuario> (query,new { idUsuario});
        }
        return usuario;

    }
    static public List<datoFamiliar> GetDatoFamiliar(int idUsuario)
    {
        List<datoFamiliar> datosFamiliares = new List<datoFamiliar>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT nombre,apellido,parentesco,descrpcion FROM datoFamiliar WHERE idUsuario = @idUsuario";
            datosFamiliares = connection.Query<datoFamiliar> (query,new { idUsuario}).ToList();
        }
        return datosFamiliares;
    }
    static public List<datoInteres> GetDatoInteres(int idUsuario)
    {
        List<datoInteres> datosDeInteres = new List<datoInteres>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT tipoInteres,interes FROM datoInteres WHERE idUsuario = @idUsuario";
            datosDeInteres = connection.Query<datoInteres> (query,new {idUsuario}).ToList();
        }
        return datosDeInteres;
    }
    
}