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
    public partial class FormGestorStock : Form
    {
        public FormGestorStock()
        {
            InitializeComponent();
        }

        private void btnGStockVerStock_Click(object sender, EventArgs e)
        {
            FormControlStock formularioControlStock = new FormControlStock(this);
            formularioControlStock.ShowDialog();
        }

        private void btnGStockSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
