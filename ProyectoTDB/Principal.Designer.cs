﻿namespace ProyectoDB
{
    partial class Principal
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
            this.BarraMenu = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cerrarSesiónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contratosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.frecuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pocoFrecuentesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pocoFrecuenteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendaToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.virtualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.configuraciónDeTiendaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.carritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.inventarioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pedidosRealizadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.porLlamadaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empresasDeEnvíoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.miCarritoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesProcesadasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.facturasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.almacenToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.ordenesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteTableAdapter = new ProyectoDB.DataSet.FacturasDataSetTableAdapters.ClienteTableAdapter();
            this.facturasToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.BarraMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // BarraMenu
            // 
            this.BarraMenu.BackColor = System.Drawing.SystemColors.Control;
            this.BarraMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.usuariosToolStripMenuItem,
            this.clientesToolStripMenuItem,
            this.tiendaToolStripMenuItem,
            this.inventarioToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.reportesToolStripMenuItem,
            this.opcionesClienteToolStripMenuItem});
            this.BarraMenu.Location = new System.Drawing.Point(0, 0);
            this.BarraMenu.Name = "BarraMenu";
            this.BarraMenu.Size = new System.Drawing.Size(840, 24);
            this.BarraMenu.TabIndex = 0;
            this.BarraMenu.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cerrarSesiónToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // cerrarSesiónToolStripMenuItem
            // 
            this.cerrarSesiónToolStripMenuItem.Name = "cerrarSesiónToolStripMenuItem";
            this.cerrarSesiónToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.cerrarSesiónToolStripMenuItem.Text = "Cerrar Sesión";
            this.cerrarSesiónToolStripMenuItem.Click += new System.EventHandler(this.cerrarSesiónToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(143, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // usuariosToolStripMenuItem
            // 
            this.usuariosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónDeUsuariosToolStripMenuItem});
            this.usuariosToolStripMenuItem.Name = "usuariosToolStripMenuItem";
            this.usuariosToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.usuariosToolStripMenuItem.Text = "Usuarios";
            this.usuariosToolStripMenuItem.Visible = false;
            // 
            // configuraciónDeUsuariosToolStripMenuItem
            // 
            this.configuraciónDeUsuariosToolStripMenuItem.Name = "configuraciónDeUsuariosToolStripMenuItem";
            this.configuraciónDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(215, 22);
            this.configuraciónDeUsuariosToolStripMenuItem.Text = "Configuración De Usuarios";
            this.configuraciónDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.configuraciónDeUsuariosToolStripMenuItem_Click);
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contratosToolStripMenuItem,
            this.facturasToolStripMenuItem1,
            this.ordenesToolStripMenuItem,
            this.frecuentesToolStripMenuItem,
            this.pocoFrecuentesToolStripMenuItem});
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Visible = false;
            // 
            // contratosToolStripMenuItem
            // 
            this.contratosToolStripMenuItem.Name = "contratosToolStripMenuItem";
            this.contratosToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.contratosToolStripMenuItem.Text = "Contratos";
            this.contratosToolStripMenuItem.Click += new System.EventHandler(this.contratosToolStripMenuItem_Click);
            // 
            // frecuentesToolStripMenuItem
            // 
            this.frecuentesToolStripMenuItem.Name = "frecuentesToolStripMenuItem";
            this.frecuentesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.frecuentesToolStripMenuItem.Text = "Frecuentes";
            this.frecuentesToolStripMenuItem.Click += new System.EventHandler(this.frecuentesToolStripMenuItem_Click);
            // 
            // pocoFrecuentesToolStripMenuItem
            // 
            this.pocoFrecuentesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pocoFrecuenteToolStripMenuItem,
            this.tiendaToolStripMenuItem1,
            this.virtualToolStripMenuItem});
            this.pocoFrecuentesToolStripMenuItem.Name = "pocoFrecuentesToolStripMenuItem";
            this.pocoFrecuentesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pocoFrecuentesToolStripMenuItem.Text = "Poco Frecuentes";
            // 
            // pocoFrecuenteToolStripMenuItem
            // 
            this.pocoFrecuenteToolStripMenuItem.Name = "pocoFrecuenteToolStripMenuItem";
            this.pocoFrecuenteToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.pocoFrecuenteToolStripMenuItem.Text = "Poco Frecuente";
            this.pocoFrecuenteToolStripMenuItem.Click += new System.EventHandler(this.pocoFrecuenteToolStripMenuItem_Click);
            // 
            // tiendaToolStripMenuItem1
            // 
            this.tiendaToolStripMenuItem1.Name = "tiendaToolStripMenuItem1";
            this.tiendaToolStripMenuItem1.Size = new System.Drawing.Size(156, 22);
            this.tiendaToolStripMenuItem1.Text = "Tienda";
            this.tiendaToolStripMenuItem1.Click += new System.EventHandler(this.tiendaToolStripMenuItem1_Click);
            // 
            // virtualToolStripMenuItem
            // 
            this.virtualToolStripMenuItem.Name = "virtualToolStripMenuItem";
            this.virtualToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.virtualToolStripMenuItem.Text = "Virtual";
            this.virtualToolStripMenuItem.Click += new System.EventHandler(this.virtualToolStripMenuItem_Click);
            // 
            // tiendaToolStripMenuItem
            // 
            this.tiendaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónDeTiendaToolStripMenuItem,
            this.carritoToolStripMenuItem});
            this.tiendaToolStripMenuItem.Name = "tiendaToolStripMenuItem";
            this.tiendaToolStripMenuItem.Size = new System.Drawing.Size(54, 20);
            this.tiendaToolStripMenuItem.Text = "Tienda";
            this.tiendaToolStripMenuItem.Visible = false;
            // 
            // configuraciónDeTiendaToolStripMenuItem
            // 
            this.configuraciónDeTiendaToolStripMenuItem.Name = "configuraciónDeTiendaToolStripMenuItem";
            this.configuraciónDeTiendaToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.configuraciónDeTiendaToolStripMenuItem.Text = "Configuración de Tienda";
            this.configuraciónDeTiendaToolStripMenuItem.Click += new System.EventHandler(this.configuraciónDeTiendaToolStripMenuItem_Click);
            // 
            // carritoToolStripMenuItem
            // 
            this.carritoToolStripMenuItem.Name = "carritoToolStripMenuItem";
            this.carritoToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.carritoToolStripMenuItem.Text = "Carrito";
            this.carritoToolStripMenuItem.Click += new System.EventHandler(this.carritoToolStripMenuItem_Click);
            // 
            // inventarioToolStripMenuItem
            // 
            this.inventarioToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.almacenToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.almacenToolStripMenuItem2});
            this.inventarioToolStripMenuItem.Name = "inventarioToolStripMenuItem";
            this.inventarioToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.inventarioToolStripMenuItem.Text = "Inventario";
            this.inventarioToolStripMenuItem.Visible = false;
            // 
            // almacenToolStripMenuItem
            // 
            this.almacenToolStripMenuItem.Name = "almacenToolStripMenuItem";
            this.almacenToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.almacenToolStripMenuItem.Text = "Productos";
            this.almacenToolStripMenuItem.Click += new System.EventHandler(this.almacenToolStripMenuItem_Click);
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pedidosRealizadosToolStripMenuItem,
            this.porLlamadaToolStripMenuItem,
            this.empresasDeEnvíoToolStripMenuItem});
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            this.pedidosToolStripMenuItem.Visible = false;
            // 
            // pedidosRealizadosToolStripMenuItem
            // 
            this.pedidosRealizadosToolStripMenuItem.Name = "pedidosRealizadosToolStripMenuItem";
            this.pedidosRealizadosToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.pedidosRealizadosToolStripMenuItem.Text = "Ordenes";
            this.pedidosRealizadosToolStripMenuItem.Click += new System.EventHandler(this.pedidosRealizadosToolStripMenuItem_Click);
            // 
            // porLlamadaToolStripMenuItem
            // 
            this.porLlamadaToolStripMenuItem.Name = "porLlamadaToolStripMenuItem";
            this.porLlamadaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.porLlamadaToolStripMenuItem.Text = "Por Llamada";
            this.porLlamadaToolStripMenuItem.Click += new System.EventHandler(this.porLlamadaToolStripMenuItem_Click);
            // 
            // empresasDeEnvíoToolStripMenuItem
            // 
            this.empresasDeEnvíoToolStripMenuItem.Name = "empresasDeEnvíoToolStripMenuItem";
            this.empresasDeEnvíoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.empresasDeEnvíoToolStripMenuItem.Text = "Empresas de Envío";
            this.empresasDeEnvíoToolStripMenuItem.Click += new System.EventHandler(this.empresasDeEnvíoToolStripMenuItem_Click);
            // 
            // reportesToolStripMenuItem
            // 
            this.reportesToolStripMenuItem.Name = "reportesToolStripMenuItem";
            this.reportesToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.reportesToolStripMenuItem.Text = "Reportes";
            this.reportesToolStripMenuItem.Visible = false;
            // 
            // opcionesClienteToolStripMenuItem
            // 
            this.opcionesClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCarritoToolStripMenuItem,
            this.ordenesProcesadasToolStripMenuItem,
            this.facturasToolStripMenuItem});
            this.opcionesClienteToolStripMenuItem.Name = "opcionesClienteToolStripMenuItem";
            this.opcionesClienteToolStripMenuItem.Size = new System.Drawing.Size(109, 20);
            this.opcionesClienteToolStripMenuItem.Text = "Opciones Cliente";
            this.opcionesClienteToolStripMenuItem.Visible = false;
            // 
            // miCarritoToolStripMenuItem
            // 
            this.miCarritoToolStripMenuItem.Name = "miCarritoToolStripMenuItem";
            this.miCarritoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.miCarritoToolStripMenuItem.Text = "Mi Carrito";
            this.miCarritoToolStripMenuItem.Click += new System.EventHandler(this.miCarritoToolStripMenuItem_Click);
            // 
            // ordenesProcesadasToolStripMenuItem
            // 
            this.ordenesProcesadasToolStripMenuItem.Name = "ordenesProcesadasToolStripMenuItem";
            this.ordenesProcesadasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ordenesProcesadasToolStripMenuItem.Text = "Ordenes Procesadas";
            this.ordenesProcesadasToolStripMenuItem.Click += new System.EventHandler(this.ordenesProcesadasToolStripMenuItem_Click);
            // 
            // facturasToolStripMenuItem
            // 
            this.facturasToolStripMenuItem.Name = "facturasToolStripMenuItem";
            this.facturasToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.facturasToolStripMenuItem.Text = "Facturas";
            this.facturasToolStripMenuItem.Click += new System.EventHandler(this.facturasToolStripMenuItem_Click);
            // 
            // almacenToolStripMenuItem2
            // 
            this.almacenToolStripMenuItem2.Name = "almacenToolStripMenuItem2";
            this.almacenToolStripMenuItem2.Size = new System.Drawing.Size(130, 22);
            this.almacenToolStripMenuItem2.Text = "Almacen";
            this.almacenToolStripMenuItem2.Click += new System.EventHandler(this.almacenToolStripMenuItem2_Click);
            // 
            // ordenesToolStripMenuItem
            // 
            this.ordenesToolStripMenuItem.Name = "ordenesToolStripMenuItem";
            this.ordenesToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.ordenesToolStripMenuItem.Text = "Ordenes";
            this.ordenesToolStripMenuItem.Click += new System.EventHandler(this.ordenesToolStripMenuItem_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // facturasToolStripMenuItem1
            // 
            this.facturasToolStripMenuItem1.Name = "facturasToolStripMenuItem1";
            this.facturasToolStripMenuItem1.Size = new System.Drawing.Size(161, 22);
            this.facturasToolStripMenuItem1.Text = "Facturas";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(840, 522);
            this.Controls.Add(this.BarraMenu);
            this.MainMenuStrip = this.BarraMenu;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.BarraMenu.ResumeLayout(false);
            this.BarraMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip BarraMenu;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cerrarSesiónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem inventarioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem configuraciónDeTiendaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pedidosRealizadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem contratosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem carritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesClienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem miCarritoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ordenesProcesadasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem frecuentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pocoFrecuentesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tiendaToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem virtualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pocoFrecuenteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem porLlamadaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empresasDeEnvíoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem almacenToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ordenesToolStripMenuItem;
        private DataSet.FacturasDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem facturasToolStripMenuItem1;
    }
}