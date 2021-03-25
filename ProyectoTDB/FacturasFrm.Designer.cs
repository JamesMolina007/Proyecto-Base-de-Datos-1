namespace ProyectoDB
{
    partial class FacturasFrm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacturasFrm));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.btn_Recargar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tb_BuscarCliente = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DetalleFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasDataSet = new ProyectoDB.DataSet.FacturasDataSet();
            this.detalleFacturaTableAdapter = new ProyectoDB.DataSet.FacturasDataSetTableAdapters.DetalleFacturaTableAdapter();
            this.EncabezadoFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturaTableAdapter = new ProyectoDB.DataSet.FacturasDataSetTableAdapters.FacturaTableAdapter();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.noFacturaDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTiendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_EncabezadoFactura = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_Tienda = new System.Windows.Forms.ComboBox();
            this.TiendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaDataSet = new ProyectoDB.DataSet.TiendaDataSet();
            this.cb_Cliente = new System.Windows.Forms.ComboBox();
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataSet = new ProyectoDB.DataSet.ClientesDataSet();
            this.tb_RTN = new System.Windows.Forms.TextBox();
            this.tb_direccion = new System.Windows.Forms.TextBox();
            this.gb_Detalle = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Cantidad = new System.Windows.Forms.TextBox();
            this.cb_Producto = new System.Windows.Forms.ComboBox();
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosDataSet = new ProyectoDB.DataSet.ProductosDataSet();
            this.clienteVirtualTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteVirtualTableAdapter();
            this.tiendaTableAdapter = new ProyectoDB.DataSet.TiendaDataSetTableAdapters.TiendaTableAdapter();
            this.productoTableAdapter = new ProyectoDB.DataSet.ProductosDataSetTableAdapters.ProductoTableAdapter();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncabezadoFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gb_EncabezadoFactura.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            this.gb_Detalle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Eliminar,
            this.btn_Recargar,
            this.toolStripLabel1,
            this.tb_BuscarCliente});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(848, 54);
            this.toolStripMenu.TabIndex = 22;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(54, 51);
            this.btn_Eliminar.Text = "Eliminar";
            this.btn_Eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Recargar
            // 
            this.btn_Recargar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Recargar.Image")));
            this.btn_Recargar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Recargar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Recargar.Name = "btn_Recargar";
            this.btn_Recargar.Size = new System.Drawing.Size(57, 51);
            this.btn_Recargar.Text = "Recargar";
            this.btn_Recargar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Recargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Recargar.Click += new System.EventHandler(this.btn_Recargar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(85, 51);
            this.toolStripLabel1.Text = "Buscar Cliente:";
            // 
            // tb_BuscarCliente
            // 
            this.tb_BuscarCliente.Name = "tb_BuscarCliente";
            this.tb_BuscarCliente.Size = new System.Drawing.Size(100, 54);
            this.tb_BuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_BuscarCliente_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noFacturaDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.cantidadProductoDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.isvDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.DetalleFacturaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 270);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(306, 206);
            this.dataGridView1.TabIndex = 23;
            // 
            // noFacturaDataGridViewTextBoxColumn
            // 
            this.noFacturaDataGridViewTextBoxColumn.DataPropertyName = "NoFactura";
            this.noFacturaDataGridViewTextBoxColumn.HeaderText = "NoFactura";
            this.noFacturaDataGridViewTextBoxColumn.Name = "noFacturaDataGridViewTextBoxColumn";
            this.noFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            this.noFacturaDataGridViewTextBoxColumn.Visible = false;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "ID Producto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadProductoDataGridViewTextBoxColumn
            // 
            this.cantidadProductoDataGridViewTextBoxColumn.DataPropertyName = "cantidadProducto";
            this.cantidadProductoDataGridViewTextBoxColumn.HeaderText = "Cantidad Producto";
            this.cantidadProductoDataGridViewTextBoxColumn.Name = "cantidadProductoDataGridViewTextBoxColumn";
            this.cantidadProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadProductoDataGridViewTextBoxColumn.Width = 130;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Visible = false;
            this.totalDataGridViewTextBoxColumn.Width = 80;
            // 
            // isvDataGridViewTextBoxColumn
            // 
            this.isvDataGridViewTextBoxColumn.DataPropertyName = "isv";
            this.isvDataGridViewTextBoxColumn.HeaderText = "ISV";
            this.isvDataGridViewTextBoxColumn.Name = "isvDataGridViewTextBoxColumn";
            this.isvDataGridViewTextBoxColumn.ReadOnly = true;
            this.isvDataGridViewTextBoxColumn.Visible = false;
            this.isvDataGridViewTextBoxColumn.Width = 80;
            // 
            // DetalleFacturaBindingSource
            // 
            this.DetalleFacturaBindingSource.DataMember = "DetalleFactura";
            this.DetalleFacturaBindingSource.DataSource = this.facturasDataSet;
            // 
            // facturasDataSet
            // 
            this.facturasDataSet.DataSetName = "FacturasDataSet";
            this.facturasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalleFacturaTableAdapter
            // 
            this.detalleFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // EncabezadoFacturaBindingSource
            // 
            this.EncabezadoFacturaBindingSource.DataMember = "Factura";
            this.EncabezadoFacturaBindingSource.DataSource = this.facturasDataSet;
            this.EncabezadoFacturaBindingSource.PositionChanged += new System.EventHandler(this.EncabezadoFacturaBindingSource_PositionChanged);
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noFacturaDataGridViewTextBoxColumn1,
            this.idClienteDataGridViewTextBoxColumn,
            this.direccionDataGridViewTextBoxColumn,
            this.rTNDataGridViewTextBoxColumn,
            this.fechaEmisionDataGridViewTextBoxColumn,
            this.codigoTiendaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.EncabezadoFacturaBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 57);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(475, 196);
            this.dataGridView2.TabIndex = 24;
            // 
            // noFacturaDataGridViewTextBoxColumn1
            // 
            this.noFacturaDataGridViewTextBoxColumn1.DataPropertyName = "noFactura";
            this.noFacturaDataGridViewTextBoxColumn1.HeaderText = "noFactura";
            this.noFacturaDataGridViewTextBoxColumn1.Name = "noFacturaDataGridViewTextBoxColumn1";
            this.noFacturaDataGridViewTextBoxColumn1.ReadOnly = true;
            this.noFacturaDataGridViewTextBoxColumn1.Visible = false;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "ID Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionDataGridViewTextBoxColumn
            // 
            this.direccionDataGridViewTextBoxColumn.DataPropertyName = "Direccion";
            this.direccionDataGridViewTextBoxColumn.HeaderText = "Direccion";
            this.direccionDataGridViewTextBoxColumn.Name = "direccionDataGridViewTextBoxColumn";
            this.direccionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rTNDataGridViewTextBoxColumn
            // 
            this.rTNDataGridViewTextBoxColumn.DataPropertyName = "RTN";
            this.rTNDataGridViewTextBoxColumn.HeaderText = "RTN";
            this.rTNDataGridViewTextBoxColumn.Name = "rTNDataGridViewTextBoxColumn";
            this.rTNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEmisionDataGridViewTextBoxColumn
            // 
            this.fechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "FechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaEmisionDataGridViewTextBoxColumn.Name = "fechaEmisionDataGridViewTextBoxColumn";
            this.fechaEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoTiendaDataGridViewTextBoxColumn
            // 
            this.codigoTiendaDataGridViewTextBoxColumn.DataPropertyName = "codigoTienda";
            this.codigoTiendaDataGridViewTextBoxColumn.HeaderText = "codigoTienda";
            this.codigoTiendaDataGridViewTextBoxColumn.Name = "codigoTiendaDataGridViewTextBoxColumn";
            this.codigoTiendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoTiendaDataGridViewTextBoxColumn.Visible = false;
            // 
            // gb_EncabezadoFactura
            // 
            this.gb_EncabezadoFactura.Controls.Add(this.label4);
            this.gb_EncabezadoFactura.Controls.Add(this.label3);
            this.gb_EncabezadoFactura.Controls.Add(this.label2);
            this.gb_EncabezadoFactura.Controls.Add(this.label1);
            this.gb_EncabezadoFactura.Controls.Add(this.cb_Tienda);
            this.gb_EncabezadoFactura.Controls.Add(this.cb_Cliente);
            this.gb_EncabezadoFactura.Controls.Add(this.tb_RTN);
            this.gb_EncabezadoFactura.Controls.Add(this.tb_direccion);
            this.gb_EncabezadoFactura.Enabled = false;
            this.gb_EncabezadoFactura.Location = new System.Drawing.Point(493, 58);
            this.gb_EncabezadoFactura.Name = "gb_EncabezadoFactura";
            this.gb_EncabezadoFactura.Size = new System.Drawing.Size(336, 195);
            this.gb_EncabezadoFactura.TabIndex = 25;
            this.gb_EncabezadoFactura.TabStop = false;
            this.gb_EncabezadoFactura.Text = "Datos de Encabezado";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 159);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tienda:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "RTN:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Dirección";
            // 
            // cb_Tienda
            // 
            this.cb_Tienda.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.EncabezadoFacturaBindingSource, "codigoTienda", true));
            this.cb_Tienda.DataSource = this.TiendaBindingSource;
            this.cb_Tienda.DisplayMember = "codigoTienda";
            this.cb_Tienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tienda.FormattingEnabled = true;
            this.cb_Tienda.Location = new System.Drawing.Point(74, 156);
            this.cb_Tienda.Name = "cb_Tienda";
            this.cb_Tienda.Size = new System.Drawing.Size(238, 21);
            this.cb_Tienda.TabIndex = 3;
            this.cb_Tienda.ValueMember = "codigoTienda";
            // 
            // TiendaBindingSource
            // 
            this.TiendaBindingSource.DataMember = "Tienda";
            this.TiendaBindingSource.DataSource = this.tiendaDataSet;
            // 
            // tiendaDataSet
            // 
            this.tiendaDataSet.DataSetName = "TiendaDataSet";
            this.tiendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // cb_Cliente
            // 
            this.cb_Cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.EncabezadoFacturaBindingSource, "idCliente", true));
            this.cb_Cliente.DataSource = this.ClienteBindingSource;
            this.cb_Cliente.DisplayMember = "idCliente";
            this.cb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Cliente.FormattingEnabled = true;
            this.cb_Cliente.Location = new System.Drawing.Point(74, 117);
            this.cb_Cliente.Name = "cb_Cliente";
            this.cb_Cliente.Size = new System.Drawing.Size(238, 21);
            this.cb_Cliente.TabIndex = 2;
            this.cb_Cliente.ValueMember = "idCliente";
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataMember = "ClienteVirtual";
            this.ClienteBindingSource.DataSource = this.clientesDataSet;
            // 
            // clientesDataSet
            // 
            this.clientesDataSet.DataSetName = "ClientesDataSet";
            this.clientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_RTN
            // 
            this.tb_RTN.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EncabezadoFacturaBindingSource, "RTN", true));
            this.tb_RTN.Location = new System.Drawing.Point(74, 77);
            this.tb_RTN.Name = "tb_RTN";
            this.tb_RTN.Size = new System.Drawing.Size(238, 20);
            this.tb_RTN.TabIndex = 1;
            // 
            // tb_direccion
            // 
            this.tb_direccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.EncabezadoFacturaBindingSource, "Direccion", true));
            this.tb_direccion.Location = new System.Drawing.Point(74, 37);
            this.tb_direccion.Name = "tb_direccion";
            this.tb_direccion.Size = new System.Drawing.Size(238, 20);
            this.tb_direccion.TabIndex = 0;
            // 
            // gb_Detalle
            // 
            this.gb_Detalle.Controls.Add(this.label6);
            this.gb_Detalle.Controls.Add(this.label5);
            this.gb_Detalle.Controls.Add(this.tb_Cantidad);
            this.gb_Detalle.Controls.Add(this.cb_Producto);
            this.gb_Detalle.Enabled = false;
            this.gb_Detalle.Location = new System.Drawing.Point(336, 270);
            this.gb_Detalle.Name = "gb_Detalle";
            this.gb_Detalle.Size = new System.Drawing.Size(336, 206);
            this.gb_Detalle.TabIndex = 26;
            this.gb_Detalle.TabStop = false;
            this.gb_Detalle.Text = "Detalle de Factura";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Cantidad";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Producto:";
            // 
            // tb_Cantidad
            // 
            this.tb_Cantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DetalleFacturaBindingSource, "cantidadProducto", true));
            this.tb_Cantidad.Location = new System.Drawing.Point(74, 90);
            this.tb_Cantidad.Name = "tb_Cantidad";
            this.tb_Cantidad.Size = new System.Drawing.Size(238, 20);
            this.tb_Cantidad.TabIndex = 8;
            // 
            // cb_Producto
            // 
            this.cb_Producto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.DetalleFacturaBindingSource, "idProducto", true));
            this.cb_Producto.DataSource = this.ProductoBindingSource;
            this.cb_Producto.DisplayMember = "nombreProducto";
            this.cb_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Producto.FormattingEnabled = true;
            this.cb_Producto.Location = new System.Drawing.Point(74, 45);
            this.cb_Producto.Name = "cb_Producto";
            this.cb_Producto.Size = new System.Drawing.Size(238, 21);
            this.cb_Producto.TabIndex = 8;
            this.cb_Producto.ValueMember = "idProducto";
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataMember = "Producto";
            this.ProductoBindingSource.DataSource = this.productosDataSet;
            // 
            // productosDataSet
            // 
            this.productosDataSet.DataSetName = "ProductosDataSet";
            this.productosDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteVirtualTableAdapter
            // 
            this.clienteVirtualTableAdapter.ClearBeforeFill = true;
            // 
            // tiendaTableAdapter
            // 
            this.tiendaTableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // textBox4
            // 
            this.textBox4.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DetalleFacturaBindingSource, "isv", true));
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(711, 315);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(123, 20);
            this.textBox4.TabIndex = 27;
            // 
            // textBox5
            // 
            this.textBox5.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.DetalleFacturaBindingSource, "Total", true));
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(718, 363);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(118, 20);
            this.textBox5.TabIndex = 28;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(678, 318);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(27, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "ISV:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(678, 367);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(34, 13);
            this.label8.TabIndex = 30;
            this.label8.Text = "Total:";
            // 
            // FacturasFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(848, 488);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.gb_Detalle);
            this.Controls.Add(this.gb_EncabezadoFactura);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "FacturasFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturas";
            this.Load += new System.EventHandler(this.FacturasFrm_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncabezadoFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gb_EncabezadoFactura.ResumeLayout(false);
            this.gb_EncabezadoFactura.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).EndInit();
            this.gb_Detalle.ResumeLayout(false);
            this.gb_Detalle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btn_Eliminar;
        private System.Windows.Forms.ToolStripButton btn_Recargar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tb_BuscarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource DetalleFacturaBindingSource;
        private DataSet.FacturasDataSet facturasDataSet;
        private DataSet.FacturasDataSetTableAdapters.DetalleFacturaTableAdapter detalleFacturaTableAdapter;
        private System.Windows.Forms.BindingSource EncabezadoFacturaBindingSource;
        private DataSet.FacturasDataSetTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn noFacturaDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTiendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox gb_EncabezadoFactura;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Tienda;
        private System.Windows.Forms.ComboBox cb_Cliente;
        private System.Windows.Forms.TextBox tb_RTN;
        private System.Windows.Forms.TextBox tb_direccion;
        private System.Windows.Forms.GroupBox gb_Detalle;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Cantidad;
        private System.Windows.Forms.ComboBox cb_Producto;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private DataSet.ClientesDataSet clientesDataSet;
        private DataSet.ClientesDataSetTableAdapters.ClienteVirtualTableAdapter clienteVirtualTableAdapter;
        private System.Windows.Forms.BindingSource TiendaBindingSource;
        private DataSet.TiendaDataSet tiendaDataSet;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
        private DataSet.TiendaDataSetTableAdapters.TiendaTableAdapter tiendaTableAdapter;
        private DataSet.ProductosDataSet productosDataSet;
        private DataSet.ProductosDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isvDataGridViewTextBoxColumn;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}