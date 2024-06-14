

﻿namespace TC_Electrodomesticos
{
    partial class FormGerente
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
            this.bListaClientes = new System.Windows.Forms.Button();
            this.bVerFacturas = new System.Windows.Forms.Button();
            this.bSalirGerente = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dListaGerente = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.bBuscarFacturaGere = new System.Windows.Forms.Button();
            this.dFechaFactura = new System.Windows.Forms.DateTimePicker();
            this.lFacturasGerente = new System.Windows.Forms.ListBox();
            this.lModifiPerfil = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dListaGerente)).BeginInit();
            this.SuspendLayout();
            // 
            // bListaClientes
            // 
            this.bListaClientes.BackColor = System.Drawing.Color.Silver;
            this.bListaClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bListaClientes.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bListaClientes.Location = new System.Drawing.Point(566, 58);
            this.bListaClientes.Name = "bListaClientes";
            this.bListaClientes.Size = new System.Drawing.Size(96, 23);
            this.bListaClientes.TabIndex = 0;
            this.bListaClientes.Text = "Lista de Clientes";
            this.bListaClientes.UseVisualStyleBackColor = false;
            this.bListaClientes.Click += new System.EventHandler(this.bListaClientes_Click);
            // 
            // bVerFacturas
            // 
            this.bVerFacturas.BackColor = System.Drawing.Color.Silver;
            this.bVerFacturas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bVerFacturas.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bVerFacturas.Location = new System.Drawing.Point(430, 58);
            this.bVerFacturas.Name = "bVerFacturas";
            this.bVerFacturas.Size = new System.Drawing.Size(91, 23);
            this.bVerFacturas.TabIndex = 1;
            this.bVerFacturas.Text = "Ver Facturas";
            this.bVerFacturas.UseVisualStyleBackColor = false;
            this.bVerFacturas.Click += new System.EventHandler(this.bVerFacturas_Click);
            // 
            // bSalirGerente
            // 
            this.bSalirGerente.BackColor = System.Drawing.Color.Silver;
            this.bSalirGerente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bSalirGerente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bSalirGerente.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bSalirGerente.Location = new System.Drawing.Point(630, 281);
            this.bSalirGerente.Name = "bSalirGerente";
            this.bSalirGerente.Size = new System.Drawing.Size(75, 23);
            this.bSalirGerente.TabIndex = 2;
            this.bSalirGerente.Text = "Salir";
            this.bSalirGerente.UseVisualStyleBackColor = false;
            this.bSalirGerente.Click += new System.EventHandler(this.bSalirGerente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(293, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "INTERFAZ GERENTE";
            // 
            // dListaGerente
            // 
            this.dListaGerente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dListaGerente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dListaGerente.Location = new System.Drawing.Point(41, 117);
            this.dListaGerente.Name = "dListaGerente";
            this.dListaGerente.Size = new System.Drawing.Size(583, 154);
            this.dListaGerente.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(96, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Filtro de Facturas";
            // 
            // bBuscarFacturaGere
            // 
            this.bBuscarFacturaGere.BackColor = System.Drawing.Color.Silver;
            this.bBuscarFacturaGere.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bBuscarFacturaGere.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bBuscarFacturaGere.Location = new System.Drawing.Point(285, 57);
            this.bBuscarFacturaGere.Name = "bBuscarFacturaGere";
            this.bBuscarFacturaGere.Size = new System.Drawing.Size(91, 23);
            this.bBuscarFacturaGere.TabIndex = 7;
            this.bBuscarFacturaGere.Text = "Buscar Factura";
            this.bBuscarFacturaGere.UseVisualStyleBackColor = false;
            this.bBuscarFacturaGere.Click += new System.EventHandler(this.button1_Click);
            // 
            // dFechaFactura
            // 
            this.dFechaFactura.Location = new System.Drawing.Point(41, 57);
            this.dFechaFactura.Name = "dFechaFactura";
            this.dFechaFactura.Size = new System.Drawing.Size(200, 20);
            this.dFechaFactura.TabIndex = 8;
            // 
            // lFacturasGerente
            // 
            this.lFacturasGerente.FormattingEnabled = true;
            this.lFacturasGerente.Location = new System.Drawing.Point(41, 117);
            this.lFacturasGerente.Name = "lFacturasGerente";
            this.lFacturasGerente.Size = new System.Drawing.Size(583, 147);
            this.lFacturasGerente.TabIndex = 9;
            // 
            // lModifiPerfil
            // 
            this.lModifiPerfil.AutoSize = true;
            this.lModifiPerfil.Location = new System.Drawing.Point(38, 291);
            this.lModifiPerfil.Name = "lModifiPerfil";
            this.lModifiPerfil.Size = new System.Drawing.Size(76, 13);
            this.lModifiPerfil.TabIndex = 10;
            this.lModifiPerfil.TabStop = true;
            this.lModifiPerfil.Text = "Modificar Perfil";
            this.lModifiPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lModifiPerfil_LinkClicked);
            // 
            // FormGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(717, 316);
            this.Controls.Add(this.lModifiPerfil);
            this.Controls.Add(this.lFacturasGerente);
            this.Controls.Add(this.dFechaFactura);
            this.Controls.Add(this.bBuscarFacturaGere);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dListaGerente);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bSalirGerente);
            this.Controls.Add(this.bVerFacturas);
            this.Controls.Add(this.bListaClientes);
            this.Name = "FormGerente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gerente";
            this.Load += new System.EventHandler(this.FormGerente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dListaGerente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bListaClientes;
        private System.Windows.Forms.Button bVerFacturas;
        private System.Windows.Forms.Button bSalirGerente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dListaGerente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button bBuscarFacturaGere;
        private System.Windows.Forms.DateTimePicker dFechaFactura;
        private System.Windows.Forms.ListBox lFacturasGerente;
        private System.Windows.Forms.LinkLabel lModifiPerfil;
    }
}