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
    public partial class FormBuscarProducto : Form
    {
        private Form formuGestorStock;
        ProductoBLL productObject = new ProductoBLL();
        CategoriaBLL ObjCategorias = new CategoriaBLL();

        DataTable dtableProd, dtablecategory = new DataTable();

        public FormBuscarProducto(Form formGestorStock)
        {
            InitializeComponent();
            this.formuGestorStock = formGestorStock;
            tboxIdArticu.Visible = false;    gboxArticuloSelect.Enabled = false;
            CargarCategorias();
        }

        private void btnAtras_Click_1(object sender, EventArgs e)
        {
            this.Close();
            formuGestorStock.Show();
        }

        private void CargarCategorias()
        {
            dtablecategory = ObjCategorias.CargarCategoria();

            cboxPorCatego.DataSource = dtablecategory;
            cboxPorCatego.DisplayMember = "nombre";
            cboxPorCatego.ValueMember = "id";
        }

        #region serie de eventos del formulario FormBuscarProducto---------------------------------------------------------------------

        private void rbPorId_CheckedChanged(object sender, EventArgs e)
        {
            tboxPorID.Visible = true; tboxPorID.Text = "Buscar por ID.";
            tboxPorNombre.Visible = false;
            cboxPorCatego.Visible = false;
        }

        private void rbPorNombre_CheckedChanged(object sender, EventArgs e)
        {
            tboxPorID.Visible = false;
            tboxPorNombre.Visible = true; tboxPorNombre.Text = "Buscar por Nombre.";
            cboxPorCatego.Visible = false;
        }

        private void rbPorCatego_CheckedChanged(object sender, EventArgs e)
        {
            tboxPorID.Visible = false;
            tboxPorNombre.Visible = false;
            cboxPorCatego.Visible = true; cboxPorCatego.Text = "Buscar por Categoría.";
        }

        private void tboxPorNombre_Enter(object sender, EventArgs e)
        {
            tboxPorNombre.Text = "";
        }

        private void tboxPorID_Enter(object sender, EventArgs e)
        {
            tboxPorID.Text = "";
        }

        private void cboxPorCatego_Enter(object sender, EventArgs e)
        {
            cboxPorCatego.Text = "";
        }

        //EN EL TEXTBOX DE BUSQUEDA POR ID, SOLO PERMITIRA NUMEROS ENTEROS
        private void tboxPorID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        //POR CADA VEZ QUE HACEMOS CLICK EN UNA CELDA CON VALOR, SE DISPARA EL EVENTO CORRESPONDIENTE
        private void dgvResultadoBusqueda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            gboxArticuloSelect.Enabled = true;
            tboxIdArticu.Text = dgvResultadoBusqueda.CurrentRow.Cells[0].Value.ToString();
            tboxNombreArticu.Text = dgvResultadoBusqueda.CurrentRow.Cells[1].Value.ToString();
            tboxPrecioArticu.Text = dgvResultadoBusqueda.CurrentRow.Cells[2].Value.ToString();
            nudStockArticu.Value = Convert.ToInt32(dgvResultadoBusqueda.CurrentRow.Cells[4].Value);
            tboxDescriptArticu.Text = dgvResultadoBusqueda.CurrentRow.Cells[5].Value.ToString();
            int valorCatego = (Convert.ToInt32(dgvResultadoBusqueda.CurrentRow.Cells[6].Value)) - 1;//PIVOTE NRO. FILA/ROW
            cboxCategoArticu.Text = (dtablecategory.Rows[valorCatego]["nombre"]).ToString();

            cboxCategoArticu.DataSource = dtablecategory;//HACEMOS CLICK EN UNA FILA Y CARGARA LA CATEGORIA A LA QUE PERTENECE
            cboxCategoArticu.DisplayMember = "nombre";
            cboxCategoArticu.ValueMember = "id";
        }
        #endregion

        #region funcion de busqueda de producto---------------------------------------------------------------------
        private void btnBuscarProd_Click(object sender, EventArgs e)
        {
            try
            {
                if (rbPorId.Checked == true)
                {
                    int valorIdABuscar = ObtenerIDaBuscar();
                    string contextBusqueda = "id";
                    //MessageBox.Show(valorIdABuscar.ToString());
                    dtableProd = productObject.ObtenerValorIDproduct(valorIdABuscar, contextBusqueda);

                    if (dtableProd.Rows.Count > 0)
                    {
                        MostrarValoresProdEnDataGrid(dtableProd);
                    }
                    else if (valorIdABuscar == 0)
                    {
                        MessageBox.Show("Debe elegir un numero mayor a cero.");
                    }
                    else
                    {
                        MessageBox.Show("No hay resultados.");
                    }
                }//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
                if (rbPorNombre.Checked == true)
                {
                    int valorInt = 0;//VARIABLE AUXILIAR
                    string contextBusqueda = ObtenerCadenaStringBuscar();
                    dtableProd = productObject.ObtenerValorIDproduct(valorInt, contextBusqueda);//REUTILIZAMOS LA FUNCION DE BUSQUEDA POR ID
                    if (dtableProd.Rows.Count > 0)
                    {
                        MostrarValoresProdEnDataGrid(dtableProd);
                    }
                    else
                    {
                        MessageBox.Show("No hay resultados.");
                    }
                    //MessageBox.Show(contextBusqueda);
                }//|||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||
                if (rbPorCatego.Checked == true)
                {
                    int valorCategoABuscar = ObtenerCategoriaBuscar();
                    string contextBusqueda = "categoria";
                    dtableProd = ObjCategorias.ObtenerValorProductosPorCatego(valorCategoABuscar, contextBusqueda);

                    //MessageBox.Show(valorCategoABuscar.ToString());
                    if (dtableProd.Rows.Count > 0)
                    {
                        MostrarValoresProdEnDataGrid(dtableProd);
                    }
                    if (valorCategoABuscar == 0)
                    {
                        MessageBox.Show("Debe seleccionar una categoría para iniciar la búsqueda.");
                    }
                }
            }
            catch (Exception atrapado)
            {
                MessageBox.Show(atrapado.Message);
            }
        }
        #endregion

        #region funciones de retorno de valores para busqueda---------------------------------------------------------------------
        private int ObtenerIDaBuscar()
        {
            if (string.IsNullOrEmpty(tboxPorID.Text) || tboxPorID.Text == "Buscar por ID.")
            {
                throw new Exception("Debe ingresar un valor ID para iniciar la búsqueda.");
            }
            else
            {
                return (Convert.ToInt32(tboxPorID.Text));
            }
        }

        private int ObtenerCategoriaBuscar()
        {
            if (string.IsNullOrEmpty(cboxPorCatego.Text) || cboxPorCatego.Text == "Buscar por Categoría.")
            {
                throw new Exception("Debe seleccionar una categoría para iniciar la búsqueda.");
            }
            else
            {
                return (Convert.ToInt32(cboxPorCatego.SelectedValue));
            }
        }

        private string ObtenerCadenaStringBuscar()
        {
            if(string.IsNullOrEmpty(tboxPorNombre.Text) || tboxPorNombre.Text == "Buscar por Nombre.")
            {
                throw new Exception("Debe ingresar el nombre de un articulo a buscar.");
            }
            else
            {
                return ($"{tboxPorNombre.Text}%").ToString();   //INTERPOLACION DE CARACTERES BAJO CONVERSION A STRING.
            }
        }
        #endregion

        private void MostrarValoresProdEnDataGrid(DataTable receivDtable)
        {
            dgvResultadoBusqueda.AllowUserToAddRows = false;//SE DESACTIVAN LAS EDICIONES DE CELDAS.
            dgvResultadoBusqueda.AllowUserToDeleteRows = false;//SE DESACTIVA LA OPCION DE AGREGAR FILAS.
            dgvResultadoBusqueda.ReadOnly = true;//LOS DATOS SOLO SE PODRAN VISUALIZAR, PERO NO MODIFICARSE DESDE EL DGRID.

            dgvResultadoBusqueda.DataSource = receivDtable;
        }

        #region funcion de actualizacion de datos de producto---------------------------------------------------------------------
        private void btnGuardarCambios_Click(object sender, EventArgs e)
        {
            try
            {
                int idArticulo = ObtenerIdArticulo();
                string nombArticulo = ObtenerNombreArticulo();
                double precioArticulo = ObtenerPrecioArticulo();
                //int stockMinimo = AgregarStockMinimo();
                int unidadesArticulo = ObtenerUnidadesArticulo();
                string descripcionArticulo = ObtenerDescripcionArticulo();
                int categoriaArticulo = ObtenerCategoriaArticulo();
                bool productoActualizado = productObject.ActualizarProdPorID(idArticulo, nombArticulo, precioArticulo, unidadesArticulo, descripcionArticulo, categoriaArticulo);

                if (productoActualizado == true)
                {
                    MessageBox.Show("Producto actualizado correctamente.");
                    gboxArticuloSelect.Enabled = false;
                    dgvResultadoBusqueda.DataSource = null;
                }
                else
                {
                    MessageBox.Show("Error al intentar actualizar el producto. Por favor, inténtalo nuevamente.");
                }
            }
            catch (Exception atrapado)
            {
                MessageBox.Show(atrapado.Message);
            }
        }
        #endregion

        #region funciones de retorno de valores presentes en los textbox---------------------------------------------------------------------
        private int ObtenerIdArticulo()
        {
            if (string.IsNullOrEmpty(tboxIdArticu.Text))
            {
                throw new Exception("Solo puede editar productos ya registrados.");
            }
            else
            {
                return (Convert.ToInt32(tboxIdArticu.Text));
            }
        }

        private string ObtenerNombreArticulo()
        {
            if (string.IsNullOrEmpty(tboxNombreArticu.Text))
            {
                throw new Exception("Campo NOMBRE vacío");
            }
            else
            {
                return tboxNombreArticu.Text;
            }
        }

        private double ObtenerPrecioArticulo()
        {
            if (string.IsNullOrEmpty(tboxPrecioArticu.Text))
            {
                throw new Exception("Campo PRECIO vacío");
            }
            else
            {
                return (Convert.ToDouble(tboxPrecioArticu.Text));
            }
        }

        private void tboxPrecioArticu_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != ','))
            {
                e.Handled = true;
            }

            // solo 1 coma decimal
            if ((e.KeyChar == ',') && ((sender as TextBox).Text.IndexOf(',') > -1))
            {
                e.Handled = true;
            }
        }

        private int ObtenerUnidadesArticulo()
        {
            if (nudStockArticu.Value == 0)
            {
                throw new Exception("Campo UNIDADES en valor cero");
            }
            else
            {
                return (Convert.ToInt32(nudStockArticu.Value));
            }
        }

        private string ObtenerDescripcionArticulo()
        {
            if (string.IsNullOrEmpty(tboxDescriptArticu.Text))
            {
                throw new Exception("Campo DESCRIPCIÓN vacío");
            }
            else
            {
                return tboxDescriptArticu.Text;
            }
        }

        private int ObtenerCategoriaArticulo()
        {
            return Convert.ToInt32(cboxCategoArticu.SelectedValue);
        }
        #endregion
    }
}
