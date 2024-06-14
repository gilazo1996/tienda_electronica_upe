namespace TC_Electrodomesticos
{
    partial class FromRegistro
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
            this.tboxRegisterName = new System.Windows.Forms.TextBox();
            this.tboxRegisterMail = new System.Windows.Forms.TextBox();
            this.tboxRegisterPssw = new System.Windows.Forms.TextBox();
            this.registerUsername = new System.Windows.Forms.Label();
            this.registerMail = new System.Windows.Forms.Label();
            this.registerPssw = new System.Windows.Forms.Label();
            this.btnRegistrarse = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.registerText = new System.Windows.Forms.Label();
            this.tboxNombreRegis = new System.Windows.Forms.TextBox();
            this.registerNombre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxRegisterName
            // 
            this.tboxRegisterName.Location = new System.Drawing.Point(0, 0);
            this.tboxRegisterName.Name = "tboxRegisterName";
            this.tboxRegisterName.Size = new System.Drawing.Size(100, 20);
            this.tboxRegisterName.TabIndex = 9;
            // 
            // tboxRegisterMail
            // 
            this.tboxRegisterMail.Location = new System.Drawing.Point(45, 130);
            this.tboxRegisterMail.Name = "tboxRegisterMail";
            this.tboxRegisterMail.Size = new System.Drawing.Size(100, 20);
            this.tboxRegisterMail.TabIndex = 1;
            // 
            // tboxRegisterPssw
            // 
            this.tboxRegisterPssw.Location = new System.Drawing.Point(45, 169);
            this.tboxRegisterPssw.Name = "tboxRegisterPssw";
            this.tboxRegisterPssw.Size = new System.Drawing.Size(100, 20);
            this.tboxRegisterPssw.TabIndex = 2;
            // 
            // registerUsername
            // 
            this.registerUsername.Location = new System.Drawing.Point(0, 0);
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.Size = new System.Drawing.Size(100, 23);
            this.registerUsername.TabIndex = 8;
            // 
            // registerMail
            // 
            this.registerMail.AutoSize = true;
            this.registerMail.Location = new System.Drawing.Point(153, 137);
            this.registerMail.Name = "registerMail";
            this.registerMail.Size = new System.Drawing.Size(38, 13);
            this.registerMail.TabIndex = 4;
            this.registerMail.Text = "Correo";
            // 
            // registerPssw
            // 
            this.registerPssw.AutoSize = true;
            this.registerPssw.Location = new System.Drawing.Point(153, 176);
            this.registerPssw.Name = "registerPssw";
            this.registerPssw.Size = new System.Drawing.Size(61, 13);
            this.registerPssw.TabIndex = 5;
            this.registerPssw.Text = "Contraseña";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.BackColor = System.Drawing.Color.Silver;
            this.btnRegistrarse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarse.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegistrarse.Location = new System.Drawing.Point(35, 235);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarse.TabIndex = 6;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = false;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.Silver;
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(139, 235);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // registerText
            // 
            this.registerText.AutoSize = true;
            this.registerText.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registerText.Location = new System.Drawing.Point(44, 49);
            this.registerText.Name = "registerText";
            this.registerText.Size = new System.Drawing.Size(152, 13);
            this.registerText.TabIndex = 10;
            this.registerText.Text = "REGISTRO DE USUARIO";
            this.registerText.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tboxNombreRegis
            // 
            this.tboxNombreRegis.Location = new System.Drawing.Point(45, 97);
            this.tboxNombreRegis.Name = "tboxNombreRegis";
            this.tboxNombreRegis.Size = new System.Drawing.Size(100, 20);
            this.tboxNombreRegis.TabIndex = 11;
            // 
            // registerNombre
            // 
            this.registerNombre.AutoSize = true;
            this.registerNombre.Location = new System.Drawing.Point(152, 97);
            this.registerNombre.Name = "registerNombre";
            this.registerNombre.Size = new System.Drawing.Size(44, 13);
            this.registerNombre.TabIndex = 12;
            this.registerNombre.Text = "Nombre";
            // 
            // FromRegistro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(247, 297);
            this.Controls.Add(this.registerNombre);
            this.Controls.Add(this.tboxNombreRegis);
            this.Controls.Add(this.registerText);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.registerPssw);
            this.Controls.Add(this.registerMail);
            this.Controls.Add(this.registerUsername);
            this.Controls.Add(this.tboxRegisterPssw);
            this.Controls.Add(this.tboxRegisterMail);
            this.Controls.Add(this.tboxRegisterName);
            this.Name = "FromRegistro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Register";
            this.Load += new System.EventHandler(this.FromRegistro_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxRegisterName;
        private System.Windows.Forms.TextBox tboxRegisterMail;
        private System.Windows.Forms.TextBox tboxRegisterPssw;
        private System.Windows.Forms.Label registerUsername;
        private System.Windows.Forms.Label registerMail;
        private System.Windows.Forms.Label registerPssw;
        private System.Windows.Forms.Button btnRegistrarse;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label registerText;
        private System.Windows.Forms.TextBox tboxNombreRegis;
        private System.Windows.Forms.Label registerNombre;
    }
}