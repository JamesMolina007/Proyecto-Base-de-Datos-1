namespace ProyectoDB
{
    partial class OrdenesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrdenesFrm));
            this.OrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenDataSet = new ProyectoDB.DataSet.OrdenDataSet();
            this.EmpresaEnvíoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasDeEnvioDataSet = new ProyectoDB.DataSet.EmpresasDeEnvioDataSet();
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataSet = new ProyectoDB.DataSet.ClientesDataSet();
            this.ordenTableAdapter = new ProyectoDB.DataSet.OrdenDataSetTableAdapters.OrdenTableAdapter();
            this.empresaDeEnvioTableAdapter = new ProyectoDB.DataSet.EmpresasDeEnvioDataSetTableAdapters.EmpresaDeEnvioTableAdapter();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.btn_Recargar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tb_Buscar = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.gb_DatosOrden = new System.Windows.Forms.GroupBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.FacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasDataSet = new ProyectoDB.DataSet.FacturasDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.tb_NoSeguimiento = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cb_Estatus = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_EmpresaEnvio = new System.Windows.Forms.ComboBox();
            this.cb_Cliente = new System.Windows.Forms.ComboBox();
            this.tb_Direccion = new System.Windows.Forms.TextBox();
            this.tb_Remitente = new System.Windows.Forms.TextBox();
            this.clienteVirtualTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteVirtualTableAdapter();
            this.facturaTableAdapter = new ProyectoDB.DataSet.FacturasDataSetTableAdapters.FacturaTableAdapter();
            this.noFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOrdenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreRemitenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSeguimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresaEnvíoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDeEnvioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_DatosOrden.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // OrdenBindingSource
            // 
            this.OrdenBindingSource.DataMember = "Orden";
            this.OrdenBindingSource.DataSource = this.ordenDataSet;
            this.OrdenBindingSource.PositionChanged += new System.EventHandler(this.OrdenBindingSource_PositionChanged);
            // 
            // ordenDataSet
            // 
            this.ordenDataSet.DataSetName = "OrdenDataSet";
            this.ordenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // EmpresaEnvíoBindingSource
            // 
            this.EmpresaEnvíoBindingSource.DataMember = "EmpresaDeEnvio";
            this.EmpresaEnvíoBindingSource.DataSource = this.empresasDeEnvioDataSet;
            // 
            // empresasDeEnvioDataSet
            // 
            this.empresasDeEnvioDataSet.DataSetName = "EmpresasDeEnvioDataSet";
            this.empresasDeEnvioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // ordenTableAdapter
            // 
            this.ordenTableAdapter.ClearBeforeFill = true;
            // 
            // empresaDeEnvioTableAdapter
            // 
            this.empresaDeEnvioTableAdapter.ClearBeforeFill = true;
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
            this.tb_Buscar});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(1229, 54);
            this.toolStripMenu.TabIndex = 23;
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
            // tb_Buscar
            // 
            this.tb_Buscar.Name = "tb_Buscar";
            this.tb_Buscar.Size = new System.Drawing.Size(100, 54);
            this.tb_Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Buscar_KeyPress);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noFactura,
            this.noOrdenDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.nombreRemitenteDataGridViewTextBoxColumn,
            this.empresaEnvioDataGridViewTextBoxColumn,
            this.direccionEnvioDataGridViewTextBoxColumn,
            this.noSeguimientoDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.OrdenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 68);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(933, 366);
            this.dataGridView1.TabIndex = 24;
            // 
            // gb_DatosOrden
            // 
            this.gb_DatosOrden.Controls.Add(this.label7);
            this.gb_DatosOrden.Controls.Add(this.comboBox1);
            this.gb_DatosOrden.Controls.Add(this.label6);
            this.gb_DatosOrden.Controls.Add(this.tb_NoSeguimiento);
            this.gb_DatosOrden.Controls.Add(this.label5);
            this.gb_DatosOrden.Controls.Add(this.cb_Estatus);
            this.gb_DatosOrden.Controls.Add(this.label4);
            this.gb_DatosOrden.Controls.Add(this.label3);
            this.gb_DatosOrden.Controls.Add(this.label2);
            this.gb_DatosOrden.Controls.Add(this.label1);
            this.gb_DatosOrden.Controls.Add(this.cb_EmpresaEnvio);
            this.gb_DatosOrden.Controls.Add(this.cb_Cliente);
            this.gb_DatosOrden.Controls.Add(this.tb_Direccion);
            this.gb_DatosOrden.Controls.Add(this.tb_Remitente);
            this.gb_DatosOrden.Location = new System.Drawing.Point(968, 68);
            this.gb_DatosOrden.Name = "gb_DatosOrden";
            this.gb_DatosOrden.Size = new System.Drawing.Size(249, 366);
            this.gb_DatosOrden.TabIndex = 25;
            this.gb_DatosOrden.TabStop = false;
            this.gb_DatosOrden.Text = "Datos de Orden:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 265);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Factura:";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.OrdenBindingSource, "noFactura", true));
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.OrdenBindingSource, "noFactura", true));
            this.comboBox1.DataSource = this.FacturaBindingSource;
            this.comboBox1.DisplayMember = "noFactura";
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(55, 262);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(188, 21);
            this.comboBox1.TabIndex = 12;
            this.comboBox1.ValueMember = "noFactura";
            // 
            // FacturaBindingSource
            // 
            this.FacturaBindingSource.DataMember = "Factura";
            this.FacturaBindingSource.DataSource = this.facturasDataSet;
            // 
            // facturasDataSet
            // 
            this.facturasDataSet.DataSetName = "FacturasDataSet";
            this.facturasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(10, 298);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "No. Seguimiento:";
            // 
            // tb_NoSeguimiento
            // 
            this.tb_NoSeguimiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.OrdenBindingSource, "noSeguimiento", true));
            this.tb_NoSeguimiento.Location = new System.Drawing.Point(101, 294);
            this.tb_NoSeguimiento.Name = "tb_NoSeguimiento";
            this.tb_NoSeguimiento.Size = new System.Drawing.Size(142, 20);
            this.tb_NoSeguimiento.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 230);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Estatus:";
            // 
            // cb_Estatus
            // 
            this.cb_Estatus.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.OrdenBindingSource, "Estatus", true));
            this.cb_Estatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Estatus.FormattingEnabled = true;
            this.cb_Estatus.Items.AddRange(new object[] {
            "En Proceso",
            "Enviado",
            "Recibido"});
            this.cb_Estatus.Location = new System.Drawing.Point(55, 227);
            this.cb_Estatus.Name = "cb_Estatus";
            this.cb_Estatus.Size = new System.Drawing.Size(188, 21);
            this.cb_Estatus.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Cliente:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Empresa de Envío";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Remitente:";
            // 
            // cb_EmpresaEnvio
            // 
            this.cb_EmpresaEnvio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.OrdenBindingSource, "empresaEnvio", true));
            this.cb_EmpresaEnvio.DataSource = this.EmpresaEnvíoBindingSource;
            this.cb_EmpresaEnvio.DisplayMember = "nombreEmpresa";
            this.cb_EmpresaEnvio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_EmpresaEnvio.FormattingEnabled = true;
            this.cb_EmpresaEnvio.Location = new System.Drawing.Point(108, 145);
            this.cb_EmpresaEnvio.Name = "cb_EmpresaEnvio";
            this.cb_EmpresaEnvio.Size = new System.Drawing.Size(135, 21);
            this.cb_EmpresaEnvio.TabIndex = 3;
            this.cb_EmpresaEnvio.ValueMember = "nombreEmpresa";
            // 
            // cb_Cliente
            // 
            this.cb_Cliente.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.OrdenBindingSource, "idCliente", true));
            this.cb_Cliente.DataSource = this.ClienteBindingSource;
            this.cb_Cliente.DisplayMember = "idCliente";
            this.cb_Cliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Cliente.FormattingEnabled = true;
            this.cb_Cliente.Location = new System.Drawing.Point(55, 187);
            this.cb_Cliente.Name = "cb_Cliente";
            this.cb_Cliente.Size = new System.Drawing.Size(188, 21);
            this.cb_Cliente.TabIndex = 2;
            this.cb_Cliente.ValueMember = "idCliente";
            // 
            // tb_Direccion
            // 
            this.tb_Direccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.OrdenBindingSource, "direccionEnvio", true));
            this.tb_Direccion.Location = new System.Drawing.Point(78, 72);
            this.tb_Direccion.Multiline = true;
            this.tb_Direccion.Name = "tb_Direccion";
            this.tb_Direccion.Size = new System.Drawing.Size(165, 52);
            this.tb_Direccion.TabIndex = 1;
            // 
            // tb_Remitente
            // 
            this.tb_Remitente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.OrdenBindingSource, "nombreRemitente", true));
            this.tb_Remitente.Location = new System.Drawing.Point(78, 33);
            this.tb_Remitente.Name = "tb_Remitente";
            this.tb_Remitente.Size = new System.Drawing.Size(165, 20);
            this.tb_Remitente.TabIndex = 0;
            // 
            // clienteVirtualTableAdapter
            // 
            this.clienteVirtualTableAdapter.ClearBeforeFill = true;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // noFactura
            // 
            this.noFactura.DataPropertyName = "noFactura";
            this.noFactura.HeaderText = "No Factura";
            this.noFactura.Name = "noFactura";
            this.noFactura.ReadOnly = true;
            // 
            // noOrdenDataGridViewTextBoxColumn
            // 
            this.noOrdenDataGridViewTextBoxColumn.DataPropertyName = "noOrden";
            this.noOrdenDataGridViewTextBoxColumn.HeaderText = "No Orden";
            this.noOrdenDataGridViewTextBoxColumn.Name = "noOrdenDataGridViewTextBoxColumn";
            this.noOrdenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "ID Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreRemitenteDataGridViewTextBoxColumn
            // 
            this.nombreRemitenteDataGridViewTextBoxColumn.DataPropertyName = "nombreRemitente";
            this.nombreRemitenteDataGridViewTextBoxColumn.HeaderText = "Remitente";
            this.nombreRemitenteDataGridViewTextBoxColumn.Name = "nombreRemitenteDataGridViewTextBoxColumn";
            this.nombreRemitenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresaEnvioDataGridViewTextBoxColumn
            // 
            this.empresaEnvioDataGridViewTextBoxColumn.DataPropertyName = "empresaEnvio";
            this.empresaEnvioDataGridViewTextBoxColumn.HeaderText = "Empresa Envío";
            this.empresaEnvioDataGridViewTextBoxColumn.Name = "empresaEnvioDataGridViewTextBoxColumn";
            this.empresaEnvioDataGridViewTextBoxColumn.ReadOnly = true;
            this.empresaEnvioDataGridViewTextBoxColumn.Width = 130;
            // 
            // direccionEnvioDataGridViewTextBoxColumn
            // 
            this.direccionEnvioDataGridViewTextBoxColumn.DataPropertyName = "direccionEnvio";
            this.direccionEnvioDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionEnvioDataGridViewTextBoxColumn.Name = "direccionEnvioDataGridViewTextBoxColumn";
            this.direccionEnvioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noSeguimientoDataGridViewTextBoxColumn
            // 
            this.noSeguimientoDataGridViewTextBoxColumn.DataPropertyName = "noSeguimiento";
            this.noSeguimientoDataGridViewTextBoxColumn.HeaderText = "No. Seguimiento";
            this.noSeguimientoDataGridViewTextBoxColumn.Name = "noSeguimientoDataGridViewTextBoxColumn";
            this.noSeguimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.noSeguimientoDataGridViewTextBoxColumn.Width = 130;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // OrdenesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 446);
            this.Controls.Add(this.gb_DatosOrden);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStripMenu);
            this.Name = "OrdenesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes";
            this.Load += new System.EventHandler(this.OrdenClienteFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresaEnvíoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDeEnvioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_DatosOrden.ResumeLayout(false);
            this.gb_DatosOrden.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource OrdenBindingSource;
        private DataSet.OrdenDataSet ordenDataSet;
        private System.Windows.Forms.BindingSource EmpresaEnvíoBindingSource;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private DataSet.OrdenDataSetTableAdapters.OrdenTableAdapter ordenTableAdapter;
        private DataSet.EmpresasDeEnvioDataSet empresasDeEnvioDataSet;
        private DataSet.EmpresasDeEnvioDataSetTableAdapters.EmpresaDeEnvioTableAdapter empresaDeEnvioTableAdapter;
        private DataSet.ClientesDataSet clientesDataSet;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btn_Nuevo;
        private System.Windows.Forms.ToolStripButton btn_Guardar;
        private System.Windows.Forms.ToolStripButton btn_Eliminar;
        private System.Windows.Forms.ToolStripButton btn_Recargar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tb_Buscar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox gb_DatosOrden;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cb_Estatus;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_EmpresaEnvio;
        private System.Windows.Forms.ComboBox cb_Cliente;
        private System.Windows.Forms.TextBox tb_Direccion;
        private System.Windows.Forms.TextBox tb_Remitente;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tb_NoSeguimiento;
        private DataSet.ClientesDataSetTableAdapters.ClienteVirtualTableAdapter clienteVirtualTableAdapter;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource FacturaBindingSource;
        private DataSet.FacturasDataSet facturasDataSet;
        private DataSet.FacturasDataSetTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noFactura;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOrdenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRemitenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSeguimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
    }
}