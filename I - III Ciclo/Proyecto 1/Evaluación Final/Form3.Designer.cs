namespace Evaluación_Final
{
    partial class frmProducto
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
            this.dgvProducto = new System.Windows.Forms.DataGridView();
            this.txtPUnitario = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNProducto = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblErrorPrecioUnitario = new System.Windows.Forms.Label();
            this.lblErrorNombreProducto = new System.Windows.Forms.Label();
            this.lblErrorCodigoProducto = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbAccion = new System.Windows.Forms.ComboBox();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnProcesar = new System.Windows.Forms.Button();
            this.lblErrorStockProducto = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvProducto
            // 
            this.dgvProducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducto.Location = new System.Drawing.Point(29, 256);
            this.dgvProducto.Name = "dgvProducto";
            this.dgvProducto.Size = new System.Drawing.Size(935, 296);
            this.dgvProducto.TabIndex = 29;
            // 
            // txtPUnitario
            // 
            this.txtPUnitario.Location = new System.Drawing.Point(193, 126);
            this.txtPUnitario.Name = "txtPUnitario";
            this.txtPUnitario.Size = new System.Drawing.Size(375, 20);
            this.txtPUnitario.TabIndex = 27;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(193, 177);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(100, 20);
            this.txtStock.TabIndex = 26;
            // 
            // txtNProducto
            // 
            this.txtNProducto.Location = new System.Drawing.Point(193, 75);
            this.txtNProducto.Name = "txtNProducto";
            this.txtNProducto.Size = new System.Drawing.Size(330, 20);
            this.txtNProducto.TabIndex = 25;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(193, 24);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 24;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "Stock";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(64, 127);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Precio Unitario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Nombre del Producto";
            // 
            // lblErrorPrecioUnitario
            // 
            this.lblErrorPrecioUnitario.AutoSize = true;
            this.lblErrorPrecioUnitario.Location = new System.Drawing.Point(190, 155);
            this.lblErrorPrecioUnitario.Name = "lblErrorPrecioUnitario";
            this.lblErrorPrecioUnitario.Size = new System.Drawing.Size(0, 13);
            this.lblErrorPrecioUnitario.TabIndex = 18;
            // 
            // lblErrorNombreProducto
            // 
            this.lblErrorNombreProducto.AutoSize = true;
            this.lblErrorNombreProducto.Location = new System.Drawing.Point(190, 104);
            this.lblErrorNombreProducto.Name = "lblErrorNombreProducto";
            this.lblErrorNombreProducto.Size = new System.Drawing.Size(0, 13);
            this.lblErrorNombreProducto.TabIndex = 17;
            // 
            // lblErrorCodigoProducto
            // 
            this.lblErrorCodigoProducto.AutoSize = true;
            this.lblErrorCodigoProducto.Location = new System.Drawing.Point(190, 53);
            this.lblErrorCodigoProducto.Name = "lblErrorCodigoProducto";
            this.lblErrorCodigoProducto.Size = new System.Drawing.Size(0, 13);
            this.lblErrorCodigoProducto.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Código Producto";
            // 
            // cmbAccion
            // 
            this.cmbAccion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbAccion.FormattingEnabled = true;
            this.cmbAccion.Location = new System.Drawing.Point(655, 50);
            this.cmbAccion.Name = "cmbAccion";
            this.cmbAccion.Size = new System.Drawing.Size(121, 21);
            this.cmbAccion.TabIndex = 14;
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(796, 88);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(87, 33);
            this.btnSalir.TabIndex = 12;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            // 
            // btnProcesar
            // 
            this.btnProcesar.Location = new System.Drawing.Point(796, 44);
            this.btnProcesar.Name = "btnProcesar";
            this.btnProcesar.Size = new System.Drawing.Size(87, 33);
            this.btnProcesar.TabIndex = 13;
            this.btnProcesar.Text = "Procesar";
            this.btnProcesar.UseVisualStyleBackColor = true;
            this.btnProcesar.Click += new System.EventHandler(this.btnProcesar_Click);
            // 
            // lblErrorStockProducto
            // 
            this.lblErrorStockProducto.AutoSize = true;
            this.lblErrorStockProducto.Location = new System.Drawing.Point(190, 206);
            this.lblErrorStockProducto.Name = "lblErrorStockProducto";
            this.lblErrorStockProducto.Size = new System.Drawing.Size(0, 13);
            this.lblErrorStockProducto.TabIndex = 18;
            // 
            // frmProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(986, 603);
            this.Controls.Add(this.dgvProducto);
            this.Controls.Add(this.txtPUnitario);
            this.Controls.Add(this.txtStock);
            this.Controls.Add(this.txtNProducto);
            this.Controls.Add(this.txtCodigo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblErrorStockProducto);
            this.Controls.Add(this.lblErrorPrecioUnitario);
            this.Controls.Add(this.lblErrorNombreProducto);
            this.Controls.Add(this.lblErrorCodigoProducto);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbAccion);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnProcesar);
            this.Name = "frmProducto";
            this.Text = "Administrar Productos";
            this.Load += new System.EventHandler(this.frmProducto_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvProducto;
        private System.Windows.Forms.TextBox txtPUnitario;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtNProducto;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblErrorPrecioUnitario;
        private System.Windows.Forms.Label lblErrorNombreProducto;
        private System.Windows.Forms.Label lblErrorCodigoProducto;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbAccion;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnProcesar;
        private System.Windows.Forms.Label lblErrorStockProducto;
    }
}