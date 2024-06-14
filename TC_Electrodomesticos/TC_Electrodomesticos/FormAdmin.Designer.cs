namespace TC_Electrodomesticos
{
    partial class FormularioAdministrador
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormularioAdministrador));
            this.label1 = new System.Windows.Forms.Label();
            this.admSalir = new System.Windows.Forms.Button();
            this.btnCrearUser = new System.Windows.Forms.Button();
            this.btnBuscarUsuario = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lModifiPerfil = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "INTERFAZ ADMINISTRADOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // admSalir
            // 
            this.admSalir.Location = new System.Drawing.Point(157, 254);
            this.admSalir.Name = "admSalir";
            this.admSalir.Size = new System.Drawing.Size(75, 23);
            this.admSalir.TabIndex = 1;
            this.admSalir.Text = "Salir";
            this.admSalir.UseVisualStyleBackColor = true;
            this.admSalir.Click += new System.EventHandler(this.admSalir_Click);
            // 
            // btnCrearUser
            // 
            this.btnCrearUser.Location = new System.Drawing.Point(52, 121);
            this.btnCrearUser.Name = "btnCrearUser";
            this.btnCrearUser.Size = new System.Drawing.Size(149, 23);
            this.btnCrearUser.TabIndex = 2;
            this.btnCrearUser.Text = "CREAR USUARIO";
            this.btnCrearUser.UseVisualStyleBackColor = true;
            this.btnCrearUser.Click += new System.EventHandler(this.btnCrearUser_Click);
            // 
            // btnBuscarUsuario
            // 
            this.btnBuscarUsuario.Location = new System.Drawing.Point(52, 150);
            this.btnBuscarUsuario.Name = "btnBuscarUsuario";
            this.btnBuscarUsuario.Size = new System.Drawing.Size(149, 23);
            this.btnBuscarUsuario.TabIndex = 4;
            this.btnBuscarUsuario.Text = "BUSCAR USUARIOS";
            this.btnBuscarUsuario.UseVisualStyleBackColor = true;
            this.btnBuscarUsuario.Click += new System.EventHandler(this.btnBuscarUsuario_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(101, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(40, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // lModifiPerfil
            // 
            this.lModifiPerfil.AutoSize = true;
            this.lModifiPerfil.Location = new System.Drawing.Point(12, 259);
            this.lModifiPerfil.Name = "lModifiPerfil";
            this.lModifiPerfil.Size = new System.Drawing.Size(76, 13);
            this.lModifiPerfil.TabIndex = 11;
            this.lModifiPerfil.TabStop = true;
            this.lModifiPerfil.Text = "Modificar Perfil";
            this.lModifiPerfil.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lModifiPerfil_LinkClicked);
            // 
            // FormularioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(244, 289);
            this.Controls.Add(this.lModifiPerfil);
            this.Controls.Add(this.btnBuscarUsuario);
            this.Controls.Add(this.btnCrearUser);
            this.Controls.Add(this.admSalir);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FormularioAdministrador";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormAdmin";
            this.Load += new System.EventHandler(this.FormularioAdministrador_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button admSalir;
        private System.Windows.Forms.Button btnCrearUser;
        private System.Windows.Forms.Button btnBuscarUsuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.LinkLabel lModifiPerfil;
    }
}