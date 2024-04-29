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
    public partial class FormComprarProducto : Form
    {
        public FormComprarProducto()
        {
            InitializeComponent();
        }

        private void textNombreCOmpleto_Click(object sender, EventArgs e)
        {

        }

        private void btnComprarPro_Click(object sender, EventArgs e)
        {
            string nombre = tboxNombreCompleto.Text;
            string cuil = tboxCuil.Text;

            // acá tomamos el ID del usuario autenticado desde la propiedad estatica de UsuarioBE
            int idUsuario = UsuarioBE.IdUsuario;

            if (idUsuario > 0) // verifico si hay un ID de usuario cargado, es decir, si el usuario se logeo
            {
                UsuarioDAL usuarioDAL = new UsuarioDAL();

                // Uso el ID del usuario autenticado en el método RegistrarCliente
                bool registroExitoso = usuarioDAL.RegistrarCliente(nombre, cuil, idUsuario);

                if (registroExitoso)
                {
                    MessageBox.Show("Compra existosa. ¡Bienvenido, nuevo cliente!");
                    this.Close(); // ciero el formulario
                }
                else
                {
                    MessageBox.Show("Error comprar el producto. Por favor, inténtalo nuevamente.");
                }
            }
            else
            {
                MessageBox.Show("Necesita registrarse y estar logeado para comprar.");
            }
        }

        private void FormComprarProducto_Load(object sender, EventArgs e)
        {

        }

        private void btnCancelarPro_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
