using BLL;
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
    public partial class FormVerInventario : Form
    {
        private Form formuGestorStock;
        GestorStock gestorStock = new GestorStock();
        ProductoDAL productoDAL = new ProductoDAL();

        public FormVerInventario(Form formGestorStock)
        {
            InitializeComponent();

            productoDAL.CargarProductosDesdeBD(gestorStock);
            List<ProductoBE> listInventario = gestorStock.ListaProductos;
            tboxIdProd.Visible = false;

            if (listInventario != null && listInventario.Count > 0)
            {
                dgvListaProd.Refresh();
                dgvListaProd.AllowUserToAddRows = false;//SE DESACTIVAN LAS EDICIONES DE CELDAS.
                dgvListaProd.AllowUserToDeleteRows = false;//SE DESACTIVA LA OPCION DE AGREGAR FILAS.
                dgvListaProd.ReadOnly = true;//LOS DATOS SOLO SE PODRAN VISUALIZAR, PERO NO MODIFICARSE DESDE EL DGRID.
                dgvListaProd.DataSource = listInventario;
                dgvListaProd.Columns[0].HeaderText = "Nro. articulo";
                dgvListaProd.Columns[1].HeaderText = "Articulo";
                dgvListaProd.Columns[2].HeaderText = "Descripcion";
                dgvListaProd.Columns[3].HeaderText = "Categoria";
                dgvListaProd.Columns[4].HeaderText = "Precio";
                dgvListaProd.Columns[5].HeaderText = "Unidades";
            }
            else
            {
                MessageBox.Show("No hay productos disponibles para mostrar.");
            }

            this.formuGestorStock = formGestorStock;
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            formuGestorStock.Show();
        }

        private void btnEliminarProd_Click(object sender, EventArgs e)
        {
            if (dgvListaProd.SelectedRows.Count > 0)
            {
                tboxIdProd.Text = dgvListaProd.CurrentRow.Cells[0].Value.ToString();
                productoDAL.CargarProductosDesdeBD(gestorStock);
                List<ProductoBE> listInventario = gestorStock.ListaProductos;
                ProductoBLL productBLL = new ProductoBLL();
                int valorId = Convert.ToInt32(tboxIdProd.Text);

                if (MessageBox.Show("Desea eliminar producto seleccionado?", "Confirmación", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    productBLL.EliminarProductoPorID(valorId);
                    MessageBox.Show("El articulo ha sido borrado");
                    dgvListaProd.DataSource = null; 
                    dgvListaProd.DataSource = listInventario;
                }
            }
            else
            {
                MessageBox.Show("seleccione una fila por favor");
            }
        }
    }
}
