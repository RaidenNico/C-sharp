namespace Proyecto_de_Bodega
{
    partial class frmProveedores
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRuc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textNumero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtWeb = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDepartamento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtDistrito = new System.Windows.Forms.TextBox();
            this.btnContacto = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnContacto);
            this.panel1.Controls.Add(this.txtDistrito);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtDepartamento);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtWeb);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.textNumero);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtRuc);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtRazonSocial);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cbProveedor);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(775, 425);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Proveedor";
            // 
            // cbProveedor
            // 
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Items.AddRange(new object[] {
            "Agrolatina",
            "Natural Foods & Fruits",
            "Sacks America Latina",
            "Corporacion Vega"});
            this.cbProveedor.Location = new System.Drawing.Point(190, 11);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(190, 26);
            this.cbProveedor.TabIndex = 1;
            this.cbProveedor.SelectedIndexChanged += new System.EventHandler(this.cbProveedor_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Razon Social";
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(190, 58);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(321, 24);
            this.txtRazonSocial.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 100);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "RUC";
            // 
            // txtRuc
            // 
            this.txtRuc.Location = new System.Drawing.Point(190, 100);
            this.txtRuc.Name = "txtRuc";
            this.txtRuc.Size = new System.Drawing.Size(321, 24);
            this.txtRuc.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 323);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(144, 18);
            this.label4.TabIndex = 6;
            this.label4.Text = "Número de Telefono";
            // 
            // textNumero
            // 
            this.textNumero.Location = new System.Drawing.Point(187, 320);
            this.textNumero.Name = "textNumero";
            this.textNumero.Size = new System.Drawing.Size(190, 24);
            this.textNumero.TabIndex = 7;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(18, 146);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Web";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // txtWeb
            // 
            this.txtWeb.Location = new System.Drawing.Point(190, 146);
            this.txtWeb.Name = "txtWeb";
            this.txtWeb.Size = new System.Drawing.Size(278, 24);
            this.txtWeb.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(18, 190);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 18);
            this.label6.TabIndex = 10;
            this.label6.Text = "Dirección Legal";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(187, 190);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(363, 24);
            this.txtDireccion.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 277);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 18);
            this.label7.TabIndex = 12;
            this.label7.Text = "Departamento";
            // 
            // txtDepartamento
            // 
            this.txtDepartamento.Location = new System.Drawing.Point(187, 274);
            this.txtDepartamento.Name = "txtDepartamento";
            this.txtDepartamento.Size = new System.Drawing.Size(278, 24);
            this.txtDepartamento.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(18, 234);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(105, 18);
            this.label8.TabIndex = 14;
            this.label8.Text = "Distrito/Ciudad";
            // 
            // txtDistrito
            // 
            this.txtDistrito.Location = new System.Drawing.Point(187, 231);
            this.txtDistrito.Name = "txtDistrito";
            this.txtDistrito.Size = new System.Drawing.Size(278, 24);
            this.txtDistrito.TabIndex = 15;
            // 
            // btnContacto
            // 
            this.btnContacto.Location = new System.Drawing.Point(190, 376);
            this.btnContacto.Name = "btnContacto";
            this.btnContacto.Size = new System.Drawing.Size(147, 29);
            this.btnContacto.TabIndex = 16;
            this.btnContacto.Text = "Contactar";
            this.btnContacto.UseVisualStyleBackColor = true;
            this.btnContacto.Click += new System.EventHandler(this.btnContacto_Click);
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.panel1);
            this.Name = "frmProveedores";
            this.Text = "Prooveedores";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbProveedor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRazonSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtWeb;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textNumero;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDepartamento;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDireccion;
        private System.Windows.Forms.TextBox txtDistrito;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnContacto;
    }
}