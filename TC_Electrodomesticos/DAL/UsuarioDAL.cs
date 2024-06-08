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

        private Conexion objConexion = new Conexion(); // usamos la instancia de Conexion
        AdministradorDAL verificarExiste = new AdministradorDAL();
        public bool RegistrarUsuario(string nombre, string email, string password)
        {
            try
            {

                if (verificarExiste.UsuarioExiste(email))
                {
                    throw new Exception("El usuario ya existe.");
                }

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

        public bool RegistrarCliente(string nombreCompleto, string CUIL, int id, out bool clienteYaExistente)
        {
            clienteYaExistente = false;
            try
            {
                Conexion objConexion = new Conexion(); // El id del usuario lo recibo mediante el inicio de sesión, ya que lo tomo de la propiedad estática
                objConexion.Conectar(); // Asegurarse de abrir la conexión antes de usarla

                // Verificar si el cliente ya existe
                string sqlVerificarCliente = "SELECT COUNT(*) FROM clientes WHERE id_usuario_creador = @id";
                SqlParameter[] parametrosVerificarCliente = new SqlParameter[]
                {
                     new SqlParameter("@id", id)
                };

                int clienteExiste = Convert.ToInt32(objConexion.LeerPorComandoScalar(sqlVerificarCliente, parametrosVerificarCliente));

                if (clienteExiste > 0)
                {
                    // El cliente ya existe, no realizar la inserción
                    clienteYaExistente = true;
                    return true; // Retornamos true ya que, desde la perspectiva del método, la operación fue exitosa
                }

                // Insertar nuevo cliente
                string sqlInsertCliente = "INSERT INTO clientes (nombre, cuil, id_usuario_creador) VALUES (@nombre, @CUIL, @id)";
                SqlParameter[] parametrosInsertCliente = new SqlParameter[]
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

        public bool RegistrarCompra(int idProducto, int idUsuario, decimal precioProducto)
        {
            try
            {
                Conexion objConexion = new Conexion();

                // Obtener la fecha actual
                DateTime fechaActual = DateTime.Now;

                // Insertar el registro en la tabla de Factura
                string sqlInsertFactura = @"
                    INSERT INTO Factura (id_usuario, fecha_compra, total, id_producto_comprado)
                    VALUES (@IdUsuario, @Fecha, @Total, @IdProducto)";

                SqlParameter[] parametrosFactura = new SqlParameter[]
                {
                    new SqlParameter("@IdUsuario", idUsuario),
                    new SqlParameter("@Fecha", fechaActual),
                    new SqlParameter("@Total", precioProducto),
                    new SqlParameter("@IdProducto", idProducto)
                };

                int filasAfectadasFactura = objConexion.EjecutarComando(sqlInsertFactura, parametrosFactura);

                if (filasAfectadasFactura > 0)
                {
                    // Actualizar el stock del producto
                    string sqlUpdateStock = @"UPDATE Producto SET stockActual = stockActual - 1 WHERE id = @IdProducto";
                    SqlParameter[] parametrosUpdateStock = new SqlParameter[]
                    {
                new SqlParameter("@IdProducto", idProducto)
                    };
                    int filasAfectadasStock = objConexion.EjecutarComando(sqlUpdateStock, parametrosUpdateStock);

                    return filasAfectadasStock > 0; // Retorna true si se actualizó el stock correctamente
                }
                else
                {
                    Console.WriteLine("Error al insertar en la tabla Factura.");
                    return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al registrar la compra: " + ex.Message);
                throw;
            }
        }

        public int ObtenerIdUsuarioPorEmail(string email) //mediante el mail obtengo el id del usuario correspondiente
        {
            string consulta = "SELECT id FROM usuarios WHERE email = @Email";
            SqlParameter[] parametros = new SqlParameter[]
            {
                new SqlParameter("@Email", email)
            };

            DataTable dt = objConexion.LeerPorComando(consulta, parametros); //obtengo los resultados devueltos de LeerPorComanto en un datatable

            if (dt.Rows.Count > 0)
            {
                return Convert.ToInt32(dt.Rows[0]["id"]); //el valor retornado es el id, que fue convertido en un entero
            }

            return -1; // Cambiar el valor de retorno según tus necesidades
        }

        private static string connectionString = "Integrated Security=SSPI;Persist Security Info=False;Initial Catalog=TC_Permisos;Data Source=localhost\\sqlexpress";

        public static int ObtenerIdRolUsuario() //nota: modificar este método para usar la clae conexion.cs
        {
            string rolUsuario = "usuario"; //cadena usuario para trabajar con la consulta
            string sql = "SELECT id FROM roles WHERE nombre = @RolUsuario"; //consulta para obtener el id de la tabla roles donde el usuario coincida

            using (SqlConnection connection = new SqlConnection(connectionString)) //instancio objeto SqlCommand para trabajar con la conexion a la bbdd dentro del bloque using, para asegurarme de que los recursos se liberen correctamente después de su uso
            {
                connection.Open();
                SqlCommand sqlConsulta = new SqlCommand(sql, connection);
                sqlConsulta.Parameters.AddWithValue("@RolUsuario", rolUsuario); //asigno al parametro obtenido el valor de la cadena rolUsuario

                int idRolUsuario = Convert.ToInt32(sqlConsulta.ExecuteScalar()); //convierto el idRol obtenido a entero
                return idRolUsuario; //retorno el id que obtuve una vez q lo convertí en entero
            }
        }


    }
}
