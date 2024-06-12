using DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC_Electrodomesticos
{
    public partial class FromRegistro : Form
    {
        public FromRegistro()
        {
            InitializeComponent();
            tboxRegisterPssw.PasswordChar = '*';

        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string nombre = tboxNombreRegis.Text;
            string email = tboxRegisterMail.Text;
            string password = tboxRegisterPssw.Text;

            if (!EsEmailValido(email))
            {
                MessageBox.Show("Por favor, ingresa un correo electrónico válido.");
                return;
            }

            try
            {
                UsuarioDAL usuarioDAL = new UsuarioDAL();
                bool registroExitoso = usuarioDAL.RegistrarUsuario(nombre, email, password);

                if (registroExitoso)
                {
                    MessageBox.Show("Registro exitoso. ¡Bienvenido!");
                    this.Close(); // cerrar el formulario de registro después de un registro exitoso
                }
                else
                {
                    MessageBox.Show("Error al registrar el usuario. Por favor, inténtalo nuevamente.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al registrar: " + ex.Message);
            }
        }

        private bool EsEmailValido(string email)
        {
            // expresion regular para validar el formato del correo electrónico
            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patronEmail);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void FromRegistro_Load(object sender, EventArgs e)
        {

        }
    }
}
