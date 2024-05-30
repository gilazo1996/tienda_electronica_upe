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

        public static bool EliminarUsuario()
        {
            string emailUsuario = "email@ejemplo.com";
            /*el estado por defecto de los usuarios es activo y lo elimino de forma
            logica cambiando el estado a inactivo*/
            string sql ="UPDATE usuarios SET estado = 'inactivo' WHERE email = @EmailUsuario";

            using (SqlConnection connection = new SqlConnection(connectionString)) //instancio objeto SqlCommand para trabajar con la conexion a la bbdd dentro del bloque using, para asegurarme de que los recursos se liberen correctamente después de su uso
            {
                connection.Open();
                SqlCommand sqlConsulta = new SqlCommand(sql, connection);
                sqlConsulta.Parameters.AddWithValue("@Email", emailUsuario); //asigno al parametro obtenido el valor de la cadena rolUsuario

            }
        }

        public bool RegistrarCliente(string nombreCompleto, string CUIL, int id) //al momento de que un usuario compra un producto, se vuelve cliente
        {
            try
            {
                    Conexion objConexion = new Conexion();  //el id del usuario lo recibo mediante el inicio de sesión, ya que lo tomo de la propiedad static

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


        public void CargarProductosDesdeBD(GestorStock gestorStock)
        {
            try
            {
                Conexion objConexion = new Conexion();
                //consulta SQL que me trae todos los datos del producto, correspondiendo con el gestor de stock, proveedor y almacen que trajo el producto
                //nota a futuro: eliminar campo clienteId
                string sqlSelectProductos = @" 
                               SELECT 
                                p.id,
                                p.nombre, 
                                p.precio, 
                                p.stockMinimo, 
                                p.stockActual, 
                                p.descripcion, 
                                c.nombre AS nombreCategoria, 
                                pr.nombre AS proveedorNombre, 
                                a.nombre AS almacenNombre, 
                                cl.nombre AS clienteNombre, 
                                g.nombreGestor AS gestorStockNombre, 
                                v.nombreVendedor AS vendedorNombre
                            FROM 
                                Producto p
                            LEFT JOIN 
                                Categoria_Producto c ON p.categoriaId = c.id
                            LEFT JOIN 
                                Proveedor pr ON p.proveedorId = pr.id
                            LEFT JOIN 
                                Almacen a ON p.almacenId = a.id
                            LEFT JOIN 
                                Clientes cl ON p.clienteId = cl.id
                            LEFT JOIN 
                                gestores_stock g ON p.gestorStockId = g.id
                            LEFT JOIN 
                                vendedores v ON p.vendedorId = v.id;";

                DataTable dtProductos = objConexion.LeerPorComando(sqlSelectProductos);

                gestorStock.ListaProductos.Clear();

                foreach (DataRow row in dtProductos.Rows)
                {
                    ProductoBE producto = new ProductoBE
                    {
                        IDproducto = Convert.ToInt32(row["id"]),
                        NombreProducto = row["nombre"].ToString(),
                        Descripcion = row["descripcion"].ToString(),
                        Categoria = row["nombreCategoria"].ToString(),
                        Precio = Convert.ToDouble(row["precio"]),
                        Stock = Convert.ToInt32(row["stockActual"])
                    };

                    gestorStock.ListaProductos.Add(producto);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al cargar productos desde la base de datos: " + ex.Message);
                throw;
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

        public decimal ObtenerPrecioProducto(string nombreProductoCompleto)
        {
            decimal precioProducto = 0;

            try
            {
                Conexion objConexion = new Conexion();

                // Separar el nombre del producto del resto de la cadena
                string[] partesProducto = nombreProductoCompleto.Split(new string[] { " - " }, StringSplitOptions.None);
                string nombreProducto = partesProducto[0]; // El nombre del producto estará en el primer campo

                string sqlSelectPrecio = @"
                    SELECT precio FROM Producto WHERE nombre = @NombreProducto";

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@NombreProducto", nombreProducto)
                };

                DataTable dtPrecio = objConexion.LeerPorComando(sqlSelectPrecio, parametros);

                if (dtPrecio.Rows.Count > 0)
                {
                    precioProducto = Convert.ToDecimal(dtPrecio.Rows[0]["precio"]);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el precio del producto: " + ex.Message);
                throw;
            }

            return precioProducto;
        }



        // método para obtener el ID del producto por su nombre
        public int ObtenerIdProductoPorNombre(string nombreProductoCompleto) //recibo el nombre del producto seleccionado
        {
            int idProducto = 0;

            try
            {
                Conexion objConexion = new Conexion();

                // acá me fjo solo el nombre del producto eliminando el precio y la categoría
                string[] partesProducto = nombreProductoCompleto.Split(new string[] { " - " }, StringSplitOptions.None);
                //como el item seleccionado contiene la structura de {Nombre - Categoria - Precio} necesito separar estos campos
                string nombreProducto = partesProducto[0]; // el nombre del producto estará en el primer campo

                string sqlSelectProducto = @"
                SELECT id FROM Producto WHERE nombre = @NombreProducto"; //traigo el id del producto con el mismo nombre

                SqlParameter[] parametros = new SqlParameter[]
                {
                    new SqlParameter("@NombreProducto", nombreProducto)
                };

                DataTable dtProducto = objConexion.LeerPorComando(sqlSelectProducto, parametros); 

                if (dtProducto.Rows.Count > 0)
                {
                    idProducto = Convert.ToInt32(dtProducto.Rows[0]["id"]);//convierto en entero el valor obtenido de la consulta
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener el ID del producto: " + ex.Message);
                throw;
            }
             
            return idProducto; //retorno el id para trabajarlo
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
