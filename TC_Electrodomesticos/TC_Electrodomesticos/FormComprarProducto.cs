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
        private ProductoDAL dalVerProducto = new ProductoDAL();

        public FormComprarProducto()
        {
            InitializeComponent();
            VerProductos();
        }

        private void VerProductos()
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
        //con esta funcion obtengo los datos de los producto del carrito
        private void ObtenerDetallesFactura()
        {
            
            foreach(var item in listBoxCarrito.Items)
            {
                
                string productoSeleccionado = item.ToString();

                string[] partesProducto = productoSeleccionado.Split(new string[] { " X " }, StringSplitOptions.None);
                
                string nombreProducto = partesProducto[0];
                
                int precio = Convert.ToInt32(partesProducto[1]);
                int cantidad = Convert.ToInt32(partesProducto[2]);
                int subtotal = precio * cantidad;

                
                UsuarioDAL usuarioDAL = new UsuarioDAL();
                int idUsuario = UsuarioBE.IdUsuario;
                //busco la factura asociada al cliente
                int id_factura = usuarioDAL.ObtenerIDFacturaCliente(idUsuario);
                //si la encuentro inserto el detalle de la venta

                // Obtener el ID del producto seleccionado utilizando ProductoDAL
                ProductoDAL productoDAL = new ProductoDAL();
                int idProducto = productoDAL.ObtenerIdProductoPorNombre(nombreProducto);

                if (id_factura > 0)
                {
                    usuarioDAL.InsertarDetalleVenta(id_factura,idProducto,cantidad,subtotal);
                    usuarioDAL.ActualizarStock(nombreProducto, cantidad);
                }
                

            }

        }
        private int ValidarCamposCompletos()
        {
            string nombre = tboxNombreCompleto.Text;
            string cuil = tboxCuil.Text;
            int resultado = -1;
            if(string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(cuil))
            {
                MessageBox.Show("Complete todos los campos");
                resultado = -1;


            }
            else
            {
                resultado = 0;
            }
            return resultado ;
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

                // Tomamos el ID del usuario autenticado desde la propiedad estática de UsuarioBE
                int idUsuario = UsuarioBE.IdUsuario;
                int camposCompletos = ValidarCamposCompletos();

                if (idUsuario > 0 && camposCompletos == 0) // Verifico si hay un ID de usuario cargado, es decir, si el usuario se logueó
                {
                    
                    string nombre = tboxNombreCompleto.Text;
                    string cuil = tboxCuil.Text;

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
                            int totalCompra = Convert.ToInt32(textBoxTotalCompra.Text); 
                            // Registrar la compra utilizando el ID del producto obtenido, el ID del cliente y el precio del producto
                            bool registroCompraExitoso = usuarioDAL.RegistrarCompra(idUsuario,totalCompra);

                            if (registroCompraExitoso)
                            {
                                
                                MessageBox.Show( (clienteYaExistente ? "Compra exitosa! ": "¡Bienvenido, nuevo cliente!"));
                                //con esta funcion obtengo los detalles de la compra
                                ObtenerDetallesFactura();
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
                //cargo el stock del producto seleccionado en el combobox
                CargarStockComboBox();

            }
        }

        private void tboxNombreCompleto_TextChanged(object sender, EventArgs e)
        {

        }
        //aca cargo el stock del producto en el combo box para seleccionar
        private void CargarStockComboBox()
        {
            comboBoxCantidadPro.Items.Clear();
            if (lboxMostrarProductos.SelectedItem!=null)
            {
                try
                {
                    string productoSeleccionado = lboxMostrarProductos.SelectedItem.ToString();

                    string[] partesProducto = productoSeleccionado.Split(new string[] { " - " }, StringSplitOptions.None);
                    int unidad=0;
                    int stockProducto = Convert.ToInt32(partesProducto[3]);

                    while (unidad < stockProducto)
                    {
                        unidad++;
                        
                        comboBoxCantidadPro.Items.Add(unidad.ToString());
                    }
                    comboBoxCantidadPro.SelectedIndex = 0;

                }
                catch (Exception e)
                {
                    MessageBox.Show(e.ToString());

                }
            }
        }
        int totalCompra;
        //esta funcion agrega los productos al carrito
        private void btnAñadirAlCarrito_Click(object sender, EventArgs e)
        {
            
            if (lboxMostrarProductos.SelectedItem != null && comboBoxCantidadPro.SelectedItem != null)
            {
                string productoSeleccionado = lboxMostrarProductos.SelectedItem.ToString();

                string[] partesProducto = productoSeleccionado.Split(new string[] { " - " }, StringSplitOptions.None);
                // obtengo el nombre del producto, el nombre del producto esta
                // en el primer campo                 
                listBoxCarrito.Items.Add(partesProducto[0] + " X " + partesProducto[2] + " X " + comboBoxCantidadPro.SelectedItem.ToString());

                int precioProducto = Convert.ToInt32(partesProducto[2]);
                int cantidadProducto = Int32.Parse(comboBoxCantidadPro.SelectedItem.ToString());
                totalCompra = totalCompra + precioProducto * cantidadProducto;
                textBoxTotalCompra.Text = totalCompra.ToString();


            }
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            if (listBoxCarrito.SelectedItem != null)
            {
                string productoSeleccionado = listBoxCarrito.SelectedItem.ToString();

                string[] partesProducto = productoSeleccionado.Split(new string[] { " X " }, StringSplitOptions.None);
                // obtengo el nombre del producto, el nombre del producto esta

                int precioProducto = Convert.ToInt32(partesProducto[1]);
                int cantidadProducto = Convert.ToInt32(partesProducto[2]);

                totalCompra = totalCompra - precioProducto * cantidadProducto;
                textBoxTotalCompra.Text = totalCompra.ToString();
                listBoxCarrito.Items.Remove(listBoxCarrito.SelectedItem);
            }
        }

        private void comboBoxCantidadPro_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormComprarProducto_Load(object sender, EventArgs e)
        {

        }
    }
}
///


