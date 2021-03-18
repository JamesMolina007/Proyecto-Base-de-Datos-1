namespace ProyectoDB
{
    partial class ClienteProcesaOrdenFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ClienteProcesaOrdenFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Agregar = new System.Windows.Forms.Button();
            this.btn_Eliminar = new System.Windows.Forms.Button();
            this.cb_Envio = new System.Windows.Forms.ComboBox();
            this.OrdenBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordenDataSet = new ProyectoDB.DataSet.OrdenDataSet();
            this.EmpresaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empresasDeEnvioDataSet = new ProyectoDB.DataSet.EmpresasDeEnvioDataSet();
            this.label3 = new System.Windows.Forms.Label();
            this.tb_Remitente = new System.Windows.Forms.TextBox();
            this.tb_Direccion = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ordenTableAdapter = new ProyectoDB.DataSet.OrdenDataSetTableAdapters.OrdenTableAdapter();
            this.empresaDeEnvioTableAdapter = new ProyectoDB.DataSet.EmpresasDeEnvioDataSetTableAdapters.EmpresaDeEnvioTableAdapter();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDeEnvioDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_Agregar);
            this.groupBox1.Controls.Add(this.btn_Eliminar);
            this.groupBox1.Controls.Add(this.cb_Envio);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.tb_Remitente);
            this.groupBox1.Controls.Add(this.tb_Direccion);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 289);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos del Proceso:";
            // 
            // btn_Agregar
            // 
            this.btn_Agregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Agregar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Agregar.Image")));
            this.btn_Agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Agregar.Location = new System.Drawing.Point(23, 222);
            this.btn_Agregar.Name = "btn_Agregar";
            this.btn_Agregar.Size = new System.Drawing.Size(113, 41);
            this.btn_Agregar.TabIndex = 10;
            this.btn_Agregar.Text = "     &Firmar";
            this.btn_Agregar.UseVisualStyleBackColor = true;
            this.btn_Agregar.Click += new System.EventHandler(this.btn_Agregar_Click);
            // 
            // btn_Eliminar
            // 
            this.btn_Eliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Eliminar.Image")));
            this.btn_Eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Eliminar.Location = new System.Drawing.Point(185, 222);
            this.btn_Eliminar.Name = "btn_Eliminar";
            this.btn_Eliminar.Size = new System.Drawing.Size(113, 41);
            this.btn_Eliminar.TabIndex = 9;
            this.btn_Eliminar.Text = "     &Cancelar";
            this.btn_Eliminar.UseVisualStyleBackColor = true;
            this.btn_Eliminar.Click += new System.EventHandler(this.btn_Eliminar_Click);
            // 
            // cb_Envio
            // 
            this.cb_Envio.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.OrdenBindingSource, "empresaEnvio", true));
            this.cb_Envio.DataSource = this.EmpresaBindingSource;
            this.cb_Envio.DisplayMember = "nombreEmpresa";
            this.cb_Envio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Envio.FormattingEnabled = true;
            this.cb_Envio.Location = new System.Drawing.Point(111, 161);
            this.cb_Envio.Name = "cb_Envio";
            this.cb_Envio.Size = new System.Drawing.Size(187, 21);
            this.cb_Envio.TabIndex = 5;
            this.cb_Envio.ValueMember = "nombreEmpresa";
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
            // EmpresaBindingSource
            // 
            this.EmpresaBindingSource.DataMember = "EmpresaDeEnvio";
            this.EmpresaBindingSource.DataSource = this.empresasDeEnvioDataSet;
            // 
            // empresasDeEnvioDataSet
            // 
            this.empresasDeEnvioDataSet.DataSetName = "EmpresasDeEnvioDataSet";
            this.empresasDeEnvioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Empresa de Envío:";
            // 
            // tb_Remitente
            // 
            this.tb_Remitente.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.OrdenBindingSource, "nombreRemitente", true));
            this.tb_Remitente.Location = new System.Drawing.Point(66, 34);
            this.tb_Remitente.Name = "tb_Remitente";
            this.tb_Remitente.Size = new System.Drawing.Size(232, 20);
            this.tb_Remitente.TabIndex = 3;
            // 
            // tb_Direccion
            // 
            this.tb_Direccion.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.OrdenBindingSource, "direccionEnvio", true));
            this.tb_Direccion.Location = new System.Drawing.Point(66, 85);
            this.tb_Direccion.Multiline = true;
            this.tb_Direccion.Name = "tb_Direccion";
            this.tb_Direccion.Size = new System.Drawing.Size(232, 52);
            this.tb_Direccion.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(10, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Dirección:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Remitente:";
            // 
            // ordenTableAdapter
            // 
            this.ordenTableAdapter.ClearBeforeFill = true;
            // 
            // empresaDeEnvioTableAdapter
            // 
            this.empresaDeEnvioTableAdapter.ClearBeforeFill = true;
            // 
            // ClienteProcesaOrdenFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 321);
            this.Controls.Add(this.groupBox1);
            this.Name = "ClienteProcesaOrdenFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Proceso de Orden";
            this.Load += new System.EventHandler(this.ClienteProcesaOrdenFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.OrdenBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordenDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EmpresaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.empresasDeEnvioDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tb_Direccion;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cb_Envio;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tb_Remitente;
        private System.Windows.Forms.Button btn_Agregar;
        private System.Windows.Forms.Button btn_Eliminar;
        private System.Windows.Forms.BindingSource OrdenBindingSource;
        private DataSet.OrdenDataSet ordenDataSet;
        private System.Windows.Forms.BindingSource EmpresaBindingSource;
        private DataSet.OrdenDataSetTableAdapters.OrdenTableAdapter ordenTableAdapter;
        private DataSet.EmpresasDeEnvioDataSet empresasDeEnvioDataSet;
        private DataSet.EmpresasDeEnvioDataSetTableAdapters.EmpresaDeEnvioTableAdapter empresaDeEnvioTableAdapter;
    }
}