namespace ProyectoDB
{
    partial class ClienteTiendaFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteTiendaFrm));
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cb_IdCliente = new System.Windows.Forms.ComboBox();
            this.ClienteTiendaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ClienteFrecuenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataSet = new ProyectoDB.DataSet.ClientesDataSet();
            this.clienteFrecuenteTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteFrecuenteTableAdapter();
            this.ClientePocoFrecuenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientePocoFrecuenteTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClientePocoFrecuenteTableAdapter();
            this.clienteTiendaTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteTiendaTableAdapter();
            this.clienteTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteTableAdapter();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.idClienteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteTiendaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteFrecuenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientePocoFrecuenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(81, 69);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(113, 40);
            this.btn_Agregar.TabIndex = 13;
            this.btn_Agregar.Text = "     &Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 12;
            this.label1.Text = "Nombre del Cliente:";
            // 
            // cb_IdCliente
            // 
            this.cb_IdCliente.DataSource = this.ClienteBindingSource;
            this.cb_IdCliente.DisplayMember = "nombreCliente";
            this.cb_IdCliente.FormattingEnabled = true;
            this.cb_IdCliente.Location = new System.Drawing.Point(8, 42);
            this.cb_IdCliente.Name = "cb_IdCliente";
            this.cb_IdCliente.Size = new System.Drawing.Size(271, 21);
            this.cb_IdCliente.TabIndex = 11;
            this.cb_IdCliente.ValueMember = "idCliente";
            // 
            // ClienteTiendaBindingSource
            // 
            this.ClienteTiendaBindingSource.DataMember = "ClienteTienda";
            this.ClienteTiendaBindingSource.DataSource = this.clientesDataSet;
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataMember = "Cliente";
            this.ClienteBindingSource.DataSource = this.clientesDataSet;
            // 
            // ClienteFrecuenteBindingSource
            // 
            this.ClienteFrecuenteBindingSource.DataMember = "ClienteFrecuente";
            this.ClienteFrecuenteBindingSource.DataSource = this.clientesDataSet;
            // 
            // clientesDataSet
            // 
            this.clientesDataSet.DataSetName = "ClientesDataSet";
            this.clientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteFrecuenteTableAdapter
            // 
            this.clienteFrecuenteTableAdapter.ClearBeforeFill = true;
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
            // clienteTiendaTableAdapter
            // 
            this.clienteTiendaTableAdapter.ClearBeforeFill = true;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idClienteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.ClienteTiendaBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(11, 115);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(268, 205);
            this.dataGridView1.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(101, 330);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 42);
            this.button1.TabIndex = 15;
            this.button1.Text = "&Eliminar";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idClienteDataGridViewTextBoxColumn
            // 
            this.idClienteDataGridViewTextBoxColumn.DataPropertyName = "idCliente";
            this.idClienteDataGridViewTextBoxColumn.HeaderText = "ID del Cliente";
            this.idClienteDataGridViewTextBoxColumn.Name = "idClienteDataGridViewTextBoxColumn";
            this.idClienteDataGridViewTextBoxColumn.ReadOnly = true;
            this.idClienteDataGridViewTextBoxColumn.Width = 200;
            // 
            // ClienteTiendaFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(291, 384);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_IdCliente);
            this.Name = "ClienteTiendaFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes de Tienda";
            this.Load += new System.EventHandler(this.ClienteTiendaFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteTiendaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteFrecuenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientePocoFrecuenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_IdCliente;
        private System.Windows.Forms.BindingSource ClienteTiendaBindingSource;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private System.Windows.Forms.BindingSource ClienteFrecuenteBindingSource;
        private DataSet.ClientesDataSet clientesDataSet;
        private DataSet.ClientesDataSetTableAdapters.ClienteFrecuenteTableAdapter clienteFrecuenteTableAdapter;
        private System.Windows.Forms.BindingSource ClientePocoFrecuenteBindingSource;
        private DataSet.ClientesDataSetTableAdapters.ClientePocoFrecuenteTableAdapter clientePocoFrecuenteTableAdapter;
        private DataSet.ClientesDataSetTableAdapters.ClienteTiendaTableAdapter clienteTiendaTableAdapter;
        private DataSet.ClientesDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewTextBoxColumn idClienteDataGridViewTextBoxColumn;
    }
}