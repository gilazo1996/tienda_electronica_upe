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
            this.btnGStockSalir = new System.Windows.Forms.Button();
            this.tboxGestorStock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnGStockBuscarProd
            // 
            this.btnGStockBuscarProd.Location = new System.Drawing.Point(51, 59);
            this.btnGStockBuscarProd.Name = "btnGStockBuscarProd";
            this.btnGStockBuscarProd.Size = new System.Drawing.Size(113, 35);
            this.btnGStockBuscarProd.TabIndex = 0;
            this.btnGStockBuscarProd.Text = "Buscar producto";
            this.btnGStockBuscarProd.UseVisualStyleBackColor = true;
            this.btnGStockBuscarProd.Click += new System.EventHandler(this.btnGStockBuscarProd_Click);
            // 
            // btnGStockCargarNewProd
            // 
            this.btnGStockCargarNewProd.Location = new System.Drawing.Point(179, 59);
            this.btnGStockCargarNewProd.Name = "btnGStockCargarNewProd";
            this.btnGStockCargarNewProd.Size = new System.Drawing.Size(140, 35);
            this.btnGStockCargarNewProd.TabIndex = 1;
            this.btnGStockCargarNewProd.Text = "Cargar nuevo producto";
            this.btnGStockCargarNewProd.UseVisualStyleBackColor = true;
            this.btnGStockCargarNewProd.Click += new System.EventHandler(this.btnGStockCargarNewProd_Click);
            // 
            // btnGStockVerInventario
            // 
            this.btnGStockVerInventario.Location = new System.Drawing.Point(51, 109);
            this.btnGStockVerInventario.Name = "btnGStockVerInventario";
            this.btnGStockVerInventario.Size = new System.Drawing.Size(113, 41);
            this.btnGStockVerInventario.TabIndex = 2;
            this.btnGStockVerInventario.Text = "Visualizar inventario";
            this.btnGStockVerInventario.UseVisualStyleBackColor = true;
            this.btnGStockVerInventario.Click += new System.EventHandler(this.btnGStockVerInventario_Click);
            // 
            // btnGStockVerStock
            // 
            this.btnGStockVerStock.Location = new System.Drawing.Point(179, 109);
            this.btnGStockVerStock.Name = "btnGStockVerStock";
            this.btnGStockVerStock.Size = new System.Drawing.Size(140, 41);
            this.btnGStockVerStock.TabIndex = 3;
            this.btnGStockVerStock.Text = "Control de Stock";
            this.btnGStockVerStock.UseVisualStyleBackColor = true;
            this.btnGStockVerStock.Click += new System.EventHandler(this.btnGStockVerStock_Click);
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
            this.Controls.Add(this.btnGStockVerStock);
            this.Controls.Add(this.btnGStockVerInventario);
            this.Controls.Add(this.btnGStockCargarNewProd);
            this.Controls.Add(this.btnGStockBuscarProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormGestorStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormGestorStock";
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
    }
}