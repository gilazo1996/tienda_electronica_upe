namespace TC_Electrodomesticos
{
    partial class FormControlStock
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
            this.lblTituloControlStock = new System.Windows.Forms.Label();
            this.dgvDatosStock = new System.Windows.Forms.DataGridView();
            this.btnAtras = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosStock)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTituloControlStock
            // 
            this.lblTituloControlStock.AutoSize = true;
            this.lblTituloControlStock.Location = new System.Drawing.Point(25, 19);
            this.lblTituloControlStock.Name = "lblTituloControlStock";
            this.lblTituloControlStock.Size = new System.Drawing.Size(149, 13);
            this.lblTituloControlStock.TabIndex = 0;
            this.lblTituloControlStock.Text = "Control de Stock por producto";
            // 
            // dgvDatosStock
            // 
            this.dgvDatosStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosStock.Location = new System.Drawing.Point(28, 51);
            this.dgvDatosStock.Name = "dgvDatosStock";
            this.dgvDatosStock.Size = new System.Drawing.Size(215, 298);
            this.dgvDatosStock.TabIndex = 0;
            this.dgvDatosStock.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDatosStock_CellContentClick);
            this.dgvDatosStock.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvDatosStock_CellFormatting);
            // 
            // btnAtras
            // 
            this.btnAtras.Location = new System.Drawing.Point(511, 359);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 38);
            this.btnAtras.TabIndex = 2;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = true;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // FormControlStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 418);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dgvDatosStock);
            this.Controls.Add(this.lblTituloControlStock);
            this.Name = "FormControlStock";
            this.Text = "FormGestorStock - Control de Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosStock)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloControlStock;
        private System.Windows.Forms.DataGridView dgvDatosStock;
        private System.Windows.Forms.Button btnAtras;
    }
}