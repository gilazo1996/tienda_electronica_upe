namespace TC_Electrodomesticos
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
            this.btnGStockBuscarProve = new System.Windows.Forms.Button();
            this.btnGStockCargarNewProve = new System.Windows.Forms.Button();
            this.btnGStockVerListaProve = new System.Windows.Forms.Button();
            this.btnGStockSalir = new System.Windows.Forms.Button();
            this.tboxGestorStock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGStockBuscarProd
            // 
            this.btnGStockBuscarProd.Location = new System.Drawing.Point(43, 58);
            this.btnGStockBuscarProd.Name = "btnGStockBuscarProd";
            this.btnGStockBuscarProd.Size = new System.Drawing.Size(75, 35);
            this.btnGStockBuscarProd.TabIndex = 0;
            this.btnGStockBuscarProd.Text = "Buscar \r\nproducto";
            this.btnGStockBuscarProd.UseVisualStyleBackColor = true;
            // 
            // btnGStockCargarNewProd
            // 
            this.btnGStockCargarNewProd.Location = new System.Drawing.Point(43, 99);
            this.btnGStockCargarNewProd.Name = "btnGStockCargarNewProd";
            this.btnGStockCargarNewProd.Size = new System.Drawing.Size(75, 47);
            this.btnGStockCargarNewProd.TabIndex = 1;
            this.btnGStockCargarNewProd.Text = "Cargar nuevo producto";
            this.btnGStockCargarNewProd.UseVisualStyleBackColor = true;
            // 
            // btnGStockVerInventario
            // 
            this.btnGStockVerInventario.Location = new System.Drawing.Point(43, 152);
            this.btnGStockVerInventario.Name = "btnGStockVerInventario";
            this.btnGStockVerInventario.Size = new System.Drawing.Size(75, 41);
            this.btnGStockVerInventario.TabIndex = 2;
            this.btnGStockVerInventario.Text = "Visualizar inventario";
            this.btnGStockVerInventario.UseVisualStyleBackColor = true;
            // 
            // btnGStockVerStock
            // 
            this.btnGStockVerStock.Location = new System.Drawing.Point(43, 199);
            this.btnGStockVerStock.Name = "btnGStockVerStock";
            this.btnGStockVerStock.Size = new System.Drawing.Size(75, 38);
            this.btnGStockVerStock.TabIndex = 3;
            this.btnGStockVerStock.Text = "Control de Stock";
            this.btnGStockVerStock.UseVisualStyleBackColor = true;
            this.btnGStockVerStock.Click += new System.EventHandler(this.btnGStockVerStock_Click);
            // 
            // btnGStockBuscarProve
            // 
            this.btnGStockBuscarProve.Location = new System.Drawing.Point(172, 58);
            this.btnGStockBuscarProve.Name = "btnGStockBuscarProve";
            this.btnGStockBuscarProve.Size = new System.Drawing.Size(75, 35);
            this.btnGStockBuscarProve.TabIndex = 4;
            this.btnGStockBuscarProve.Text = "Buscar proveedor";
            this.btnGStockBuscarProve.UseVisualStyleBackColor = true;
            // 
            // btnGStockCargarNewProve
            // 
            this.btnGStockCargarNewProve.Location = new System.Drawing.Point(172, 99);
            this.btnGStockCargarNewProve.Name = "btnGStockCargarNewProve";
            this.btnGStockCargarNewProve.Size = new System.Drawing.Size(75, 47);
            this.btnGStockCargarNewProve.TabIndex = 5;
            this.btnGStockCargarNewProve.Text = "Cargar nuevo proveedor";
            this.btnGStockCargarNewProve.UseVisualStyleBackColor = true;
            // 
            // btnGStockVerListaProve
            // 
            this.btnGStockVerListaProve.Location = new System.Drawing.Point(172, 152);
            this.btnGStockVerListaProve.Name = "btnGStockVerListaProve";
            this.btnGStockVerListaProve.Size = new System.Drawing.Size(75, 41);
            this.btnGStockVerListaProve.TabIndex = 6;
            this.btnGStockVerListaProve.Text = "Lista de proveedores";
            this.btnGStockVerListaProve.UseVisualStyleBackColor = true;
            // 
            // btnGStockSalir
            // 
            this.btnGStockSalir.Location = new System.Drawing.Point(277, 253);
            this.btnGStockSalir.Name = "btnGStockSalir";
            this.btnGStockSalir.Size = new System.Drawing.Size(75, 23);
            this.btnGStockSalir.TabIndex = 7;
            this.btnGStockSalir.Text = "Salir";
            this.btnGStockSalir.UseVisualStyleBackColor = true;
            this.btnGStockSalir.Click += new System.EventHandler(this.btnGStockSalir_Click);
            // 
            // tboxGestorStock
            // 
            this.tboxGestorStock.AutoSize = true;
            this.tboxGestorStock.Location = new System.Drawing.Point(22, 9);
            this.tboxGestorStock.Name = "tboxGestorStock";
            this.tboxGestorStock.Size = new System.Drawing.Size(319, 13);
            this.tboxGestorStock.TabIndex = 8;
            this.tboxGestorStock.Text = "BIENVENIDO, ESTA ES LA INTERFAZ DE GESTOR DE STOCK";
            // 
            // FormGestorStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 288);
            this.Controls.Add(this.tboxGestorStock);
            this.Controls.Add(this.btnGStockSalir);
            this.Controls.Add(this.btnGStockVerListaProve);
            this.Controls.Add(this.btnGStockCargarNewProve);
            this.Controls.Add(this.btnGStockBuscarProve);
            this.Controls.Add(this.btnGStockVerStock);
            this.Controls.Add(this.btnGStockVerInventario);
            this.Controls.Add(this.btnGStockCargarNewProd);
            this.Controls.Add(this.btnGStockBuscarProd);
            this.Name = "FormGestorStock";
            this.Text = "FormGestorStock";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGStockBuscarProd;
        private System.Windows.Forms.Button btnGStockCargarNewProd;
        private System.Windows.Forms.Button btnGStockVerInventario;
        private System.Windows.Forms.Button btnGStockVerStock;
        private System.Windows.Forms.Button btnGStockBuscarProve;
        private System.Windows.Forms.Button btnGStockCargarNewProve;
        private System.Windows.Forms.Button btnGStockVerListaProve;
        private System.Windows.Forms.Button btnGStockSalir;
        private System.Windows.Forms.Label tboxGestorStock;
    }
}