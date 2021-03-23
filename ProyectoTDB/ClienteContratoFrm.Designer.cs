namespace ProyectoDB
{
    partial class ClienteContratoFrm
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.numCuentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cuotaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ContratoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.contratoDataSet = new ProyectoDB.DataSet.ContratoDataSet();
            this.contratoTableAdapter = new ProyectoDB.DataSet.ContratoDataSetTableAdapters.ContratoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContratoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numCuentaDataGridViewTextBoxColumn,
            this.cuotaDataGridViewTextBoxColumn,
            this.idClienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ContratoBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(381, 216);
            this.dataGridView1.TabIndex = 3;
            // 
            // numCuentaDataGridViewTextBoxColumn
            // 
            this.numCuentaDataGridViewTextBoxColumn.DataPropertyName = "numCuenta";
            this.numCuentaDataGridViewTextBoxColumn.HeaderText = "Cuenta";
            this.numCuentaDataGridViewTextBoxColumn.Name = "numCuentaDataGridViewTextBoxColumn";
            this.numCuentaDataGridViewTextBoxColumn.ReadOnly = true;
            this.numCuentaDataGridViewTextBoxColumn.Width = 150;
            // 
            // cuotaDataGridViewTextBoxColumn
            // 
            this.cuotaDataGridViewTextBoxColumn.DataPropertyName = "Cuota";
            this.cuotaDataGridViewTextBoxColumn.HeaderText = "Cuota";
            this.cuotaDataGridViewTextBoxColumn.Name = "cuotaDataGridViewTextBoxColumn";
            this.cuotaDataGridViewTextBoxColumn.ReadOnly = true;
            this.cuotaDataGridViewTextBoxColumn.Width = 150;
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Visible = false;
            // 
            // ContratoBindingSource
            // 
            this.ContratoBindingSource.DataMember = "Contrato";
            this.ContratoBindingSource.DataSource = this.contratoDataSet;
            // 
            // contratoDataSet
            // 
            this.contratoDataSet.DataSetName = "ContratoDataSet";
            this.contratoDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // contratoTableAdapter
            // 
            this.contratoTableAdapter.ClearBeforeFill = true;
            // 
            // ClienteContratoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 245);
            this.Controls.Add(this.dataGridView1);
            this.Name = "ClienteContratoFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contrato";
            this.Load += new System.EventHandler(this.ClienteContratoFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ContratoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.contratoDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource ContratoBindingSource;
        private DataSet.ContratoDataSet contratoDataSet;
        private DataSet.ContratoDataSetTableAdapters.ContratoTableAdapter contratoTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn numCuentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn cuotaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
    }
}