using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using BE;
using System.Data;

namespace DAL
{
    public class UsuarioDAL
    {

        private static string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TC_Permisos;Data Source=localhost\\sqlexpress";
        private Conexion objConexion = new Conexion(); // usamos la instancia de Conexion

        public bool RegistrarUsuario(string nombre, string email, string password)
        {
            try
            {
                string sqlInsertUsuario = "INSERT INTO usuarios (nombre, email, password) VALUES (@Nombre, @Email, @Password)";
                SqlParameter[] parametrosInsertUsuario = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", nombre), //los parametros de cada campo de la tabla son asignados a los valores recibidos del metodo
                    new SqlParameter("@Email", email),
                    new SqlParameter("@Password", password)
                };

                int filasAfectadasUsuario = objConexion.EscribirPorComando(sqlInsertUsuario, parametrosInsertUsuario);

                if (filasAfectadasUsuario > 0)
                {
                    int idUsuario = ObtenerIdUsuarioPorEmail(email); //Si se pudo ingresar un usuario, entonces en la tabla roles usuarios tambien debo ingresar el rol del usuario

                    string sqlInsertRolUsuario = "INSERT INTO roles_usuarios (id_rol, id_usuario) VALUES (@IdRol, @IdUsuario)";
                    SqlParameter[] parametrosInsertRolUsuario = new SqlParameter[]
                    {
                        new SqlParameter("@IdRol", ObtenerIdRolUsuario()),
                        new SqlParameter("@IdUsuario", idUsuario)
                    };

                    int filasAfectadasRolUsuario = objConexion.EscribirPorComando(sqlInsertRolUsuario, parametrosInsertRolUsuario);

                    return filasAfectadasRolUsuario > 0;
                }

                return false;
            }
            catch (Exception ex) //manejo de excepciones generales
            {
                throw ex;
            }
        }

        public bool RegistrarCliente(string nombreCompleto, string CUIL, int id) //al momento de que un usuario compra un producto, se vuelve cliente
        {
            try
            {
                    Conexion objConexion = new Conexion();  //el id del usuario lo recibo mediante el inicio de sesión, ya que lo gauarde en una variable static

                    string sqlInsertCliente = "INSERT INTO clientes (nombre, cuil, id_usuario_creador) VALUES (@nombre, @CUIL, @id)";
                    SqlParameter[] parametrosInsertCliente = new SqlParameter[]//entonces inserto en nuestra tabla clientes los valores pedidos al usuario
                    {
                        new SqlParameter("@nombre", nombreCompleto),
                        new SqlParameter("@CUIL", CUIL),
                        new SqlParameter("@id", id),
                    };

                    int filasAfectadasCliente = objConexion.EscribirPorComando(sqlInsertCliente, parametrosInsertCliente);

                    return filasAfectadasCliente > 0;
                }
            catch (Exception ex)
            {
                    throw ex;
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


        public int ObtenerIdUsuarioPorEmail(string email) //mediante el mail obtengo el id del usuario correspondiente
        {
            string consulta = "SELECT id FROM usuarios WHERE email = @Email";
            SqlParameter[] parametros = new SqlParameter[]
            {
        new SqlParameter("@Email", email)
            };

            DataTable dt = objConexion.LeerPorComando(consulta, parametros);

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["id"]); //el valor retornado es el id, que fue convertido en un entero
            }

            return -1; // Cambiar el valor de retorno según tus necesidades
        }

       /* public List<string> ObtenerRoles(int idUsuario)
        {
            List<string> roles = new List<string>();
            string consulta = "SELECT nombre FROM roles WHERE id IN (SELECT id_rol FROM roles_usuarios WHERE id_usuario = @IdUsuario)";
            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@IdUsuario", idUsuario)
            };

            DataTable dt = objConexion.LeerPorComando(consulta, parametros);

            foreach (DataRow row in dt.Rows)
            {
                roles.Add(row["nombre"].ToString());
            }

            return roles;
        }*/

        /*public int ObtenerIdRolPorNombre(string nombreRol)
        {
            string sql = "SELECT id FROM roles WHERE nombre = @NombreRol";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand sqlConsulta = new SqlCommand(sql, connection);
                sqlConsulta.Parameters.AddWithValue("@NombreRol", nombreRol);

                int idRol = Convert.ToInt32(sqlConsulta.ExecuteScalar());
                return idRol;
            }
        }*/

       /* public bool CambiarRol(int idUsuario, string nuevoRol)
        {
            try
            {
                string sqlActualizarRol = "UPDATE roles_usuarios SET id_rol = @IdRol WHERE id_usuario = @IdUsuario";
                SqlParameter[] parametrosActualizarRol = new SqlParameter[]
                {
            new SqlParameter("@IdRol", ObtenerIdRolPorNombre(nuevoRol)),
            new SqlParameter("@IdUsuario", idUsuario)
                };

                int filasAfectadas = objConexion.EscribirPorComando(sqlActualizarRol, parametrosActualizarRol);

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                // Manejar la excepción según tus necesidades
                throw ex;
            }
        }*/
    }
}
