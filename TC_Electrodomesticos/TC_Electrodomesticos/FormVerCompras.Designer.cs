namespace TC_Electrodomesticos
{
    partial class FormVerCompras
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
            this.listBoxMisCompras = new System.Windows.Forms.ListBox();
            this.btnSalirCompras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(289, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estas son tus compras";
            // 
            // listBoxMisCompras
            // 
            this.listBoxMisCompras.FormattingEnabled = true;
            this.listBoxMisCompras.Location = new System.Drawing.Point(18, 96);
            this.listBoxMisCompras.Name = "listBoxMisCompras";
            this.listBoxMisCompras.Size = new System.Drawing.Size(623, 212);
            this.listBoxMisCompras.TabIndex = 1;
            this.listBoxMisCompras.SelectedIndexChanged += new System.EventHandler(this.listBoxMisCompras_SelectedIndexChanged);
            // 
            // btnSalirCompras
            // 
            this.btnSalirCompras.Location = new System.Drawing.Point(18, 354);
            this.btnSalirCompras.Name = "btnSalirCompras";
            this.btnSalirCompras.Size = new System.Drawing.Size(75, 23);
            this.btnSalirCompras.TabIndex = 2;
            this.btnSalirCompras.Text = "Salir";
            this.btnSalirCompras.UseVisualStyleBackColor = true;
            this.btnSalirCompras.Click += new System.EventHandler(this.btnSalirCompras_Click);
            // 
            // FormVerCompras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 450);
            this.Controls.Add(this.btnSalirCompras);
            this.Controls.Add(this.listBoxMisCompras);
            this.Controls.Add(this.label1);
            this.Name = "FormVerCompras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ver mis compras";
            this.Load += new System.EventHandler(this.FormVerCompras_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox listBoxMisCompras;
        private System.Windows.Forms.Button btnSalirCompras;
    }
}