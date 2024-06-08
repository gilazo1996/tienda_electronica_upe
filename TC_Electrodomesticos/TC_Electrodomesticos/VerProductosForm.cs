using BE;
using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC_Electrodomesticos
{
    public partial class VerProductosForm : Form
    {
        public VerProductosForm()
        {
            InitializeComponent();
        }

        private void FormGrilla_Load(object sender, EventArgs e)
        {
            GestorStock gestorStock = new GestorStock();
            ProductoDAL usuarioDAL = new ProductoDAL();
            usuarioDAL.CargarProductosDesdeBD(gestorStock); // Cargar los productos en la instancia de GestorStock

            List<ProductoBE> listaProductos = gestorStock.ListaProductos; // Obtener la lista de productos

            if (listaProductos != null && listaProductos.Count > 0)
            {
                dataGrillaProductos.DataSource = listaProductos; // Asignar la lista de productos al DataSource del DataGridView
                dataGrillaProductos.Refresh(); // Actualizar la visualización de la grilla
            }
            else
            {
                MessageBox.Show("No hay productos disponibles para mostrar.");
            }
        }

        private void dataGrillaProductos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
