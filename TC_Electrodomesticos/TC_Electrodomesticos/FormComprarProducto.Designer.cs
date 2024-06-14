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
            this.label1 = new System.Windows.Forms.Label();
            this.lboxMostrarProductos = new System.Windows.Forms.ListBox();
            this.comboBoxCantidadPro = new System.Windows.Forms.ComboBox();
            this.btnAñadirAlCarrito = new System.Windows.Forms.Button();
            this.btnEliminarProducto = new System.Windows.Forms.Button();
            this.listBoxCarrito = new System.Windows.Forms.ListBox();
            this.labelSeleccionarCantidad = new System.Windows.Forms.Label();
            this.labelTotalCompra = new System.Windows.Forms.Label();
            this.textBoxTotalCompra = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tboxNombreCompleto
            // 
            this.tboxNombreCompleto.Location = new System.Drawing.Point(467, 307);
            this.tboxNombreCompleto.Name = "tboxNombreCompleto";
            this.tboxNombreCompleto.Size = new System.Drawing.Size(215, 20);
            this.tboxNombreCompleto.TabIndex = 0;
            this.tboxNombreCompleto.TextChanged += new System.EventHandler(this.tboxNombreCompleto_TextChanged);
            // 
            // tboxCuil
            // 
            this.tboxCuil.Location = new System.Drawing.Point(467, 369);
            this.tboxCuil.Name = "tboxCuil";
            this.tboxCuil.Size = new System.Drawing.Size(215, 20);
            this.tboxCuil.TabIndex = 1;
            // 
            // textNombreCOmpleto
            // 
            this.textNombreCOmpleto.AutoSize = true;
            this.textNombreCOmpleto.Location = new System.Drawing.Point(464, 283);
            this.textNombreCOmpleto.Name = "textNombreCOmpleto";
            this.textNombreCOmpleto.Size = new System.Drawing.Size(91, 13);
            this.textNombreCOmpleto.TabIndex = 2;
            this.textNombreCOmpleto.Text = "Nombre Completo";
            // 
            // textCUIL
            // 
            this.textCUIL.AutoSize = true;
            this.textCUIL.Location = new System.Drawing.Point(464, 340);
            this.textCUIL.Name = "textCUIL";
            this.textCUIL.Size = new System.Drawing.Size(31, 13);
            this.textCUIL.TabIndex = 3;
            this.textCUIL.Text = "CUIL";
            // 
            // btnComprarPro
            // 
            this.btnComprarPro.Location = new System.Drawing.Point(467, 404);
            this.btnComprarPro.Name = "btnComprarPro";
            this.btnComprarPro.Size = new System.Drawing.Size(75, 23);
            this.btnComprarPro.TabIndex = 4;
            this.btnComprarPro.Text = "Comprar";
            this.btnComprarPro.UseVisualStyleBackColor = true;
            this.btnComprarPro.Click += new System.EventHandler(this.btnComprarPro_Click);
            // 
            // btnCancelarPro
            // 
            this.btnCancelarPro.Location = new System.Drawing.Point(607, 404);
            this.btnCancelarPro.Name = "btnCancelarPro";
            this.btnCancelarPro.Size = new System.Drawing.Size(75, 23);
            this.btnCancelarPro.TabIndex = 5;
            this.btnCancelarPro.Text = "Cancelar";
            this.btnCancelarPro.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(422, 25);
            this.label1.TabIndex = 8;
            this.label1.Text = "Seleccione el producto que desea comprar";
            // 
            // lboxMostrarProductos
            // 
            this.lboxMostrarProductos.FormattingEnabled = true;
            this.lboxMostrarProductos.Location = new System.Drawing.Point(12, 55);
            this.lboxMostrarProductos.Name = "lboxMostrarProductos";
            this.lboxMostrarProductos.Size = new System.Drawing.Size(590, 173);
            this.lboxMostrarProductos.TabIndex = 10;
            this.lboxMostrarProductos.SelectedIndexChanged += new System.EventHandler(this.lboxMostrarProductos_SelectedIndexChanged);
            // 
            // comboBoxCantidadPro
            // 
            this.comboBoxCantidadPro.FormattingEnabled = true;
            this.comboBoxCantidadPro.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.comboBoxCantidadPro.Location = new System.Drawing.Point(12, 275);
            this.comboBoxCantidadPro.Name = "comboBoxCantidadPro";
            this.comboBoxCantidadPro.Size = new System.Drawing.Size(74, 21);
            this.comboBoxCantidadPro.TabIndex = 11;
            this.comboBoxCantidadPro.SelectedIndexChanged += new System.EventHandler(this.comboBoxCantidadPro_SelectedIndexChanged);
            // 
            // btnAñadirAlCarrito
            // 
            this.btnAñadirAlCarrito.BackColor = System.Drawing.SystemColors.Control;
            this.btnAñadirAlCarrito.Location = new System.Drawing.Point(118, 273);
            this.btnAñadirAlCarrito.Name = "btnAñadirAlCarrito";
            this.btnAñadirAlCarrito.Size = new System.Drawing.Size(95, 23);
            this.btnAñadirAlCarrito.TabIndex = 12;
            this.btnAñadirAlCarrito.Text = "Añadir al carrito";
            this.btnAñadirAlCarrito.UseVisualStyleBackColor = false;
            this.btnAñadirAlCarrito.Click += new System.EventHandler(this.btnAñadirAlCarrito_Click);
            // 
            // btnEliminarProducto
            // 
            this.btnEliminarProducto.BackColor = System.Drawing.SystemColors.Control;
            this.btnEliminarProducto.FlatAppearance.BorderColor = System.Drawing.Color.Blue;
            this.btnEliminarProducto.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnEliminarProducto.Location = new System.Drawing.Point(236, 273);
            this.btnEliminarProducto.Margin = new System.Windows.Forms.Padding(0);
            this.btnEliminarProducto.Name = "btnEliminarProducto";
            this.btnEliminarProducto.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarProducto.TabIndex = 13;
            this.btnEliminarProducto.Text = "Eliminar";
            this.btnEliminarProducto.UseVisualStyleBackColor = false;
            this.btnEliminarProducto.Click += new System.EventHandler(this.btnEliminarProducto_Click);
            // 
            // listBoxCarrito
            // 
            this.listBoxCarrito.FormattingEnabled = true;
            this.listBoxCarrito.Location = new System.Drawing.Point(12, 323);
            this.listBoxCarrito.Name = "listBoxCarrito";
            this.listBoxCarrito.Size = new System.Drawing.Size(282, 95);
            this.listBoxCarrito.TabIndex = 14;
            // 
            // labelSeleccionarCantidad
            // 
            this.labelSeleccionarCantidad.AutoSize = true;
            this.labelSeleccionarCantidad.Location = new System.Drawing.Point(9, 247);
            this.labelSeleccionarCantidad.Name = "labelSeleccionarCantidad";
            this.labelSeleccionarCantidad.Size = new System.Drawing.Size(115, 13);
            this.labelSeleccionarCantidad.TabIndex = 15;
            this.labelSeleccionarCantidad.Text = "Seleccione la cantidad";
            // 
            // labelTotalCompra
            // 
            this.labelTotalCompra.AutoSize = true;
            this.labelTotalCompra.Location = new System.Drawing.Point(62, 429);
            this.labelTotalCompra.Name = "labelTotalCompra";
            this.labelTotalCompra.Size = new System.Drawing.Size(78, 13);
            this.labelTotalCompra.TabIndex = 16;
            this.labelTotalCompra.Text = "Total compra $";
            // 
            // textBoxTotalCompra
            // 
            this.textBoxTotalCompra.Location = new System.Drawing.Point(146, 422);
            this.textBoxTotalCompra.Name = "textBoxTotalCompra";
            this.textBoxTotalCompra.ReadOnly = true;
            this.textBoxTotalCompra.Size = new System.Drawing.Size(148, 20);
            this.textBoxTotalCompra.TabIndex = 17;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(420, 247);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 25);
            this.label2.TabIndex = 18;
            this.label2.Text = "Complete los campos para finalizar la compra";
            // 
            // FormComprarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(917, 501);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxTotalCompra);
            this.Controls.Add(this.labelTotalCompra);
            this.Controls.Add(this.labelSeleccionarCantidad);
            this.Controls.Add(this.listBoxCarrito);
            this.Controls.Add(this.btnEliminarProducto);
            this.Controls.Add(this.btnAñadirAlCarrito);
            this.Controls.Add(this.comboBoxCantidadPro);
            this.Controls.Add(this.lboxMostrarProductos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnCancelarPro);
            this.Controls.Add(this.btnComprarPro);
            this.Controls.Add(this.textCUIL);
            this.Controls.Add(this.textNombreCOmpleto);
            this.Controls.Add(this.tboxCuil);
            this.Controls.Add(this.tboxNombreCompleto);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "FormComprarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lboxMostrarProductos;
        private System.Windows.Forms.ComboBox comboBoxCantidadPro;
        private System.Windows.Forms.Button btnAñadirAlCarrito;
        private System.Windows.Forms.Button btnEliminarProducto;
        private System.Windows.Forms.ListBox listBoxCarrito;
        private System.Windows.Forms.Label labelSeleccionarCantidad;
        private System.Windows.Forms.Label labelTotalCompra;
        private System.Windows.Forms.TextBox textBoxTotalCompra;
        private System.Windows.Forms.Label label2;
    }
}