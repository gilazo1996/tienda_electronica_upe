namespace TC_Electrodomesticos
{
    partial class FormModificarPerfil
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormModificarPerfil));
            this.registerNombre = new System.Windows.Forms.Label();
            this.tboxNombreModi = new System.Windows.Forms.TextBox();
            this.registerPssw = new System.Windows.Forms.Label();
            this.registerMail = new System.Windows.Forms.Label();
            this.tboxPSSWModi = new System.Windows.Forms.TextBox();
            this.tboxCorreoModi = new System.Windows.Forms.TextBox();
            this.bModificarPerfil = new System.Windows.Forms.Button();
            this.bCancelarModificacion = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pMostrarContra = new System.Windows.Forms.PictureBox();
            this.pOcultarContra = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pMostrarContra)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOcultarContra)).BeginInit();
            this.SuspendLayout();
            // 
            // registerNombre
            // 
            this.registerNombre.AutoSize = true;
            this.registerNombre.Location = new System.Drawing.Point(198, 101);
            this.registerNombre.Name = "registerNombre";
            this.registerNombre.Size = new System.Drawing.Size(46, 13);
            this.registerNombre.TabIndex = 26;
            this.registerNombre.Text = "Nombre";
            // 
            // tboxNombreModi
            // 
            this.tboxNombreModi.Location = new System.Drawing.Point(91, 98);
            this.tboxNombreModi.Name = "tboxNombreModi";
            this.tboxNombreModi.Size = new System.Drawing.Size(100, 21);
            this.tboxNombreModi.TabIndex = 25;
            // 
            // registerPssw
            // 
            this.registerPssw.AutoSize = true;
            this.registerPssw.Location = new System.Drawing.Point(198, 157);
            this.registerPssw.Name = "registerPssw";
            this.registerPssw.Size = new System.Drawing.Size(59, 13);
            this.registerPssw.TabIndex = 24;
            this.registerPssw.Text = "Contraseña";
            // 
            // registerMail
            // 
            this.registerMail.AutoSize = true;
            this.registerMail.Location = new System.Drawing.Point(198, 127);
            this.registerMail.Name = "registerMail";
            this.registerMail.Size = new System.Drawing.Size(39, 13);
            this.registerMail.TabIndex = 23;
            this.registerMail.Text = "Correo";
            // 
            // tboxPSSWModi
            // 
            this.tboxPSSWModi.Location = new System.Drawing.Point(91, 154);
            this.tboxPSSWModi.Name = "tboxPSSWModi";
            this.tboxPSSWModi.Size = new System.Drawing.Size(100, 21);
            this.tboxPSSWModi.TabIndex = 22;
            this.tboxPSSWModi.UseSystemPasswordChar = true;
            // 
            // tboxCorreoModi
            // 
            this.tboxCorreoModi.Location = new System.Drawing.Point(91, 124);
            this.tboxCorreoModi.Name = "tboxCorreoModi";
            this.tboxCorreoModi.Size = new System.Drawing.Size(100, 21);
            this.tboxCorreoModi.TabIndex = 21;
            // 
            // bModificarPerfil
            // 
            this.bModificarPerfil.BackColor = System.Drawing.Color.Silver;
            this.bModificarPerfil.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bModificarPerfil.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bModificarPerfil.Location = new System.Drawing.Point(43, 255);
            this.bModificarPerfil.Name = "bModificarPerfil";
            this.bModificarPerfil.Size = new System.Drawing.Size(75, 23);
            this.bModificarPerfil.TabIndex = 27;
            this.bModificarPerfil.Text = "Aceptar";
            this.bModificarPerfil.UseVisualStyleBackColor = false;
            this.bModificarPerfil.Click += new System.EventHandler(this.bModificarPerfil_Click);
            // 
            // bCancelarModificacion
            // 
            this.bCancelarModificacion.BackColor = System.Drawing.Color.Silver;
            this.bCancelarModificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bCancelarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bCancelarModificacion.Location = new System.Drawing.Point(201, 255);
            this.bCancelarModificacion.Name = "bCancelarModificacion";
            this.bCancelarModificacion.Size = new System.Drawing.Size(75, 23);
            this.bCancelarModificacion.TabIndex = 28;
            this.bCancelarModificacion.Text = "Cancelar";
            this.bCancelarModificacion.UseVisualStyleBackColor = false;
            this.bCancelarModificacion.Click += new System.EventHandler(this.bCancelarModificacion_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(61, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 24);
            this.label1.TabIndex = 29;
            this.label1.Text = "MODIFICAR PERFIL";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pMostrarContra
            // 
            this.pMostrarContra.Image = ((System.Drawing.Image)(resources.GetObject("pMostrarContra.Image")));
            this.pMostrarContra.Location = new System.Drawing.Point(65, 154);
            this.pMostrarContra.Name = "pMostrarContra";
            this.pMostrarContra.Size = new System.Drawing.Size(20, 20);
            this.pMostrarContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pMostrarContra.TabIndex = 30;
            this.pMostrarContra.TabStop = false;
            this.pMostrarContra.Click += new System.EventHandler(this.pMostrarContra_Click);
            // 
            // pOcultarContra
            // 
            this.pOcultarContra.Image = ((System.Drawing.Image)(resources.GetObject("pOcultarContra.Image")));
            this.pOcultarContra.Location = new System.Drawing.Point(65, 154);
            this.pOcultarContra.Name = "pOcultarContra";
            this.pOcultarContra.Size = new System.Drawing.Size(20, 20);
            this.pOcultarContra.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pOcultarContra.TabIndex = 31;
            this.pOcultarContra.TabStop = false;
            this.pOcultarContra.Click += new System.EventHandler(this.pOcultarContra_Click);
            // 
            // FormModificarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(316, 304);
            this.Controls.Add(this.pMostrarContra);
            this.Controls.Add(this.pOcultarContra);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.bCancelarModificacion);
            this.Controls.Add(this.bModificarPerfil);
            this.Controls.Add(this.registerNombre);
            this.Controls.Add(this.tboxNombreModi);
            this.Controls.Add(this.registerPssw);
            this.Controls.Add(this.registerMail);
            this.Controls.Add(this.tboxPSSWModi);
            this.Controls.Add(this.tboxCorreoModi);
            this.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormModificarPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar Perfil";
            this.Load += new System.EventHandler(this.FormModificarPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pMostrarContra)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pOcultarContra)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerNombre;
        private System.Windows.Forms.TextBox tboxNombreModi;
        private System.Windows.Forms.Label registerPssw;
        private System.Windows.Forms.Label registerMail;
        private System.Windows.Forms.TextBox tboxPSSWModi;
        private System.Windows.Forms.TextBox tboxCorreoModi;
        private System.Windows.Forms.Button bModificarPerfil;
        private System.Windows.Forms.Button bCancelarModificacion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pMostrarContra;
        private System.Windows.Forms.PictureBox pOcultarContra;
    }
}