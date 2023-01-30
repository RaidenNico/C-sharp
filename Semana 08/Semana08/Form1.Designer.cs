namespace Semana08
{
    partial class frmRepetitivas
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lista = new System.Windows.Forms.ListBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.lista2 = new System.Windows.Forms.ListBox();
            this.lista3 = new System.Windows.Forms.ListBox();
            this.lista4 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lista
            // 
            this.lista.FormattingEnabled = true;
            this.lista.Location = new System.Drawing.Point(49, 27);
            this.lista.Name = "lista";
            this.lista.Size = new System.Drawing.Size(160, 186);
            this.lista.TabIndex = 0;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(199, 263);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(160, 33);
            this.btnSalir.TabIndex = 1;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.Location = new System.Drawing.Point(129, 220);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(80, 20);
            this.txtTotal.TabIndex = 3;
            // 
            // lista2
            // 
            this.lista2.FormattingEnabled = true;
            this.lista2.Location = new System.Drawing.Point(225, 27);
            this.lista2.Name = "lista2";
            this.lista2.Size = new System.Drawing.Size(120, 186);
            this.lista2.TabIndex = 4;
            // 
            // lista3
            // 
            this.lista3.FormattingEnabled = true;
            this.lista3.Location = new System.Drawing.Point(360, 27);
            this.lista3.Name = "lista3";
            this.lista3.Size = new System.Drawing.Size(120, 186);
            this.lista3.TabIndex = 5;
            // 
            // lista4
            // 
            this.lista4.FormattingEnabled = true;
            this.lista4.Location = new System.Drawing.Point(503, 27);
            this.lista4.Name = "lista4";
            this.lista4.Size = new System.Drawing.Size(120, 186);
            this.lista4.TabIndex = 6;
            // 
            // frmRepetitivas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(672, 320);
            this.Controls.Add(this.lista4);
            this.Controls.Add(this.lista3);
            this.Controls.Add(this.lista2);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.lista);
            this.Name = "frmRepetitivas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estructuras Repetitivas";
            this.Load += new System.EventHandler(this.frmRepetitivas_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lista;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.ListBox lista2;
        private System.Windows.Forms.ListBox lista3;
        private System.Windows.Forms.ListBox lista4;
    }
}

