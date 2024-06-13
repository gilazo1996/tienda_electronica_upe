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
    public partial class FormAltaProducto : Form
    {
        private Form formuGestorStock;

        public FormAltaProducto(Form formGestorStock)
        {
            InitializeComponent();

            this.formuGestorStock = formGestorStock;

            CargarCategorias();   //CON ESTA FUNCION CARGAREMOS EL COMBOBOX DE CATEGORIA
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            this.Close();
            formuGestorStock.Show();
        }

        private void btnRegistrarProd_Click(object sender, EventArgs e)
        {
            try
            {
                string nombProd = ObtenerNombreProd();
                double precioProd = ObtenerPrecioProd();
                int stockMinimo = AgregarStockMinimo();
                int unidadesProd = ObtenerUnidadesProd();
                string descripcionProd = ObtenerDescripcionProd();
                int categoriaProd = ObtenerCategoriaProd();
                //MessageBox.Show(categoriaProd.ToString());
                ProductoDAL productDal = new ProductoDAL();
                bool productoAgregado = productDal.RegistrarProductoNuevo(nombProd, precioProd, stockMinimo, unidadesProd, descripcionProd, categoriaProd);
                
                if(productoAgregado == true)
                {
                    MessageBox.Show("Producto agregado correctamente.");
                    LimpiarCamposProd();
                }
                else
                {
                    MessageBox.Show("Error al registrar el producto. Por favor, inténtalo nuevamente.");
                }
            }
            catch (Exception atrapado)
            {
                MessageBox.Show(atrapado.Message);
            }
        }

        private string ObtenerNombreProd()
        {
            if (string.IsNullOrEmpty(tboxNombreProd.Text))
            {
                throw new Exception("Campo NOMBRE vacío");
            }
            else
            {
                return tboxNombreProd.Text;
            }
        }

        private double ObtenerPrecioProd()
        {
            if (string.IsNullOrEmpty(tboxPrecioProd.Text))
            {
                throw new Exception("Campo PRECIO vacío");
            }
            else
            {
                return (Convert.ToDouble(tboxPrecioProd.Text));
            }
        }

        //ESTA FUNCION ES PARA DETERMINAR QUE EN EL CAMPO DE PRECIO SOLO ACEPTE VALORES DECIMALES.
        private void tboxPrecioProd_KeyPress(object sender, KeyPressEventArgs e)
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

        private int AgregarStockMinimo()   //VALOR POR DEFECTO PARA EL STOCK MINIMO
        {
            return 7;
        }

        private int ObtenerUnidadesProd()
        {
            if (nudStockProd.Value == 0)
            {
                throw new Exception("Campo UNIDADES en valor cero");
            }
            else
            {
                return (Convert.ToInt32(nudStockProd.Value));
            }
        }

        private string ObtenerDescripcionProd()
        {
            if (string.IsNullOrEmpty(tboxDescriptProd.Text))
            {
                throw new Exception("Campo DESCRIPCIÓN vacío");
            }
            else
            {
                return tboxDescriptProd.Text;
            }
        }

        private int ObtenerCategoriaProd()
        {
            return Convert.ToInt32(cboxCategProd.SelectedValue);
        }

        private void CargarCategorias()
        {
            CategoriaBLL ObjCategorias = new CategoriaBLL();
            DataTable category = ObjCategorias.CargarCategoria();

            cboxCategProd.DataSource = category;
            cboxCategProd.DisplayMember = "nombre";
            cboxCategProd.ValueMember = "id";
        }

        public void LimpiarCamposProd()   //Por cada registro de producto, los campos se limpiaran.
        {
            tboxNombreProd.Text = "";    tboxPrecioProd.Text = "";
            nudStockProd.Value = 1;    tboxDescriptProd.Text = "";
        }

        private void btnLimpiarCampos_Click(object sender, EventArgs e)
        {
            LimpiarCamposProd();
        }
    }
}
