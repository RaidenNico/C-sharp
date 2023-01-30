namespace Proyecto
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cLIENTEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.recurrenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.pagosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tarjetaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.efectivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.transferenciaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pRODUCTOToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ventaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaVentaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarVentasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pROVEEDORToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.compraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nuevaCompraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.revisarComprasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.registroProducto = new System.Windows.Forms.ToolStripButton();
            this.comprarProducto = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cLIENTEToolStripMenuItem,
            this.pRODUCTOToolStripMenuItem,
            this.pROVEEDORToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 29);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // cLIENTEToolStripMenuItem
            // 
            this.cLIENTEToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevoToolStripMenuItem,
            this.recurrenteToolStripMenuItem,
            this.toolStripSeparator1,
            this.pagosToolStripMenuItem});
            this.cLIENTEToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cLIENTEToolStripMenuItem.Image = global::Proyecto.Properties.Resources.clientes;
            this.cLIENTEToolStripMenuItem.Name = "cLIENTEToolStripMenuItem";
            this.cLIENTEToolStripMenuItem.Size = new System.Drawing.Size(106, 25);
            this.cLIENTEToolStripMenuItem.Text = "CLIENTES";
            // 
            // nuevoToolStripMenuItem
            // 
            this.nuevoToolStripMenuItem.Image = global::Proyecto.Properties.Resources.nuevoCl;
            this.nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            this.nuevoToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.nuevoToolStripMenuItem.Text = "Nuevo";
            this.nuevoToolStripMenuItem.Click += new System.EventHandler(this.nuevoToolStripMenuItem_Click);
            // 
            // recurrenteToolStripMenuItem
            // 
            this.recurrenteToolStripMenuItem.Image = global::Proyecto.Properties.Resources.cl_recurrente;
            this.recurrenteToolStripMenuItem.Name = "recurrenteToolStripMenuItem";
            this.recurrenteToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.recurrenteToolStripMenuItem.Text = "Recurrente";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(181, 6);
            // 
            // pagosToolStripMenuItem
            // 
            this.pagosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tarjetaToolStripMenuItem,
            this.efectivoToolStripMenuItem,
            this.transferenciaToolStripMenuItem});
            this.pagosToolStripMenuItem.Image = global::Proyecto.Properties.Resources.pago;
            this.pagosToolStripMenuItem.Name = "pagosToolStripMenuItem";
            this.pagosToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.pagosToolStripMenuItem.Text = "Pago";
            // 
            // tarjetaToolStripMenuItem
            // 
            this.tarjetaToolStripMenuItem.Image = global::Proyecto.Properties.Resources.pag_tarjeta;
            this.tarjetaToolStripMenuItem.Name = "tarjetaToolStripMenuItem";
            this.tarjetaToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.tarjetaToolStripMenuItem.Text = "Tarjeta";
            // 
            // efectivoToolStripMenuItem
            // 
            this.efectivoToolStripMenuItem.Image = global::Proyecto.Properties.Resources.pag_efec;
            this.efectivoToolStripMenuItem.Name = "efectivoToolStripMenuItem";
            this.efectivoToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.efectivoToolStripMenuItem.Text = "Efectivo";
            // 
            // transferenciaToolStripMenuItem
            // 
            this.transferenciaToolStripMenuItem.Image = global::Proyecto.Properties.Resources.transferencia;
            this.transferenciaToolStripMenuItem.Name = "transferenciaToolStripMenuItem";
            this.transferenciaToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.transferenciaToolStripMenuItem.Text = "Transferencia";
            // 
            // pRODUCTOToolStripMenuItem
            // 
            this.pRODUCTOToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.toolStripSeparator2,
            this.ventaToolStripMenuItem});
            this.pRODUCTOToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pRODUCTOToolStripMenuItem.Image = global::Proyecto.Properties.Resources.producto;
            this.pRODUCTOToolStripMenuItem.Name = "pRODUCTOToolStripMenuItem";
            this.pRODUCTOToolStripMenuItem.Size = new System.Drawing.Size(116, 25);
            this.pRODUCTOToolStripMenuItem.Text = "PRODUCTO";
            // 
            // registrarToolStripMenuItem
            // 
            this.registrarToolStripMenuItem.Image = global::Proyecto.Properties.Resources.producto1;
            this.registrarToolStripMenuItem.Name = "registrarToolStripMenuItem";
            this.registrarToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.registrarToolStripMenuItem.Text = "Registro";
            this.registrarToolStripMenuItem.Click += new System.EventHandler(this.registrarToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.Image = global::Proyecto.Properties.Resources.inventarioP;
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(181, 6);
            // 
            // ventaToolStripMenuItem
            // 
            this.ventaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaVentaToolStripMenuItem,
            this.revisarVentasToolStripMenuItem});
            this.ventaToolStripMenuItem.Image = global::Proyecto.Properties.Resources.venta;
            this.ventaToolStripMenuItem.Name = "ventaToolStripMenuItem";
            this.ventaToolStripMenuItem.Size = new System.Drawing.Size(184, 26);
            this.ventaToolStripMenuItem.Text = "Venta";
            // 
            // nuevaVentaToolStripMenuItem
            // 
            this.nuevaVentaToolStripMenuItem.Image = global::Proyecto.Properties.Resources.nuevo;
            this.nuevaVentaToolStripMenuItem.Name = "nuevaVentaToolStripMenuItem";
            this.nuevaVentaToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.nuevaVentaToolStripMenuItem.Text = "Nueva Venta";
            // 
            // revisarVentasToolStripMenuItem
            // 
            this.revisarVentasToolStripMenuItem.Image = global::Proyecto.Properties.Resources.buscar;
            this.revisarVentasToolStripMenuItem.Name = "revisarVentasToolStripMenuItem";
            this.revisarVentasToolStripMenuItem.Size = new System.Drawing.Size(166, 26);
            this.revisarVentasToolStripMenuItem.Text = "Buscar Ventas";
            // 
            // pROVEEDORToolStripMenuItem
            // 
            this.pROVEEDORToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.inventarioToolStripMenuItem1,
            this.toolStripSeparator3,
            this.compraToolStripMenuItem});
            this.pROVEEDORToolStripMenuItem.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pROVEEDORToolStripMenuItem.Image = global::Proyecto.Properties.Resources.proveedor;
            this.pROVEEDORToolStripMenuItem.Name = "pROVEEDORToolStripMenuItem";
            this.pROVEEDORToolStripMenuItem.Size = new System.Drawing.Size(123, 25);
            this.pROVEEDORToolStripMenuItem.Text = "PROVEEDOR";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.Image = global::Proyecto.Properties.Resources.regProv;
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.registroToolStripMenuItem.Text = "Registro";
            // 
            // inventarioToolStripMenuItem1
            // 
            this.inventarioToolStripMenuItem1.Image = global::Proyecto.Properties.Resources.inventarioProv;
            this.inventarioToolStripMenuItem1.Name = "inventarioToolStripMenuItem1";
            this.inventarioToolStripMenuItem1.Size = new System.Drawing.Size(144, 26);
            this.inventarioToolStripMenuItem1.Text = "Inventario";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(141, 6);
            // 
            // compraToolStripMenuItem
            // 
            this.compraToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nuevaCompraToolStripMenuItem,
            this.revisarComprasToolStripMenuItem});
            this.compraToolStripMenuItem.Image = global::Proyecto.Properties.Resources.compras;
            this.compraToolStripMenuItem.Name = "compraToolStripMenuItem";
            this.compraToolStripMenuItem.Size = new System.Drawing.Size(144, 26);
            this.compraToolStripMenuItem.Text = "Compra";
            // 
            // nuevaCompraToolStripMenuItem
            // 
            this.nuevaCompraToolStripMenuItem.Image = global::Proyecto.Properties.Resources.nuevo1;
            this.nuevaCompraToolStripMenuItem.Name = "nuevaCompraToolStripMenuItem";
            this.nuevaCompraToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.nuevaCompraToolStripMenuItem.Text = "Nueva Compra";
            // 
            // revisarComprasToolStripMenuItem
            // 
            this.revisarComprasToolStripMenuItem.Image = global::Proyecto.Properties.Resources.revisarCom;
            this.revisarComprasToolStripMenuItem.Name = "revisarComprasToolStripMenuItem";
            this.revisarComprasToolStripMenuItem.Size = new System.Drawing.Size(183, 26);
            this.revisarComprasToolStripMenuItem.Text = "Revisar Compras";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroProducto,
            this.comprarProducto,
            this.toolStripButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 29);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(800, 44);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // registroProducto
            // 
            this.registroProducto.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registroProducto.Image = ((System.Drawing.Image)(resources.GetObject("registroProducto.Image")));
            this.registroProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.registroProducto.Name = "registroProducto";
            this.registroProducto.Size = new System.Drawing.Size(135, 41);
            this.registroProducto.Text = "Registrar Productos";
            this.registroProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.registroProducto.Click += new System.EventHandler(this.registroProducto_Click);
            // 
            // comprarProducto
            // 
            this.comprarProducto.Font = new System.Drawing.Font("Sitka Banner", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comprarProducto.Image = ((System.Drawing.Image)(resources.GetObject("comprarProducto.Image")));
            this.comprarProducto.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.comprarProducto.Name = "comprarProducto";
            this.comprarProducto.Size = new System.Drawing.Size(104, 41);
            this.comprarProducto.Text = "Nueva Compra";
            this.comprarProducto.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.comprarProducto.Click += new System.EventHandler(this.comprarProducto_Click);
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton1.BackColor = System.Drawing.Color.Gold;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(42, 41);
            this.toolStripButton1.Text = "Salida";
            this.toolStripButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.toolStripButton1.TextDirection = System.Windows.Forms.ToolStripTextDirection.Horizontal;
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proyecto.Properties.Resources.bodega;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "SISTEMA";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem cLIENTEToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem recurrenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem pagosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tarjetaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem efectivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem transferenciaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pRODUCTOToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem ventaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaVentaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisarVentasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pROVEEDORToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem compraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nuevaCompraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem revisarComprasToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton registroProducto;
        private System.Windows.Forms.ToolStripButton comprarProducto;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
    }
}