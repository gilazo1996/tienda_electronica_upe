using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace DAL
{
    public class Permisos
    {
        private static string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TC_Permisos;Data Source=localhost\\sqlexpress";

        public static bool TienePermiso(string permiso, int idUsuario)
        {
            if (string.IsNullOrEmpty(permiso) || idUsuario <= 0)
            {
                return false;
            }

            string[] permisos = new string[] { permiso };
            return TieneAlgunPermiso(permisos, idUsuario);
        }

        public static bool TieneAlgunPermiso(string[] permisos, int idUsuario)
        {
            if (permisos == null || permisos.Length == 0 || idUsuario <= 0)
            {
                return false;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = @"
                SELECT 1 FROM permisos
                INNER JOIN roles_permisos ON roles_permisos.id_permiso = permisos.id
                INNER JOIN roles_usuarios ON roles_usuarios.id_rol = roles_permisos.id_rol
                WHERE roles_usuarios.id_usuario = @IdUsuario AND permisos.nombre IN (
                    SELECT value FROM STRING_SPLIT(@Permisos, ',')
                )";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                command.Parameters.AddWithValue("@Permisos", string.Join(",", permisos));

                SqlDataReader reader = command.ExecuteReader();
                bool result = reader.HasRows;
                reader.Close();
                return result;
            }
        }

        public static List<string> ObtenerPermisos(int idUsuario)
        {
            if (idUsuario <= 0)
            {
                return new List<string>();
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = @"
                    SELECT permisos.nombre FROM permisos
                    INNER JOIN roles_permisos ON roles_permisos.id_permiso = permisos.id
                    INNER JOIN roles_usuarios ON roles_usuarios.id_rol = roles_permisos.id_rol
                    WHERE roles_usuarios.id_usuario = @IdUsuario";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                SqlDataReader reader = command.ExecuteReader();
                List<string> permisos = new List<string>();
                while (reader.Read())
                {
                    permisos.Add(reader["nombre"].ToString());
                }
                reader.Close();
                return permisos;
            }
        }

        // (esRol, esAlgunRol, etc.)
        public static bool EsRol(string rol, int idUsuario)
        {
            if (string.IsNullOrEmpty(rol) || idUsuario <= 0)
            {
                return false;
            }

            string[] roles = new string[] { rol };
            return EsAlgunRol(roles, idUsuario);
        }

        public static bool EsAlgunRol(string[] roles, int idUsuario)
        {
            if (roles == null || roles.Length == 0 || idUsuario <= 0)
            {
                return false;
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = @"
                    SELECT 1 FROM roles
                    INNER JOIN roles_usuarios ON roles_usuarios.id_rol = roles.id
                    WHERE roles_usuarios.id_usuario = @IdUsuario AND roles.nombre IN (@Roles)";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);
                command.Parameters.AddWithValue("@Roles", string.Join(",", roles));

                SqlDataReader reader = command.ExecuteReader();
                bool result = reader.HasRows;
                reader.Close();
                return result;
            }
        }

        public static List<string> ObtenerRoles(int idUsuario)
        {
            if (idUsuario <= 0)
            {
                return new List<string>();
            }

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string sql = @"
                    SELECT roles.nombre FROM roles
                    INNER JOIN roles_usuarios ON roles_usuarios.id_rol = roles.id
                    WHERE roles_usuarios.id_usuario = @IdUsuario";
                SqlCommand command = new SqlCommand(sql, connection);
                command.Parameters.AddWithValue("@IdUsuario", idUsuario);

                SqlDataReader reader = command.ExecuteReader();
                List<string> roles = new List<string>();
                while (reader.Read())
                {
                    roles.Add(reader["nombre"].ToString());
                }
                reader.Close();
                return roles;
            }
        }
    }
}
