namespace ProyectoDB
{
    partial class SQLFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SQLFrm));
            this.tb_SQL = new System.Windows.Forms.TextBox();
            this.dbGrid_sql = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid_sql)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_SQL
            // 
            this.tb_SQL.Location = new System.Drawing.Point(13, 65);
            this.tb_SQL.Multiline = true;
            this.tb_SQL.Name = "tb_SQL";
            this.tb_SQL.Size = new System.Drawing.Size(748, 143);
            this.tb_SQL.TabIndex = 0;
            // 
            // dbGrid_sql
            // 
            this.dbGrid_sql.AllowUserToAddRows = false;
            this.dbGrid_sql.AllowUserToDeleteRows = false;
            this.dbGrid_sql.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbGrid_sql.Location = new System.Drawing.Point(13, 214);
            this.dbGrid_sql.Name = "dbGrid_sql";
            this.dbGrid_sql.ReadOnly = true;
            this.dbGrid_sql.Size = new System.Drawing.Size(748, 259);
            this.dbGrid_sql.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(318, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 47);
            this.button1.TabIndex = 2;
            this.button1.Text = "EJECUTAR";
            this.button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // SQLFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(773, 485);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dbGrid_sql);
            this.Controls.Add(this.tb_SQL);
            this.Name = "SQLFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SQL";
            ((System.ComponentModel.ISupportInitialize)(this.dbGrid_sql)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_SQL;
        private System.Windows.Forms.DataGridView dbGrid_sql;
        private System.Windows.Forms.Button button1;
    }
}