using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public class ProductoDAL
    {

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


        public void CargarProductosDesdeBD(GestorStock gestorStock)
        {
            try
            {
                Conexion objConexion = new Conexion();
                // Consulta SQL que trae todos los datos del producto junto con el nombre de la categoría
                string sqlSelectProductos = @"
                    SELECT 
                        p.id,
                        p.nombre, 
                        p.precio, 
                        p.stockMinimo, 
                        p.stockActual, 
                        p.descripcion, 
                        c.nombre AS nombreCategoria
                    FROM 
                        Producto p
                    LEFT JOIN 
                        Categoria_Producto c ON p.categoriaId = c.id;";

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

        public bool RegistrarProductoNuevo(string nombre, double precio, int stockMinimo, int unidades, string descripcion, int categoria)
        {
            try
            {
                Conexion connect = new Conexion();    
                string comandInsertProd = "INSERT INTO Producto(nombre, precio, stockMinimo, stockActual, descripcion, categoriaId) VALUES (@Nombre, @Precio, @StockMinimo, @StockActual, @Descripcion, @CategoriaId)";
                SqlParameter[] parametrosInsertProducto = new SqlParameter[]
                {
                    new SqlParameter("@Nombre", nombre), //los parametros de cada campo de la tabla son asignados a los valores recibidos del metodo
                    new SqlParameter("@Precio", precio),
                    new SqlParameter("@StockMinimo", stockMinimo),
                    new SqlParameter("@StockActual", unidades),
                    new SqlParameter("@Descripcion", descripcion),
                    new SqlParameter("@CategoriaId", categoria)
                };
                int filasAfectadasProducto = connect.EscribirPorComando(comandInsertProd, parametrosInsertProducto);
            }
            catch(Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public DataTable DevolverDatosdeProducto(int idReceived, string contextBusqueda)
        {
            DataTable dtableProd = new DataTable();

            try
            {
                Conexion connect = new Conexion();

                if(contextBusqueda == "id")
                {
                    string comandConsultID = @"SELECT * FROM Producto WHERE id = @idProducto";

                    SqlParameter[] idParametros = new SqlParameter[]
                    {
                    new SqlParameter("@idProducto", idReceived)
                    };

                    dtableProd = connect.LeerPorComando(comandConsultID, idParametros);
                }//''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
                if (contextBusqueda == "categoria")
                {
                    string comandConsultCatego = @"SELECT * FROM Producto WHERE categoriaId = @idCategoria";

                    SqlParameter[] idParametros = new SqlParameter[]
                    {
                    new SqlParameter("@idCategoria", idReceived)
                    };

                    dtableProd = connect.LeerPorComando(comandConsultCatego, idParametros);
                }
                if (idReceived == 0)
                {
                    string comandConsultNombre = @"SELECT * FROM Producto AS p WHERE p.nombre LIKE @Nombre";

                    SqlParameter[] idParametros = new SqlParameter[]
                    {
                    new SqlParameter("@Nombre", contextBusqueda)
                    };

                    dtableProd = connect.LeerPorComando(comandConsultNombre, idParametros);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al obtener resultados por ID: " + ex.Message);
                throw;
            }
            return dtableProd;
        }

        public bool UpdateProductoPorID(int id, string nombre, double precio, int unidades, string descripcion, int categoria)
        {
            try
            {
                Conexion connect = new Conexion();
                string comandUpdateProd = "UPDATE Producto SET nombre = @Nombre, precio = @Precio, stockActual = @StockActual, descripcion = @Descripcion, categoriaId = @CategoriaId WHERE id = @Id;";
                SqlParameter[] parametrosUpdateProducto = new SqlParameter[]
                {
                    new SqlParameter("@Id", id),
                    new SqlParameter("@Nombre", nombre), //los parametros de cada campo de la tabla son asignados a los valores recibidos del metodo
                    new SqlParameter("@Precio", precio),
                    new SqlParameter("@StockActual", unidades),
                    new SqlParameter("@Descripcion", descripcion),
                    new SqlParameter("@CategoriaId", categoria)
                };
                int filasAfectadasProducto = connect.EscribirPorComando(comandUpdateProd, parametrosUpdateProducto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }

        public bool EliminarProductoPorID(int idReceived)
        {
            try
            {
                Conexion connect = new Conexion();
                string comandDeleteProd = "DELETE FROM Producto WHERE id = @Id";

                SqlParameter[] parametrosDeleteProducto = new SqlParameter[]
                {
                    new SqlParameter("@Id", idReceived)
                };
                int filasAfectadasProducto = connect.EscribirPorComando(comandDeleteProd, parametrosDeleteProducto);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return true;
        }
    }
}
