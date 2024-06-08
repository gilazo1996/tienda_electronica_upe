namespace TC_Electrodomesticos
{
    partial class Admin_CrearUsuario
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
            this.registerNombre = new System.Windows.Forms.Label();
            this.tboxNombreCrear = new System.Windows.Forms.TextBox();
            this.btnCerrarForm = new System.Windows.Forms.Button();
            this.btnCrearUsuario = new System.Windows.Forms.Button();
            this.registerPssw = new System.Windows.Forms.Label();
            this.registerMail = new System.Windows.Forms.Label();
            this.tboxPSSWCrear = new System.Windows.Forms.TextBox();
            this.tboxCorreoCrear = new System.Windows.Forms.TextBox();
            this.cboxRoles = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelCrearUser = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // registerNombre
            // 
            this.registerNombre.AutoSize = true;
            this.registerNombre.Location = new System.Drawing.Point(197, 98);
            this.registerNombre.Name = "registerNombre";
            this.registerNombre.Size = new System.Drawing.Size(44, 13);
            this.registerNombre.TabIndex = 20;
            this.registerNombre.Text = "Nombre";
            // 
            // tboxNombreCrear
            // 
            this.tboxNombreCrear.Location = new System.Drawing.Point(91, 98);
            this.tboxNombreCrear.Name = "tboxNombreCrear";
            this.tboxNombreCrear.Size = new System.Drawing.Size(100, 20);
            this.tboxNombreCrear.TabIndex = 19;
            // 
            // btnCerrarForm
            // 
            this.btnCerrarForm.Location = new System.Drawing.Point(229, 251);
            this.btnCerrarForm.Name = "btnCerrarForm";
            this.btnCerrarForm.Size = new System.Drawing.Size(75, 23);
            this.btnCerrarForm.TabIndex = 18;
            this.btnCerrarForm.Text = "Cancelar";
            this.btnCerrarForm.UseVisualStyleBackColor = true;
            this.btnCerrarForm.Click += new System.EventHandler(this.btnCerrarForm_Click);
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.Location = new System.Drawing.Point(12, 251);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Size = new System.Drawing.Size(107, 23);
            this.btnCrearUsuario.TabIndex = 17;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.UseVisualStyleBackColor = true;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // registerPssw
            // 
            this.registerPssw.AutoSize = true;
            this.registerPssw.Location = new System.Drawing.Point(197, 157);
            this.registerPssw.Name = "registerPssw";
            this.registerPssw.Size = new System.Drawing.Size(61, 13);
            this.registerPssw.TabIndex = 16;
            this.registerPssw.Text = "Contraseña";
            // 
            // registerMail
            // 
            this.registerMail.AutoSize = true;
            this.registerMail.Location = new System.Drawing.Point(197, 127);
            this.registerMail.Name = "registerMail";
            this.registerMail.Size = new System.Drawing.Size(38, 13);
            this.registerMail.TabIndex = 15;
            this.registerMail.Text = "Correo";
            // 
            // tboxPSSWCrear
            // 
            this.tboxPSSWCrear.Location = new System.Drawing.Point(91, 154);
            this.tboxPSSWCrear.Name = "tboxPSSWCrear";
            this.tboxPSSWCrear.Size = new System.Drawing.Size(100, 20);
            this.tboxPSSWCrear.TabIndex = 14;
            // 
            // tboxCorreoCrear
            // 
            this.tboxCorreoCrear.Location = new System.Drawing.Point(91, 124);
            this.tboxCorreoCrear.Name = "tboxCorreoCrear";
            this.tboxCorreoCrear.Size = new System.Drawing.Size(100, 20);
            this.tboxCorreoCrear.TabIndex = 13;
            // 
            // cboxRoles
            // 
            this.cboxRoles.FormattingEnabled = true;
            this.cboxRoles.Location = new System.Drawing.Point(91, 180);
            this.cboxRoles.Name = "cboxRoles";
            this.cboxRoles.Size = new System.Drawing.Size(100, 21);
            this.cboxRoles.TabIndex = 21;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(197, 183);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Asignar ROL";
            // 
            // labelCrearUser
            // 
            this.labelCrearUser.AutoSize = true;
            this.labelCrearUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCrearUser.Location = new System.Drawing.Point(20, 18);
            this.labelCrearUser.Name = "labelCrearUser";
            this.labelCrearUser.Size = new System.Drawing.Size(284, 25);
            this.labelCrearUser.TabIndex = 23;
            this.labelCrearUser.Text = "CREAR NUEVO USUARIO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(54, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 13);
            this.label2.TabIndex = 24;
            this.label2.Text = "Ingrese credenciales para el nuevo usuario";
            // 
            // Admin_CrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 304);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.labelCrearUser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboxRoles);
            this.Controls.Add(this.registerNombre);
            this.Controls.Add(this.tboxNombreCrear);
            this.Controls.Add(this.btnCerrarForm);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.registerPssw);
            this.Controls.Add(this.registerMail);
            this.Controls.Add(this.tboxPSSWCrear);
            this.Controls.Add(this.tboxCorreoCrear);
            this.Name = "Admin_CrearUsuario";
            this.Text = "Admin_CrearUsuario";
            this.Load += new System.EventHandler(this.Admin_CrearUsuario_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label registerNombre;
        private System.Windows.Forms.TextBox tboxNombreCrear;
        private System.Windows.Forms.Button btnCerrarForm;
        private System.Windows.Forms.Button btnCrearUsuario;
        private System.Windows.Forms.Label registerPssw;
        private System.Windows.Forms.Label registerMail;
        private System.Windows.Forms.TextBox tboxPSSWCrear;
        private System.Windows.Forms.TextBox tboxCorreoCrear;
        private System.Windows.Forms.ComboBox cboxRoles;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelCrearUser;
        private System.Windows.Forms.Label label2;
    }
}