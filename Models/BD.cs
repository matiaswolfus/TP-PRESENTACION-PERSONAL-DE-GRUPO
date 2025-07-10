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
            string query = "SELECT * FROM Usuario WHERE idUsuario = @idUsuario";
            usuario = connection.QueryFirstOrDefault <Usuario> (query,new { idUsuario});
        }
        return usuario;

    }
}