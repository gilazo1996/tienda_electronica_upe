using BLL;
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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string username = tboxUsername.Text;
            string password = tboxPassword.Text;

            
            Login login = new Login();// creo una instancia de la clase Login
            Usuarios usuarios = new Usuarios();
            // invoco método de inicio de sesión de la clase Login
            bool loginSuccessful = login.IniciarSesion(username, password);

            if (loginSuccessful)
            {
                // Obtener el ID de usuario
                int idUsuario = Usuarios.ObtenerIdUsuarioPorEmail(username); //invoco al metodo para obtener el id mediante el mail del user

                //invoco el metodo para obtener los permisos del user, con esto muestro por pantalla
                List<string> permisosUsuario = Permisos.ObtenerRoles(idUsuario);

                if (permisosUsuario.Contains("administrador"))
                {
                    MessageBox.Show("Inicio de Sesión exitoso. El usuario es administrador.");
                }
                else
                {
                    MessageBox.Show("Inicio de Sesión exitoso. El usuario NO es administrador.");
                }
            }
            else
            {
                MessageBox.Show("Inicio de sesión fallido. Verifica tu usuario y contraseña.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); //Con el boton cancelar cierro la ventana del login
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
            Register formRegistro = new Register(); //instancia del formulario para registarse
            formRegistro.ShowDialog(); //muestro el formulario como un modal

        }
    }
}
