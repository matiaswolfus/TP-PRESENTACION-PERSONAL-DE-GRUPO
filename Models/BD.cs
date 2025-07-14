namespace TP03;
using Microsoft.Data.SqlClient;
using Dapper;
public class BD
{
    private static string _connectionString = @"Server = localhost; DataBase = [PRESENTACION DE GRUPO];Integrated Security = True; TrustServerCertificate = True;"; 


    public int logIn(string mail, string constraseña)
    {
        int idUsuario = -1;
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT * FROM Usuario WHERE mail = @mail AND contraseña = @contraseña";
            idUsuario = connection.QueryFirstOrDefault <int> (query, new {mail,constraseña});
        }
        return idUsuario;
    }

    public Usuario GetUsuario(int idUsuario)
    {
        Usuario usuario = new Usuario();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT usuario.nombre, usuario.apellido, usuario.mail, usuario.contraseña, usuario.fechaNacimiento, usuario.foto FROM Usuario WHERE idUsuario = @idUsuario";
            usuario = connection.QueryFirstOrDefault <Usuario> (query,new { idUsuario});
        }
        return usuario;

    }
    List<datoFamiliar> GetDatoFamiliar(int idUsuario)
    {
        List<datoFamiliar> datosFamiliares = new List<datoFamiliar>();
        using (SqlConnection connection = new SqlConnection(_connectionString))
        {
            string query = "SELECT nombre,apellido,parentesco,descripcion FROM datoFamiliar WHERE idUsuario = @idUsuario";
            datosFamiliares = connection.Query<datoFamiliar> (query,new { idUsuario}).ToList();
        }
        return datosFamiliares;
    }
    List<datoInteres> GetDatoInteres(int idUsuario)
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