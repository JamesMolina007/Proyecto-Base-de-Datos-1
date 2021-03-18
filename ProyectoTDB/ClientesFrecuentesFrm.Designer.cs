namespace ProyectoDB
{
    partial class ClientesFrecuentesFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClientesFrecuentesFrm));
            this.ClienteFrecuenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataSet = new ProyectoDB.DataSet.ClientesDataSet();
            this.ClientePocoFrecuenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteFrecuenteTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteFrecuenteTableAdapter();
            this.clientePocoFrecuenteTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClientePocoFrecuenteTableAdapter();
            this.cb_IdCliente = new System.Windows.Forms.ComboBox();
            this.ClientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.clienteTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteFrecuenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientePocoFrecuenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).BeginInit();
            this.SuspendLayout();
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
            // ClientePocoFrecuenteBindingSource
            // 
            this.ClientePocoFrecuenteBindingSource.DataMember = "ClientePocoFrecuente";
            this.ClientePocoFrecuenteBindingSource.DataSource = this.clientesDataSet;
            // 
            // clienteFrecuenteTableAdapter
            // 
            this.clienteFrecuenteTableAdapter.ClearBeforeFill = true;
            // 
            // clientePocoFrecuenteTableAdapter
            // 
            this.clientePocoFrecuenteTableAdapter.ClearBeforeFill = true;
            // 
            // cb_IdCliente
            // 
            this.cb_IdCliente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.ClientesBindingSource, "idCliente", true));
            this.cb_IdCliente.DataSource = this.ClientesBindingSource;
            this.cb_IdCliente.DisplayMember = "nombreCliente";
            this.cb_IdCliente.FormattingEnabled = true;
            this.cb_IdCliente.Location = new System.Drawing.Point(13, 43);
            this.cb_IdCliente.Name = "cb_IdCliente";
            this.cb_IdCliente.Size = new System.Drawing.Size(259, 21);
            this.cb_IdCliente.TabIndex = 0;
            this.cb_IdCliente.ValueMember = "idCliente";
            // 
            // ClientesBindingSource
            // 
            this.ClientesBindingSource.DataMember = "Cliente";
            this.ClientesBindingSource.DataSource = this.clientesDataSet;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre del Cliente:";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(86, 83);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(113, 40);
            this.btn_Agregar.TabIndex = 10;
            this.btn_Agregar.Text = "     &Agregar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // ClientesFrecuentesFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(289, 146);
            this.Controls.Add(this.btn_Agregar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_IdCliente);
            this.Name = "ClientesFrecuentesFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes Frecuentes";
            this.Load += new System.EventHandler(this.ClientesFrecuentesFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ClienteFrecuenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientePocoFrecuenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.BindingSource ClienteFrecuenteBindingSource;
        private DataSet.ClientesDataSet clientesDataSet;
        private System.Windows.Forms.BindingSource ClientePocoFrecuenteBindingSource;
        private DataSet.ClientesDataSetTableAdapters.ClienteFrecuenteTableAdapter clienteFrecuenteTableAdapter;
        private DataSet.ClientesDataSetTableAdapters.ClientePocoFrecuenteTableAdapter clientePocoFrecuenteTableAdapter;
        private System.Windows.Forms.ComboBox cb_IdCliente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.BindingSource ClientesBindingSource;
        private DataSet.ClientesDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
    }
}