﻿namespace TC_Electrodomesticos
{
    partial class FormGestorStock
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
            this.btnGStockBuscarProd = new System.Windows.Forms.Button();
            this.btnGStockCargarNewProd = new System.Windows.Forms.Button();
            this.btnGStockVerInventario = new System.Windows.Forms.Button();
            this.btnGStockVerStock = new System.Windows.Forms.Button();
            this.btnGStockSalir = new System.Windows.Forms.Button();
            this.tboxGestorStock = new System.Windows.Forms.Label();
            this.lModifiPerfil = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // btnGStockBuscarProd
            // 
            this.btnGStockBuscarProd.BackColor = System.Drawing.Color.Silver;
            this.btnGStockBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGStockBuscarProd.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGStockBuscarProd.Location = new System.Drawing.Point(25, 75);
            this.btnGStockBuscarProd.Name = "btnGStockBuscarProd";
            this.btnGStockBuscarProd.Size = new System.Drawing.Size(140, 35);
            this.btnGStockBuscarProd.TabIndex = 0;
            this.btnGStockBuscarProd.Text = "Buscar producto";
            this.btnGStockBuscarProd.UseVisualStyleBackColor = false;
            this.btnGStockBuscarProd.Click += new System.EventHandler(this.btnGStockBuscarProd_Click);
            // 
            // btnGStockCargarNewProd
            // 
            this.btnGStockCargarNewProd.BackColor = System.Drawing.Color.Silver;
            this.btnGStockCargarNewProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGStockCargarNewProd.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGStockCargarNewProd.Location = new System.Drawing.Point(201, 75);
            this.btnGStockCargarNewProd.Name = "btnGStockCargarNewProd";
            this.btnGStockCargarNewProd.Size = new System.Drawing.Size(140, 35);
            this.btnGStockCargarNewProd.TabIndex = 1;
            this.btnGStockCargarNewProd.Text = "Cargar nuevo producto";
            this.btnGStockCargarNewProd.UseVisualStyleBackColor = false;
            this.btnGStockCargarNewProd.Click += new System.EventHandler(this.btnGStockCargarNewProd_Click);
            // 
            // btnGStockVerInventario
            // 
            this.btnGStockVerInventario.BackColor = System.Drawing.Color.Silver;
            this.btnGStockVerInventario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGStockVerInventario.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGStockVerInventario.Location = new System.Drawing.Point(25, 140);
            this.btnGStockVerInventario.Name = "btnGStockVerInventario";
            this.btnGStockVerInventario.Size = new System.Drawing.Size(140, 35);
            this.btnGStockVerInventario.TabIndex = 2;
            this.btnGStockVerInventario.Text = "Visualizar inventario";
            this.btnGStockVerInventario.UseVisualStyleBackColor = false;
            this.btnGStockVerInventario.Click += new System.EventHandler(this.btnGStockVerInventario_Click);
            // 
            // btnGStockVerStock
            // 
            this.btnGStockVerStock.BackColor = System.Drawing.Color.Silver;
            this.btnGStockVerStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGStockVerStock.Font = new System.Drawing.Font("Constantia", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGStockVerStock.Location = new System.Drawing.Point(201, 140);
            this.btnGStockVerStock.Name = "btnGStockVerStock";
            this.btnGStockVerStock.Size = new System.Drawing.Size(140, 35);
            this.btnGStockVerStock.TabIndex = 3;
            this.btnGStockVerStock.Text = "Control de Stock";
            this.btnGStockVerStock.UseVisualStyleBackColor = false;
            this.btnGStockVerStock.Click += new System.EventHandler(this.btnGStockVerStock_Click);
            // 
            // btnGStockSalir
            // 
            this.btnGStockSalir.BackColor = System.Drawing.Color.Silver;
            this.btnGStockSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGStockSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGStockSalir.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGStockSalir.Location = new System.Drawing.Point(277, 253);
            this.btnGStockSalir.Name = "btnGStockSalir";
            this.btnGStockSalir.Size = new System.Drawing.Size(75, 23);
            this.btnGStockSalir.TabIndex = 7;
            this.btnGStockSalir.Text = "Salir";
            this.btnGStockSalir.UseVisualStyleBackColor = false;
            this.btnGStockSalir.Click += new System.EventHandler(this.btnGStockSalir_Click);
            // 
            // tboxGestorStock
            // 
            this.tboxGestorStock.AutoSize = true;
            this.tboxGestorStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxGestorStock.Location = new System.Drawing.Point(67, 30);
            this.tboxGestorStock.Name = "tboxGestorStock";
            this.tboxGestorStock.Size = new System.Drawing.Size(210, 13);
            this.tboxGestorStock.TabIndex = 8;
            this.tboxGestorStock.Text = "INTERFAZ DE GESTOR DE STOCK";
            // 
            // lModifiPerfil
            // 
            this.lModifiPerfil.AutoSize = true;
            this.lModifiPerfil.Location = new System.Drawing.Point(12, 263);
            this.lModifiPerfil.Name = "lModifiPerfil";
            this.lModifiPerfil.Size = new System.Drawing.Size(76, 13);
            this.lModifiPerfil.TabIndex = 11;
            this.lModifiPerfil.TabStop = true;
            this.lModifiPerfil.Text = "Modificar Perfil";
            this.lModifiPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lModifiPerfil_LinkClicked);
            // 
            // FormGestorStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 288);
            this.Controls.Add(this.lModifiPerfil);
            this.Controls.Add(this.tboxGestorStock);
            this.Controls.Add(this.btnGStockSalir);
            this.Controls.Add(this.btnGStockVerStock);
            this.Controls.Add(this.btnGStockVerInventario);
            this.Controls.Add(this.btnGStockCargarNewProd);
            this.Controls.Add(this.btnGStockBuscarProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGestorStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestor de Stock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGStockBuscarProd;
        private System.Windows.Forms.Button btnGStockCargarNewProd;
        private System.Windows.Forms.Button btnGStockVerInventario;
        private System.Windows.Forms.Button btnGStockVerStock;
        private System.Windows.Forms.Button btnGStockSalir;
        private System.Windows.Forms.Label tboxGestorStock;
        private System.Windows.Forms.LinkLabel lModifiPerfil;
    }
}