using BE;
using BLL;
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
    public partial class FormModificarPerfil : Form
    {
        private UsuarioBLL usuarioM;
        public FormModificarPerfil()
        {
            InitializeComponent();
            usuarioM = new UsuarioBLL();
        }

        private void FormModificarPerfil_Load(object sender, EventArgs e)
        {
            
            DataTable tablita = usuarioM.UsuarioActual(UsuarioBE.IdUsuario);

            tboxNombreModi.Text = tablita.Rows[0]["nombre"].ToString();
            tboxCorreoModi.Text = tablita.Rows[0]["email"].ToString();
            tboxPSSWModi.Text = tablita.Rows[0]["password"].ToString();

        }

        private void bCancelarModificacion_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bModificarPerfil_Click(object sender, EventArgs e)
        {
            string nombre = tboxNombreModi.Text;
            string email = tboxCorreoModi.Text;
            string password = tboxPSSWModi.Text;

            try
            {
                

                if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
                {
                    MessageBox.Show("Todos los campos son obligatorios.");
                    return;
                }

                if (!EsEmailValido(email))
                {
                    MessageBox.Show("Por favor, ingresa un correo electrónico válido.");
                    return;
                }

                string mensaje;
                bool resultado = usuarioM.ModificarUsuari(UsuarioBE.IdUsuario, nombre, email, password, out mensaje);

                MessageBox.Show(mensaje);
                this.Close();

                

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al realizar las operaciones " + ex.Message);
            }
        }

        private bool EsEmailValido(string email)
        {
            // expresion regular para validar el formato del correo electrónico
            string patronEmail = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, patronEmail);
        }

        private void pOcultarContra_Click(object sender, EventArgs e)
        {
            
            pMostrarContra.BringToFront();
            //tboxPSSWModi.PasswordChar = '*';
            tboxPSSWModi.UseSystemPasswordChar = true;
        }

        private void pMostrarContra_Click(object sender, EventArgs e)
        {
            pOcultarContra.BringToFront();
            //tboxPSSWModi.PasswordChar = '\0';
            tboxPSSWModi.UseSystemPasswordChar = false;
        }
    }
}
