namespace ProyectoDB
{
    partial class ConsultaOrdenClienteFrm
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
            this.OrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenDataSet = new ProyectoDB.DataSet.OrdenDataSet();
            this.ordenTableAdapter = new ProyectoDB.DataSet.OrdenDataSetTableAdapters.OrdenTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.noOrdenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreRemitenteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empresaEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.direccionEnvioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noSeguimientoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.noFacturaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.noOrdenDataGridViewTextBoxColumn,
            this.nombreRemitenteDataGridViewTextBoxColumn,
            this.empresaEnvioDataGridViewTextBoxColumn,
            this.direccionEnvioDataGridViewTextBoxColumn,
            this.noSeguimientoDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.noFacturaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.OrdenBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(873, 312);
            this.dataGridView1.TabIndex = 0;
            // 
            // noOrdenDataGridViewTextBoxColumn
            // 
            this.noOrdenDataGridViewTextBoxColumn.DataPropertyName = "noOrden";
            this.noOrdenDataGridViewTextBoxColumn.HeaderText = "No Orden";
            this.noOrdenDataGridViewTextBoxColumn.Name = "noOrdenDataGridViewTextBoxColumn";
            this.noOrdenDataGridViewTextBoxColumn.ReadOnly = true;
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
            this.empresaEnvioDataGridViewTextBoxColumn.Width = 150;
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
            this.noSeguimientoDataGridViewTextBoxColumn.Width = 150;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "ID Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "Estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "Estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            this.estatusDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // noFacturaDataGridViewTextBoxColumn
            // 
            this.noFacturaDataGridViewTextBoxColumn.DataPropertyName = "noFactura";
            this.noFacturaDataGridViewTextBoxColumn.HeaderText = "No Factura";
            this.noFacturaDataGridViewTextBoxColumn.Name = "noFacturaDataGridViewTextBoxColumn";
            this.noFacturaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // ConsultaOrdenClienteFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(898, 342);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ConsultaOrdenClienteFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ordenes Procesadas";
            this.Load += new System.EventHandler(this.ConsultaOrdenClienteFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.OrdenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.BindingSource OrdenBindingSource;
        private DataSet.OrdenDataSet ordenDataSet;
        private DataSet.OrdenDataSetTableAdapters.OrdenTableAdapter ordenTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn noOrdenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreRemitenteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empresaEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn direccionEnvioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noSeguimientoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn noFacturaDataGridViewTextBoxColumn;
    }
}