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
            this.label1 = new System.Windows.Forms.Label();
            this.admSalir = new System.Windows.Forms.Button();
            this.btnAltaUser = new System.Windows.Forms.Button();
            this.btnEliminarUser = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(70, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "INTERFAZ ADMINISTRADOR";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // admSalir
            // 
            this.admSalir.Location = new System.Drawing.Point(107, 262);
            this.admSalir.Name = "admSalir";
            this.admSalir.Size = new System.Drawing.Size(75, 23);
            this.admSalir.TabIndex = 1;
            this.admSalir.Text = "Salir";
            this.admSalir.UseVisualStyleBackColor = true;
            this.admSalir.Click += new System.EventHandler(this.admSalir_Click);
            // 
            // btnAltaUser
            // 
            this.btnAltaUser.Location = new System.Drawing.Point(73, 158);
            this.btnAltaUser.Name = "btnAltaUser";
            this.btnAltaUser.Size = new System.Drawing.Size(149, 23);
            this.btnAltaUser.TabIndex = 2;
            this.btnAltaUser.Text = "ALTA USUARIO";
            this.btnAltaUser.UseVisualStyleBackColor = true;
            // 
            // btnEliminarUser
            // 
            this.btnEliminarUser.Location = new System.Drawing.Point(73, 187);
            this.btnEliminarUser.Name = "btnEliminarUser";
            this.btnEliminarUser.Size = new System.Drawing.Size(149, 23);
            this.btnEliminarUser.TabIndex = 3;
            this.btnEliminarUser.Text = "ELIMINAR USUARIO";
            this.btnEliminarUser.UseVisualStyleBackColor = true;
            // 
            // FormularioAdministrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(324, 343);
            this.Controls.Add(this.btnEliminarUser);
            this.Controls.Add(this.btnAltaUser);
            this.Controls.Add(this.admSalir);
            this.Controls.Add(this.label1);
            this.Name = "FormularioAdministrador";
            this.Text = "FormAdmin";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button admSalir;
        private System.Windows.Forms.Button btnAltaUser;
        private System.Windows.Forms.Button btnEliminarUser;
    }
}