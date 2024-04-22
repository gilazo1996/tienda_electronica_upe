/*
 Notas: El codigo se puede optimizar, mas que nada en las consultas que ocupo conectarme a la base de datos en cada método.
 
 */

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;


namespace DAL
{
    public class Usuarios
    {
        private static string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TC_Permisos;Data Source=localhost\\sqlexpress";

        public static int ObtenerIdUsuarioPorEmail(string email)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = "SELECT id FROM usuarios WHERE email = @Email";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@Email", email);

                object result = command.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    return Convert.ToInt32(result);
                }
                else
                {
                    // El correo electrónico no está asociado a ningún usuario
                    return -1;
                }
            }
        }

        public static int ObtenerIdRolUsuario()
        {
            string rolUsuario = "usuario"; //cadena usuario para trabajar con la consulta
            string sql = "SELECT id FROM roles WHERE nombre = @RolUsuario"; //consulta para obtener el id de la tabla roles donde el usuario coincida

            using (SqlConnection connection = new SqlConnection(connectionString)) //instancio objeto SqlCommand para trabajar con la conexion a la bbdd
            {
                connection.Open(); 
                SqlCommand sqlConsulta = new SqlCommand(sql, connection);
                sqlConsulta.Parameters.AddWithValue("@RolUsuario", rolUsuario); //asigno al parametro obtenido el valor de la cadena rolUsuario

                int idRolUsuario = Convert.ToInt32(sqlConsulta.ExecuteScalar()); //convierto el idRol obtenido a entero
                return idRolUsuario; //retorno el id que obtuve una vez q lo convertí en entero
            }
        }

        public static bool RegistrarUsuario(string nombre, string email, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sqlInsertUsuario = "INSERT INTO usuarios (nombre, email, password) VALUES (@Nombre, @Email, @Password)";
                SqlCommand insertParametrosSQL = new SqlCommand(sqlInsertUsuario, connection); //insntacio objeto SqlCommand para trabajar con la conexion a la bbdd
                insertParametrosSQL.Parameters.AddWithValue("@Nombre", nombre); //en estas tres lineas, asigno a los parametros de la consulta los valores de las variables que obtuve
                insertParametrosSQL.Parameters.AddWithValue("@Email", email);
                insertParametrosSQL.Parameters.AddWithValue("@Password", password);

                int rowsAffectedUsuario = insertParametrosSQL.ExecuteNonQuery(); //ejecuto la consulta de insercion

                if (rowsAffectedUsuario > 0) //Si la insercion fue exitosa
                {
                    string sqlSelectIDuser = "SELECT @@IDENTITY"; //consulta para obtener el id (campo identidad) del usuario
                    SqlCommand sqlSelectUsuario = new SqlCommand(sqlSelectIDuser, connection); //insntacio objeto SqlCommand para trabajar con la conexion a la bbdd
                    int idUsuario = Convert.ToInt32(sqlSelectUsuario.ExecuteScalar()); //ejecuta la consulta para obtener el ultimo valor del id y lo convierto en entero

                    
                    string sqlInsertRolUsuario = "INSERT INTO roles_usuarios (id_rol, id_usuario) VALUES (@IdRol, @IdUsuario)"; //Consulta para asignarle el rol cliente al usuario q obtuve con el id
                    SqlCommand sqlInsertROLuser = new SqlCommand(sqlInsertRolUsuario, connection);
                    sqlInsertROLuser.Parameters.AddWithValue("@IdRol", ObtenerIdRolUsuario());
                    sqlInsertROLuser.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    int rowsAffectedRolUsuario = sqlInsertROLuser.ExecuteNonQuery(); //ejecuto la consulta q inserta registro en la tabla roles usuarios

                    return rowsAffectedRolUsuario > 0;
                }

                return false;
            }
        }
    }
}