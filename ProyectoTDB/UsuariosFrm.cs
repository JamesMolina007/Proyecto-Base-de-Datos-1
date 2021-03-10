﻿using System;
using System.Data;
using System.Threading;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class UsuariosFrm : Form
    {
        public UsuariosFrm()
        {
            InitializeComponent();
        }

        private void UsuariosFrm_Load(object sender, EventArgs e)
        {
            this.usuariosTableAdapter.Fill(this.usuarioDataSet.Usuarios);
            deshabilitar();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e){
            DataRowView drvUsuario = (DataRowView)usuariosBindingSource.Current;
            tb_nombre.Text = drvUsuario.Row["Nombre"].ToString();
            tb_nombreUsuario.Text = drvUsuario.Row["nombreUsuario"].ToString();
            tb_Contrasena1.Text = drvUsuario.Row["Contrasena"].ToString();
            tb_Contrasena2.Text = drvUsuario.Row["Contrasena"].ToString();
            habilitar();
            btn_nuevo.Enabled = false;
            btn_guardar.Enabled = true;
            btn_eliminar.Enabled = true;
            drvUsuario = null;
        }

        private void deshabilitar()
        {
            tb_nombre.Enabled = false;
            tb_nombreUsuario.Enabled = false;
            tb_Contrasena1.Enabled = false;
            tb_Contrasena2.Enabled = false;
            cb_TipoUsuario.Enabled = false;
            btn_guardar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_nuevo.Enabled = true;
        }

        private void habilitar()
        {
            tb_nombre.Enabled = true;
            tb_nombreUsuario.Enabled = true;
            tb_Contrasena1.Enabled = true;
            tb_Contrasena2.Enabled = true;
            cb_TipoUsuario.Enabled = true;
            btn_guardar.Enabled = true;
        }

        

        private void recargar()
        {
            this.usuariosTableAdapter.Fill(this.usuarioDataSet.Usuarios);
            deshabilitar();
            
        }

        private void btn_Recargar_Click(object sender, EventArgs e)
        {
            recargar();
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            habilitar();
            usuariosBindingSource.AddNew();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_Contrasena1.Text.Equals(tb_Contrasena2.Text))
                {
                    DataRowView reg = (DataRowView)usuariosBindingSource.Current;
                    this.Validate();
                    this.usuariosBindingSource.EndEdit();
                    this.usuariosTableAdapter.Update(this.usuarioDataSet.Usuarios);
                    MessageBox.Show("Guardado Correctamente");
                    recargar();
                }
                else
                {
                    MessageBox.Show("Las contraseñas deben ser las mismas");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try{
                DialogResult dialogResult = MessageBox.Show("¿Está Seguro que quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes){
                    usuariosBindingSource.RemoveCurrent();
                    this.usuariosBindingSource.EndEdit();
                    this.usuariosTableAdapter.Update(this.usuarioDataSet.Usuarios);
                    MessageBox.Show("El registro ha sido eliminado");
                    recargar();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("El registro no ha sido eliminado");
                }
                
            }catch(Exception exception){
                MessageBox.Show(exception.ToString());
            }
            
        
        }

        private void BuscartoolStripTextBox_Click(object sender, EventArgs e) { 
            ThreadStart hiloDeBusqueda = new ThreadStart(busqueda);
            Thread hilo = new Thread(hiloDeBusqueda);
            hilo.Start();
        }

        private void busqueda(){
            Thread.Sleep(3000);
            MessageBox.Show("Hola Mundo");
            try
            {
                if (!BuscartoolStripTextBox.Equals(""))
                {
                    usuariosTableAdapter.FillByCaracter(usuarioDataSet.Usuarios, BuscartoolStripTextBox.Text);
                }
            }
            catch (Exception e)
            {

            }
        }

    }
}
