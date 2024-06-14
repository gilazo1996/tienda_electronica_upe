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
    public partial class FormularioAdministrador : Form
    {
        public FormularioAdministrador()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Text = "Interfaz de Administrador";
        }

        private void admSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormularioAdministrador_Load(object sender, EventArgs e)
        {

        }

        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            Admin_BuscarUserForm formBuscarUser = new Admin_BuscarUserForm();
            formBuscarUser.ShowDialog();

        }

        private void btnCrearUser_Click(object sender, EventArgs e)
        {
            Admin_CrearUsuario formCrearUser = new Admin_CrearUsuario();
            formCrearUser.ShowDialog();
        }

        private void lModifiPerfil_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormModificarPerfil modiperfil = new FormModificarPerfil();
            modiperfil.ShowDialog();
        }
    }
}
