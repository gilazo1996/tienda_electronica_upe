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
    public partial class FormVerCompras : Form
    {
        private UsuarioDAL dalVerCompras = new UsuarioDAL();
        private ClienteBE cliente = new ClienteBE();

        public FormVerCompras()
        {

            InitializeComponent();
            VerMisCompras();

        }

        public int VerMisCompras()
        {
            int resultado = 1;
            try
            {
                int idUsuario = UsuarioBE.IdUsuario;
                UsuarioDAL usuarioDAL = new UsuarioDAL();
                usuarioDAL.VerFacturasUsuario(cliente, idUsuario);
                // cargo los productos desde la base de datos

                // verifico si la lista de productos está llena
                if (cliente.ListaFacturas.Count == 0) //valido que se pueda mostrar los productos
                {
                    resultado = 0;

                }
                else
                {
                    // limpio el ListBox antes de añadir los nuevos productos
                    listBoxMisCompras.Items.Clear();

                    // agrego las facturas al ListBox
                    foreach (FacturaBE factura in cliente.ListaFacturas)
                    {
                        listBoxMisCompras.Items.Add(factura); //por c ada producto encontrado, lo agrego al listbox
                        foreach (DetalleFactura detalleFactura in factura.ListaDetalles)
                        {
                            listBoxMisCompras.Items.Add(detalleFactura);

                        }
                        listBoxMisCompras.Items.Add("");
                    }


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar las facturas: " + ex.Message); //manejo de excepciones
            }
            return resultado;
        }
        private void btnSalirCompras_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBoxMisCompras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void FormVerCompras_Load(object sender, EventArgs e)
        {
 
        }
    }
}
