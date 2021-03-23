namespace ProyectoDB
{
    partial class Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            this.lbl_nombreUsuario = new System.Windows.Forms.Label();
            this.lbl_contraseña = new System.Windows.Forms.Label();
            this.LogoPictureBox = new System.Windows.Forms.PictureBox();
            this.btn_aceptar = new System.Windows.Forms.Button();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.PrincipalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioDataSet = new ProyectoDB.DataSet.UsuarioDataSet();
            this.usuariosTableAdapter = new ProyectoDB.DataSet.UsuarioDataSetTableAdapters.UsuariosTableAdapter();
            this.tb_Contraseña = new System.Windows.Forms.TextBox();
            this.tb_nombreUsuario = new System.Windows.Forms.TextBox();
            this.ClienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesDataSet = new ProyectoDB.DataSet.ClientesDataSet();
            this.clienteVirtualTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteVirtualTableAdapter();
            this.ClienteFrecuenteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteFrecuenteTableAdapter = new ProyectoDB.DataSet.ClientesDataSetTableAdapters.ClienteFrecuenteTableAdapter();
            this.ActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usuarioActualTableAdapter = new ProyectoDB.DataSet.UsuarioDataSetTableAdapters.UsuarioActualTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteFrecuenteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActualBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_nombreUsuario
            // 
            this.lbl_nombreUsuario.AutoSize = true;
            this.lbl_nombreUsuario.Location = new System.Drawing.Point(171, 31);
            this.lbl_nombreUsuario.Name = "lbl_nombreUsuario";
            this.lbl_nombreUsuario.Size = new System.Drawing.Size(98, 13);
            this.lbl_nombreUsuario.TabIndex = 30;
            this.lbl_nombreUsuario.Text = "&Nombre de Usuario";
            // 
            // lbl_contraseña
            // 
            this.lbl_contraseña.AutoSize = true;
            this.lbl_contraseña.BackColor = System.Drawing.SystemColors.Control;
            this.lbl_contraseña.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbl_contraseña.Location = new System.Drawing.Point(171, 86);
            this.lbl_contraseña.Name = "lbl_contraseña";
            this.lbl_contraseña.Size = new System.Drawing.Size(61, 13);
            this.lbl_contraseña.TabIndex = 31;
            this.lbl_contraseña.Text = "&Contraseña";
            // 
            // LogoPictureBox
            // 
            this.LogoPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("LogoPictureBox.Image")));
            this.LogoPictureBox.Location = new System.Drawing.Point(0, 0);
            this.LogoPictureBox.Name = "LogoPictureBox";
            this.LogoPictureBox.Size = new System.Drawing.Size(165, 193);
            this.LogoPictureBox.TabIndex = 32;
            this.LogoPictureBox.TabStop = false;
            // 
            // btn_aceptar
            // 
            this.btn_aceptar.Location = new System.Drawing.Point(174, 139);
            this.btn_aceptar.Name = "btn_aceptar";
            this.btn_aceptar.Size = new System.Drawing.Size(95, 30);
            this.btn_aceptar.TabIndex = 3;
            this.btn_aceptar.Text = "&Aceptar";
            this.btn_aceptar.UseVisualStyleBackColor = true;
            this.btn_aceptar.Click += new System.EventHandler(this.btn_aceptar_Click);
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(301, 139);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(95, 30);
            this.btn_cancelar.TabIndex = 34;
            this.btn_cancelar.Text = "&Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // PrincipalBindingSource
            // 
            this.PrincipalBindingSource.DataMember = "Usuarios";
            this.PrincipalBindingSource.DataSource = this.usuarioDataSet;
            // 
            // usuarioDataSet
            // 
            this.usuarioDataSet.DataSetName = "UsuarioDataSet";
            this.usuarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usuariosTableAdapter
            // 
            this.usuariosTableAdapter.ClearBeforeFill = true;
            // 
            // tb_Contraseña
            // 
            this.tb_Contraseña.Location = new System.Drawing.Point(174, 102);
            this.tb_Contraseña.Name = "tb_Contraseña";
            this.tb_Contraseña.PasswordChar = '*';
            this.tb_Contraseña.Size = new System.Drawing.Size(223, 20);
            this.tb_Contraseña.TabIndex = 1;
            // 
            // tb_nombreUsuario
            // 
            this.tb_nombreUsuario.Location = new System.Drawing.Point(174, 48);
            this.tb_nombreUsuario.Name = "tb_nombreUsuario";
            this.tb_nombreUsuario.Size = new System.Drawing.Size(222, 20);
            this.tb_nombreUsuario.TabIndex = 0;
            this.tb_nombreUsuario.Tag = "";
            // 
            // ClienteBindingSource
            // 
            this.ClienteBindingSource.DataMember = "ClienteVirtual";
            this.ClienteBindingSource.DataSource = this.clientesDataSet;
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
            // ClienteFrecuenteBindingSource
            // 
            this.ClienteFrecuenteBindingSource.DataMember = "ClienteFrecuente";
            this.ClienteFrecuenteBindingSource.DataSource = this.clientesDataSet;
            // 
            // clienteFrecuenteTableAdapter
            // 
            this.clienteFrecuenteTableAdapter.ClearBeforeFill = true;
            // 
            // ActualBindingSource
            // 
            this.ActualBindingSource.DataMember = "UsuarioActual";
            this.ActualBindingSource.DataSource = this.usuarioDataSet;
            // 
            // usuarioActualTableAdapter
            // 
            this.usuarioActualTableAdapter.ClearBeforeFill = true;
            // 
            // Login
            // 
            this.AcceptButton = this.btn_aceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(423, 192);
            this.Controls.Add(this.tb_nombreUsuario);
            this.Controls.Add(this.tb_Contraseña);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.btn_aceptar);
            this.Controls.Add(this.LogoPictureBox);
            this.Controls.Add(this.lbl_contraseña);
            this.Controls.Add(this.lbl_nombreUsuario);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LogoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PrincipalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usuarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClienteFrecuenteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ActualBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_nombreUsuario;
        private System.Windows.Forms.Label lbl_contraseña;
        internal System.Windows.Forms.PictureBox LogoPictureBox;
        private System.Windows.Forms.Button btn_aceptar;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.BindingSource PrincipalBindingSource;
        private DataSet.UsuarioDataSet usuarioDataSet;
        private DataSet.UsuarioDataSetTableAdapters.UsuariosTableAdapter usuariosTableAdapter;
        private System.Windows.Forms.TextBox tb_Contraseña;
        private System.Windows.Forms.TextBox tb_nombreUsuario;
        private System.Windows.Forms.BindingSource ClienteBindingSource;
        private DataSet.ClientesDataSet clientesDataSet;
        private DataSet.ClientesDataSetTableAdapters.ClienteVirtualTableAdapter clienteVirtualTableAdapter;
        private System.Windows.Forms.BindingSource ClienteFrecuenteBindingSource;
        private DataSet.ClientesDataSetTableAdapters.ClienteFrecuenteTableAdapter clienteFrecuenteTableAdapter;
        private System.Windows.Forms.BindingSource ActualBindingSource;
        private DataSet.UsuarioDataSetTableAdapters.UsuarioActualTableAdapter usuarioActualTableAdapter;
    }
}