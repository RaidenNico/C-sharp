namespace Evaluación_Final
{
    partial class frmVendedor
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
            this.cmbAccion = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDatosVendedor = new System.Windows.Forms.TextBox();
            this.txtDNIVendedor = new System.Windows.Forms.TextBox();
            this.txtDireccionVendedor = new System.Windows.Forms.TextBox();
            this.cmbSexo = new System.Windows.Forms.ComboBox();
            this.lblErrorCodigoVendedor = new System.Windows.Forms.Label();
            this.lblErrorDatosVendedor = new System.Windows.Forms.Label();
            this.lblErrorDireccionVendedor = new System.Windows.Forms.Label();
            this.lblErrrorDNIVendedor = new System.Windows.Forms.Label();
            this.dgvVendedor = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbAccion
            // 
            this.cmbAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccion.FormattingEnabled = true;
            this.cmbAccion.Location = new System.Drawing.Point(659, 55);
            this.cmbAccion.Name = "cmbAccion";
            this.cmbAccion.Size = new System.Drawing.Size(121, 21);
            this.cmbAccion.TabIndex = 7;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(800, 93);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 33);
            this.btnSalir.TabIndex = 5;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(800, 49);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(87, 33);
            this.btnProcesar.TabIndex = 6;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(90, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Código Vendedor";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Datos del Vendedor";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Dirección del Vendedor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(89, 187);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "DNi del Vendedor";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(119, 239);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sexo";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(236, 30);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 9;
            // 
            // txtDatosVendedor
            // 
            this.txtDatosVendedor.Location = new System.Drawing.Point(236, 78);
            this.txtDatosVendedor.Name = "txtDatosVendedor";
            this.txtDatosVendedor.Size = new System.Drawing.Size(330, 20);
            this.txtDatosVendedor.TabIndex = 9;
            // 
            // txtDNIVendedor
            // 
            this.txtDNIVendedor.Location = new System.Drawing.Point(236, 184);
            this.txtDNIVendedor.Name = "txtDNIVendedor";
            this.txtDNIVendedor.Size = new System.Drawing.Size(100, 20);
            this.txtDNIVendedor.TabIndex = 9;
            // 
            // txtDireccionVendedor
            // 
            this.txtDireccionVendedor.Location = new System.Drawing.Point(236, 130);
            this.txtDireccionVendedor.Name = "txtDireccionVendedor";
            this.txtDireccionVendedor.Size = new System.Drawing.Size(375, 20);
            this.txtDireccionVendedor.TabIndex = 9;
            // 
            // cmbSexo
            // 
            this.cmbSexo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSexo.FormattingEnabled = true;
            this.cmbSexo.Location = new System.Drawing.Point(236, 235);
            this.cmbSexo.Name = "cmbSexo";
            this.cmbSexo.Size = new System.Drawing.Size(121, 21);
            this.cmbSexo.TabIndex = 10;
            // 
            // lblErrorCodigoVendedor
            // 
            this.lblErrorCodigoVendedor.AutoSize = true;
            this.lblErrorCodigoVendedor.Location = new System.Drawing.Point(233, 58);
            this.lblErrorCodigoVendedor.Name = "lblErrorCodigoVendedor";
            this.lblErrorCodigoVendedor.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoVendedor.TabIndex = 8;
            // 
            // lblErrorDatosVendedor
            // 
            this.lblErrorDatosVendedor.AutoSize = true;
            this.lblErrorDatosVendedor.Location = new System.Drawing.Point(233, 106);
            this.lblErrorDatosVendedor.Name = "lblErrorDatosVendedor";
            this.lblErrorDatosVendedor.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDatosVendedor.TabIndex = 8;
            // 
            // lblErrorDireccionVendedor
            // 
            this.lblErrorDireccionVendedor.AutoSize = true;
            this.lblErrorDireccionVendedor.Location = new System.Drawing.Point(233, 162);
            this.lblErrorDireccionVendedor.Name = "lblErrorDireccionVendedor";
            this.lblErrorDireccionVendedor.Size = new System.Drawing.Size(0, 13);
            this.lblErrorDireccionVendedor.TabIndex = 8;
            // 
            // lblErrrorDNIVendedor
            // 
            this.lblErrrorDNIVendedor.AutoSize = true;
            this.lblErrrorDNIVendedor.Location = new System.Drawing.Point(233, 215);
            this.lblErrrorDNIVendedor.Name = "lblErrrorDNIVendedor";
            this.lblErrrorDNIVendedor.Size = new System.Drawing.Size(0, 13);
            this.lblErrrorDNIVendedor.TabIndex = 8;
            // 
            // dgvVendedor
            // 
            this.dgvVendedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVendedor.Location = new System.Drawing.Point(27, 287);
            this.dgvVendedor.Name = "dgvVendedor";
            this.dgvVendedor.Size = new System.Drawing.Size(935, 296);
            this.dgvVendedor.TabIndex = 11;
            // 
            // frmVendedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(981, 603);
            this.Controls.Add(this.dgvVendedor);
            this.Controls.Add(this.cmbSexo);
            this.Controls.Add(this.txtDireccionVendedor);
            this.Controls.Add(this.txtDNIVendedor);
            this.Controls.Add(this.txtDatosVendedor);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErrrorDNIVendedor);
            this.Controls.Add(this.lblErrorDireccionVendedor);
            this.Controls.Add(this.lblErrorDatosVendedor);
            this.Controls.Add(this.lblErrorCodigoVendedor);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAccion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProcesar);
            this.Name = "frmVendedor";
            this.Text = "Administración de vendedores";
            this.Load += new System.EventHandler(this.frmVendedor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVendedor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbAccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDatosVendedor;
        private System.Windows.Forms.TextBox txtDNIVendedor;
        private System.Windows.Forms.TextBox txtDireccionVendedor;
        private System.Windows.Forms.ComboBox cmbSexo;
        private System.Windows.Forms.Label lblErrorCodigoVendedor;
        private System.Windows.Forms.Label lblErrorDatosVendedor;
        private System.Windows.Forms.Label lblErrorDireccionVendedor;
        private System.Windows.Forms.Label lblErrrorDNIVendedor;
        private System.Windows.Forms.DataGridView dgvVendedor;
    }
}