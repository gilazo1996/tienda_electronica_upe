
namespace TC_Electrodomesticos
{
    partial class FormAltaProducto
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
            this.lblTextoAltaProd = new System.Windows.Forms.Label();
            this.gboxAltaProd = new System.Windows.Forms.GroupBox();
            this.cboxCategProd = new System.Windows.Forms.ComboBox();
            this.lblCategProd = new System.Windows.Forms.Label();
            this.lblDescriptProd = new System.Windows.Forms.Label();
            this.tboxDescriptProd = new System.Windows.Forms.TextBox();
            this.nudStockProd = new System.Windows.Forms.NumericUpDown();
            this.lblStockProd = new System.Windows.Forms.Label();
            this.lblPrecioProd = new System.Windows.Forms.Label();
            this.tboxPrecioProd = new System.Windows.Forms.TextBox();
            this.lblNombreProd = new System.Windows.Forms.Label();
            this.tboxNombreProd = new System.Windows.Forms.TextBox();
            this.btnCancelarRegistro = new System.Windows.Forms.Button();
            this.btnRegistrarProd = new System.Windows.Forms.Button();
            this.btnLimpiarCampos = new System.Windows.Forms.Button();
            this.gboxAltaProd.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockProd)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextoAltaProd
            // 
            this.lblTextoAltaProd.AutoSize = true;
            this.lblTextoAltaProd.Location = new System.Drawing.Point(21, 18);
            this.lblTextoAltaProd.Name = "lblTextoAltaProd";
            this.lblTextoAltaProd.Size = new System.Drawing.Size(175, 13);
            this.lblTextoAltaProd.TabIndex = 0;
            this.lblTextoAltaProd.Text = "REGISTRAR NUEVO PRODUCTO";
            // 
            // gboxAltaProd
            // 
            this.gboxAltaProd.Controls.Add(this.cboxCategProd);
            this.gboxAltaProd.Controls.Add(this.lblCategProd);
            this.gboxAltaProd.Controls.Add(this.lblDescriptProd);
            this.gboxAltaProd.Controls.Add(this.tboxDescriptProd);
            this.gboxAltaProd.Controls.Add(this.nudStockProd);
            this.gboxAltaProd.Controls.Add(this.lblStockProd);
            this.gboxAltaProd.Controls.Add(this.lblPrecioProd);
            this.gboxAltaProd.Controls.Add(this.tboxPrecioProd);
            this.gboxAltaProd.Controls.Add(this.lblNombreProd);
            this.gboxAltaProd.Controls.Add(this.tboxNombreProd);
            this.gboxAltaProd.Location = new System.Drawing.Point(22, 44);
            this.gboxAltaProd.Name = "gboxAltaProd";
            this.gboxAltaProd.Size = new System.Drawing.Size(216, 223);
            this.gboxAltaProd.TabIndex = 13;
            this.gboxAltaProd.TabStop = false;
            // 
            // cboxCategProd
            // 
            this.cboxCategProd.FormattingEnabled = true;
            this.cboxCategProd.Location = new System.Drawing.Point(96, 169);
            this.cboxCategProd.Name = "cboxCategProd";
            this.cboxCategProd.Size = new System.Drawing.Size(100, 21);
            this.cboxCategProd.TabIndex = 22;
            // 
            // lblCategProd
            // 
            this.lblCategProd.AutoSize = true;
            this.lblCategProd.Location = new System.Drawing.Point(36, 172);
            this.lblCategProd.Name = "lblCategProd";
            this.lblCategProd.Size = new System.Drawing.Size(54, 13);
            this.lblCategProd.TabIndex = 21;
            this.lblCategProd.Text = "Categoría";
            // 
            // lblDescriptProd
            // 
            this.lblDescriptProd.AutoSize = true;
            this.lblDescriptProd.Location = new System.Drawing.Point(27, 137);
            this.lblDescriptProd.Name = "lblDescriptProd";
            this.lblDescriptProd.Size = new System.Drawing.Size(63, 13);
            this.lblDescriptProd.TabIndex = 20;
            this.lblDescriptProd.Text = "Descripción";
            // 
            // tboxDescriptProd
            // 
            this.tboxDescriptProd.Location = new System.Drawing.Point(96, 134);
            this.tboxDescriptProd.Name = "tboxDescriptProd";
            this.tboxDescriptProd.Size = new System.Drawing.Size(100, 20);
            this.tboxDescriptProd.TabIndex = 19;
            // 
            // nudStockProd
            // 
            this.nudStockProd.Location = new System.Drawing.Point(96, 99);
            this.nudStockProd.Name = "nudStockProd";
            this.nudStockProd.Size = new System.Drawing.Size(69, 20);
            this.nudStockProd.TabIndex = 18;
            this.nudStockProd.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lblStockProd
            // 
            this.lblStockProd.AutoSize = true;
            this.lblStockProd.Location = new System.Drawing.Point(38, 101);
            this.lblStockProd.Name = "lblStockProd";
            this.lblStockProd.Size = new System.Drawing.Size(52, 13);
            this.lblStockProd.TabIndex = 17;
            this.lblStockProd.Text = "Unidades";
            // 
            // lblPrecioProd
            // 
            this.lblPrecioProd.AutoSize = true;
            this.lblPrecioProd.Location = new System.Drawing.Point(53, 66);
            this.lblPrecioProd.Name = "lblPrecioProd";
            this.lblPrecioProd.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioProd.TabIndex = 16;
            this.lblPrecioProd.Text = "Precio";
            // 
            // tboxPrecioProd
            // 
            this.tboxPrecioProd.Location = new System.Drawing.Point(96, 63);
            this.tboxPrecioProd.Name = "tboxPrecioProd";
            this.tboxPrecioProd.Size = new System.Drawing.Size(69, 20);
            this.tboxPrecioProd.TabIndex = 15;
            this.tboxPrecioProd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxPrecioProd_KeyPress);
            // 
            // lblNombreProd
            // 
            this.lblNombreProd.AutoSize = true;
            this.lblNombreProd.Location = new System.Drawing.Point(19, 31);
            this.lblNombreProd.Name = "lblNombreProd";
            this.lblNombreProd.Size = new System.Drawing.Size(71, 13);
            this.lblNombreProd.TabIndex = 14;
            this.lblNombreProd.Text = "Nombre prod.";
            // 
            // tboxNombreProd
            // 
            this.tboxNombreProd.Location = new System.Drawing.Point(96, 28);
            this.tboxNombreProd.Name = "tboxNombreProd";
            this.tboxNombreProd.Size = new System.Drawing.Size(100, 20);
            this.tboxNombreProd.TabIndex = 13;
            // 
            // btnCancelarRegistro
            // 
            this.btnCancelarRegistro.Location = new System.Drawing.Point(268, 236);
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(75, 31);
            this.btnCancelarRegistro.TabIndex = 14;
            this.btnCancelarRegistro.Text = "Cancelar";
            this.btnCancelarRegistro.UseVisualStyleBackColor = true;
            this.btnCancelarRegistro.Click += new System.EventHandler(this.btnCancelarRegistro_Click);
            // 
            // btnRegistrarProd
            // 
            this.btnRegistrarProd.Location = new System.Drawing.Point(268, 132);
            this.btnRegistrarProd.Name = "btnRegistrarProd";
            this.btnRegistrarProd.Size = new System.Drawing.Size(75, 39);
            this.btnRegistrarProd.TabIndex = 15;
            this.btnRegistrarProd.Text = "Registrar producto";
            this.btnRegistrarProd.UseVisualStyleBackColor = true;
            this.btnRegistrarProd.Click += new System.EventHandler(this.btnRegistrarProd_Click);
            // 
            // btnLimpiarCampos
            // 
            this.btnLimpiarCampos.Location = new System.Drawing.Point(268, 181);
            this.btnLimpiarCampos.Name = "btnLimpiarCampos";
            this.btnLimpiarCampos.Size = new System.Drawing.Size(75, 45);
            this.btnLimpiarCampos.TabIndex = 16;
            this.btnLimpiarCampos.Text = "Limpiar campos";
            this.btnLimpiarCampos.UseVisualStyleBackColor = true;
            this.btnLimpiarCampos.Click += new System.EventHandler(this.btnLimpiarCampos_Click);
            // 
            // FormAltaProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(364, 288);
            this.Controls.Add(this.btnLimpiarCampos);
            this.Controls.Add(this.btnRegistrarProd);
            this.Controls.Add(this.btnCancelarRegistro);
            this.Controls.Add(this.gboxAltaProd);
            this.Controls.Add(this.lblTextoAltaProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormAltaProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar Producto";
            this.gboxAltaProd.ResumeLayout(false);
            this.gboxAltaProd.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoAltaProd;
        private System.Windows.Forms.GroupBox gboxAltaProd;
        private System.Windows.Forms.ComboBox cboxCategProd;
        private System.Windows.Forms.Label lblCategProd;
        private System.Windows.Forms.Label lblDescriptProd;
        private System.Windows.Forms.TextBox tboxDescriptProd;
        private System.Windows.Forms.NumericUpDown nudStockProd;
        private System.Windows.Forms.Label lblStockProd;
        private System.Windows.Forms.Label lblPrecioProd;
        private System.Windows.Forms.TextBox tboxPrecioProd;
        private System.Windows.Forms.Label lblNombreProd;
        private System.Windows.Forms.TextBox tboxNombreProd;
        private System.Windows.Forms.Button btnCancelarRegistro;
        private System.Windows.Forms.Button btnRegistrarProd;
        private System.Windows.Forms.Button btnLimpiarCampos;
    }
}