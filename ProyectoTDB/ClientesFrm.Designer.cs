namespace ProyectoDB
{
    partial class ClientesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesFrm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Nombre = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_TipoCliente = new System.Windows.Forms.ComboBox();
            this.gb_tipoCompra = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cb_TipoCompra = new System.Windows.Forms.ComboBox();
            this.gb_ClienteVirtual = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tb_CodigoSeguridad = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Contrasena = new System.Windows.Forms.TextBox();
            this.tb_Contrasena2 = new System.Windows.Forms.TextBox();
            this.tb_TarjetaHabiente = new System.Windows.Forms.TextBox();
            this.tb_NumeroTarjeta = new System.Windows.Forms.TextBox();
            this.tb_MesVencimiento = new System.Windows.Forms.TextBox();
            this.tb_AñoVencimiento = new System.Windows.Forms.TextBox();
            this.tb_Direccion = new System.Windows.Forms.TextBox();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.btn_Recargar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tb_BuscarCliente = new System.Windows.Forms.ToolStripTextBox();
            this.VirtualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataSet = new ProyectoDB.DataSet.ClientesDataSet();
            this.PrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clienteTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteTableAdapter();
            this.clienteVirtualTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteVirtualTableAdapter();
            this.FrecuenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteFrecuenteTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteFrecuenteTableAdapter();
            this.PocoFrecuenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientePocoFrecuenteTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClientePocoFrecuenteTableAdapter();
            this.TiendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTiendaTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteTiendaTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.gb_tipoCompra.SuspendLayout();
            this.gb_ClienteVirtual.SuspendLayout();
            this.toolStripMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VirtualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrecuenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PocoFrecuenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiendaBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.PrincipalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(324, 318);
            this.dataGridView1.TabIndex = 11;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_Nombre);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cb_TipoCliente);
            this.groupBox1.Location = new System.Drawing.Point(355, 63);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(230, 125);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(8, 76);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Nombre:";
            // 
            // tb_Nombre
            // 
            this.tb_Nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.PrincipalBindingSource, "nombreCliente", true));
            this.tb_Nombre.Location = new System.Drawing.Point(59, 73);
            this.tb_Nombre.Name = "tb_Nombre";
            this.tb_Nombre.Size = new System.Drawing.Size(155, 20);
            this.tb_Nombre.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tipo de Cliente:";
            // 
            // cb_TipoCliente
            // 
            this.cb_TipoCliente.FormattingEnabled = true;
            this.cb_TipoCliente.Location = new System.Drawing.Point(93, 29);
            this.cb_TipoCliente.Name = "cb_TipoCliente";
            this.cb_TipoCliente.Size = new System.Drawing.Size(121, 21);
            this.cb_TipoCliente.TabIndex = 0;
            this.cb_TipoCliente.SelectedIndexChanged += new System.EventHandler(this.cb_TipoCliente_SelectedIndexChanged);
            // 
            // gb_tipoCompra
            // 
            this.gb_tipoCompra.Controls.Add(this.label3);
            this.gb_tipoCompra.Controls.Add(this.cb_TipoCompra);
            this.gb_tipoCompra.Location = new System.Drawing.Point(355, 203);
            this.gb_tipoCompra.Name = "gb_tipoCompra";
            this.gb_tipoCompra.Size = new System.Drawing.Size(236, 77);
            this.gb_tipoCompra.TabIndex = 16;
            this.gb_tipoCompra.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Compras:";
            // 
            // cb_TipoCompra
            // 
            this.cb_TipoCompra.FormattingEnabled = true;
            this.cb_TipoCompra.Items.AddRange(new object[] {
            "Virtual",
            "Tienda"});
            this.cb_TipoCompra.Location = new System.Drawing.Point(63, 29);
            this.cb_TipoCompra.Name = "cb_TipoCompra";
            this.cb_TipoCompra.Size = new System.Drawing.Size(151, 21);
            this.cb_TipoCompra.TabIndex = 0;
            this.cb_TipoCompra.SelectedIndexChanged += new System.EventHandler(this.cb_TipoCompra_SelectedIndexChanged);
            // 
            // gb_ClienteVirtual
            // 
            this.gb_ClienteVirtual.Controls.Add(this.label10);
            this.gb_ClienteVirtual.Controls.Add(this.tb_CodigoSeguridad);
            this.gb_ClienteVirtual.Controls.Add(this.label12);
            this.gb_ClienteVirtual.Controls.Add(this.label11);
            this.gb_ClienteVirtual.Controls.Add(this.label9);
            this.gb_ClienteVirtual.Controls.Add(this.label8);
            this.gb_ClienteVirtual.Controls.Add(this.label7);
            this.gb_ClienteVirtual.Controls.Add(this.label6);
            this.gb_ClienteVirtual.Controls.Add(this.label4);
            this.gb_ClienteVirtual.Controls.Add(this.tb_Contrasena);
            this.gb_ClienteVirtual.Controls.Add(this.tb_Contrasena2);
            this.gb_ClienteVirtual.Controls.Add(this.tb_TarjetaHabiente);
            this.gb_ClienteVirtual.Controls.Add(this.tb_NumeroTarjeta);
            this.gb_ClienteVirtual.Controls.Add(this.tb_MesVencimiento);
            this.gb_ClienteVirtual.Controls.Add(this.tb_AñoVencimiento);
            this.gb_ClienteVirtual.Controls.Add(this.tb_Direccion);
            this.gb_ClienteVirtual.Location = new System.Drawing.Point(610, 63);
            this.gb_ClienteVirtual.Name = "gb_ClienteVirtual";
            this.gb_ClienteVirtual.Size = new System.Drawing.Size(273, 318);
            this.gb_ClienteVirtual.TabIndex = 17;
            this.gb_ClienteVirtual.TabStop = false;
            this.gb_ClienteVirtual.Text = "Datos de Cliente Virtual:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 215);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Código de Seguridad:";
            // 
            // tb_CodigoSeguridad
            // 
            this.tb_CodigoSeguridad.AcceptsTab = true;
            this.tb_CodigoSeguridad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VirtualBindingSource, "codigoSeguridad", true));
            this.tb_CodigoSeguridad.Location = new System.Drawing.Point(125, 212);
            this.tb_CodigoSeguridad.Name = "tb_CodigoSeguridad";
            this.tb_CodigoSeguridad.PasswordChar = '*';
            this.tb_CodigoSeguridad.Size = new System.Drawing.Size(129, 20);
            this.tb_CodigoSeguridad.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 284);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Año de Vencimiento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 249);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Mes de Vencimiento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 182);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Número de Tarjeta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tarjeta Habiente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 112);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Confirmar Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dirección:";
            // 
            // tb_Contrasena
            // 
            this.tb_Contrasena.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VirtualBindingSource, "password", true));
            this.tb_Contrasena.Location = new System.Drawing.Point(83, 69);
            this.tb_Contrasena.Name = "tb_Contrasena";
            this.tb_Contrasena.PasswordChar = '*';
            this.tb_Contrasena.Size = new System.Drawing.Size(171, 20);
            this.tb_Contrasena.TabIndex = 1;
            this.tb_Contrasena.Tag = "";
            // 
            // tb_Contrasena2
            // 
            this.tb_Contrasena2.Location = new System.Drawing.Point(130, 109);
            this.tb_Contrasena2.Name = "tb_Contrasena2";
            this.tb_Contrasena2.PasswordChar = '*';
            this.tb_Contrasena2.Size = new System.Drawing.Size(124, 20);
            this.tb_Contrasena2.TabIndex = 2;
            this.tb_Contrasena2.Tag = "";
            // 
            // tb_TarjetaHabiente
            // 
            this.tb_TarjetaHabiente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VirtualBindingSource, "tarjetahabiente", true));
            this.tb_TarjetaHabiente.Location = new System.Drawing.Point(108, 143);
            this.tb_TarjetaHabiente.Name = "tb_TarjetaHabiente";
            this.tb_TarjetaHabiente.Size = new System.Drawing.Size(146, 20);
            this.tb_TarjetaHabiente.TabIndex = 3;
            this.tb_TarjetaHabiente.Tag = "";
            // 
            // tb_NumeroTarjeta
            // 
            this.tb_NumeroTarjeta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VirtualBindingSource, "numeroTarjeta", true));
            this.tb_NumeroTarjeta.Location = new System.Drawing.Point(117, 179);
            this.tb_NumeroTarjeta.Name = "tb_NumeroTarjeta";
            this.tb_NumeroTarjeta.Size = new System.Drawing.Size(137, 20);
            this.tb_NumeroTarjeta.TabIndex = 4;
            // 
            // tb_MesVencimiento
            // 
            this.tb_MesVencimiento.AcceptsTab = true;
            this.tb_MesVencimiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VirtualBindingSource, "mesVencimiento", true));
            this.tb_MesVencimiento.Location = new System.Drawing.Point(125, 246);
            this.tb_MesVencimiento.Name = "tb_MesVencimiento";
            this.tb_MesVencimiento.Size = new System.Drawing.Size(129, 20);
            this.tb_MesVencimiento.TabIndex = 6;
            // 
            // tb_AñoVencimiento
            // 
            this.tb_AñoVencimiento.AcceptsTab = true;
            this.tb_AñoVencimiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VirtualBindingSource, "yearVencimiento", true));
            this.tb_AñoVencimiento.Location = new System.Drawing.Point(125, 281);
            this.tb_AñoVencimiento.Name = "tb_AñoVencimiento";
            this.tb_AñoVencimiento.Size = new System.Drawing.Size(129, 20);
            this.tb_AñoVencimiento.TabIndex = 7;
            // 
            // tb_Direccion
            // 
            this.tb_Direccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.VirtualBindingSource, "direccionFacturacion", true));
            this.tb_Direccion.Location = new System.Drawing.Point(74, 29);
            this.tb_Direccion.Name = "tb_Direccion";
            this.tb_Direccion.Size = new System.Drawing.Size(180, 20);
            this.tb_Direccion.TabIndex = 0;
            this.tb_Direccion.Tag = "";
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
            this.toolStripMenu.Size = new System.Drawing.Size(911, 54);
            this.toolStripMenu.TabIndex = 20;
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
            this.btn_Nuevo.Click += new System.EventHandler(this.toolStripButton1_Click);
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
            this.btn_Guardar.Click += new System.EventHandler(this.toolStripButton2_Click);
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
            this.btn_Eliminar.Click += new System.EventHandler(this.toolStripButton3_Click);
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
            this.tb_BuscarCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Buscar_KeyPress);
            // 
            // VirtualBindingSource
            // 
            this.VirtualBindingSource.DataMember = "ClienteVirtual";
            this.VirtualBindingSource.DataSource = this.clientesDataSet;
            // 
            // clientesDataSet
            // 
            this.clientesDataSet.DataSetName = "ClientesDataSet";
            this.clientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // PrincipalBindingSource
            // 
            this.PrincipalBindingSource.DataMember = "Cliente";
            this.PrincipalBindingSource.DataSource = this.clientesDataSet;
            this.PrincipalBindingSource.PositionChanged += new System.EventHandler(this.PrincipalBindingSource_PositionChanged);
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            this.idClienteDataGridViewTextBoxColumn.Width = 150;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "nombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Nombre del Cliente";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.nombreClienteDataGridViewTextBoxColumn.Width = 250;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // clienteVirtualTableAdapter
            // 
            this.clienteVirtualTableAdapter.ClearBeforeFill = true;
            // 
            // FrecuenteBindingSource
            // 
            this.FrecuenteBindingSource.DataMember = "ClienteFrecuente";
            this.FrecuenteBindingSource.DataSource = this.clientesDataSet;
            // 
            // clienteFrecuenteTableAdapter
            // 
            this.clienteFrecuenteTableAdapter.ClearBeforeFill = true;
            // 
            // PocoFrecuenteBindingSource
            // 
            this.PocoFrecuenteBindingSource.DataMember = "ClientePocoFrecuente";
            this.PocoFrecuenteBindingSource.DataSource = this.clientesDataSet;
            // 
            // clientePocoFrecuenteTableAdapter
            // 
            this.clientePocoFrecuenteTableAdapter.ClearBeforeFill = true;
            // 
            // TiendaBindingSource
            // 
            this.TiendaBindingSource.DataMember = "ClienteTienda";
            this.TiendaBindingSource.DataSource = this.clientesDataSet;
            // 
            // clienteTiendaTableAdapter
            // 
            this.clienteTiendaTableAdapter.ClearBeforeFill = true;
            // 
            // ClientesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 406);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.gb_ClienteVirtual);
            this.Controls.Add(this.gb_tipoCompra);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClientesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.ClientesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.gb_tipoCompra.ResumeLayout(false);
            this.gb_tipoCompra.PerformLayout();
            this.gb_ClienteVirtual.ResumeLayout(false);
            this.gb_ClienteVirtual.PerformLayout();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.VirtualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.FrecuenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PocoFrecuenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiendaBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource PrincipalBindingSource;
        private DataSet.ClientesDataSet clientesDataSet;
        private DataSet.ClientesDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Nombre;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_TipoCliente;
        private System.Windows.Forms.GroupBox gb_tipoCompra;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cb_TipoCompra;
        private System.Windows.Forms.GroupBox gb_ClienteVirtual;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Contrasena;
        private System.Windows.Forms.TextBox tb_Contrasena2;
        private System.Windows.Forms.TextBox tb_TarjetaHabiente;
        private System.Windows.Forms.TextBox tb_NumeroTarjeta;
        private System.Windows.Forms.TextBox tb_MesVencimiento;
        private System.Windows.Forms.TextBox tb_Direccion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_CodigoSeguridad;
        private System.Windows.Forms.BindingSource VirtualBindingSource;
        private DataSet.ClientesDataSetTableAdapters.ClienteVirtualTableAdapter clienteVirtualTableAdapter;
        private System.Windows.Forms.BindingSource FrecuenteBindingSource;
        private DataSet.ClientesDataSetTableAdapters.ClienteFrecuenteTableAdapter clienteFrecuenteTableAdapter;
        private System.Windows.Forms.BindingSource PocoFrecuenteBindingSource;
        private DataSet.ClientesDataSetTableAdapters.ClientePocoFrecuenteTableAdapter clientePocoFrecuenteTableAdapter;
        private System.Windows.Forms.BindingSource TiendaBindingSource;
        private DataSet.ClientesDataSetTableAdapters.ClienteTiendaTableAdapter clienteTiendaTableAdapter;
        private System.Windows.Forms.TextBox tb_AñoVencimiento;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btn_Nuevo;
        private System.Windows.Forms.ToolStripButton btn_Guardar;
        private System.Windows.Forms.ToolStripButton btn_Eliminar;
        private System.Windows.Forms.ToolStripButton btn_Recargar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tb_BuscarCliente;
    }
}