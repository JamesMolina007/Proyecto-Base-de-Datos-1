namespace ProyectoDB
{
    partial class CarritoClienteFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarritoClienteFrm));
            this.ProductosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carritoClienteDataSet = new ProyectoDB.DataSet.CarritoClienteDataSet();
            this.CarritoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.carritoTableAdapter = new ProyectoDB.DataSet.CarritoClienteDataSetTableAdapters.CarritoTableAdapter();
            this.productoTableAdapter = new ProyectoDB.DataSet.CarritoClienteDataSetTableAdapters.ProductoTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProductoCarritoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idProductoDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.modeloDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fabricanteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreCategoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gb_Producto = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Categoria = new System.Windows.Forms.TextBox();
            this.tb_Precio = new System.Windows.Forms.TextBox();
            this.tb_Fabricante = new System.Windows.Forms.TextBox();
            this.tb_Tipo = new System.Windows.Forms.TextBox();
            this.tb_Modelo = new System.Windows.Forms.TextBox();
            this.ne_Cantidad = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Comprar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Total = new System.Windows.Forms.TextBox();
            this.tb_ISV = new System.Windows.Forms.TextBox();
            this.tb_subTotal = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.carritoClienteDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.gb_Producto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ne_Cantidad)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ProductosBindingSource
            // 
            this.ProductosBindingSource.DataMember = "Producto";
            this.ProductosBindingSource.DataSource = this.carritoClienteDataSet;
            // 
            // carritoClienteDataSet
            // 
            this.carritoClienteDataSet.DataSetName = "CarritoClienteDataSet";
            this.carritoClienteDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // CarritoBindingSource
            // 
            this.CarritoBindingSource.DataMember = "Carrito";
            this.CarritoBindingSource.DataSource = this.carritoClienteDataSet;
            // 
            // carritoTableAdapter
            // 
            this.carritoTableAdapter.ClearBeforeFill = true;
            // 
            // productoTableAdapter
            // 
            this.productoTableAdapter.ClearBeforeFill = true;
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
            this.cantidadProductoCarritoDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.CarritoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(573, 43);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(373, 282);
            this.dataGridView1.TabIndex = 0;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "ID Producto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProductoDataGridViewTextBoxColumn.Width = 150;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // cantidadProductoCarritoDataGridViewTextBoxColumn
            // 
            this.cantidadProductoCarritoDataGridViewTextBoxColumn.DataPropertyName = "cantidadProductoCarrito";
            this.cantidadProductoCarritoDataGridViewTextBoxColumn.HeaderText = "Cantidad de Producto";
            this.cantidadProductoCarritoDataGridViewTextBoxColumn.Name = "cantidadProductoCarritoDataGridViewTextBoxColumn";
            this.cantidadProductoCarritoDataGridViewTextBoxColumn.ReadOnly = true;
            this.cantidadProductoCarritoDataGridViewTextBoxColumn.Width = 150;
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
            this.precioDataGridViewTextBoxColumn,
            this.nombreCategoriaDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.ProductosBindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(12, 43);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.Size = new System.Drawing.Size(387, 278);
            this.dataGridView2.TabIndex = 1;
            // 
            // idProductoDataGridViewTextBoxColumn1
            // 
            this.idProductoDataGridViewTextBoxColumn1.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn1.HeaderText = "ID Producto";
            this.idProductoDataGridViewTextBoxColumn1.Name = "idProductoDataGridViewTextBoxColumn1";
            this.idProductoDataGridViewTextBoxColumn1.ReadOnly = true;
            this.idProductoDataGridViewTextBoxColumn1.Width = 70;
            // 
            // nombreProductoDataGridViewTextBoxColumn
            // 
            this.nombreProductoDataGridViewTextBoxColumn.DataPropertyName = "nombreProducto";
            this.nombreProductoDataGridViewTextBoxColumn.HeaderText = "Producto";
            this.nombreProductoDataGridViewTextBoxColumn.Name = "nombreProductoDataGridViewTextBoxColumn";
            this.nombreProductoDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.tipoProductoDataGridViewTextBoxColumn.HeaderText = "Tipo";
            this.tipoProductoDataGridViewTextBoxColumn.Name = "tipoProductoDataGridViewTextBoxColumn";
            this.tipoProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoProductoDataGridViewTextBoxColumn.Visible = false;
            // 
            // fabricanteDataGridViewTextBoxColumn
            // 
            this.fabricanteDataGridViewTextBoxColumn.DataPropertyName = "fabricante";
            this.fabricanteDataGridViewTextBoxColumn.HeaderText = "Fabricante";
            this.fabricanteDataGridViewTextBoxColumn.Name = "fabricanteDataGridViewTextBoxColumn";
            this.fabricanteDataGridViewTextBoxColumn.ReadOnly = true;
            this.fabricanteDataGridViewTextBoxColumn.Visible = false;
            // 
            // precioDataGridViewTextBoxColumn
            // 
            this.precioDataGridViewTextBoxColumn.DataPropertyName = "Precio";
            this.precioDataGridViewTextBoxColumn.HeaderText = "Precio";
            this.precioDataGridViewTextBoxColumn.Name = "precioDataGridViewTextBoxColumn";
            this.precioDataGridViewTextBoxColumn.ReadOnly = true;
            this.precioDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreCategoriaDataGridViewTextBoxColumn
            // 
            this.nombreCategoriaDataGridViewTextBoxColumn.DataPropertyName = "nombreCategoria";
            this.nombreCategoriaDataGridViewTextBoxColumn.HeaderText = "Categoría";
            this.nombreCategoriaDataGridViewTextBoxColumn.Name = "nombreCategoriaDataGridViewTextBoxColumn";
            this.nombreCategoriaDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreCategoriaDataGridViewTextBoxColumn.Visible = false;
            // 
            // gb_Producto
            // 
            this.gb_Producto.Controls.Add(this.label9);
            this.gb_Producto.Controls.Add(this.label8);
            this.gb_Producto.Controls.Add(this.label7);
            this.gb_Producto.Controls.Add(this.label6);
            this.gb_Producto.Controls.Add(this.label5);
            this.gb_Producto.Controls.Add(this.tb_Categoria);
            this.gb_Producto.Controls.Add(this.tb_Precio);
            this.gb_Producto.Controls.Add(this.tb_Fabricante);
            this.gb_Producto.Controls.Add(this.tb_Tipo);
            this.gb_Producto.Controls.Add(this.tb_Modelo);
            this.gb_Producto.Enabled = false;
            this.gb_Producto.Location = new System.Drawing.Point(22, 331);
            this.gb_Producto.Name = "gb_Producto";
            this.gb_Producto.Size = new System.Drawing.Size(377, 229);
            this.gb_Producto.TabIndex = 3;
            this.gb_Producto.TabStop = false;
            this.gb_Producto.Text = "Datos del Producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 181);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 14;
            this.label9.Text = "Categoría:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 13;
            this.label8.Text = "Precio:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 103);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 12;
            this.label7.Text = "Fabricante:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 69);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(31, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Tipo:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 34);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Modelo:";
            // 
            // tb_Categoria
            // 
            this.tb_Categoria.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductosBindingSource, "nombreCategoria", true));
            this.tb_Categoria.Location = new System.Drawing.Point(89, 177);
            this.tb_Categoria.Name = "tb_Categoria";
            this.tb_Categoria.Size = new System.Drawing.Size(217, 20);
            this.tb_Categoria.TabIndex = 7;
            // 
            // tb_Precio
            // 
            this.tb_Precio.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductosBindingSource, "Precio", true));
            this.tb_Precio.Location = new System.Drawing.Point(89, 141);
            this.tb_Precio.Name = "tb_Precio";
            this.tb_Precio.Size = new System.Drawing.Size(217, 20);
            this.tb_Precio.TabIndex = 6;
            // 
            // tb_Fabricante
            // 
            this.tb_Fabricante.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductosBindingSource, "fabricante", true));
            this.tb_Fabricante.Location = new System.Drawing.Point(89, 101);
            this.tb_Fabricante.Name = "tb_Fabricante";
            this.tb_Fabricante.Size = new System.Drawing.Size(217, 20);
            this.tb_Fabricante.TabIndex = 5;
            // 
            // tb_Tipo
            // 
            this.tb_Tipo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductosBindingSource, "tipoProducto", true));
            this.tb_Tipo.Location = new System.Drawing.Point(89, 66);
            this.tb_Tipo.Name = "tb_Tipo";
            this.tb_Tipo.Size = new System.Drawing.Size(217, 20);
            this.tb_Tipo.TabIndex = 4;
            // 
            // tb_Modelo
            // 
            this.tb_Modelo.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ProductosBindingSource, "Modelo", true));
            this.tb_Modelo.Location = new System.Drawing.Point(89, 31);
            this.tb_Modelo.Name = "tb_Modelo";
            this.tb_Modelo.Size = new System.Drawing.Size(217, 20);
            this.tb_Modelo.TabIndex = 3;
            // 
            // ne_Cantidad
            // 
            this.ne_Cantidad.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.CarritoBindingSource, "cantidadProductoCarrito", true));
            this.ne_Cantidad.Location = new System.Drawing.Point(420, 123);
            this.ne_Cantidad.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.ne_Cantidad.Name = "ne_Cantidad";
            this.ne_Cantidad.Size = new System.Drawing.Size(135, 20);
            this.ne_Cantidad.TabIndex = 4;
            this.ne_Cantidad.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(420, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Cantidad:";
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(420, 273);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(132, 52);
            this.btn_Eliminar.TabIndex = 7;
            this.btn_Eliminar.Text = "     &Eliminar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(420, 212);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(132, 52);
            this.btn_Agregar.TabIndex = 8;
            this.btn_Agregar.Text = "     &Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Comprar
            // 
            this.btn_Comprar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Comprar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Comprar.Image")));
            this.btn_Comprar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Comprar.Location = new System.Drawing.Point(408, 43);
            this.btn_Comprar.Name = "btn_Comprar";
            this.btn_Comprar.Size = new System.Drawing.Size(159, 52);
            this.btn_Comprar.TabIndex = 9;
            this.btn_Comprar.Text = "     &Comprar";
            this.btn_Comprar.UseVisualStyleBackColor = true;
            this.btn_Comprar.Click += new System.EventHandler(this.btn_Comprar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Productos";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(573, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(37, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Carrito";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_Total);
            this.groupBox1.Controls.Add(this.tb_ISV);
            this.groupBox1.Controls.Add(this.tb_subTotal);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(573, 343);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 217);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Costos:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(18, 134);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 5;
            this.label11.Text = "Total:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(18, 89);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 4;
            this.label10.Text = "ISV:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(18, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "SubTotal:";
            // 
            // tb_Total
            // 
            this.tb_Total.Location = new System.Drawing.Point(77, 131);
            this.tb_Total.Name = "tb_Total";
            this.tb_Total.Size = new System.Drawing.Size(266, 20);
            this.tb_Total.TabIndex = 2;
            // 
            // tb_ISV
            // 
            this.tb_ISV.Location = new System.Drawing.Point(77, 89);
            this.tb_ISV.Name = "tb_ISV";
            this.tb_ISV.Size = new System.Drawing.Size(266, 20);
            this.tb_ISV.TabIndex = 1;
            // 
            // tb_subTotal
            // 
            this.tb_subTotal.Location = new System.Drawing.Point(77, 47);
            this.tb_subTotal.Name = "tb_subTotal";
            this.tb_subTotal.Size = new System.Drawing.Size(266, 20);
            this.tb_subTotal.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(420, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 52);
            this.button1.TabIndex = 13;
            this.button1.Text = "     &Actualizar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CarritoClienteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(956, 572);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_Comprar);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.btn_Eliminar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ne_Cantidad);
            this.Controls.Add(this.gb_Producto);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Name = "CarritoClienteFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Mi Carrito";
            this.Load += new System.EventHandler(this.CarritoClienteFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.carritoClienteDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CarritoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.gb_Producto.ResumeLayout(false);
            this.gb_Producto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ne_Cantidad)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ProductosBindingSource;
        private System.Windows.Forms.BindingSource CarritoBindingSource;
        private DataSet.CarritoClienteDataSet carritoClienteDataSet;
        private DataSet.CarritoClienteDataSetTableAdapters.CarritoTableAdapter carritoTableAdapter;
        private DataSet.CarritoClienteDataSetTableAdapters.ProductoTableAdapter productoTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProductoCarritoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.GroupBox gb_Producto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Categoria;
        private System.Windows.Forms.TextBox tb_Precio;
        private System.Windows.Forms.TextBox tb_Fabricante;
        private System.Windows.Forms.TextBox tb_Tipo;
        private System.Windows.Forms.TextBox tb_Modelo;
        private System.Windows.Forms.NumericUpDown ne_Cantidad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Comprar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn modeloDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fabricanteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreCategoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Total;
        private System.Windows.Forms.TextBox tb_ISV;
        private System.Windows.Forms.TextBox tb_subTotal;
        private System.Windows.Forms.Button button1;
    }
}