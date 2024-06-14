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
    public partial class FormGerente : Form
    {
        public FormGerente()
        {
            InitializeComponent();
        }

        private void FormGerente_Load(object sender, EventArgs e)
        {
            dListaGerente.Visible = false;
            lFacturasGerente.Hide();
        }

        private void bSalirGerente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bListaClientes_Click(object sender, EventArgs e)
        {
            dListaGerente.Visible = true;
            lFacturasGerente.Hide();
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            List<ClienteBE> clientesBEs = new List<ClienteBE>();

            usuarioDAL.VisualizarCliente(clientesBEs);

            if (clientesBEs != null && clientesBEs.Count > 0)
            {
                dListaGerente.Refresh();
                dListaGerente.DataSource = clientesBEs;
                //dgvDatosStock.Columns[0].HeaderText = "Id";   //PARA CAMBIAR EL NOMBRE DE LA CABECERA DE COLUMNA
                dListaGerente.Columns["Nombre"].Visible = false;
                dListaGerente.Columns["IdUsuarioCreador"].Visible = false;
                dListaGerente.Columns["Password"].Visible = false;
            }
            else
            {
                MessageBox.Show("No hay clientes registrados en el sistema");
            }
        }

        private void bVerFacturas_Click(object sender, EventArgs e)
        {
            dListaGerente.Visible = false;
            lFacturasGerente.Show();
            GerenteDAL gerenteBE = new GerenteDAL();
            
            List<ClienteBE> clientes = new List<ClienteBE>();
            gerenteBE.MostrarFacturas(clientes);
            if (clientes.Count == 0) //valido que se pueda mostrar los productos
            {
                MessageBox.Show("No se encontraron facturas asocidas.");
            }
            if (clientes != null)
            {
                lFacturasGerente.Items.Clear();
                // agrego las facturas al ListBox
                foreach (ClienteBE cliente in clientes)
                {
                    lFacturasGerente.Items.Add("Cliente: " + cliente.NombreCliente);
                    lFacturasGerente.Items.Add(cliente.ListaFacturas[0]);//por c ada producto encontrado, lo agrego al listbox
                    lFacturasGerente.Items.Add("Detalles:");
                    foreach (DetalleFactura detalleFactura in cliente.ListaFacturas[0].ListaDetalles)
                    {
                        lFacturasGerente.Items.Add(detalleFactura);
                    }
                    lFacturasGerente.Items.Add("");
                }
            }
            else
            {
                MessageBox.Show("No hay Ventas registradas en el sistema");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dListaGerente.Visible = false;
            lFacturasGerente.Show();

            GerenteDAL gerenteDAL = new GerenteDAL();
            List<ClienteBE> facturasbuscadas = new List<ClienteBE>();

            gerenteDAL.BuscarFactura(facturasbuscadas, dFechaFactura.Value);

            if (facturasbuscadas != null)
            {
                lFacturasGerente.Items.Clear();
                if (facturasbuscadas.Count == 0) //valido que se pueda mostrar los productos
                {
                    MessageBox.Show("No se encontraron facturas asocidas.");
                }
                // agrego las facturas al ListBox
                foreach (ClienteBE cliente in facturasbuscadas)
                {
                    lFacturasGerente.Items.Add("Cliente: " + cliente.NombreCliente);
                    lFacturasGerente.Items.Add(cliente.ListaFacturas[0]);
                    lFacturasGerente.Items.Add("Detalles:");//por c ada producto encontrado, lo agrego al listbox
                    foreach (DetalleFactura detalleFactura in cliente.ListaFacturas[0].ListaDetalles)
                    {
                        lFacturasGerente.Items.Add(detalleFactura);
                    }
                    lFacturasGerente.Items.Add("");
                }
            }
            else
            {
                MessageBox.Show("No hay Ventas registradas en el sistema");
            }
        }

        private void lModifiPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormModificarPerfil modiperfil = new FormModificarPerfil();
            modiperfil.ShowDialog();
        }
    }
}