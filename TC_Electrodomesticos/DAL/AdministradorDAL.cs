using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AdministradorDAL
    {


        public DataTable ObtenerUsuariosPorNombreYCorreo(string nombre, string correo)
        {
            try
            {
                Conexion objConexion = new Conexion();
                objConexion.Conectar();

                string sql = "SELECT * FROM usuarios WHERE nombre LIKE @nombre AND email LIKE @correo";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@nombre", "%" + nombre + "%"), //los parametros solo seran el nombre y el correo
                    new SqlParameter("@correo", "%" + correo + "%")
                };

                DataTable dtUsuarios = objConexion.LeerPorComando(sql, parametros);
                //objConexion.Desconectar();
                return dtUsuarios;

            }catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public DataTable ObtenerTodosLosUsuarios()
        {
            try
            {
                Conexion objConexion = new Conexion();
                objConexion.Conectar();

                string sql = "SELECT * FROM usuarios";
                DataTable dtUsuarios = objConexion.LeerPorComando(sql);
                //objConexion.Desconectar();
                return dtUsuarios;

            }catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

        public bool BloquearUsuario(int idUsuario)
        {
            try
            {
                Conexion objConexion = new Conexion();
                objConexion.Conectar();

                string sqlUpdateEstado = "UPDATE usuarios SET estado = 'inactivo' WHERE id = @IdUsuario";
                SqlParameter[] parametros = new SqlParameter[]
                {
                new SqlParameter("@IdUsuario", idUsuario)
                };

                int filasAfectadas = objConexion.EjecutarComando(sqlUpdateEstado, parametros);

                return filasAfectadas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al bloquear usuario: " + ex.Message);
                return false;
            }
        }

        public bool DesbloquearUsuario(int idUsuario)
        {
            try
            {
                Conexion conexion = new Conexion();
                conexion.Conectar();

                string sqlUpdateEstado = "UPDATE usuarios SET estado = 'activo' WHERE id = @idUsuario";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter ("@IdUsuario", idUsuario)
                };

                int filasCambiadas = conexion.EjecutarComando(sqlUpdateEstado, parametros);

                return filasCambiadas > 0;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        // Método para obtener los roles disponibles
        public DataTable ObtenerRoles()
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sqlQuery = "SELECT id, nombre FROM roles";
            return conexion.LeerPorComando(sqlQuery);
        }

        // Método para crear un usuario
        public int CrearUsuario(string nombre, string email, string password)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();

            if (UsuarioExiste(email))
            {
                throw new Exception("El usuario ya existe.");
            }

            string sqlQuery = "INSERT INTO usuarios (nombre, email, password, estado) VALUES (@Nombre, @Email, @Password, 'activo'); SELECT SCOPE_IDENTITY();";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Nombre", nombre),
                new SqlParameter("@Email", email),
                new SqlParameter("@Password", password)
            };
            return Convert.ToInt32(conexion.LeerPorComandoScalar(sqlQuery, parametros));
        }

        public bool UsuarioExiste(string email)
        {
            Conexion conexion = new Conexion();
            conexion.Conectar();
            string sqlQuery = "SELECT COUNT(*) FROM usuarios WHERE email = @Email";
            SqlParameter[] parametros = new SqlParameter[]
            {
            new SqlParameter("@Email", email)
            };
            int count = Convert.ToInt32(conexion.LeerPorComandoScalar(sqlQuery, parametros));
            return count > 0;
        }

        // Método para asignar un rol a un usuario
        public bool AsignarRolUsuario(int idUsuario, int idRol)
        {
            try
            {
                Conexion objConexion = new Conexion();
                objConexion.Conectar();
                string sqlQuery = "INSERT INTO roles_usuarios (id_rol, id_usuario) VALUES (@IdRol, @IdUsuario)";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdRol", idRol),
                    new SqlParameter("@IdUsuario", idUsuario)
                };
                return objConexion.EscribirPorComando(sqlQuery, parametros) > 0;

            }catch(Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }


        public bool ModificarUsuarioCampo(int idUsuario, string campo, string valor)
        {

            try
            {
                Conexion objConexion = new Conexion();
                objConexion.Conectar();
                string sqlQuery = $"UPDATE usuarios SET {campo} = @Valor WHERE id = @IdUsuario";
                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@IdUsuario", idUsuario),
                    new SqlParameter("@Valor", valor)
                };
                return objConexion.EscribirPorComando(sqlQuery, parametros) > 0;

            }catch (Exception ex)
            {
                Console.Write(ex.Message);
                return false;
            }
        }


    }
}
