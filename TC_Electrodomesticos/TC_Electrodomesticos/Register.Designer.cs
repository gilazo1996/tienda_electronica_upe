namespace TC_Electrodomesticos
{
    partial class Register
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
            this.SuspendLayout();
            // 
            // tboxRegisterName
            // 
            this.tboxRegisterName.Location = new System.Drawing.Point(244, 142);
            this.tboxRegisterName.Name = "tboxRegisterName";
            this.tboxRegisterName.Size = new System.Drawing.Size(100, 20);
            this.tboxRegisterName.TabIndex = 0;
            // 
            // tboxRegisterMail
            // 
            this.tboxRegisterMail.Location = new System.Drawing.Point(244, 180);
            this.tboxRegisterMail.Name = "tboxRegisterMail";
            this.tboxRegisterMail.Size = new System.Drawing.Size(100, 20);
            this.tboxRegisterMail.TabIndex = 1;
            // 
            // tboxRegisterPssw
            // 
            this.tboxRegisterPssw.Location = new System.Drawing.Point(244, 219);
            this.tboxRegisterPssw.Name = "tboxRegisterPssw";
            this.tboxRegisterPssw.Size = new System.Drawing.Size(100, 20);
            this.tboxRegisterPssw.TabIndex = 2;
            // 
            // registerUsername
            // 
            this.registerUsername.AutoSize = true;
            this.registerUsername.Location = new System.Drawing.Point(352, 149);
            this.registerUsername.Name = "registerUsername";
            this.registerUsername.Size = new System.Drawing.Size(83, 13);
            this.registerUsername.TabIndex = 3;
            this.registerUsername.Text = "Nombre Usuario";
            // 
            // registerMail
            // 
            this.registerMail.AutoSize = true;
            this.registerMail.Location = new System.Drawing.Point(352, 187);
            this.registerMail.Name = "registerMail";
            this.registerMail.Size = new System.Drawing.Size(38, 13);
            this.registerMail.TabIndex = 4;
            this.registerMail.Text = "Correo";
            // 
            // registerPssw
            // 
            this.registerPssw.AutoSize = true;
            this.registerPssw.Location = new System.Drawing.Point(352, 226);
            this.registerPssw.Name = "registerPssw";
            this.registerPssw.Size = new System.Drawing.Size(61, 13);
            this.registerPssw.TabIndex = 5;
            this.registerPssw.Text = "Contraseña";
            // 
            // btnRegistrarse
            // 
            this.btnRegistrarse.Location = new System.Drawing.Point(231, 285);
            this.btnRegistrarse.Name = "btnRegistrarse";
            this.btnRegistrarse.Size = new System.Drawing.Size(75, 23);
            this.btnRegistrarse.TabIndex = 6;
            this.btnRegistrarse.Text = "Registrarse";
            this.btnRegistrarse.UseVisualStyleBackColor = true;
            this.btnRegistrarse.Click += new System.EventHandler(this.btnRegistrarse_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(325, 285);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnRegistrarse);
            this.Controls.Add(this.registerPssw);
            this.Controls.Add(this.registerMail);
            this.Controls.Add(this.registerUsername);
            this.Controls.Add(this.tboxRegisterPssw);
            this.Controls.Add(this.tboxRegisterMail);
            this.Controls.Add(this.tboxRegisterName);
            this.Name = "Register";
            this.Text = "Register";
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
    }
}