

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
            ((System.ComponentModel.ISupportInitialize)(this.dListaGerente)).BeginInit();
            this.SuspendLayout();
            // 
            // bListaClientes
            // 
            this.bListaClientes.Location = new System.Drawing.Point(566, 58);
            this.bListaClientes.Name = "bListaClientes";
            this.bListaClientes.Size = new System.Drawing.Size(96, 23);
            this.bListaClientes.TabIndex = 0;
            this.bListaClientes.Text = "Lista de Clientes";
            this.bListaClientes.UseVisualStyleBackColor = true;
            this.bListaClientes.Click += new System.EventHandler(this.bListaClientes_Click);
            // 
            // bVerFacturas
            // 
            this.bVerFacturas.Location = new System.Drawing.Point(430, 58);
            this.bVerFacturas.Name = "bVerFacturas";
            this.bVerFacturas.Size = new System.Drawing.Size(91, 23);
            this.bVerFacturas.TabIndex = 1;
            this.bVerFacturas.Text = "Ver Facturas";
            this.bVerFacturas.UseVisualStyleBackColor = true;
            this.bVerFacturas.Click += new System.EventHandler(this.bVerFacturas_Click);
            // 
            // bSalirGerente
            // 
            this.bSalirGerente.Location = new System.Drawing.Point(630, 281);
            this.bSalirGerente.Name = "bSalirGerente";
            this.bSalirGerente.Size = new System.Drawing.Size(75, 23);
            this.bSalirGerente.TabIndex = 2;
            this.bSalirGerente.Text = "Salir";
            this.bSalirGerente.UseVisualStyleBackColor = true;
            this.bSalirGerente.Click += new System.EventHandler(this.bSalirGerente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(293, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 13);
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
            this.bBuscarFacturaGere.Location = new System.Drawing.Point(285, 57);
            this.bBuscarFacturaGere.Name = "bBuscarFacturaGere";
            this.bBuscarFacturaGere.Size = new System.Drawing.Size(91, 23);
            this.bBuscarFacturaGere.TabIndex = 7;
            this.bBuscarFacturaGere.Text = "Buscar Factura";
            this.bBuscarFacturaGere.UseVisualStyleBackColor = true;
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
            // FormGerente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(717, 316);
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
            this.Text = "FormGerente";
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
    }
}