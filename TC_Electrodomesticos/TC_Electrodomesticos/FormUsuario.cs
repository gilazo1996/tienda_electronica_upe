using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using BLL;

namespace TC_Electrodomesticos
{
    public partial class FormUsuario : Form
    {
        public FormUsuario()
        {
            InitializeComponent();
        }

        private void textCliente_Click(object sender, EventArgs e)
        {
            this.Text = "Interfaz de Cliente";
        }

        private void btnClienteSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormCliente_Load(object sender, EventArgs e)
        {

        }

        private void btnUsuarioComprar_Click(object sender, EventArgs e)
        {
            FormComprarProducto formComprarProducto = new FormComprarProducto(); //instancia del formulario para registarse
            formComprarProducto.ShowDialog(); //muestro el formulario como un modal//se supone que al comprar un producto, se le pid
        }
    }
}