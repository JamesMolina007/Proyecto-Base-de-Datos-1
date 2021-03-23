namespace ProyectoDB
{
    partial class InventarioFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(InventarioFrm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.btn_Recargar = new System.Windows.Forms.ToolStripButton();
            this.InventarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDataSet = new ProyectoDB.DataSet.InventarioDataSet();
            this.inventarioTableAdapter = new ProyectoDB.DataSet.InventarioDataSetTableAdapters.InventarioTableAdapter();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoAlmacenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTiendaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_Producto = new System.Windows.Forms.ComboBox();
            this.cb_Almacen = new System.Windows.Forms.ComboBox();
            this.cb_Tienda = new System.Windows.Forms.ComboBox();
            this.tb_Cantidad = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productosDataSet = new ProyectoDB.DataSet.ProductosDataSet();
            this.productoTableAdapter = new ProyectoDB.DataSet.ProductosDataSetTableAdapters.ProductoTableAdapter();
            this.AlmacenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.almacenDataSet = new ProyectoDB.DataSet.AlmacenDataSet();
            this.almacenTableAdapter = new ProyectoDB.DataSet.AlmacenDataSetTableAdapters.AlmacenTableAdapter();
            this.TiendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tiendaDataSet = new ProyectoDB.DataSet.TiendaDataSet();
            this.tiendaTableAdapter = new ProyectoDB.DataSet.TiendaDataSetTableAdapters.TiendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlmacenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProductoDataGridViewTextBoxColumn,
            this.codigoAlmacenDataGridViewTextBoxColumn,
            this.codigoTiendaDataGridViewTextBoxColumn,
            this.cantidadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.InventarioBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(530, 320);
            this.dataGridView1.TabIndex = 0;
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Nuevo,
            this.btn_Guardar,
            this.btn_Eliminar,
            this.btn_Recargar});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(782, 54);
            this.toolStripMenu.TabIndex = 22;
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
            // InventarioBindingSource
            // 
            this.InventarioBindingSource.DataMember = "Inventario";
            this.InventarioBindingSource.DataSource = this.inventarioDataSet;
            // 
            // inventarioDataSet
            // 
            this.inventarioDataSet.DataSetName = "InventarioDataSet";
            this.inventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inventarioTableAdapter
            // 
            this.inventarioTableAdapter.ClearBeforeFill = true;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "ID Producto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoAlmacenDataGridViewTextBoxColumn
            // 
            this.codigoAlmacenDataGridViewTextBoxColumn.DataPropertyName = "codigoAlmacen";
            this.codigoAlmacenDataGridViewTextBoxColumn.HeaderText = "Código Almacen";
            this.codigoAlmacenDataGridViewTextBoxColumn.Name = "codigoAlmacenDataGridViewTextBoxColumn";
            this.codigoAlmacenDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoAlmacenDataGridViewTextBoxColumn.Width = 130;
            // 
            // codigoTiendaDataGridViewTextBoxColumn
            // 
            this.codigoTiendaDataGridViewTextBoxColumn.DataPropertyName = "codigoTienda";
            this.codigoTiendaDataGridViewTextBoxColumn.HeaderText = "Código Tienda";
            this.codigoTiendaDataGridViewTextBoxColumn.Name = "codigoTiendaDataGridViewTextBoxColumn";
            this.codigoTiendaDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoTiendaDataGridViewTextBoxColumn.Width = 130;
            // 
            // cantidadDataGridViewTextBoxColumn
            // 
            this.cantidadDataGridViewTextBoxColumn.DataPropertyName = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadDataGridViewTextBoxColumn.Name = "cantidadDataGridViewTextBoxColumn";
            this.cantidadDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tb_Cantidad);
            this.groupBox1.Controls.Add(this.cb_Tienda);
            this.groupBox1.Controls.Add(this.cb_Almacen);
            this.groupBox1.Controls.Add(this.cb_Producto);
            this.groupBox1.Location = new System.Drawing.Point(564, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 320);
            this.groupBox1.TabIndex = 23;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos de lnventario:";
            // 
            // cb_Producto
            // 
            this.cb_Producto.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.InventarioBindingSource, "idProducto", true));
            this.cb_Producto.DataSource = this.ProductoBindingSource;
            this.cb_Producto.DisplayMember = "nombreProducto";
            this.cb_Producto.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Producto.FormattingEnabled = true;
            this.cb_Producto.Location = new System.Drawing.Point(7, 61);
            this.cb_Producto.Name = "cb_Producto";
            this.cb_Producto.Size = new System.Drawing.Size(187, 21);
            this.cb_Producto.TabIndex = 0;
            this.cb_Producto.ValueMember = "idProducto";
            // 
            // cb_Almacen
            // 
            this.cb_Almacen.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.InventarioBindingSource, "codigoAlmacen", true));
            this.cb_Almacen.DataSource = this.AlmacenBindingSource;
            this.cb_Almacen.DisplayMember = "codigoAlmacen";
            this.cb_Almacen.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Almacen.FormattingEnabled = true;
            this.cb_Almacen.Location = new System.Drawing.Point(7, 125);
            this.cb_Almacen.Name = "cb_Almacen";
            this.cb_Almacen.Size = new System.Drawing.Size(187, 21);
            this.cb_Almacen.TabIndex = 1;
            this.cb_Almacen.ValueMember = "codigoAlmacen";
            // 
            // cb_Tienda
            // 
            this.cb_Tienda.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.InventarioBindingSource, "codigoTienda", true));
            this.cb_Tienda.DataSource = this.TiendaBindingSource;
            this.cb_Tienda.DisplayMember = "codigoTienda";
            this.cb_Tienda.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tienda.FormattingEnabled = true;
            this.cb_Tienda.Location = new System.Drawing.Point(7, 191);
            this.cb_Tienda.Name = "cb_Tienda";
            this.cb_Tienda.Size = new System.Drawing.Size(187, 21);
            this.cb_Tienda.TabIndex = 2;
            this.cb_Tienda.ValueMember = "codigoTienda";
            // 
            // tb_Cantidad
            // 
            this.tb_Cantidad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.InventarioBindingSource, "Cantidad", true));
            this.tb_Cantidad.Location = new System.Drawing.Point(7, 269);
            this.tb_Cantidad.Name = "tb_Cantidad";
            this.tb_Cantidad.Size = new System.Drawing.Size(187, 20);
            this.tb_Cantidad.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "ID Producto:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 109);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Código Almacen:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Código Tienda:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 252);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cantidad:";
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
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
            // 
            // AlmacenBindingSource
            // 
            this.AlmacenBindingSource.DataMember = "Almacen";
            this.AlmacenBindingSource.DataSource = this.almacenDataSet;
            // 
            // almacenDataSet
            // 
            this.almacenDataSet.DataSetName = "AlmacenDataSet";
            this.almacenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // almacenTableAdapter
            // 
            this.almacenTableAdapter.ClearBeforeFill = true;
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
            // tiendaTableAdapter
            // 
            this.tiendaTableAdapter.ClearBeforeFill = true;
            // 
            // InventarioFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 402);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "InventarioFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.InventarioFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.InventarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productosDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlmacenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.almacenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tiendaDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btn_Nuevo;
        private System.Windows.Forms.ToolStripButton btn_Guardar;
        private System.Windows.Forms.ToolStripButton btn_Eliminar;
        private System.Windows.Forms.ToolStripButton btn_Recargar;
        private System.Windows.Forms.BindingSource InventarioBindingSource;
        private DataSet.InventarioDataSet inventarioDataSet;
        private DataSet.InventarioDataSetTableAdapters.InventarioTableAdapter inventarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoAlmacenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTiendaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Cantidad;
        private System.Windows.Forms.ComboBox cb_Tienda;
        private System.Windows.Forms.ComboBox cb_Almacen;
        private System.Windows.Forms.ComboBox cb_Producto;
        private System.Windows.Forms.BindingSource ProductoBindingSource;
        private DataSet.ProductosDataSet productosDataSet;
        private DataSet.ProductosDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.BindingSource AlmacenBindingSource;
        private DataSet.AlmacenDataSet almacenDataSet;
        private DataSet.AlmacenDataSetTableAdapters.AlmacenTableAdapter almacenTableAdapter;
        private System.Windows.Forms.BindingSource TiendaBindingSource;
        private DataSet.TiendaDataSet tiendaDataSet;
        private DataSet.TiendaDataSetTableAdapters.TiendaTableAdapter tiendaTableAdapter;
    }
}