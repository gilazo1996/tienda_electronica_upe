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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormUsuario));
            this.textCliente = new System.Windows.Forms.Label();
            this.btnClienteSalir = new System.Windows.Forms.Button();
            this.btnUsuarioComprar = new System.Windows.Forms.Button();
            this.btnVerCompras = new System.Windows.Forms.Button();
            this.lModifiPerfil = new System.Windows.Forms.LinkLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // textCliente
            // 
            this.textCliente.AutoSize = true;
            this.textCliente.Font = new System.Drawing.Font("Franklin Gothic Medium", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textCliente.Location = new System.Drawing.Point(46, 45);
            this.textCliente.Name = "textCliente";
            this.textCliente.Size = new System.Drawing.Size(273, 17);
            this.textCliente.TabIndex = 0;
            this.textCliente.Text = "BIENVENIDO, ESTA ES LA INTERFAZ DE USUARIO";
            this.textCliente.Click += new System.EventHandler(this.textCliente_Click);
            // 
            // btnClienteSalir
            // 
            this.btnClienteSalir.BackColor = System.Drawing.Color.Silver;
            this.btnClienteSalir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnClienteSalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClienteSalir.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClienteSalir.Location = new System.Drawing.Point(277, 253);
            this.btnClienteSalir.Name = "btnClienteSalir";
            this.btnClienteSalir.Size = new System.Drawing.Size(75, 23);
            this.btnClienteSalir.TabIndex = 1;
            this.btnClienteSalir.Text = "Salir";
            this.btnClienteSalir.UseVisualStyleBackColor = false;
            this.btnClienteSalir.Click += new System.EventHandler(this.btnClienteSalir_Click);
            // 
            // btnUsuarioComprar
            // 
            this.btnUsuarioComprar.BackColor = System.Drawing.Color.Silver;
            this.btnUsuarioComprar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnUsuarioComprar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuarioComprar.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuarioComprar.Location = new System.Drawing.Point(115, 101);
            this.btnUsuarioComprar.Name = "btnUsuarioComprar";
            this.btnUsuarioComprar.Size = new System.Drawing.Size(134, 23);
            this.btnUsuarioComprar.TabIndex = 2;
            this.btnUsuarioComprar.Text = "Comprar Producto";
            this.btnUsuarioComprar.UseVisualStyleBackColor = false;
            this.btnUsuarioComprar.Click += new System.EventHandler(this.btnUsuarioComprar_Click);
            // 
            // btnVerCompras
            // 
            this.btnVerCompras.BackColor = System.Drawing.Color.Silver;
            this.btnVerCompras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnVerCompras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerCompras.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerCompras.Location = new System.Drawing.Point(115, 148);
            this.btnVerCompras.Name = "btnVerCompras";
            this.btnVerCompras.Size = new System.Drawing.Size(134, 23);
            this.btnVerCompras.TabIndex = 4;
            this.btnVerCompras.Text = "Ver compras";
            this.btnVerCompras.UseVisualStyleBackColor = false;
            this.btnVerCompras.Click += new System.EventHandler(this.btnVerCompras_Click);
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
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(264, 117);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(78, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // FormUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(364, 288);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lModifiPerfil);
            this.Controls.Add(this.btnVerCompras);
            this.Controls.Add(this.btnUsuarioComprar);
            this.Controls.Add(this.btnClienteSalir);
            this.Controls.Add(this.textCliente);
            this.Name = "FormUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.FormCliente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label textCliente;
        private System.Windows.Forms.Button btnClienteSalir;
        private System.Windows.Forms.Button btnUsuarioComprar;
        private System.Windows.Forms.Button btnVerCompras;
        private System.Windows.Forms.LinkLabel lModifiPerfil;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}