using BLL;
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
    public partial class Admin_CrearUsuario : Form
    {
        AdministradorBLL _administradorBL = new AdministradorBLL();
        public Admin_CrearUsuario()
        {
            InitializeComponent();
            tboxPSSWCrear.PasswordChar = '*';

            _administradorBL = new AdministradorBLL();
            CargarRoles();
        }


        private void CargarRoles()
        {
            try
            {
                DataTable roles = _administradorBL.ObtenerRoles();
                cboxRoles.DataSource = roles;
                cboxRoles.DisplayMember = "nombre";
                cboxRoles.ValueMember = "id";

            }catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los roles " + ex.Message);
            }
        }


        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            string nombre = tboxNombreCrear.Text;
            string email = tboxCorreoCrear.Text;
            string password = tboxPSSWCrear.Text;

            try
            {
                int idRol = Convert.ToInt32(cboxRoles.SelectedValue);

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                string mensaje;
                bool resultado = _administradorBL.CrearUsuario(nombre, email, password, idRol, out mensaje);

                MessageBox.Show(mensaje);

            }catch (Exception ex)
            {
                MessageBox.Show("Error al realizar las operaciones " + ex.Message);
            }

        }

        private void Admin_CrearUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnCerrarForm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
