
namespace TC_Electrodomesticos
{
    partial class FormVerInventario
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
            this.dgvListaProd = new System.Windows.Forms.DataGridView();
            this.lblTituloListaProd = new System.Windows.Forms.Label();
            this.btnAtras = new System.Windows.Forms.Button();
            this.btnEliminarProd = new System.Windows.Forms.Button();
            this.tboxIdProd = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProd)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvListaProd
            // 
            this.dgvListaProd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaProd.Location = new System.Drawing.Point(21, 51);
            this.dgvListaProd.Name = "dgvListaProd";
            this.dgvListaProd.Size = new System.Drawing.Size(566, 273);
            this.dgvListaProd.TabIndex = 0;
            // 
            // lblTituloListaProd
            // 
            this.lblTituloListaProd.AutoSize = true;
            this.lblTituloListaProd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloListaProd.Location = new System.Drawing.Point(18, 22);
            this.lblTituloListaProd.Name = "lblTituloListaProd";
            this.lblTituloListaProd.Size = new System.Drawing.Size(144, 13);
            this.lblTituloListaProd.TabIndex = 1;
            this.lblTituloListaProd.Text = "LISTA DE PRODUCTOS";
            // 
            // btnAtras
            // 
            this.btnAtras.BackColor = System.Drawing.Color.Silver;
            this.btnAtras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtras.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtras.Location = new System.Drawing.Point(512, 330);
            this.btnAtras.Name = "btnAtras";
            this.btnAtras.Size = new System.Drawing.Size(75, 38);
            this.btnAtras.TabIndex = 3;
            this.btnAtras.Text = "Atrás";
            this.btnAtras.UseVisualStyleBackColor = false;
            this.btnAtras.Click += new System.EventHandler(this.btnAtras_Click);
            // 
            // btnEliminarProd
            // 
            this.btnEliminarProd.BackColor = System.Drawing.Color.Silver;
            this.btnEliminarProd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminarProd.Font = new System.Drawing.Font("Constantia", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminarProd.Location = new System.Drawing.Point(412, 330);
            this.btnEliminarProd.Name = "btnEliminarProd";
            this.btnEliminarProd.Size = new System.Drawing.Size(94, 38);
            this.btnEliminarProd.TabIndex = 5;
            this.btnEliminarProd.Text = "Eliminar producto";
            this.btnEliminarProd.UseVisualStyleBackColor = false;
            this.btnEliminarProd.Click += new System.EventHandler(this.btnEliminarProd_Click);
            // 
            // tboxIdProd
            // 
            this.tboxIdProd.Location = new System.Drawing.Point(544, 19);
            this.tboxIdProd.Name = "tboxIdProd";
            this.tboxIdProd.Size = new System.Drawing.Size(43, 20);
            this.tboxIdProd.TabIndex = 6;
            // 
            // FormVerInventario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(608, 418);
            this.Controls.Add(this.tboxIdProd);
            this.Controls.Add(this.btnEliminarProd);
            this.Controls.Add(this.btnAtras);
            this.Controls.Add(this.lblTituloListaProd);
            this.Controls.Add(this.dgvListaProd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormVerInventario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaProd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvListaProd;
        private System.Windows.Forms.Label lblTituloListaProd;
        private System.Windows.Forms.Button btnAtras;
        private System.Windows.Forms.Button btnEliminarProd;
        private System.Windows.Forms.TextBox tboxIdProd;
    }
}