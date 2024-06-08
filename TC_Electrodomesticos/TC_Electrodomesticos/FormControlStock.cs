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
    public partial class FormControlStock : Form
    {
        private Form formuGestorStock;

        public FormControlStock(Form formGestorStock)
        {
            InitializeComponent();

            GestorStock gestorStock = new GestorStock();
            ProductoDAL usuarioDAL = new ProductoDAL();
            usuarioDAL.CargarProductosDesdeBD(gestorStock);

            List<ProductoBE> listaProductos = gestorStock.ListaProductos;

            if (listaProductos != null && listaProductos.Count > 0)
            {
                dgvDatosStock.Refresh();
                dgvDatosStock.DataSource = listaProductos;
                //dgvDatosStock.Columns[0].HeaderText = "Id";   //PARA CAMBIAR EL NOMBRE DE LA CABECERA DE COLUMNA
                dgvDatosStock.Columns["IDproducto"].Visible = false;
                dgvDatosStock.Columns["Descripcion"].Visible = false;
                dgvDatosStock.Columns["Categoria"].Visible = false;
                dgvDatosStock.Columns["Precio"].Visible = false;
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

        private void dgvDatosStock_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
            if (e.ColumnIndex == 5 & e.Value != null)
            {
                int valStock = Convert.ToInt32(e.Value);
                if (valStock < 7)
                {
                    e.CellStyle.BackColor = Color.LightCoral;
                }
                else if (valStock >= 7 & valStock < 14)
                {
                    e.CellStyle.BackColor = Color.Orange;
                }
                else if (valStock >= 14 & valStock < 21)
                {
                    e.CellStyle.BackColor = Color.Yellow;
                }
                else if (valStock >= 21 & valStock < 28)
                {
                    e.CellStyle.BackColor = Color.GreenYellow;
                }
                else if (valStock >= 28 & valStock < 35)
                {
                    e.CellStyle.BackColor = Color.LightSkyBlue;
                }
            }
            
        }

        private void dgvDatosStock_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }


}
