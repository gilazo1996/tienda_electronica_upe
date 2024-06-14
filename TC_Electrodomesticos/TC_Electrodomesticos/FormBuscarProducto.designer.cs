namespace TC_Electrodomesticos
{
    partial class FormBuscarProducto
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
            this.lblTextoBuscarProd = new System.Windows.Forms.Label();
            this.tboxPorID = new System.Windows.Forms.TextBox();
            this.btnBuscarProd = new System.Windows.Forms.Button();
            this.rbPorId = new System.Windows.Forms.RadioButton();
            this.rbPorNombre = new System.Windows.Forms.RadioButton();
            this.rbPorCatego = new System.Windows.Forms.RadioButton();
            this.dgvResultadoBusqueda = new System.Windows.Forms.DataGridView();
            this.gboxArticuloSelect = new System.Windows.Forms.GroupBox();
            this.tboxIdArticu = new System.Windows.Forms.TextBox();
            this.cboxCategoArticu = new System.Windows.Forms.ComboBox();
            this.btnGuardarCambios = new System.Windows.Forms.Button();
            this.nudStockArticu = new System.Windows.Forms.NumericUpDown();
            this.tboxDescriptArticu = new System.Windows.Forms.TextBox();
            this.tboxPrecioArticu = new System.Windows.Forms.TextBox();
            this.tboxNombreArticu = new System.Windows.Forms.TextBox();
            this.lblStockArticu = new System.Windows.Forms.Label();
            this.lblCategoArtic = new System.Windows.Forms.Label();
            this.lblDescriptArticu = new System.Windows.Forms.Label();
            this.lblPrecioArticu = new System.Windows.Forms.Label();
            this.lblNombreArticu = new System.Windows.Forms.Label();
            this.tboxPorNombre = new System.Windows.Forms.TextBox();
            this.btnAtras = new System.Windows.Forms.Button();
            this.cboxPorCatego = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusqueda)).BeginInit();
            this.gboxArticuloSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockArticu)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTextoBuscarProd
            // 
            this.lblTextoBuscarProd.AutoSize = true;
            this.lblTextoBuscarProd.Location = new System.Drawing.Point(22, 18);
            this.lblTextoBuscarProd.Name = "lblTextoBuscarProd";
            this.lblTextoBuscarProd.Size = new System.Drawing.Size(218, 13);
            this.lblTextoBuscarProd.TabIndex = 1;
            this.lblTextoBuscarProd.Text = "BUSCAR PRODUCTO EN EL INVENTARIO";
            // 
            // tboxPorID
            // 
            this.tboxPorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPorID.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tboxPorID.Location = new System.Drawing.Point(25, 46);
            this.tboxPorID.Name = "tboxPorID";
            this.tboxPorID.Size = new System.Drawing.Size(149, 22);
            this.tboxPorID.TabIndex = 2;
            this.tboxPorID.Text = "Buscar por Id.";
            this.tboxPorID.Enter += new System.EventHandler(this.tboxPorID_Enter);
            this.tboxPorID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxPorID_KeyPress);
            // 
            // btnBuscarProd
            // 
            this.btnBuscarProd.BackColor = System.Drawing.Color.Silver;
            this.btnBuscarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProd.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProd.Location = new System.Drawing.Point(180, 46);
            this.btnBuscarProd.Name = "btnBuscarProd";
            this.btnBuscarProd.Size = new System.Drawing.Size(69, 24);
            this.btnBuscarProd.TabIndex = 3;
            this.btnBuscarProd.Text = "Buscar";
            this.btnBuscarProd.UseVisualStyleBackColor = false;
            this.btnBuscarProd.Click += new System.EventHandler(this.btnBuscarProd_Click);
            // 
            // rbPorId
            // 
            this.rbPorId.AutoSize = true;
            this.rbPorId.Location = new System.Drawing.Point(25, 89);
            this.rbPorId.Name = "rbPorId";
            this.rbPorId.Size = new System.Drawing.Size(54, 17);
            this.rbPorId.TabIndex = 4;
            this.rbPorId.TabStop = true;
            this.rbPorId.Text = "por ID";
            this.rbPorId.UseVisualStyleBackColor = true;
            this.rbPorId.CheckedChanged += new System.EventHandler(this.rbPorId_CheckedChanged);
            // 
            // rbPorNombre
            // 
            this.rbPorNombre.AutoSize = true;
            this.rbPorNombre.Location = new System.Drawing.Point(25, 123);
            this.rbPorNombre.Name = "rbPorNombre";
            this.rbPorNombre.Size = new System.Drawing.Size(80, 17);
            this.rbPorNombre.TabIndex = 5;
            this.rbPorNombre.TabStop = true;
            this.rbPorNombre.Text = "por Nombre";
            this.rbPorNombre.UseVisualStyleBackColor = true;
            this.rbPorNombre.CheckedChanged += new System.EventHandler(this.rbPorNombre_CheckedChanged);
            // 
            // rbPorCatego
            // 
            this.rbPorCatego.AutoSize = true;
            this.rbPorCatego.Location = new System.Drawing.Point(25, 157);
            this.rbPorCatego.Name = "rbPorCatego";
            this.rbPorCatego.Size = new System.Drawing.Size(88, 17);
            this.rbPorCatego.TabIndex = 6;
            this.rbPorCatego.TabStop = true;
            this.rbPorCatego.Text = "por Categoria";
            this.rbPorCatego.UseVisualStyleBackColor = true;
            this.rbPorCatego.CheckedChanged += new System.EventHandler(this.rbPorCatego_CheckedChanged);
            // 
            // dgvResultadoBusqueda
            // 
            this.dgvResultadoBusqueda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResultadoBusqueda.Location = new System.Drawing.Point(25, 221);
            this.dgvResultadoBusqueda.Name = "dgvResultadoBusqueda";
            this.dgvResultadoBusqueda.Size = new System.Drawing.Size(560, 139);
            this.dgvResultadoBusqueda.TabIndex = 7;
            this.dgvResultadoBusqueda.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvResultadoBusqueda_CellContentClick);
            // 
            // gboxArticuloSelect
            // 
            this.gboxArticuloSelect.Controls.Add(this.tboxIdArticu);
            this.gboxArticuloSelect.Controls.Add(this.cboxCategoArticu);
            this.gboxArticuloSelect.Controls.Add(this.btnGuardarCambios);
            this.gboxArticuloSelect.Controls.Add(this.nudStockArticu);
            this.gboxArticuloSelect.Controls.Add(this.tboxDescriptArticu);
            this.gboxArticuloSelect.Controls.Add(this.tboxPrecioArticu);
            this.gboxArticuloSelect.Controls.Add(this.tboxNombreArticu);
            this.gboxArticuloSelect.Controls.Add(this.lblStockArticu);
            this.gboxArticuloSelect.Controls.Add(this.lblCategoArtic);
            this.gboxArticuloSelect.Controls.Add(this.lblDescriptArticu);
            this.gboxArticuloSelect.Controls.Add(this.lblPrecioArticu);
            this.gboxArticuloSelect.Controls.Add(this.lblNombreArticu);
            this.gboxArticuloSelect.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.gboxArticuloSelect.Location = new System.Drawing.Point(257, 18);
            this.gboxArticuloSelect.Name = "gboxArticuloSelect";
            this.gboxArticuloSelect.Size = new System.Drawing.Size(328, 180);
            this.gboxArticuloSelect.TabIndex = 8;
            this.gboxArticuloSelect.TabStop = false;
            this.gboxArticuloSelect.Text = "  Articulo seleccionado  ";
            // 
            // tboxIdArticu
            // 
            this.tboxIdArticu.Location = new System.Drawing.Point(168, 139);
            this.tboxIdArticu.Name = "tboxIdArticu";
            this.tboxIdArticu.Size = new System.Drawing.Size(29, 20);
            this.tboxIdArticu.TabIndex = 21;
            // 
            // cboxCategoArticu
            // 
            this.cboxCategoArticu.FormattingEnabled = true;
            this.cboxCategoArticu.Location = new System.Drawing.Point(168, 90);
            this.cboxCategoArticu.Name = "cboxCategoArticu";
            this.cboxCategoArticu.Size = new System.Drawing.Size(141, 21);
            this.cboxCategoArticu.TabIndex = 20;
            // 
            // btnGuardarCambios
            // 
            this.btnGuardarCambios.BackColor = System.Drawing.Color.Silver;
            this.btnGuardarCambios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btnGuardarCambios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCambios.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardarCambios.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btnGuardarCambios.Location = new System.Drawing.Point(212, 128);
            this.btnGuardarCambios.Name = "btnGuardarCambios";
            this.btnGuardarCambios.Size = new System.Drawing.Size(97, 31);
            this.btnGuardarCambios.TabIndex = 20;
            this.btnGuardarCambios.Text = "Guardar cambios";
            this.btnGuardarCambios.UseVisualStyleBackColor = false;
            this.btnGuardarCambios.Click += new System.EventHandler(this.btnGuardarCambios_Click);
            // 
            // nudStockArticu
            // 
            this.nudStockArticu.Location = new System.Drawing.Point(22, 139);
            this.nudStockArticu.Name = "nudStockArticu";
            this.nudStockArticu.Size = new System.Drawing.Size(119, 20);
            this.nudStockArticu.TabIndex = 9;
            // 
            // tboxDescriptArticu
            // 
            this.tboxDescriptArticu.Location = new System.Drawing.Point(168, 43);
            this.tboxDescriptArticu.Name = "tboxDescriptArticu";
            this.tboxDescriptArticu.Size = new System.Drawing.Size(141, 20);
            this.tboxDescriptArticu.TabIndex = 7;
            // 
            // tboxPrecioArticu
            // 
            this.tboxPrecioArticu.Location = new System.Drawing.Point(22, 91);
            this.tboxPrecioArticu.Name = "tboxPrecioArticu";
            this.tboxPrecioArticu.Size = new System.Drawing.Size(119, 20);
            this.tboxPrecioArticu.TabIndex = 6;
            this.tboxPrecioArticu.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tboxPrecioArticu_KeyPress);
            // 
            // tboxNombreArticu
            // 
            this.tboxNombreArticu.Location = new System.Drawing.Point(22, 43);
            this.tboxNombreArticu.Name = "tboxNombreArticu";
            this.tboxNombreArticu.Size = new System.Drawing.Size(119, 20);
            this.tboxNombreArticu.TabIndex = 5;
            // 
            // lblStockArticu
            // 
            this.lblStockArticu.AutoSize = true;
            this.lblStockArticu.Location = new System.Drawing.Point(19, 123);
            this.lblStockArticu.Name = "lblStockArticu";
            this.lblStockArticu.Size = new System.Drawing.Size(52, 13);
            this.lblStockArticu.TabIndex = 4;
            this.lblStockArticu.Text = "Unidades";
            // 
            // lblCategoArtic
            // 
            this.lblCategoArtic.AutoSize = true;
            this.lblCategoArtic.Location = new System.Drawing.Point(165, 75);
            this.lblCategoArtic.Name = "lblCategoArtic";
            this.lblCategoArtic.Size = new System.Drawing.Size(52, 13);
            this.lblCategoArtic.TabIndex = 3;
            this.lblCategoArtic.Text = "Categoria";
            // 
            // lblDescriptArticu
            // 
            this.lblDescriptArticu.AutoSize = true;
            this.lblDescriptArticu.Location = new System.Drawing.Point(165, 27);
            this.lblDescriptArticu.Name = "lblDescriptArticu";
            this.lblDescriptArticu.Size = new System.Drawing.Size(63, 13);
            this.lblDescriptArticu.TabIndex = 2;
            this.lblDescriptArticu.Text = "Descripcion";
            // 
            // lblPrecioArticu
            // 
            this.lblPrecioArticu.AutoSize = true;
            this.lblPrecioArticu.Location = new System.Drawing.Point(19, 75);
            this.lblPrecioArticu.Name = "lblPrecioArticu";
            this.lblPrecioArticu.Size = new System.Drawing.Size(37, 13);
            this.lblPrecioArticu.TabIndex = 1;
            this.lblPrecioArticu.Text = "Precio";
            // 
            // lblNombreArticu
            // 
            this.lblNombreArticu.AutoSize = true;
            this.lblNombreArticu.Location = new System.Drawing.Point(19, 27);
            this.lblNombreArticu.Name = "lblNombreArticu";
            this.lblNombreArticu.Size = new System.Drawing.Size(44, 13);
            this.lblNombreArticu.TabIndex = 0;
            this.lblNombreArticu.Text = "Nombre";
            // 
            // tboxPorNombre
            // 
            this.tboxPorNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tboxPorNombre.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.tboxPorNombre.Location = new System.Drawing.Point(25, 46);
            this.tboxPorNombre.Name = "tboxPorNombre";
            this.tboxPorNombre.Size = new System.Drawing.Size(149, 22);
            this.tboxPorNombre.TabIndex = 16;
            this.tboxPorNombre.Text = "Buscar por Nombre.";
            this.tboxPorNombre.Enter += new System.EventHandler(this.tboxPorNombre_Enter);
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Silver;
            this.btnAtras.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(510, 375);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 31);
            this.btnAtras.TabIndex = 18;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click_1);
            // 
            // cboxPorCatego
            // 
            this.cboxPorCatego.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboxPorCatego.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.cboxPorCatego.FormattingEnabled = true;
            this.cboxPorCatego.Location = new System.Drawing.Point(25, 46);
            this.cboxPorCatego.Name = "cboxPorCatego";
            this.cboxPorCatego.Size = new System.Drawing.Size(149, 23);
            this.cboxPorCatego.TabIndex = 19;
            this.cboxPorCatego.Text = "Por Categoria.";
            this.cboxPorCatego.Enter += new System.EventHandler(this.cboxPorCatego_Enter);
            // 
            // FormBuscarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 418);
            this.Controls.Add(this.cboxPorCatego);
            this.Controls.Add(this.btnBuscarProd);
            this.Controls.Add(this.tboxPorNombre);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.gboxArticuloSelect);
            this.Controls.Add(this.dgvResultadoBusqueda);
            this.Controls.Add(this.rbPorCatego);
            this.Controls.Add(this.rbPorNombre);
            this.Controls.Add(this.rbPorId);
            this.Controls.Add(this.tboxPorID);
            this.Controls.Add(this.lblTextoBuscarProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormBuscarProducto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Busqueda de Productos";
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultadoBusqueda)).EndInit();
            this.gboxArticuloSelect.ResumeLayout(false);
            this.gboxArticuloSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudStockArticu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTextoBuscarProd;
        private System.Windows.Forms.TextBox tboxPorID;
        private System.Windows.Forms.Button btnBuscarProd;
        private System.Windows.Forms.RadioButton rbPorId;
        private System.Windows.Forms.RadioButton rbPorNombre;
        private System.Windows.Forms.RadioButton rbPorCatego;
        private System.Windows.Forms.DataGridView dgvResultadoBusqueda;
        private System.Windows.Forms.GroupBox gboxArticuloSelect;
        private System.Windows.Forms.TextBox tboxPorNombre;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.ComboBox cboxPorCatego;
        private System.Windows.Forms.NumericUpDown nudStockArticu;
        private System.Windows.Forms.TextBox tboxDescriptArticu;
        private System.Windows.Forms.TextBox tboxPrecioArticu;
        private System.Windows.Forms.TextBox tboxNombreArticu;
        private System.Windows.Forms.Label lblStockArticu;
        private System.Windows.Forms.Label lblCategoArtic;
        private System.Windows.Forms.Label lblDescriptArticu;
        private System.Windows.Forms.Label lblPrecioArticu;
        private System.Windows.Forms.Label lblNombreArticu;
        private System.Windows.Forms.Button btnGuardarCambios;
        private System.Windows.Forms.ComboBox cboxCategoArticu;
        private System.Windows.Forms.TextBox tboxIdArticu;
    }
}