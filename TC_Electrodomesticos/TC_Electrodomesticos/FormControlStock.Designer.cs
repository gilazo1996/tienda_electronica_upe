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
            this.gboxValoresStock = new System.Windows.Forms.GroupBox();
            this.lblDebajoStockMinimo = new System.Windows.Forms.Label();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.lblCercanoStockMinimo = new System.Windows.Forms.Label();
            this.lblValoresAceptables = new System.Windows.Forms.Label();
            this.lblValoresOptimos = new System.Windows.Forms.Label();
            this.lblSobrestock = new System.Windows.Forms.Label();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnOrange = new System.Windows.Forms.Button();
            this.btnYellow = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnWhite = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosStock)).BeginInit();
            this.gboxValoresStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTituloControlStock
            // 
            this.lblTituloControlStock.AutoSize = true;
            this.lblTituloControlStock.Location = new System.Drawing.Point(25, 19);
            this.lblTituloControlStock.Name = "lblTituloControlStock";
            this.lblTituloControlStock.Size = new System.Drawing.Size(206, 13);
            this.lblTituloControlStock.TabIndex = 0;
            this.lblTituloControlStock.Text = "CONTROL DE STOCK POR PRODUCTO";
            // 
            // dgvDatosStock
            // 
            this.dgvDatosStock.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dgvDatosStock.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDatosStock.Location = new System.Drawing.Point(28, 51);
            this.dgvDatosStock.Name = "dgvDatosStock";
            this.dgvDatosStock.Size = new System.Drawing.Size(215, 298);
            this.dgvDatosStock.TabIndex = 0;
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
            // gboxValoresStock
            // 
            this.gboxValoresStock.Controls.Add(this.lblDebajoStockMinimo);
            this.gboxValoresStock.Controls.Add(this.lblStockMinimo);
            this.gboxValoresStock.Controls.Add(this.lblCercanoStockMinimo);
            this.gboxValoresStock.Controls.Add(this.lblValoresAceptables);
            this.gboxValoresStock.Controls.Add(this.lblValoresOptimos);
            this.gboxValoresStock.Controls.Add(this.lblSobrestock);
            this.gboxValoresStock.Controls.Add(this.btnRed);
            this.gboxValoresStock.Controls.Add(this.btnOrange);
            this.gboxValoresStock.Controls.Add(this.btnYellow);
            this.gboxValoresStock.Controls.Add(this.btnGreen);
            this.gboxValoresStock.Controls.Add(this.btnBlue);
            this.gboxValoresStock.Controls.Add(this.btnWhite);
            this.gboxValoresStock.Location = new System.Drawing.Point(263, 51);
            this.gboxValoresStock.Name = "gboxValoresStock";
            this.gboxValoresStock.Size = new System.Drawing.Size(180, 222);
            this.gboxValoresStock.TabIndex = 4;
            this.gboxValoresStock.TabStop = false;
            this.gboxValoresStock.Text = "Referencia";
            // 
            // lblDebajoStockMinimo
            // 
            this.lblDebajoStockMinimo.AutoSize = true;
            this.lblDebajoStockMinimo.Location = new System.Drawing.Point(45, 188);
            this.lblDebajoStockMinimo.Name = "lblDebajoStockMinimo";
            this.lblDebajoStockMinimo.Size = new System.Drawing.Size(120, 13);
            this.lblDebajoStockMinimo.TabIndex = 5;
            this.lblDebajoStockMinimo.Text = "Debajo de stock minimo";
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Location = new System.Drawing.Point(45, 158);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(118, 13);
            this.lblStockMinimo.TabIndex = 5;
            this.lblStockMinimo.Text = "Llegado a stock minimo";
            // 
            // lblCercanoStockMinimo
            // 
            this.lblCercanoStockMinimo.AutoSize = true;
            this.lblCercanoStockMinimo.Location = new System.Drawing.Point(45, 128);
            this.lblCercanoStockMinimo.Name = "lblCercanoStockMinimo";
            this.lblCercanoStockMinimo.Size = new System.Drawing.Size(120, 13);
            this.lblCercanoStockMinimo.TabIndex = 5;
            this.lblCercanoStockMinimo.Text = "Cercano a stock minimo";
            // 
            // lblValoresAceptables
            // 
            this.lblValoresAceptables.AutoSize = true;
            this.lblValoresAceptables.Location = new System.Drawing.Point(45, 98);
            this.lblValoresAceptables.Name = "lblValoresAceptables";
            this.lblValoresAceptables.Size = new System.Drawing.Size(97, 13);
            this.lblValoresAceptables.TabIndex = 5;
            this.lblValoresAceptables.Text = "Valores aceptables";
            // 
            // lblValoresOptimos
            // 
            this.lblValoresOptimos.AutoSize = true;
            this.lblValoresOptimos.Location = new System.Drawing.Point(45, 68);
            this.lblValoresOptimos.Name = "lblValoresOptimos";
            this.lblValoresOptimos.Size = new System.Drawing.Size(81, 13);
            this.lblValoresOptimos.TabIndex = 5;
            this.lblValoresOptimos.Text = "Valores optimos";
            // 
            // lblSobrestock
            // 
            this.lblSobrestock.AutoSize = true;
            this.lblSobrestock.Location = new System.Drawing.Point(45, 38);
            this.lblSobrestock.Name = "lblSobrestock";
            this.lblSobrestock.Size = new System.Drawing.Size(61, 13);
            this.lblSobrestock.TabIndex = 5;
            this.lblSobrestock.Text = "Sobrestock";
            // 
            // btnRed
            // 
            this.btnRed.BackColor = System.Drawing.Color.LightCoral;
            this.btnRed.Location = new System.Drawing.Point(15, 182);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(24, 24);
            this.btnRed.TabIndex = 5;
            this.btnRed.UseVisualStyleBackColor = false;
            // 
            // btnOrange
            // 
            this.btnOrange.BackColor = System.Drawing.Color.Orange;
            this.btnOrange.Location = new System.Drawing.Point(15, 152);
            this.btnOrange.Name = "btnOrange";
            this.btnOrange.Size = new System.Drawing.Size(24, 24);
            this.btnOrange.TabIndex = 4;
            this.btnOrange.UseVisualStyleBackColor = false;
            // 
            // btnYellow
            // 
            this.btnYellow.BackColor = System.Drawing.Color.Yellow;
            this.btnYellow.Location = new System.Drawing.Point(15, 122);
            this.btnYellow.Name = "btnYellow";
            this.btnYellow.Size = new System.Drawing.Size(24, 24);
            this.btnYellow.TabIndex = 3;
            this.btnYellow.UseVisualStyleBackColor = false;
            // 
            // btnGreen
            // 
            this.btnGreen.BackColor = System.Drawing.Color.GreenYellow;
            this.btnGreen.Location = new System.Drawing.Point(15, 92);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(24, 24);
            this.btnGreen.TabIndex = 2;
            this.btnGreen.UseVisualStyleBackColor = false;
            // 
            // btnBlue
            // 
            this.btnBlue.BackColor = System.Drawing.Color.LightSkyBlue;
            this.btnBlue.Location = new System.Drawing.Point(15, 62);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(24, 24);
            this.btnBlue.TabIndex = 1;
            this.btnBlue.UseVisualStyleBackColor = false;
            // 
            // btnWhite
            // 
            this.btnWhite.BackColor = System.Drawing.Color.White;
            this.btnWhite.Location = new System.Drawing.Point(15, 32);
            this.btnWhite.Name = "btnWhite";
            this.btnWhite.Size = new System.Drawing.Size(24, 24);
            this.btnWhite.TabIndex = 0;
            this.btnWhite.UseVisualStyleBackColor = false;
            // 
            // FormControlStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(608, 418);
            this.Controls.Add(this.gboxValoresStock);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.dgvDatosStock);
            this.Controls.Add(this.lblTituloControlStock);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormControlStock";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control de Stock";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDatosStock)).EndInit();
            this.gboxValoresStock.ResumeLayout(false);
            this.gboxValoresStock.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloControlStock;
        private System.Windows.Forms.DataGridView dgvDatosStock;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.GroupBox gboxValoresStock;
        private System.Windows.Forms.Button btnWhite;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnOrange;
        private System.Windows.Forms.Button btnYellow;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Label lblValoresAceptables;
        private System.Windows.Forms.Label lblValoresOptimos;
        private System.Windows.Forms.Label lblSobrestock;
        private System.Windows.Forms.Label lblDebajoStockMinimo;
        private System.Windows.Forms.Label lblStockMinimo;
        private System.Windows.Forms.Label lblCercanoStockMinimo;
    }
}