namespace ProyectoDB
{
    partial class VistaUnoFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VistaUnoFrm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vistasDataSet = new ProyectoDB.DataSet.VistasDataSet();
            this.ordenDestruidaTableAdapter = new ProyectoDB.DataSet.VistasDataSetTableAdapters.OrdenDestruidaTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.EncabezadoFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.facturasDataSet = new ProyectoDB.DataSet.FacturasDataSet();
            this.DetalleFacturaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.OrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenDataSet = new ProyectoDB.DataSet.OrdenDataSet();
            this.facturaTableAdapter = new ProyectoDB.DataSet.FacturasDataSetTableAdapters.FacturaTableAdapter();
            this.detalleFacturaTableAdapter = new ProyectoDB.DataSet.FacturasDataSetTableAdapters.DetalleFacturaTableAdapter();
            this.ordenTableAdapter = new ProyectoDB.DataSet.OrdenDataSetTableAdapters.OrdenTableAdapter();
            this.noFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rTNDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreRemitenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaEmisionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidadProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isvDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoTienda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncabezadoFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleFacturaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noFacturaDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.nombreClienteDataGridViewTextBoxColumn,
            this.rTNDataGridViewTextBoxColumn,
            this.nombreRemitenteDataGridViewTextBoxColumn,
            this.direccionEnvioDataGridViewTextBoxColumn,
            this.fechaEmisionDataGridViewTextBoxColumn,
            this.empresaEnvioDataGridViewTextBoxColumn,
            this.idProductoDataGridViewTextBoxColumn,
            this.cantidadProductoDataGridViewTextBoxColumn,
            this.isvDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn,
            this.codigoTienda});
            this.dataGridView1.DataSource = this.PrincipalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(9, 63);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1195, 367);
            this.dataGridView1.TabIndex = 0;
            // 
            // PrincipalBindingSource
            // 
            this.PrincipalBindingSource.DataMember = "OrdenDestruida";
            this.PrincipalBindingSource.DataSource = this.vistasDataSet;
            // 
            // vistasDataSet
            // 
            this.vistasDataSet.DataSetName = "VistasDataSet";
            this.vistasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ordenDestruidaTableAdapter
            // 
            this.ordenDestruidaTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(13, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(163, 44);
            this.button1.TabIndex = 1;
            this.button1.Text = "Reemplazar y Reenviar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EncabezadoFacturaBindingSource
            // 
            this.EncabezadoFacturaBindingSource.DataMember = "Factura";
            this.EncabezadoFacturaBindingSource.DataSource = this.facturasDataSet;
            // 
            // facturasDataSet
            // 
            this.facturasDataSet.DataSetName = "FacturasDataSet";
            this.facturasDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // DetalleFacturaBindingSource
            // 
            this.DetalleFacturaBindingSource.DataMember = "DetalleFactura";
            this.DetalleFacturaBindingSource.DataSource = this.facturasDataSet;
            // 
            // OrdenBindingSource
            // 
            this.OrdenBindingSource.DataMember = "Orden";
            this.OrdenBindingSource.DataSource = this.ordenDataSet;
            // 
            // ordenDataSet
            // 
            this.ordenDataSet.DataSetName = "OrdenDataSet";
            this.ordenDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // facturaTableAdapter
            // 
            this.facturaTableAdapter.ClearBeforeFill = true;
            // 
            // detalleFacturaTableAdapter
            // 
            this.detalleFacturaTableAdapter.ClearBeforeFill = true;
            // 
            // ordenTableAdapter
            // 
            this.ordenTableAdapter.ClearBeforeFill = true;
            // 
            // noFacturaDataGridViewTextBoxColumn
            // 
            this.noFacturaDataGridViewTextBoxColumn.DataPropertyName = "NoFactura";
            this.noFacturaDataGridViewTextBoxColumn.HeaderText = "No. Factura";
            this.noFacturaDataGridViewTextBoxColumn.Name = "noFacturaDataGridViewTextBoxColumn";
            this.noFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // nombreClienteDataGridViewTextBoxColumn
            // 
            this.nombreClienteDataGridViewTextBoxColumn.DataPropertyName = "nombreCliente";
            this.nombreClienteDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreClienteDataGridViewTextBoxColumn.Name = "nombreClienteDataGridViewTextBoxColumn";
            this.nombreClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // rTNDataGridViewTextBoxColumn
            // 
            this.rTNDataGridViewTextBoxColumn.DataPropertyName = "RTN";
            this.rTNDataGridViewTextBoxColumn.HeaderText = "RTN";
            this.rTNDataGridViewTextBoxColumn.Name = "rTNDataGridViewTextBoxColumn";
            this.rTNDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nombreRemitenteDataGridViewTextBoxColumn
            // 
            this.nombreRemitenteDataGridViewTextBoxColumn.DataPropertyName = "nombreRemitente";
            this.nombreRemitenteDataGridViewTextBoxColumn.HeaderText = "Remitente";
            this.nombreRemitenteDataGridViewTextBoxColumn.Name = "nombreRemitenteDataGridViewTextBoxColumn";
            this.nombreRemitenteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // direccionEnvioDataGridViewTextBoxColumn
            // 
            this.direccionEnvioDataGridViewTextBoxColumn.DataPropertyName = "direccionEnvio";
            this.direccionEnvioDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionEnvioDataGridViewTextBoxColumn.Name = "direccionEnvioDataGridViewTextBoxColumn";
            this.direccionEnvioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaEmisionDataGridViewTextBoxColumn
            // 
            this.fechaEmisionDataGridViewTextBoxColumn.DataPropertyName = "FechaEmision";
            this.fechaEmisionDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaEmisionDataGridViewTextBoxColumn.Name = "fechaEmisionDataGridViewTextBoxColumn";
            this.fechaEmisionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empresaEnvioDataGridViewTextBoxColumn
            // 
            this.empresaEnvioDataGridViewTextBoxColumn.DataPropertyName = "empresaEnvio";
            this.empresaEnvioDataGridViewTextBoxColumn.HeaderText = "Empresa Envío";
            this.empresaEnvioDataGridViewTextBoxColumn.Name = "empresaEnvioDataGridViewTextBoxColumn";
            this.empresaEnvioDataGridViewTextBoxColumn.ReadOnly = true;
            this.empresaEnvioDataGridViewTextBoxColumn.Width = 120;
            // 
            // idProductoDataGridViewTextBoxColumn
            // 
            this.idProductoDataGridViewTextBoxColumn.DataPropertyName = "idProducto";
            this.idProductoDataGridViewTextBoxColumn.HeaderText = "ID Producto";
            this.idProductoDataGridViewTextBoxColumn.Name = "idProductoDataGridViewTextBoxColumn";
            this.idProductoDataGridViewTextBoxColumn.ReadOnly = true;
            this.idProductoDataGridViewTextBoxColumn.Width = 105;
            // 
            // cantidadProductoDataGridViewTextBoxColumn
            // 
            this.cantidadProductoDataGridViewTextBoxColumn.DataPropertyName = "cantidadProducto";
            this.cantidadProductoDataGridViewTextBoxColumn.HeaderText = "Cantidad";
            this.cantidadProductoDataGridViewTextBoxColumn.Name = "cantidadProductoDataGridViewTextBoxColumn";
            this.cantidadProductoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // isvDataGridViewTextBoxColumn
            // 
            this.isvDataGridViewTextBoxColumn.DataPropertyName = "isv";
            this.isvDataGridViewTextBoxColumn.HeaderText = "ISV";
            this.isvDataGridViewTextBoxColumn.Name = "isvDataGridViewTextBoxColumn";
            this.isvDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "Total";
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // codigoTienda
            // 
            this.codigoTienda.DataPropertyName = "codigoTienda";
            this.codigoTienda.HeaderText = "codigoTienda";
            this.codigoTienda.Name = "codigoTienda";
            this.codigoTienda.ReadOnly = true;
            this.codigoTienda.Visible = false;
            // 
            // VistaUnoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1218, 442);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "VistaUnoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Orden Destruida";
            this.Load += new System.EventHandler(this.VistaUnoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vistasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EncabezadoFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturasDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DetalleFacturaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource PrincipalBindingSource;
        private DataSet.VistasDataSet vistasDataSet;
        private DataSet.VistasDataSetTableAdapters.OrdenDestruidaTableAdapter ordenDestruidaTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isv1DataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource EncabezadoFacturaBindingSource;
        private DataSet.FacturasDataSet facturasDataSet;
        private System.Windows.Forms.BindingSource DetalleFacturaBindingSource;
        private System.Windows.Forms.BindingSource OrdenBindingSource;
        private DataSet.FacturasDataSetTableAdapters.FacturaTableAdapter facturaTableAdapter;
        private DataSet.FacturasDataSetTableAdapters.DetalleFacturaTableAdapter detalleFacturaTableAdapter;
        private DataSet.OrdenDataSet ordenDataSet;
        private DataSet.OrdenDataSetTableAdapters.OrdenTableAdapter ordenTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn noFacturaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rTNDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRemitenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaEmisionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidadProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isvDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoTienda;
    }
}