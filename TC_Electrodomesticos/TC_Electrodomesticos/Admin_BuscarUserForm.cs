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
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TC_Electrodomesticos
{
    public partial class Admin_BuscarUserForm : Form
    {

        private AdministradorBLL _adminBLL;
        int _usuarioID;


        public Admin_BuscarUserForm()
        {
            InitializeComponent();
            _adminBLL = new AdministradorBLL();
        }

        private void Admin_BuscarUserForm_Load(object sender, EventArgs e)
        {

            dataGridUsuarios.AutoGenerateColumns = false;
            dataGridUsuarios.Columns.Add(new DataGridViewTextBoxColumn { Name = "id", HeaderText = "Id", DataPropertyName = "id" });
            dataGridUsuarios.Columns.Add(new DataGridViewTextBoxColumn { Name = "nombre", HeaderText = "Nombre", DataPropertyName = "nombre" });
            dataGridUsuarios.Columns.Add(new DataGridViewTextBoxColumn { Name = "email", HeaderText = "Correo", DataPropertyName = "email" });
            dataGridUsuarios.Columns.Add(new DataGridViewTextBoxColumn { Name = "estado", HeaderText = "Estado", DataPropertyName = "estado" });
        }

        private void btnVerBuscarUser_Click(object sender, EventArgs e)
        {
            string nombre = tboxUserNameBuscar.Text;
            string correo = tboxCorreoBuscar.Text;

            DataTable dtUsuarios = _adminBLL.ObtenerUsuariosPorNombreYCorreo(nombre, correo);
            dataGridUsuarios.DataSource = dtUsuarios;

        }

        private void btnVerListaUsers_Click(object sender, EventArgs e)
        {
            DataTable dtUsuarios = _adminBLL.ObtenerTodosLosUsuarios();
            dataGridUsuarios.DataSource = dtUsuarios;

        }

        private void dataGridUsuarios_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            int estadoColumnIndex = 3; // índice de la columna "estado" en el DataGrid

            if (e.ColumnIndex == estadoColumnIndex && e.Value != null)
            {
                string estado = e.Value.ToString();
                if (estado.Equals("inactivo", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = Color.Red;
                }
                else if (estado.Equals("activo", StringComparison.OrdinalIgnoreCase))
                {
                    e.CellStyle.BackColor = Color.Green;
                }
            }
        }

        private void btnBlockUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridUsuarios.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dataGridUsuarios.SelectedRows[0];
                    int idUsuario = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);

                   // AdministradorDAL adminDAL = new AdministradorDAL();
                    bool bloqueoExitoso = _adminBLL.BloquearUsuario(idUsuario);

                    if (bloqueoExitoso)
                    {
                        MessageBox.Show("Usuario bloqueado exitosamente.");
                        btnVerListaUsers_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error al bloquear al usuario.");
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un usuario para bloquear.");
                }

            }catch (Exception ex)
            {
                MessageBox.Show("Error al ejecutar los comandos. " + ex);
            }
        }

        private void btnUnlockUser_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridUsuarios.SelectedRows.Count > 0)
                {
                    DataGridViewRow filaSeleccionada = dataGridUsuarios.SelectedRows[0];
                    int idUsuario = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);

                    //AdministradorDAL adminDAL = new AdministradorDAL();
                    bool desbloqueoExitoso = _adminBLL.DesbloquearUsuario(idUsuario);

                    if (desbloqueoExitoso)
                    {
                        MessageBox.Show("Usuario desbloqueado correctamente.");
                        btnVerListaUsers_Click(sender, e);
                    }
                    else
                    {
                        MessageBox.Show("Error al desbloquear al usuario.");
                    }
                }
                else
                {
                    MessageBox.Show("Debe seleccionar un usuario para desbloquear.");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error al ejecutar los comandos. " + ex);
            }

        }

        private void btnCerrarBuscar_Click(object sender, EventArgs e)
        {
            this.Close();   
        }

        private void dataGridUsuarios_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

            int rowIndex = e.RowIndex;
            int columnIndex = e.ColumnIndex;
            try
            {
                if (rowIndex >= 0 && columnIndex >= 0)
                {
                    DataGridViewRow row = dataGridUsuarios.Rows[rowIndex];
                    int usuarioId = Convert.ToInt32(row.Cells["id"].Value);
                    string nombreColumna = dataGridUsuarios.Columns[columnIndex].Name;
                    string nuevoValor = row.Cells[columnIndex].Value.ToString();

                    //actualizo el valor en la base de datos
                    string mensaje;
                    bool resultado = _adminBLL.ModificarUsuarioCampo(usuarioId, nombreColumna, nuevoValor, out mensaje);

                    if (!resultado)
                    {
                        MessageBox.Show(mensaje);
                    }
                }

            }catch(Exception ex)
            {
                MessageBox.Show("Error al ejecutar los comandos." + ex.Message);
            }
        }

        private void dataGridUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
