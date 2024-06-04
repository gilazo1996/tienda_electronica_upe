﻿using DAL;
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
    public partial class FromRegistro : Form
    {
        public FromRegistro()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            string nombre = tboxNombreRegis.Text;
            string email = tboxRegisterMail.Text;
            string password = tboxRegisterPssw.Text;
            UsuarioDAL usuarioDAL = new UsuarioDAL();
            bool registroExitoso = usuarioDAL.RegistrarUsuario(nombre, email, password);

            if (registroExitoso)
            {
                MessageBox.Show("Registro exitoso. ¡Bienvenido!");
                this.Close(); // cierro el formulario de registro después de un registro exitoso
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario. Por favor, inténtalo nuevamente.");
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void tboxNombreRegis_TextChanged(object sender, EventArgs e)
        {

        }
    }
}