namespace TC_Electrodomesticos
{
    partial class FormUsuario
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
            this.textCliente = new System.Windows.Forms.Label();
            this.btnClienteSalir = new System.Windows.Forms.Button();
            this.btnUsuarioComprar = new System.Windows.Forms.Button();
            this.btnVerCompras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textCliente
            // 
            this.textCliente.AutoSize = true;
            this.textCliente.Location = new System.Drawing.Point(41, 9);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(266, 13);
            this.textCliente.TabIndex = 0;
            this.textCliente.Text = "BIENVENIDO, ESTA ES LA INTERFAZ DE USUARIO";
            this.textCliente.Click += new System.EventHandler(this.textCliente_Click);
            // 
            // btnClienteSalir
            // 
            this.btnClienteSalir.Location = new System.Drawing.Point(264, 227);
            this.btnClienteSalir.Name = "btnClienteSalir";
            this.btnClienteSalir.Size = new System.Drawing.Size(75, 23);
            this.btnClienteSalir.TabIndex = 1;
            this.btnClienteSalir.Text = "Salir";
            this.btnClienteSalir.UseVisualStyleBackColor = true;
            this.btnClienteSalir.Click += new System.EventHandler(this.btnClienteSalir_Click);
            // 
            // btnUsuarioComprar
            // 
            this.btnUsuarioComprar.Location = new System.Drawing.Point(115, 83);
            this.btnUsuarioComprar.Name = "btnUsuarioComprar";
            this.btnUsuarioComprar.Size = new System.Drawing.Size(134, 23);
            this.btnUsuarioComprar.TabIndex = 2;
            this.btnUsuarioComprar.Text = "Comprar Producto";
            this.btnUsuarioComprar.UseVisualStyleBackColor = true;
            this.btnUsuarioComprar.Click += new System.EventHandler(this.btnUsuarioComprar_Click);
            // 
            // btnVerCompras
            // 
            this.btnVerCompras.Location = new System.Drawing.Point(115, 133);
            this.btnVerCompras.Name = "btnVerCompras";
            this.btnVerCompras.Size = new System.Drawing.Size(134, 23);
            this.btnVerCompras.TabIndex = 4;
            this.btnVerCompras.Text = "Ver compras";
            this.btnVerCompras.UseVisualStyleBackColor = true;
            this.btnVerCompras.Click += new System.EventHandler(this.btnVerCompras_Click);
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 288);
            this.Controls.Add(this.btnVerCompras);
            this.Controls.Add(this.btnUsuarioComprar);
            this.Controls.Add(this.btnClienteSalir);
            this.Controls.Add(this.textCliente);
            this.Name = "FormUsuario";
            this.Text = "FormCliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textCliente;
        private System.Windows.Forms.Button btnClienteSalir;
        private System.Windows.Forms.Button btnUsuarioComprar;
        private System.Windows.Forms.Button btnVerCompras;
    }
}