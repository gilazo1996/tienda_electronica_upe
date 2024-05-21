//Nota: optimizar la conexion a la base usando la clase conexion.cs

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
    public class Permisos //CLASE PERMISOS QUE CONTIENE MÉTODOS PARA VALIDACION DE ROLES Y PERMISOS EXISTENTES EN NUESTRA BASE
    {                     // no todos los métodos son usados, pero fueron creados para su futuro uso, dichos métodos trabajan con consultas SQL y comparacion de credenciales entre tablas

        private int _id;
        private string _nombrePermiso;

        private static string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TC_Permisos;Data Source=localhost\\sqlexpress";



        public static List<string> ObtenerRoles(int idUsuario)
        {
            if (idUsuario <= 0)
            {
                return new List<string>();
            }

            using (SqlConnection connection = new SqlConnection(connectionString)) // declaración de un bloque using, que se usa para asegurarme de que los recursos se liberen correctamente después de su uso
            {
                connection.Open(); //abro la conexion a la base
                string sql = @"
                    SELECT roles.nombre FROM roles
                    INNER JOIN roles_usuarios ON roles_usuarios.id_rol = roles.id
                    WHERE roles_usuarios.id_usuario = @IdUsuario";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                SqlDataReader reader = command.ExecuteReader(); //devuelve un objeto SqlDataReader llamado reader, que se usa para leer los resultados de la consulta.
                List<string> roles = new List<string>();
                while (reader.Read())
                {
                    roles.Add(reader["nombre"].ToString()); //agrego todos los nombres de roles a la lista de roles
                }
                reader.Close(); //cierro el reader para que se libere los recursos
                return roles;
            }
        }
    }
}
