namespace ProyectoDB
{
    partial class ProcesoOrdenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProcesoOrdenFrm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.OrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenDataSet = new ProyectoDB.DataSet.OrdenDataSet();
            this.ordenTableAdapter = new ProyectoDB.DataSet.OrdenDataSetTableAdapters.OrdenTableAdapter();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btn_Nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_Guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_Eliminar = new System.Windows.Forms.ToolStripButton();
            this.btn_Recargar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.tb_Buscar = new System.Windows.Forms.ToolStripTextBox();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noOrdenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSeguimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreRemitenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noFactura = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenDataSet)).BeginInit();
            this.toolStripMenu.SuspendLayout();
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
            this.noOrdenDataGridViewTextBoxColumn,
            this.noSeguimientoDataGridViewTextBoxColumn,
            this.nombreRemitenteDataGridViewTextBoxColumn,
            this.empresaEnvioDataGridViewTextBoxColumn,
            this.direccionEnvioDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.noFactura});
            this.dataGridView1.DataSource = this.OrdenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(1019, 368);
            this.dataGridView1.TabIndex = 0;
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
            // ordenTableAdapter
            // 
            this.ordenTableAdapter.ClearBeforeFill = true;
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
            this.toolStripMenu.Size = new System.Drawing.Size(1043, 54);
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
            this.btn_Nuevo.Size = new System.Drawing.Size(53, 51);
            this.btn_Nuevo.Text = "Enviado";
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
            this.btn_Guardar.Size = new System.Drawing.Size(65, 51);
            this.btn_Guardar.Text = "Entregado";
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
            this.btn_Eliminar.Size = new System.Drawing.Size(62, 51);
            this.btn_Eliminar.Text = "Consultar";
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
            this.toolStripLabel1.Size = new System.Drawing.Size(81, 51);
            this.toolStripLabel1.Text = "Buscar Orden:";
            // 
            // tb_Buscar
            // 
            this.tb_Buscar.Name = "tb_Buscar";
            this.tb_Buscar.Size = new System.Drawing.Size(100, 54);
            this.tb_Buscar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Buscar_KeyPress);
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "ID Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noOrdenDataGridViewTextBoxColumn
            // 
            this.noOrdenDataGridViewTextBoxColumn.DataPropertyName = "noOrden";
            this.noOrdenDataGridViewTextBoxColumn.HeaderText = "No Orden";
            this.noOrdenDataGridViewTextBoxColumn.Name = "noOrdenDataGridViewTextBoxColumn";
            this.noOrdenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noSeguimientoDataGridViewTextBoxColumn
            // 
            this.noSeguimientoDataGridViewTextBoxColumn.DataPropertyName = "noSeguimiento";
            this.noSeguimientoDataGridViewTextBoxColumn.HeaderText = "No Seguimiento";
            this.noSeguimientoDataGridViewTextBoxColumn.Name = "noSeguimientoDataGridViewTextBoxColumn";
            this.noSeguimientoDataGridViewTextBoxColumn.ReadOnly = true;
            this.noSeguimientoDataGridViewTextBoxColumn.Width = 150;
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
            this.empresaEnvioDataGridViewTextBoxColumn.HeaderText = "Empresa de Envío";
            this.empresaEnvioDataGridViewTextBoxColumn.Name = "empresaEnvioDataGridViewTextBoxColumn";
            this.empresaEnvioDataGridViewTextBoxColumn.ReadOnly = true;
            this.empresaEnvioDataGridViewTextBoxColumn.Width = 150;
            // 
            // direccionEnvioDataGridViewTextBoxColumn
            // 
            this.direccionEnvioDataGridViewTextBoxColumn.DataPropertyName = "direccionEnvio";
            this.direccionEnvioDataGridViewTextBoxColumn.HeaderText = "Dirección";
            this.direccionEnvioDataGridViewTextBoxColumn.Name = "direccionEnvioDataGridViewTextBoxColumn";
            this.direccionEnvioDataGridViewTextBoxColumn.ReadOnly = true;
            this.direccionEnvioDataGridViewTextBoxColumn.Width = 150;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noFactura
            // 
            this.noFactura.DataPropertyName = "noFactura";
            this.noFactura.HeaderText = "No Factura";
            this.noFactura.Name = "noFactura";
            this.noFactura.ReadOnly = true;
            // 
            // ProcesoOrdenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 449);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ProcesoOrdenFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso de Orden";
            this.Load += new System.EventHandler(this.OrdenEnviadaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenDataSet)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource OrdenBindingSource;
        private DataSet.OrdenDataSet ordenDataSet;
        private DataSet.OrdenDataSetTableAdapters.OrdenTableAdapter ordenTableAdapter;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btn_Recargar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox tb_Buscar;
        private System.Windows.Forms.ToolStripButton btn_Nuevo;
        private System.Windows.Forms.ToolStripButton btn_Guardar;
        private System.Windows.Forms.ToolStripButton btn_Eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOrdenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSeguimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRemitenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noFactura;
    }
}