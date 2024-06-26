﻿namespace TC_Electrodomesticos
{
    partial class Admin_BuscarUserForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridUsuarios = new System.Windows.Forms.DataGridView();
            this.tboxUserNameBuscar = new System.Windows.Forms.TextBox();
            this.tboxCorreoBuscar = new System.Windows.Forms.TextBox();
            this.btnVerBuscarUser = new System.Windows.Forms.Button();
            this.labelNombreUserBuscar = new System.Windows.Forms.Label();
            this.labelCorreoUserBuscar = new System.Windows.Forms.Label();
            this.btnVerListaUsers = new System.Windows.Forms.Button();
            this.btnBlockUser = new System.Windows.Forms.Button();
            this.btnUnlockUser = new System.Windows.Forms.Button();
            this.btnCerrarBuscar = new System.Windows.Forms.Button();
            this.labelBuscarExplicacion = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridUsuarios
            // 
            this.dataGridUsuarios.AllowUserToAddRows = false;
            this.dataGridUsuarios.AllowUserToDeleteRows = false;
            this.dataGridUsuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridUsuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridUsuarios.Location = new System.Drawing.Point(12, 88);
            this.dataGridUsuarios.Name = "dataGridUsuarios";
            this.dataGridUsuarios.Size = new System.Drawing.Size(575, 210);
            this.dataGridUsuarios.TabIndex = 0;
            this.dataGridUsuarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuarios_CellContentClick);
            this.dataGridUsuarios.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridUsuarios_CellEndEdit);
            this.dataGridUsuarios.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridUsuarios_CellFormatting);
            // 
            // tboxUserNameBuscar
            // 
            this.tboxUserNameBuscar.Location = new System.Drawing.Point(12, 15);
            this.tboxUserNameBuscar.Name = "tboxUserNameBuscar";
            this.tboxUserNameBuscar.Size = new System.Drawing.Size(100, 20);
            this.tboxUserNameBuscar.TabIndex = 1;
            // 
            // tboxCorreoBuscar
            // 
            this.tboxCorreoBuscar.Location = new System.Drawing.Point(12, 43);
            this.tboxCorreoBuscar.Name = "tboxCorreoBuscar";
            this.tboxCorreoBuscar.Size = new System.Drawing.Size(100, 20);
            this.tboxCorreoBuscar.TabIndex = 2;
            // 
            // btnVerBuscarUser
            // 
            this.btnVerBuscarUser.BackColor = System.Drawing.Color.Silver;
            this.btnVerBuscarUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerBuscarUser.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerBuscarUser.Location = new System.Drawing.Point(266, 12);
            this.btnVerBuscarUser.Name = "btnVerBuscarUser";
            this.btnVerBuscarUser.Size = new System.Drawing.Size(151, 23);
            this.btnVerBuscarUser.TabIndex = 3;
            this.btnVerBuscarUser.Text = "Buscar Usuario";
            this.btnVerBuscarUser.UseVisualStyleBackColor = false;
            this.btnVerBuscarUser.Click += new System.EventHandler(this.btnVerBuscarUser_Click);
            // 
            // labelNombreUserBuscar
            // 
            this.labelNombreUserBuscar.AutoSize = true;
            this.labelNombreUserBuscar.Location = new System.Drawing.Point(118, 22);
            this.labelNombreUserBuscar.Name = "labelNombreUserBuscar";
            this.labelNombreUserBuscar.Size = new System.Drawing.Size(98, 13);
            this.labelNombreUserBuscar.TabIndex = 4;
            this.labelNombreUserBuscar.Text = "Nombre de Usuario";
            // 
            // labelCorreoUserBuscar
            // 
            this.labelCorreoUserBuscar.AutoSize = true;
            this.labelCorreoUserBuscar.Location = new System.Drawing.Point(118, 46);
            this.labelCorreoUserBuscar.Name = "labelCorreoUserBuscar";
            this.labelCorreoUserBuscar.Size = new System.Drawing.Size(92, 13);
            this.labelCorreoUserBuscar.TabIndex = 5;
            this.labelCorreoUserBuscar.Text = "Correo de Usuario";
            // 
            // btnVerListaUsers
            // 
            this.btnVerListaUsers.BackColor = System.Drawing.Color.Silver;
            this.btnVerListaUsers.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerListaUsers.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerListaUsers.Location = new System.Drawing.Point(436, 13);
            this.btnVerListaUsers.Name = "btnVerListaUsers";
            this.btnVerListaUsers.Size = new System.Drawing.Size(151, 22);
            this.btnVerListaUsers.TabIndex = 6;
            this.btnVerListaUsers.Text = "Ver todos los usuarios";
            this.btnVerListaUsers.UseVisualStyleBackColor = false;
            this.btnVerListaUsers.Click += new System.EventHandler(this.btnVerListaUsers_Click);
            // 
            // btnBlockUser
            // 
            this.btnBlockUser.BackColor = System.Drawing.Color.Silver;
            this.btnBlockUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnBlockUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBlockUser.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlockUser.Location = new System.Drawing.Point(12, 304);
            this.btnBlockUser.Name = "btnBlockUser";
            this.btnBlockUser.Size = new System.Drawing.Size(130, 23);
            this.btnBlockUser.TabIndex = 7;
            this.btnBlockUser.Text = "Bloquear Usuario";
            this.btnBlockUser.UseVisualStyleBackColor = false;
            this.btnBlockUser.Click += new System.EventHandler(this.btnBlockUser_Click);
            // 
            // btnUnlockUser
            // 
            this.btnUnlockUser.BackColor = System.Drawing.Color.Silver;
            this.btnUnlockUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnUnlockUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUnlockUser.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnlockUser.Location = new System.Drawing.Point(148, 304);
            this.btnUnlockUser.Name = "btnUnlockUser";
            this.btnUnlockUser.Size = new System.Drawing.Size(141, 23);
            this.btnUnlockUser.TabIndex = 8;
            this.btnUnlockUser.Text = "Desbloquear Usuario";
            this.btnUnlockUser.UseVisualStyleBackColor = false;
            this.btnUnlockUser.Click += new System.EventHandler(this.btnUnlockUser_Click);
            // 
            // btnCerrarBuscar
            // 
            this.btnCerrarBuscar.BackColor = System.Drawing.Color.Silver;
            this.btnCerrarBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnCerrarBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrarBuscar.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarBuscar.Location = new System.Drawing.Point(498, 303);
            this.btnCerrarBuscar.Name = "btnCerrarBuscar";
            this.btnCerrarBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarBuscar.TabIndex = 9;
            this.btnCerrarBuscar.Text = "Cerrar";
            this.btnCerrarBuscar.UseVisualStyleBackColor = false;
            this.btnCerrarBuscar.Click += new System.EventHandler(this.btnCerrarBuscar_Click);
            // 
            // labelBuscarExplicacion
            // 
            this.labelBuscarExplicacion.AutoSize = true;
            this.labelBuscarExplicacion.Location = new System.Drawing.Point(335, 72);
            this.labelBuscarExplicacion.Name = "labelBuscarExplicacion";
            this.labelBuscarExplicacion.Size = new System.Drawing.Size(252, 13);
            this.labelBuscarExplicacion.TabIndex = 10;
            this.labelBuscarExplicacion.Text = "Para editar un usuario haga doble click en la casilla.";
            // 
            // Admin_BuscarUserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(614, 350);
            this.Controls.Add(this.labelBuscarExplicacion);
            this.Controls.Add(this.btnCerrarBuscar);
            this.Controls.Add(this.btnUnlockUser);
            this.Controls.Add(this.btnBlockUser);
            this.Controls.Add(this.btnVerListaUsers);
            this.Controls.Add(this.labelCorreoUserBuscar);
            this.Controls.Add(this.labelNombreUserBuscar);
            this.Controls.Add(this.btnVerBuscarUser);
            this.Controls.Add(this.tboxCorreoBuscar);
            this.Controls.Add(this.tboxUserNameBuscar);
            this.Controls.Add(this.dataGridUsuarios);
            this.Name = "Admin_BuscarUserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Usuario";
            this.Load += new System.EventHandler(this.Admin_BuscarUserForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridUsuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridUsuarios;
        private System.Windows.Forms.TextBox tboxUserNameBuscar;
        private System.Windows.Forms.TextBox tboxCorreoBuscar;
        private System.Windows.Forms.Button btnVerBuscarUser;
        private System.Windows.Forms.Label labelNombreUserBuscar;
        private System.Windows.Forms.Label labelCorreoUserBuscar;
        private System.Windows.Forms.Button btnVerListaUsers;
        private System.Windows.Forms.Button btnBlockUser;
        private System.Windows.Forms.Button btnUnlockUser;
        private System.Windows.Forms.Button btnCerrarBuscar;
        private System.Windows.Forms.Label labelBuscarExplicacion;
    }
}