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
    }
}
