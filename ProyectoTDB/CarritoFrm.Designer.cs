namespace ProyectoDB
{
    partial class CarritoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarritoFrm));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.btn_Recargar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tb_BuscarCliente = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.CarritoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carritoDataSet = new ProyectoDB.DataSet.CarritoDataSet();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carritoTableAdapter = new ProyectoDB.DataSet.CarritoDataSetTableAdapters.CarritoTableAdapter();
            this.productoTableAdapter = new ProyectoDB.DataSet.CarritoDataSetTableAdapters.ProductoTableAdapter();
            this.clienteVirtualTableAdapter = new ProyectoDB.DataSet.CarritoDataSetTableAdapters.ClienteVirtualTableAdapter();
            this.gb_Datos = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.TiendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaDataSet = new ProyectoDB.DataSet.TiendaDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_idProducto = new System.Windows.Forms.ComboBox();
            this.cb_idCliente = new System.Windows.Forms.ComboBox();
            this.tb_Cantidad = new System.Windows.Forms.TextBox();
            this.tiendaTableAdapter = new ProyectoDB.DataSet.TiendaDataSetTableAdapters.TiendaTableAdapter();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProductoCarritoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tiendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carritoDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            this.gb_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Nuevo,
            this.btn_Guardar,
            this.btn_Eliminar,
            this.btn_Recargar,
            this.toolStripLabel1,
            this.tb_BuscarCliente});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(748, 54);
            this.toolStripMenu.TabIndex = 21;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // btn_Nuevo
            // 
            this.btn_Nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_Nuevo.Image")));
            this.btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Nuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Nuevo.Name = "btn_Nuevo";
            this.btn_Nuevo.Size = new System.Drawing.Size(46, 51);
            this.btn_Nuevo.Text = "Nuevo";
            this.btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btn_Nuevo.Click += new System.EventHandler(this.btn_Nuevo_Click);
            // 
            // btn_Guardar
            // 
            this.btn_Guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Guardar.Image")));
            this.btn_Guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Guardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Guardar.Name = "btn_Guardar";
            this.btn_Guardar.Size = new System.Drawing.Size(53, 51);
            this.btn_Guardar.Text = "Guardar";
            this.btn_Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btn_Guardar.Click += new System.EventHandler(this.btn_Guardar_Click);
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
            this.idProductoDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.cantidadProductoCarritoDataGridViewTextBoxColumn,
            this.tiendaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.CarritoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 58);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(474, 272);
            this.dataGridView1.TabIndex = 22;
            // 
            // CarritoBindingSource
            // 
            this.CarritoBindingSource.DataMember = "Carrito";
            this.CarritoBindingSource.DataSource = this.carritoDataSet;
            this.CarritoBindingSource.PositionChanged += new System.EventHandler(this.CarritoBindingSource_PositionChanged);
            // 
            // carritoDataSet
            // 
            this.carritoDataSet.DataSetName = "CarritoDataSet";
            this.carritoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn1,
            this.nombreProductoDataGridViewTextBoxColumn,
            this.descripcionDataGridViewTextBoxColumn,
            this.modeloDataGridViewTextBoxColumn,
            this.tipoProductoDataGridViewTextBoxColumn,
            this.fabricanteDataGridViewTextBoxColumn,
            this.nombreCategoriaDataGridViewTextBoxColumn,
            this.precioDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ProductoBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(13, 347);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(628, 85);
            this.dataGridView2.TabIndex = 23;
            // 
            // idProductoDataGridViewTextBoxColumn1
            // 
            this.idProductoDataGridViewTextBoxColumn1.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn1.HeaderText = "ID";
            this.idProductoDataGridViewTextBoxColumn1.Name = "idProductoDataGridViewTextBoxColumn1";
            this.idProductoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idProductoDataGridViewTextBoxColumn1.Width = 50;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "nombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreProductoDataGridViewTextBoxColumn.Width = 130;
            // 
            // descripcionDataGridViewTextBoxColumn
            // 
            this.descripcionDataGridViewTextBoxColumn.DataPropertyName = "Descripcion";
            this.descripcionDataGridViewTextBoxColumn.HeaderText = "Descripción";
            this.descripcionDataGridViewTextBoxColumn.Name = "descripcionDataGridViewTextBoxColumn";
            this.descripcionDataGridViewTextBoxColumn.ReadOnly = true;
            this.descripcionDataGridViewTextBoxColumn.Width = 150;
            // 
            // modeloDataGridViewTextBoxColumn
            // 
            this.modeloDataGridViewTextBoxColumn.DataPropertyName = "Modelo";
            this.modeloDataGridViewTextBoxColumn.HeaderText = "Modelo";
            this.modeloDataGridViewTextBoxColumn.Name = "modeloDataGridViewTextBoxColumn";
            this.modeloDataGridViewTextBoxColumn.ReadOnly = true;
            this.modeloDataGridViewTextBoxColumn.Visible = false;
            // 
            // tipoProductoDataGridViewTextBoxColumn
            // 
            this.tipoProductoDataGridViewTextBoxColumn.DataPropertyName = "tipoProducto";
            this.tipoProductoDataGridViewTextBoxColumn.HeaderText = "tipoProducto";
            this.tipoProductoDataGridViewTextBoxColumn.Name = "tipoProductoDataGridViewTextBoxColumn";
            this.tipoProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoProductoDataGridViewTextBoxColumn.Visible = false;
            // 
            // fabricanteDataGridViewTextBoxColumn
            // 
            this.fabricanteDataGridViewTextBoxColumn.DataPropertyName = "fabricante";
            this.fabricanteDataGridViewTextBoxColumn.HeaderText = "fabricante";
            this.fabricanteDataGridViewTextBoxColumn.Name = "fabricanteDataGridViewTextBoxColumn";
            this.fabricanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.fabricanteDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreCategoriaDataGridViewTextBoxColumn
            // 
            this.nombreCategoriaDataGridViewTextBoxColumn.DataPropertyName = "nombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.nombreCategoriaDataGridViewTextBoxColumn.Name = "nombreCategoriaDataGridViewTextBoxColumn";
            this.nombreCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCategoriaDataGridViewTextBoxColumn.Width = 130;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ProductoBindingSource
            // 
            this.ProductoBindingSource.DataMember = "Producto";
            this.ProductoBindingSource.DataSource = this.carritoDataSet;
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataMember = "ClienteVirtual";
            this.ClienteBindingSource.DataSource = this.carritoDataSet;
            // 
            // carritoTableAdapter
            // 
            this.carritoTableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // clienteVirtualTableAdapter
            // 
            this.clienteVirtualTableAdapter.ClearBeforeFill = true;
            // 
            // gb_Datos
            // 
            this.gb_Datos.Controls.Add(this.label4);
            this.gb_Datos.Controls.Add(this.comboBox1);
            this.gb_Datos.Controls.Add(this.label3);
            this.gb_Datos.Controls.Add(this.label2);
            this.gb_Datos.Controls.Add(this.label1);
            this.gb_Datos.Controls.Add(this.cb_idProducto);
            this.gb_Datos.Controls.Add(this.cb_idCliente);
            this.gb_Datos.Controls.Add(this.tb_Cantidad);
            this.gb_Datos.Location = new System.Drawing.Point(493, 58);
            this.gb_Datos.Name = "gb_Datos";
            this.gb_Datos.Size = new System.Drawing.Size(241, 272);
            this.gb_Datos.TabIndex = 24;
            this.gb_Datos.TabStop = false;
            this.gb_Datos.Text = "Datos del Carrito:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Tienda:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CarritoBindingSource, "Tienda", true));
            this.comboBox1.DataSource = this.TiendaBindingSource;
            this.comboBox1.DisplayMember = "codigoTienda";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(17, 245);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(195, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.ValueMember = "codigoTienda";
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(83, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "ID Del Producto";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ID Del Cliente:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(110, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cantidad de Producto";
            // 
            // cb_idProducto
            // 
            this.cb_idProducto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CarritoBindingSource, "idProducto", true));
            this.cb_idProducto.DataSource = this.ProductoBindingSource;
            this.cb_idProducto.DisplayMember = "idProducto";
            this.cb_idProducto.FormattingEnabled = true;
            this.cb_idProducto.Location = new System.Drawing.Point(17, 185);
            this.cb_idProducto.Name = "cb_idProducto";
            this.cb_idProducto.Size = new System.Drawing.Size(195, 21);
            this.cb_idProducto.TabIndex = 2;
            this.cb_idProducto.ValueMember = "idProducto";
            // 
            // cb_idCliente
            // 
            this.cb_idCliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.CarritoBindingSource, "idCliente", true));
            this.cb_idCliente.DataSource = this.ClienteBindingSource;
            this.cb_idCliente.DisplayMember = "idCliente";
            this.cb_idCliente.FormattingEnabled = true;
            this.cb_idCliente.Location = new System.Drawing.Point(17, 119);
            this.cb_idCliente.Name = "cb_idCliente";
            this.cb_idCliente.Size = new System.Drawing.Size(195, 21);
            this.cb_idCliente.TabIndex = 1;
            this.cb_idCliente.ValueMember = "idCliente";
            // 
            // tb_Cantidad
            // 
            this.tb_Cantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.CarritoBindingSource, "cantidadProductoCarrito", true));
            this.tb_Cantidad.Location = new System.Drawing.Point(17, 52);
            this.tb_Cantidad.Name = "tb_Cantidad";
            this.tb_Cantidad.Size = new System.Drawing.Size(195, 20);
            this.tb_Cantidad.TabIndex = 0;
            // 
            // tiendaTableAdapter
            // 
            this.tiendaTableAdapter.ClearBeforeFill = true;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "ID Producto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "ID Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cantidadProductoCarritoDataGridViewTextBoxColumn
            // 
            this.cantidadProductoCarritoDataGridViewTextBoxColumn.DataPropertyName = "cantidadProductoCarrito";
            this.cantidadProductoCarritoDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadProductoCarritoDataGridViewTextBoxColumn.Name = "cantidadProductoCarritoDataGridViewTextBoxColumn";
            this.cantidadProductoCarritoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tiendaDataGridViewTextBoxColumn
            // 
            this.tiendaDataGridViewTextBoxColumn.DataPropertyName = "Tienda";
            this.tiendaDataGridViewTextBoxColumn.HeaderText = "Tienda";
            this.tiendaDataGridViewTextBoxColumn.Name = "tiendaDataGridViewTextBoxColumn";
            this.tiendaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // CarritoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(748, 444);
            this.Controls.Add(this.gb_Datos);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "CarritoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Carrito";
            this.Load += new System.EventHandler(this.CarritoFrm_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carritoDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            this.gb_Datos.ResumeLayout(false);
            this.gb_Datos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btn_Nuevo;
        private System.Windows.Forms.ToolStripButton btn_Guardar;
        private System.Windows.Forms.ToolStripButton btn_Eliminar;
        private System.Windows.Forms.ToolStripButton btn_Recargar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tb_BuscarCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.BindingSource CarritoBindingSource;
        private DataSet.CarritoDataSet carritoDataSet;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private DataSet.CarritoDataSetTableAdapters.CarritoTableAdapter carritoTableAdapter;
        private DataSet.CarritoDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private DataSet.CarritoDataSetTableAdapters.ClienteVirtualTableAdapter clienteVirtualTableAdapter;
        private System.Windows.Forms.GroupBox gb_Datos;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_idProducto;
        private System.Windows.Forms.ComboBox cb_idCliente;
        private System.Windows.Forms.TextBox tb_Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource TiendaBindingSource;
        private DataSet.TiendaDataSet tiendaDataSet;
        private DataSet.TiendaDataSetTableAdapters.TiendaTableAdapter tiendaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProductoCarritoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tiendaDataGridViewTextBoxColumn;
    }
}