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
    public partial class InterfazMain : Form
    {
        public InterfazMain()
        {
            InitializeComponent();
            tboxPassword.PasswordChar = '*';

        }

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            string username = tboxUsername.Text;
            string password = tboxPassword.Text;



            LoginUsuario login = new LoginUsuario();// creo una instancia de la clase Login
            UsuarioBLL usuarios = new UsuarioBLL();
            // invoco método de inicio de sesión de la clase Login
            bool loginSuccessful = login.IniciarSesion(username, password);

            if (loginSuccessful)
            {
                // Obtener el ID de usuario
                int idUsuario = usuarios.ObtenerIdUsuarioPorEmail(username); //invoco al metodo para obtener el id mediante el mail del user

                //invoco el metodo para obtener los permisos del user, con esto muestro por pantalla
                List<string> permisosUsuario = Permisos.ObtenerRoles(idUsuario);

                if (permisosUsuario.Contains("administrador"))
                {
                    MessageBox.Show("Inicio de Sesión exitoso. El usuario es administrador.");
                    // abro la interfaz de administrador
                    FormularioAdministrador formularioAdmin = new FormularioAdministrador();
                    formularioAdmin.ShowDialog();

                    // cierro el formulario de inicio de sesión
                    //this.Hide();
                }
                if(permisosUsuario.Contains("usuario"))
                {
                    MessageBox.Show("Inicio de Sesión exitoso. Bienvenido!.");

                    //abro interfaz de usuario
                    FormUsuario formularioUsuario = new FormUsuario();
                    formularioUsuario.ShowDialog();
                    // cierro el formulario de inicio de sesión
                    //this.Hide();
                }

                //INICIO CODIGO ROA
                if (permisosUsuario.Contains("gestorStock"))
                {
                    MessageBox.Show("Inicio de Sesión exitoso. El usuario es Gestor de Stock.");

                    //abro interfaz de usuario
                    FormGestorStock formularioGestorStock = new FormGestorStock();
                    formularioGestorStock.ShowDialog();
                    // cierro el formulario de inicio de sesión
                    //this.Hide();
                }//FIN CODIGO ROA

                //Gestion de Gerente
                if (permisosUsuario.Contains("gerente"))
                {
                    MessageBox.Show("Inicio de Sesión exitoso. El usuario es Gerente.");

                    FormGerente formulariogerente = new FormGerente();
                    formulariogerente.ShowDialog();

                    //this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Inicio de sesión fallido. Verifica tu usuario y contraseña.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close(); //con el boton cancelar cierro la ventana del login
        }

        private void btnCrearCuenta_Click(object sender, EventArgs e)
        {
           // this.Hide();
            FromRegistro formRegistro = new FromRegistro(); //instancia del formulario para registarse
            formRegistro.ShowDialog(); //muestro el formulario como un modal

            // cierro el formulario de inicio de sesión
           // this.Hide();

        }

        private void btnUsuarioComprar_Click(object sender, EventArgs e)
        {
            FormComprarProducto formComprarProducto = new FormComprarProducto(); //instancia del formulario para registarse
            formComprarProducto.ShowDialog(); //muestro el formulario como un modal//se supone que al comprar un producto, se le pid


        }

        private void InterfazMain_Load(object sender, EventArgs e)
        {

        }
    }
}
