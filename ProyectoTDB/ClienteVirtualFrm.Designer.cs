namespace ProyectoDB
{
    partial class ClienteVirtualFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteVirtualFrm));
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.btn_Recargar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tb_BuscarCliente = new System.Windows.Forms.ToolStripTextBox();
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
            this.label1 = new System.Windows.Forms.Label();
            this.cb_IdCliente = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ClienteVirtualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataSet = new ProyectoDB.DataSet.ClientesDataSet();
            this.clienteVirtualTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteVirtualTableAdapter();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionFacturacionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numeroTarjetaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tarjetahabienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mesVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.yearVencimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoSeguridadDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteTableAdapter();
            this.ClientePocoFrecuenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientePocoFrecuenteTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClientePocoFrecuenteTableAdapter();
            this.ClienteFrecuenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteFrecuenteTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteFrecuenteTableAdapter();
            this.toolStripMenu.SuspendLayout();
            this.gb_ClienteVirtual.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteVirtualBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientePocoFrecuenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteFrecuenteBindingSource)).BeginInit();
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
            this.toolStripMenu.Size = new System.Drawing.Size(706, 54);
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
            // 
            // gb_ClienteVirtual
            // 
            this.gb_ClienteVirtual.Controls.Add(this.label1);
            this.gb_ClienteVirtual.Controls.Add(this.label10);
            this.gb_ClienteVirtual.Controls.Add(this.tb_CodigoSeguridad);
            this.gb_ClienteVirtual.Controls.Add(this.cb_IdCliente);
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
            this.gb_ClienteVirtual.Location = new System.Drawing.Point(410, 67);
            this.gb_ClienteVirtual.Name = "gb_ClienteVirtual";
            this.gb_ClienteVirtual.Size = new System.Drawing.Size(273, 361);
            this.gb_ClienteVirtual.TabIndex = 21;
            this.gb_ClienteVirtual.TabStop = false;
            this.gb_ClienteVirtual.Text = "Datos de Cliente Virtual:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 256);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(109, 13);
            this.label10.TabIndex = 17;
            this.label10.Text = "Código de Seguridad:";
            // 
            // tb_CodigoSeguridad
            // 
            this.tb_CodigoSeguridad.AcceptsTab = true;
            this.tb_CodigoSeguridad.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ClienteVirtualBindingSource, "codigoSeguridad", true));
            this.tb_CodigoSeguridad.Location = new System.Drawing.Point(125, 253);
            this.tb_CodigoSeguridad.Name = "tb_CodigoSeguridad";
            this.tb_CodigoSeguridad.PasswordChar = '*';
            this.tb_CodigoSeguridad.Size = new System.Drawing.Size(129, 20);
            this.tb_CodigoSeguridad.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(14, 325);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 15;
            this.label12.Text = "Año de Vencimiento:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(106, 13);
            this.label11.TabIndex = 14;
            this.label11.Text = "Mes de Vencimiento:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 223);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(98, 13);
            this.label9.TabIndex = 12;
            this.label9.Text = "Número de Tarjeta:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 188);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 13);
            this.label8.TabIndex = 11;
            this.label8.Text = "Tarjeta Habiente:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(111, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Confirmar Contraseña:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(13, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 73);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Dirección:";
            // 
            // tb_Contrasena
            // 
            this.tb_Contrasena.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ClienteVirtualBindingSource, "password", true));
            this.tb_Contrasena.Location = new System.Drawing.Point(83, 110);
            this.tb_Contrasena.Name = "tb_Contrasena";
            this.tb_Contrasena.PasswordChar = '*';
            this.tb_Contrasena.Size = new System.Drawing.Size(171, 20);
            this.tb_Contrasena.TabIndex = 1;
            this.tb_Contrasena.Tag = "";
            // 
            // tb_Contrasena2
            // 
            this.tb_Contrasena2.Location = new System.Drawing.Point(130, 150);
            this.tb_Contrasena2.Name = "tb_Contrasena2";
            this.tb_Contrasena2.PasswordChar = '*';
            this.tb_Contrasena2.Size = new System.Drawing.Size(124, 20);
            this.tb_Contrasena2.TabIndex = 2;
            this.tb_Contrasena2.Tag = "";
            // 
            // tb_TarjetaHabiente
            // 
            this.tb_TarjetaHabiente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ClienteVirtualBindingSource, "tarjetahabiente", true));
            this.tb_TarjetaHabiente.Location = new System.Drawing.Point(108, 184);
            this.tb_TarjetaHabiente.Name = "tb_TarjetaHabiente";
            this.tb_TarjetaHabiente.Size = new System.Drawing.Size(146, 20);
            this.tb_TarjetaHabiente.TabIndex = 3;
            this.tb_TarjetaHabiente.Tag = "";
            // 
            // tb_NumeroTarjeta
            // 
            this.tb_NumeroTarjeta.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ClienteVirtualBindingSource, "numeroTarjeta", true));
            this.tb_NumeroTarjeta.Location = new System.Drawing.Point(117, 220);
            this.tb_NumeroTarjeta.Name = "tb_NumeroTarjeta";
            this.tb_NumeroTarjeta.Size = new System.Drawing.Size(137, 20);
            this.tb_NumeroTarjeta.TabIndex = 4;
            // 
            // tb_MesVencimiento
            // 
            this.tb_MesVencimiento.AcceptsTab = true;
            this.tb_MesVencimiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ClienteVirtualBindingSource, "mesVencimiento", true));
            this.tb_MesVencimiento.Location = new System.Drawing.Point(125, 287);
            this.tb_MesVencimiento.Name = "tb_MesVencimiento";
            this.tb_MesVencimiento.Size = new System.Drawing.Size(129, 20);
            this.tb_MesVencimiento.TabIndex = 6;
            // 
            // tb_AñoVencimiento
            // 
            this.tb_AñoVencimiento.AcceptsTab = true;
            this.tb_AñoVencimiento.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ClienteVirtualBindingSource, "yearVencimiento", true));
            this.tb_AñoVencimiento.Location = new System.Drawing.Point(125, 322);
            this.tb_AñoVencimiento.Name = "tb_AñoVencimiento";
            this.tb_AñoVencimiento.Size = new System.Drawing.Size(129, 20);
            this.tb_AñoVencimiento.TabIndex = 7;
            // 
            // tb_Direccion
            // 
            this.tb_Direccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ClienteVirtualBindingSource, "direccionFacturacion", true));
            this.tb_Direccion.Location = new System.Drawing.Point(74, 70);
            this.tb_Direccion.Name = "tb_Direccion";
            this.tb_Direccion.Size = new System.Drawing.Size(180, 20);
            this.tb_Direccion.TabIndex = 0;
            this.tb_Direccion.Tag = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre del Cliente:";
            // 
            // cb_IdCliente
            // 
            this.cb_IdCliente.DataSource = this.ClienteBindingSource;
            this.cb_IdCliente.DisplayMember = "nombreCliente";
            this.cb_IdCliente.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_IdCliente.FormattingEnabled = true;
            this.cb_IdCliente.Location = new System.Drawing.Point(111, 34);
            this.cb_IdCliente.Name = "cb_IdCliente";
            this.cb_IdCliente.Size = new System.Drawing.Size(143, 21);
            this.cb_IdCliente.TabIndex = 18;
            this.cb_IdCliente.ValueMember = "idCliente";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.direccionFacturacionDataGridViewTextBoxColumn,
            this.numeroTarjetaDataGridViewTextBoxColumn,
            this.tarjetahabienteDataGridViewTextBoxColumn,
            this.mesVencimientoDataGridViewTextBoxColumn,
            this.yearVencimientoDataGridViewTextBoxColumn,
            this.codigoSeguridadDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ClienteVirtualBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 67);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(375, 361);
            this.dataGridView1.TabIndex = 23;
            // 
            // ClienteVirtualBindingSource
            // 
            this.ClienteVirtualBindingSource.DataMember = "ClienteVirtual";
            this.ClienteVirtualBindingSource.DataSource = this.clientesDataSet;
            // 
            // clientesDataSet
            // 
            this.clientesDataSet.DataSetName = "ClientesDataSet";
            this.clientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteVirtualTableAdapter
            // 
            this.clienteVirtualTableAdapter.ClearBeforeFill = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "ID";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            this.passwordDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordDataGridViewTextBoxColumn.Visible = false;
            // 
            // direccionFacturacionDataGridViewTextBoxColumn
            // 
            this.direccionFacturacionDataGridViewTextBoxColumn.DataPropertyName = "direccionFacturacion";
            this.direccionFacturacionDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionFacturacionDataGridViewTextBoxColumn.Name = "direccionFacturacionDataGridViewTextBoxColumn";
            this.direccionFacturacionDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionFacturacionDataGridViewTextBoxColumn.Width = 150;
            // 
            // numeroTarjetaDataGridViewTextBoxColumn
            // 
            this.numeroTarjetaDataGridViewTextBoxColumn.DataPropertyName = "numeroTarjeta";
            this.numeroTarjetaDataGridViewTextBoxColumn.HeaderText = "Tarjeta";
            this.numeroTarjetaDataGridViewTextBoxColumn.Name = "numeroTarjetaDataGridViewTextBoxColumn";
            this.numeroTarjetaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numeroTarjetaDataGridViewTextBoxColumn.Width = 150;
            // 
            // tarjetahabienteDataGridViewTextBoxColumn
            // 
            this.tarjetahabienteDataGridViewTextBoxColumn.DataPropertyName = "tarjetahabiente";
            this.tarjetahabienteDataGridViewTextBoxColumn.HeaderText = "Tarjeta Habiente";
            this.tarjetahabienteDataGridViewTextBoxColumn.Name = "tarjetahabienteDataGridViewTextBoxColumn";
            this.tarjetahabienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.tarjetahabienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // mesVencimientoDataGridViewTextBoxColumn
            // 
            this.mesVencimientoDataGridViewTextBoxColumn.DataPropertyName = "mesVencimiento";
            this.mesVencimientoDataGridViewTextBoxColumn.HeaderText = "Mes Vencimiento";
            this.mesVencimientoDataGridViewTextBoxColumn.Name = "mesVencimientoDataGridViewTextBoxColumn";
            this.mesVencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.mesVencimientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // yearVencimientoDataGridViewTextBoxColumn
            // 
            this.yearVencimientoDataGridViewTextBoxColumn.DataPropertyName = "yearVencimiento";
            this.yearVencimientoDataGridViewTextBoxColumn.HeaderText = "Año Vencimiento";
            this.yearVencimientoDataGridViewTextBoxColumn.Name = "yearVencimientoDataGridViewTextBoxColumn";
            this.yearVencimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.yearVencimientoDataGridViewTextBoxColumn.Visible = false;
            // 
            // codigoSeguridadDataGridViewTextBoxColumn
            // 
            this.codigoSeguridadDataGridViewTextBoxColumn.DataPropertyName = "codigoSeguridad";
            this.codigoSeguridadDataGridViewTextBoxColumn.HeaderText = "codigoSeguridad";
            this.codigoSeguridadDataGridViewTextBoxColumn.Name = "codigoSeguridadDataGridViewTextBoxColumn";
            this.codigoSeguridadDataGridViewTextBoxColumn.ReadOnly = true;
            this.codigoSeguridadDataGridViewTextBoxColumn.Visible = false;
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataMember = "Cliente";
            this.ClienteBindingSource.DataSource = this.clientesDataSet;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // ClientePocoFrecuenteBindingSource
            // 
            this.ClientePocoFrecuenteBindingSource.DataMember = "ClientePocoFrecuente";
            this.ClientePocoFrecuenteBindingSource.DataSource = this.clientesDataSet;
            // 
            // clientePocoFrecuenteTableAdapter
            // 
            this.clientePocoFrecuenteTableAdapter.ClearBeforeFill = true;
            // 
            // ClienteFrecuenteBindingSource
            // 
            this.ClienteFrecuenteBindingSource.DataMember = "ClienteFrecuente";
            this.ClienteFrecuenteBindingSource.DataSource = this.clientesDataSet;
            // 
            // clienteFrecuenteTableAdapter
            // 
            this.clienteFrecuenteTableAdapter.ClearBeforeFill = true;
            // 
            // ClienteVirtualFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 449);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.gb_ClienteVirtual);
            this.Name = "ClienteVirtualFrm";
            this.Text = "Clientes Virtuales";
            this.Load += new System.EventHandler(this.ClienteVirtualFrm_Load);
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.gb_ClienteVirtual.ResumeLayout(false);
            this.gb_ClienteVirtual.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteVirtualBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientePocoFrecuenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteFrecuenteBindingSource)).EndInit();
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
        private System.Windows.Forms.GroupBox gb_ClienteVirtual;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tb_CodigoSeguridad;
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
        private System.Windows.Forms.TextBox tb_AñoVencimiento;
        private System.Windows.Forms.TextBox tb_Direccion;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_IdCliente;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ClienteVirtualBindingSource;
        private DataSet.ClientesDataSet clientesDataSet;
        private DataSet.ClientesDataSetTableAdapters.ClienteVirtualTableAdapter clienteVirtualTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionFacturacionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn numeroTarjetaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tarjetahabienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mesVencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn yearVencimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoSeguridadDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private DataSet.ClientesDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource ClientePocoFrecuenteBindingSource;
        private DataSet.ClientesDataSetTableAdapters.ClientePocoFrecuenteTableAdapter clientePocoFrecuenteTableAdapter;
        private System.Windows.Forms.BindingSource ClienteFrecuenteBindingSource;
        private DataSet.ClientesDataSetTableAdapters.ClienteFrecuenteTableAdapter clienteFrecuenteTableAdapter;
    }
}