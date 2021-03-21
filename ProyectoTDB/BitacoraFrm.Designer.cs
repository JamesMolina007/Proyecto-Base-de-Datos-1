﻿namespace ProyectoDB
{
    partial class BitacoraFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BitacoraFrm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.PrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bitacoraDataSet = new ProyectoDB.DataSet.BitacoraDataSet();
            this.bitacoraTableAdapter = new ProyectoDB.DataSet.BitacoraDataSetTableAdapters.BitacoraTableAdapter();
            this.usuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.accionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tablaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registroDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.cb_Tabla = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.tb_Accion = new System.Windows.Forms.ToolStripComboBox();
            this.btn_Filtrar = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraDataSet)).BeginInit();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.usuarioDataGridViewTextBoxColumn,
            this.accionDataGridViewTextBoxColumn,
            this.tablaDataGridViewTextBoxColumn,
            this.registroDataGridViewTextBoxColumn,
            this.fechaDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.PrincipalBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 42);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(576, 390);
            this.dataGridView1.TabIndex = 0;
            // 
            // PrincipalBindingSource
            // 
            this.PrincipalBindingSource.DataMember = "Bitacora";
            this.PrincipalBindingSource.DataSource = this.bitacoraDataSet;
            // 
            // bitacoraDataSet
            // 
            this.bitacoraDataSet.DataSetName = "BitacoraDataSet";
            this.bitacoraDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bitacoraTableAdapter
            // 
            this.bitacoraTableAdapter.ClearBeforeFill = true;
            // 
            // usuarioDataGridViewTextBoxColumn
            // 
            this.usuarioDataGridViewTextBoxColumn.DataPropertyName = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.HeaderText = "Usuario";
            this.usuarioDataGridViewTextBoxColumn.Name = "usuarioDataGridViewTextBoxColumn";
            this.usuarioDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // accionDataGridViewTextBoxColumn
            // 
            this.accionDataGridViewTextBoxColumn.DataPropertyName = "Accion";
            this.accionDataGridViewTextBoxColumn.HeaderText = "Accion";
            this.accionDataGridViewTextBoxColumn.Name = "accionDataGridViewTextBoxColumn";
            this.accionDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // tablaDataGridViewTextBoxColumn
            // 
            this.tablaDataGridViewTextBoxColumn.DataPropertyName = "Tabla";
            this.tablaDataGridViewTextBoxColumn.HeaderText = "Tabla";
            this.tablaDataGridViewTextBoxColumn.Name = "tablaDataGridViewTextBoxColumn";
            this.tablaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // registroDataGridViewTextBoxColumn
            // 
            this.registroDataGridViewTextBoxColumn.DataPropertyName = "Registro";
            this.registroDataGridViewTextBoxColumn.HeaderText = "Registro";
            this.registroDataGridViewTextBoxColumn.Name = "registroDataGridViewTextBoxColumn";
            this.registroDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // fechaDataGridViewTextBoxColumn
            // 
            this.fechaDataGridViewTextBoxColumn.DataPropertyName = "Fecha";
            this.fechaDataGridViewTextBoxColumn.HeaderText = "Fecha";
            this.fechaDataGridViewTextBoxColumn.Name = "fechaDataGridViewTextBoxColumn";
            this.fechaDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // toolStrip1
            // 
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.cb_Tabla,
            this.toolStripSeparator1,
            this.toolStripLabel2,
            this.tb_Accion,
            this.toolStripSeparator2,
            this.btn_Filtrar});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(603, 39);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 36);
            this.toolStripLabel1.Text = "Tabla:";
            // 
            // cb_Tabla
            // 
            this.cb_Tabla.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_Tabla.Name = "cb_Tabla";
            this.cb_Tabla.Size = new System.Drawing.Size(121, 39);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(47, 36);
            this.toolStripLabel2.Text = "Acción:";
            // 
            // tb_Accion
            // 
            this.tb_Accion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tb_Accion.Items.AddRange(new object[] {
            "Update",
            "Insert",
            "Delete"});
            this.tb_Accion.Name = "tb_Accion";
            this.tb_Accion.Size = new System.Drawing.Size(121, 39);
            // 
            // btn_Filtrar
            // 
            this.btn_Filtrar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Filtrar.Image")));
            this.btn_Filtrar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_Filtrar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Filtrar.Name = "btn_Filtrar";
            this.btn_Filtrar.Size = new System.Drawing.Size(73, 36);
            this.btn_Filtrar.Text = "Filtrar";
            this.btn_Filtrar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Filtrar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // BitacoraFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(603, 444);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "BitacoraFrm";
            this.Text = "Bitacora";
            this.Load += new System.EventHandler(this.BitacoraFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bitacoraDataSet)).EndInit();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource PrincipalBindingSource;
        private DataSet.BitacoraDataSet bitacoraDataSet;
        private DataSet.BitacoraDataSetTableAdapters.BitacoraTableAdapter bitacoraTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn usuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn accionDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn tablaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn registroDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox cb_Tabla;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox tb_Accion;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton btn_Filtrar;
    }
}