namespace TC_Electrodomesticos
{
    partial class FormComprarProducto
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
            this.tboxNombreCompleto = new System.Windows.Forms.TextBox();
            this.tboxCuil = new System.Windows.Forms.TextBox();
            this.textNombreCOmpleto = new System.Windows.Forms.Label();
            this.textCUIL = new System.Windows.Forms.Label();
            this.btnComprarPro = new System.Windows.Forms.Button();
            this.btnCancelarPro = new System.Windows.Forms.Button();
            this.cboxListaProductos = new System.Windows.Forms.ComboBox();
            this.labelListaProductos = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxNombreCompleto
            // 
            this.tboxNombreCompleto.Location = new System.Drawing.Point(41, 150);
            this.tboxNombreCompleto.Name = "tboxNombreCompleto";
            this.tboxNombreCompleto.Size = new System.Drawing.Size(100, 20);
            this.tboxNombreCompleto.TabIndex = 0;
            // 
            // tboxCuil
            // 
            this.tboxCuil.Location = new System.Drawing.Point(41, 193);
            this.tboxCuil.Name = "tboxCuil";
            this.tboxCuil.Size = new System.Drawing.Size(100, 20);
            this.tboxCuil.TabIndex = 1;
            // 
            // textNombreCOmpleto
            // 
            this.textNombreCOmpleto.AutoSize = true;
            this.textNombreCOmpleto.Location = new System.Drawing.Point(176, 153);
            this.textNombreCOmpleto.Name = "textNombreCOmpleto";
            this.textNombreCOmpleto.Size = new System.Drawing.Size(91, 13);
            this.textNombreCOmpleto.TabIndex = 2;
            this.textNombreCOmpleto.Text = "Nombre Completo";
            this.textNombreCOmpleto.Click += new System.EventHandler(this.textNombreCOmpleto_Click);
            // 
            // textCUIL
            // 
            this.textCUIL.AutoSize = true;
            this.textCUIL.Location = new System.Drawing.Point(203, 200);
            this.textCUIL.Name = "textCUIL";
            this.textCUIL.Size = new System.Drawing.Size(31, 13);
            this.textCUIL.TabIndex = 3;
            this.textCUIL.Text = "CUIL";
            // 
            // btnComprarPro
            // 
            this.btnComprarPro.Location = new System.Drawing.Point(12, 261);
            this.btnComprarPro.Name = "btnComprarPro";
            this.btnComprarPro.Size = new System.Drawing.Size(75, 23);
            this.btnComprarPro.TabIndex = 4;
            this.btnComprarPro.Text = "Comprar";
            this.btnComprarPro.UseVisualStyleBackColor = true;
            this.btnComprarPro.Click += new System.EventHandler(this.btnComprarPro_Click);
            // 
            // btnCancelarPro
            // 
            this.btnCancelarPro.Location = new System.Drawing.Point(225, 261);
            this.btnCancelarPro.Name = "btnCancelarPro";
            this.btnCancelarPro.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarPro.TabIndex = 5;
            this.btnCancelarPro.Text = "Cancelar";
            this.btnCancelarPro.UseVisualStyleBackColor = true;
            this.btnCancelarPro.Click += new System.EventHandler(this.btnCancelarPro_Click);
            // 
            // cboxListaProductos
            // 
            this.cboxListaProductos.FormattingEnabled = true;
            this.cboxListaProductos.Location = new System.Drawing.Point(30, 90);
            this.cboxListaProductos.Name = "cboxListaProductos";
            this.cboxListaProductos.Size = new System.Drawing.Size(121, 21);
            this.cboxListaProductos.TabIndex = 6;
            // 
            // labelListaProductos
            // 
            this.labelListaProductos.AutoSize = true;
            this.labelListaProductos.Location = new System.Drawing.Point(158, 97);
            this.labelListaProductos.Name = "labelListaProductos";
            this.labelListaProductos.Size = new System.Drawing.Size(142, 13);
            this.labelListaProductos.TabIndex = 7;
            this.labelListaProductos.Text = "LISTADO DE PRODUCTOS";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(301, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "INTERFAZ COMPRAR PRODUCTO (REGISTRAR CLIENTE)";
            // 
            // FormComprarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 319);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelListaProductos);
            this.Controls.Add(this.cboxListaProductos);
            this.Controls.Add(this.btnCancelarPro);
            this.Controls.Add(this.btnComprarPro);
            this.Controls.Add(this.textCUIL);
            this.Controls.Add(this.textNombreCOmpleto);
            this.Controls.Add(this.tboxCuil);
            this.Controls.Add(this.tboxNombreCompleto);
            this.Name = "FormComprarProducto";
            this.Text = "FormComprarProducto";
            this.Load += new System.EventHandler(this.FormComprarProducto_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tboxNombreCompleto;
        private System.Windows.Forms.TextBox tboxCuil;
        private System.Windows.Forms.Label textNombreCOmpleto;
        private System.Windows.Forms.Label textCUIL;
        private System.Windows.Forms.Button btnComprarPro;
        private System.Windows.Forms.Button btnCancelarPro;
        private System.Windows.Forms.ComboBox cboxListaProductos;
        private System.Windows.Forms.Label labelListaProductos;
        private System.Windows.Forms.Label label1;
    }
}