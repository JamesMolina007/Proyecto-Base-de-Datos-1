namespace ProyectoDB
{
    partial class UsuariosFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuariosFrm));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipoUsuarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usuariosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioDataSet = new ProyectoDB.DataSet.UsuarioDataSet();
            this.tb_nombre = new System.Windows.Forms.TextBox();
            this.tb_Contrasena1 = new System.Windows.Forms.TextBox();
            this.tb_Contrasena2 = new System.Windows.Forms.TextBox();
            this.cb_TipoUsuario = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.toolStripMenu = new System.Windows.Forms.ToolStrip();
            this.btn_nuevo = new System.Windows.Forms.ToolStripButton();
            this.btn_guardar = new System.Windows.Forms.ToolStripButton();
            this.btn_Recargar = new System.Windows.Forms.ToolStripButton();
            this.btn_eliminar = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.BuscartoolStripTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_nombreUsuario = new System.Windows.Forms.TextBox();
            this.usuariosTableAdapter = new ProyectoDB.DataSet.UsuarioDataSetTableAdapters.UsuariosTableAdapter();
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataSet = new ProyectoDB.DataSet.ClientesDataSet();
            this.clienteTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataSet)).BeginInit();
            this.toolStripMenu.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.tipoUsuarioDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.usuariosBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 66);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(560, 341);
            this.dataGridView1.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ID";
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nombre";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nombre";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "nombreUsuario";
            this.dataGridViewTextBoxColumn3.HeaderText = "Nombre de Usuario";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 150;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Contrasena";
            this.dataGridViewTextBoxColumn4.HeaderText = "Contrasena";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Visible = false;
            // 
            // tipoUsuarioDataGridViewTextBoxColumn
            // 
            this.tipoUsuarioDataGridViewTextBoxColumn.DataPropertyName = "tipoUsuario";
            this.tipoUsuarioDataGridViewTextBoxColumn.HeaderText = "Tipo de Usuario";
            this.tipoUsuarioDataGridViewTextBoxColumn.Name = "tipoUsuarioDataGridViewTextBoxColumn";
            this.tipoUsuarioDataGridViewTextBoxColumn.ReadOnly = true;
            this.tipoUsuarioDataGridViewTextBoxColumn.Width = 150;
            // 
            // usuariosBindingSource
            // 
            this.usuariosBindingSource.DataMember = "Usuarios";
            this.usuariosBindingSource.DataSource = this.usuarioDataSet;
            this.usuariosBindingSource.PositionChanged += new System.EventHandler(this.usuariosBindingSource_PositionChanged);
            // 
            // usuarioDataSet
            // 
            this.usuarioDataSet.DataSetName = "UsuarioDataSet";
            this.usuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tb_nombre
            // 
            this.tb_nombre.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Nombre", true));
            this.tb_nombre.Location = new System.Drawing.Point(16, 50);
            this.tb_nombre.Name = "tb_nombre";
            this.tb_nombre.Size = new System.Drawing.Size(223, 20);
            this.tb_nombre.TabIndex = 1;
            // 
            // tb_Contrasena1
            // 
            this.tb_Contrasena1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Contrasena", true));
            this.tb_Contrasena1.Location = new System.Drawing.Point(16, 245);
            this.tb_Contrasena1.Name = "tb_Contrasena1";
            this.tb_Contrasena1.PasswordChar = '*';
            this.tb_Contrasena1.Size = new System.Drawing.Size(223, 20);
            this.tb_Contrasena1.TabIndex = 2;
            // 
            // tb_Contrasena2
            // 
            this.tb_Contrasena2.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "Contrasena", true));
            this.tb_Contrasena2.Location = new System.Drawing.Point(16, 301);
            this.tb_Contrasena2.Name = "tb_Contrasena2";
            this.tb_Contrasena2.PasswordChar = '*';
            this.tb_Contrasena2.Size = new System.Drawing.Size(223, 20);
            this.tb_Contrasena2.TabIndex = 3;
            // 
            // cb_TipoUsuario
            // 
            this.cb_TipoUsuario.DataBindings.Add(new System.Windows.Forms.Binding("SelectedItem", this.usuariosBindingSource, "tipoUsuario", true));
            this.cb_TipoUsuario.FormattingEnabled = true;
            this.cb_TipoUsuario.Items.AddRange(new object[] {
            "Administrador",
            "Servicio al Cliente",
            "Personal de Centro de Llamadas",
            "Empleado de Almacen",
            "Cliente"});
            this.cb_TipoUsuario.Location = new System.Drawing.Point(16, 175);
            this.cb_TipoUsuario.Name = "cb_TipoUsuario";
            this.cb_TipoUsuario.Size = new System.Drawing.Size(223, 21);
            this.cb_TipoUsuario.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 150);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de Usuario:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Confirmar Contraseña:";
            // 
            // toolStripMenu
            // 
            this.toolStripMenu.BackColor = System.Drawing.SystemColors.ControlLight;
            this.toolStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_nuevo,
            this.btn_guardar,
            this.btn_Recargar,
            this.btn_eliminar,
            this.toolStripLabel1,
            this.BuscartoolStripTextBox});
            this.toolStripMenu.Location = new System.Drawing.Point(0, 0);
            this.toolStripMenu.Name = "toolStripMenu";
            this.toolStripMenu.Size = new System.Drawing.Size(859, 54);
            this.toolStripMenu.TabIndex = 9;
            this.toolStripMenu.Text = "toolStrip1";
            // 
            // btn_nuevo
            // 
            this.btn_nuevo.Image = ((System.Drawing.Image)(resources.GetObject("btn_nuevo.Image")));
            this.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_nuevo.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_nuevo.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_nuevo.Name = "btn_nuevo";
            this.btn_nuevo.Size = new System.Drawing.Size(46, 51);
            this.btn_nuevo.Text = "Nuevo";
            this.btn_nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_nuevo.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btn_nuevo.Click += new System.EventHandler(this.btn_nuevo_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_guardar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_guardar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(53, 51);
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_guardar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
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
            // btn_eliminar
            // 
            this.btn_eliminar.Image = ((System.Drawing.Image)(resources.GetObject("btn_eliminar.Image")));
            this.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_eliminar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.btn_eliminar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_eliminar.Name = "btn_eliminar";
            this.btn_eliminar.Size = new System.Drawing.Size(54, 51);
            this.btn_eliminar.Text = "Eliminar";
            this.btn_eliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_eliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_eliminar.Click += new System.EventHandler(this.btn_eliminar_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(88, 51);
            this.toolStripLabel1.Text = "Buscar Usuario:";
            // 
            // BuscartoolStripTextBox
            // 
            this.BuscartoolStripTextBox.Name = "BuscartoolStripTextBox";
            this.BuscartoolStripTextBox.Size = new System.Drawing.Size(100, 54);
            this.BuscartoolStripTextBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.BuscartoolStripTextBox_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.tb_nombreUsuario);
            this.groupBox1.Controls.Add(this.tb_nombre);
            this.groupBox1.Controls.Add(this.tb_Contrasena1);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tb_Contrasena2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cb_TipoUsuario);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(602, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(245, 341);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos De Usuario";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Nombre De Usuario:";
            // 
            // tb_nombreUsuario
            // 
            this.tb_nombreUsuario.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.usuariosBindingSource, "nombreUsuario", true));
            this.tb_nombreUsuario.Location = new System.Drawing.Point(16, 106);
            this.tb_nombreUsuario.Name = "tb_nombreUsuario";
            this.tb_nombreUsuario.Size = new System.Drawing.Size(223, 20);
            this.tb_nombreUsuario.TabIndex = 9;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataMember = "Cliente";
            this.ClienteBindingSource.DataSource = this.clientesDataSet;
            // 
            // clientesDataSet
            // 
            this.clientesDataSet.DataSetName = "ClientesDataSet";
            this.clientesDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // UsuariosFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(859, 418);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.toolStripMenu);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UsuariosFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.UsuariosFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuariosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataSet)).EndInit();
            this.toolStripMenu.ResumeLayout(false);
            this.toolStripMenu.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox tb_nombre;
        private System.Windows.Forms.TextBox tb_Contrasena1;
        private System.Windows.Forms.TextBox tb_Contrasena2;
        private System.Windows.Forms.ComboBox cb_TipoUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ToolStrip toolStripMenu;
        private System.Windows.Forms.ToolStripButton btn_nuevo;
        private System.Windows.Forms.ToolStripButton btn_guardar;
        private System.Windows.Forms.ToolStripButton btn_eliminar;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contrasenaDataGridViewTextBoxColumn;
        private DataSet.UsuarioDataSet usuarioDataSet;
        private System.Windows.Forms.BindingSource usuariosBindingSource;
        private DataSet.UsuarioDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn tipoUsuarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_nombreUsuario;
        private System.Windows.Forms.ToolStripButton btn_Recargar;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripTextBox BuscartoolStripTextBox;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private DataSet.ClientesDataSet clientesDataSet;
        private DataSet.ClientesDataSetTableAdapters.ClienteTableAdapter clienteTableAdapter;
    }
}