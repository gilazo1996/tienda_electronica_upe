using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC_Electrodomesticos
{
    public partial class FormComprarProducto : Form
    {
        private GestorStock gestorStock = new GestorStock();
        private UsuarioDAL dalVerProducto = new UsuarioDAL();

        public FormComprarProducto()
        {
            InitializeComponent();
        }

        private void btnVerProductos_Click(object sender, EventArgs e)
        {
            try
            {
                // cargo los productos desde la base de datos
                dalVerProducto.CargarProductosDesdeBD(gestorStock); //invoco al método que me trae los datos de la tabla

                // verifico si la lista de productos está llena
                if (gestorStock.ListaProductos.Count == 0) //valido que se pueda mostrar los productos
                {
                    MessageBox.Show("No se encontraron productos para mostrar.");
                    return; //salgo si no se uestran
                }

                // limpio el ListBox antes de añadir los nuevos productos
                lboxMostrarProductos.Items.Clear();

                // agrego los productos al ListBox
                foreach (ProductoBE producto in gestorStock.ListaProductos)
                {
                    lboxMostrarProductos.Items.Add(producto); //por c ada producto encontrado, lo agrego al listbox
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message); //manejo de excepciones
            }
        }


        private void btnComprarPro_Click(object sender, EventArgs e)
        {
            try
            {
                string productoSeleccionado = lboxMostrarProductos.SelectedItem?.ToString();

                if (string.IsNullOrEmpty(productoSeleccionado))
                {
                    MessageBox.Show("Seleccione un producto para comprar.");
                    return;
                }

                string nombre = tboxNombreCompleto.Text;
                string cuil = tboxCuil.Text;

                // Tomamos el ID del usuario autenticado desde la propiedad estática de UsuarioBE
                int idUsuario = UsuarioBE.IdUsuario;

                if (idUsuario > 0) // Verifico si hay un ID de usuario cargado, es decir, si el usuario se logueó
                {
                    UsuarioDAL usuarioDAL = new UsuarioDAL();

                    // Obtener el ID del producto seleccionado utilizando ProductoDAL
                    ProductoDAL productoDAL = new ProductoDAL();
                    int idProducto = productoDAL.ObtenerIdProductoPorNombre(productoSeleccionado);

                    if (idProducto > 0) // Verifico si se pudo obtener el ID del producto seleccionado
                    {
                        decimal precioProducto = productoDAL.ObtenerPrecioProducto(productoSeleccionado); // Función para obtener el precio del producto

                        // Registrar al cliente si no existe
                        bool clienteYaExistente;
                        bool registroClienteExitoso = usuarioDAL.RegistrarCliente(nombre, cuil, idUsuario, out clienteYaExistente);

                        if (registroClienteExitoso)
                        {
                            // Registrar la compra utilizando el ID del producto obtenido, el ID del cliente y el precio del producto
                            bool registroCompraExitoso = usuarioDAL.RegistrarCompra(idProducto, idUsuario, precioProducto);

                            if (registroCompraExitoso)
                            {
                                MessageBox.Show("Compra exitosa. " + (clienteYaExistente ? "¡Bienvenido de nuevo!" : "¡Bienvenido, nuevo cliente!"));
                                this.Close(); // Cierro el formulario después de la compra
                            }
                            else
                            {
                                MessageBox.Show("Error al comprar el producto. Por favor, inténtalo nuevamente.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al registrar al cliente. Por favor, inténtalo nuevamente.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener el ID del producto seleccionado. Por favor, inténtalo nuevamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Necesita registrarse y estar logueado para comprar.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error: " + ex.Message);
            }
        }


        private void lboxMostrarProductos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lboxMostrarProductos.SelectedItem != null)
            {
                string nombreProductoSeleccionado = lboxMostrarProductos.SelectedItem.ToString();
                // Ahora puedes usar nombreProductoSeleccionado para obtener el ID del producto
            }
        }
    }
}
///


