
namespace Lab02_01
{
    partial class PrincipalMDI
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mantenimientoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManCategorias = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuManClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.procesosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRVenta = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuProRCompra = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepVentas = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepCompras = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuRepIProductos = new System.Windows.Forms.ToolStripMenuItem();
            this.repProveedores = new System.Windows.Forms.ToolStripMenuItem();
            this.repUsuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.repClientes = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mantenimientoToolStripMenuItem,
            this.procesosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.sistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(582, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mantenimientoToolStripMenuItem
            // 
            this.mantenimientoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuManUsuarios,
            this.mnuManProductos,
            this.mnuManCategorias,
            this.mnuManProveedores,
            this.mnuManClientes});
            this.mantenimientoToolStripMenuItem.Name = "mantenimientoToolStripMenuItem";
            this.mantenimientoToolStripMenuItem.Size = new System.Drawing.Size(124, 26);
            this.mantenimientoToolStripMenuItem.Text = "Mantenimiento";
            // 
            // mnuManUsuarios
            // 
            this.mnuManUsuarios.Name = "mnuManUsuarios";
            this.mnuManUsuarios.Size = new System.Drawing.Size(224, 26);
            this.mnuManUsuarios.Text = "Usuarios";
            this.mnuManUsuarios.Click += new System.EventHandler(this.mnuManUsuarios_Click);
            // 
            // mnuManProductos
            // 
            this.mnuManProductos.Name = "mnuManProductos";
            this.mnuManProductos.Size = new System.Drawing.Size(224, 26);
            this.mnuManProductos.Text = "Productos";
            // 
            // mnuManCategorias
            // 
            this.mnuManCategorias.Name = "mnuManCategorias";
            this.mnuManCategorias.Size = new System.Drawing.Size(224, 26);
            this.mnuManCategorias.Text = "Categorias";
            // 
            // mnuManProveedores
            // 
            this.mnuManProveedores.Name = "mnuManProveedores";
            this.mnuManProveedores.Size = new System.Drawing.Size(224, 26);
            this.mnuManProveedores.Text = "Proveedores";
            // 
            // mnuManClientes
            // 
            this.mnuManClientes.Name = "mnuManClientes";
            this.mnuManClientes.Size = new System.Drawing.Size(224, 26);
            this.mnuManClientes.Text = "Clientes";
            // 
            // procesosToolStripMenuItem
            // 
            this.procesosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuProRVenta,
            this.mnuProRCompra});
            this.procesosToolStripMenuItem.Name = "procesosToolStripMenuItem";
            this.procesosToolStripMenuItem.Size = new System.Drawing.Size(81, 26);
            this.procesosToolStripMenuItem.Text = "Procesos";
            // 
            // mnuProRVenta
            // 
            this.mnuProRVenta.Name = "mnuProRVenta";
            this.mnuProRVenta.Size = new System.Drawing.Size(224, 26);
            this.mnuProRVenta.Text = "Registrar Venta";
            // 
            // mnuProRCompra
            // 
            this.mnuProRCompra.Name = "mnuProRCompra";
            this.mnuProRCompra.Size = new System.Drawing.Size(224, 26);
            this.mnuProRCompra.Text = "Registrar Compra";
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRepVentas,
            this.mnuRepCompras,
            this.mnuRepIProductos,
            this.repProveedores,
            this.repUsuarios,
            this.repClientes});
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(82, 26);
            this.reportesToolStripMenuItem.Text = "Reportes";
            // 
            // mnuRepVentas
            // 
            this.mnuRepVentas.Name = "mnuRepVentas";
            this.mnuRepVentas.Size = new System.Drawing.Size(252, 26);
            this.mnuRepVentas.Text = "Reporte de Ventas";
            // 
            // mnuRepCompras
            // 
            this.mnuRepCompras.Name = "mnuRepCompras";
            this.mnuRepCompras.Size = new System.Drawing.Size(252, 26);
            this.mnuRepCompras.Text = "Reporte de Compras";
            // 
            // mnuRepIProductos
            // 
            this.mnuRepIProductos.Name = "mnuRepIProductos";
            this.mnuRepIProductos.Size = new System.Drawing.Size(252, 26);
            this.mnuRepIProductos.Text = "Inventario de Productos";
            // 
            // repProveedores
            // 
            this.repProveedores.Name = "repProveedores";
            this.repProveedores.Size = new System.Drawing.Size(252, 26);
            this.repProveedores.Text = "Reporte de Proveedores";
            this.repProveedores.Click += new System.EventHandler(this.reporteDeToolStripMenuItem_Click);
            // 
            // repUsuarios
            // 
            this.repUsuarios.Name = "repUsuarios";
            this.repUsuarios.Size = new System.Drawing.Size(252, 26);
            this.repUsuarios.Text = "Reporte de Usuarios";
            // 
            // repClientes
            // 
            this.repClientes.Name = "repClientes";
            this.repClientes.Size = new System.Drawing.Size(252, 26);
            this.repClientes.Text = "Reporte de Clientes";
            // 
            // sistemaToolStripMenuItem
            // 
            this.sistemaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSalir});
            this.sistemaToolStripMenuItem.Name = "sistemaToolStripMenuItem";
            this.sistemaToolStripMenuItem.Size = new System.Drawing.Size(75, 26);
            this.sistemaToolStripMenuItem.Text = "Sistema";
            // 
            // mnuSalir
            // 
            this.mnuSalir.Name = "mnuSalir";
            this.mnuSalir.Size = new System.Drawing.Size(224, 26);
            this.mnuSalir.Text = "Salir del Sistema";
            this.mnuSalir.Click += new System.EventHandler(this.mnuSalir_Click);
            // 
            // PrincipalMDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "PrincipalMDI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Panel Principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mantenimientoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuManUsuarios;
        private System.Windows.Forms.ToolStripMenuItem mnuManProductos;
        private System.Windows.Forms.ToolStripMenuItem mnuManCategorias;
        private System.Windows.Forms.ToolStripMenuItem mnuManProveedores;
        private System.Windows.Forms.ToolStripMenuItem mnuManClientes;
        private System.Windows.Forms.ToolStripMenuItem procesosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mnuSalir;
        private System.Windows.Forms.ToolStripMenuItem mnuProRVenta;
        private System.Windows.Forms.ToolStripMenuItem mnuProRCompra;
        private System.Windows.Forms.ToolStripMenuItem mnuRepVentas;
        private System.Windows.Forms.ToolStripMenuItem mnuRepCompras;
        private System.Windows.Forms.ToolStripMenuItem mnuRepIProductos;
        private System.Windows.Forms.ToolStripMenuItem repProveedores;
        private System.Windows.Forms.ToolStripMenuItem repUsuarios;
        private System.Windows.Forms.ToolStripMenuItem repClientes;
    }
}