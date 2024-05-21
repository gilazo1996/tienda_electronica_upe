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
            {
                string productoSeleccionado = lboxMostrarProductos.SelectedItem.ToString();

                string nombre = tboxNombreCompleto.Text;
                string cuil = tboxCuil.Text;

                // acá tomamos el ID del usuario autenticado desde la propiedad estatica de UsuarioBE
                int idUsuario = UsuarioBE.IdUsuario;

                if (idUsuario > 0) // verifico si hay un ID de usuario cargado, es decir, si el usuario se logeo
                {
                    UsuarioDAL usuarioDAL = new UsuarioDAL();

                    // Obtener el ID del producto seleccionado utilizando ProductoDAL
                    UsuarioDAL productoDAL = new UsuarioDAL();
                    int idProducto = productoDAL.ObtenerIdProductoPorNombre(productoSeleccionado);

                    if (idProducto > 0) // verifico si se pudo obtener el ID del producto seleccionado
                    {
                        decimal precioProducto = productoDAL.ObtenerPrecioProducto(productoSeleccionado); // Función para obtener el precio del producto

                        // Registrar la compra utilizando el ID del producto obtenido, el ID del cliente y el precio del producto
                        bool registroCompraExitoso = usuarioDAL.RegistrarCompra(idProducto, idUsuario, precioProducto);

                        // Registrar al cliente si la compra se registró correctamente
                        if (registroCompraExitoso)
                        {
                            bool registroClienteExitoso = usuarioDAL.RegistrarCliente(nombre, cuil, idUsuario);

                            if (registroClienteExitoso)
                            {
                                MessageBox.Show("Compra existosa. ¡Bienvenido, nuevo cliente!");
                                this.Close(); // cierro el formulario después de la compra
                            }
                            else
                            {
                                MessageBox.Show("Error al registrar al cliente. Por favor, inténtalo nuevamente.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Error al comprar el producto. Por favor, inténtalo nuevamente.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("No se pudo obtener el ID del producto seleccionado. Por favor, inténtalo nuevamente.");
                    }
                }
                else
                {
                    MessageBox.Show("Necesita registrarse y estar logeado para comprar.");
                }
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


