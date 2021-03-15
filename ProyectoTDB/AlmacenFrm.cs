using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class AlmacenFrm : Form
    {
        public AlmacenFrm()
        {
            InitializeComponent();
        }

        private void AlmacenFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'almacenDataSet.Almacen' Puede moverla o quitarla según sea necesario.
            this.almacenTableAdapter.Fill(this.almacenDataSet.Almacen);
            DesHabilitar();
        }

        private void Recargar()
        {
            PrincipalBindingSource.RemoveFilter();
            this.almacenTableAdapter.Fill(this.almacenDataSet.Almacen);
            DesHabilitar();
        }

        private void Habilitar()
        {
            tb_Ciudad.Enabled = true;
            tb_Codigo.Enabled = true;
            btn_guardar.Enabled = true;
            btn_eliminar.Enabled = true;
            btn_nuevo.Enabled = false;
        }

        private void DesHabilitar()
        {
            tb_Ciudad.Enabled = false;
            tb_Codigo.Enabled = false;
            btn_guardar.Enabled = false;
            btn_eliminar.Enabled = false;
            btn_nuevo.Enabled = true;
        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            Habilitar();
            PrincipalBindingSource.AddNew();
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView reg = (DataRowView)PrincipalBindingSource.Current;
                this.Validate();
                this.PrincipalBindingSource.EndEdit();
                this.almacenTableAdapter.Update(this.almacenDataSet.Almacen);
                MessageBox.Show("Guardado Correctamente");
                Recargar();
            }
            catch (Exception exception)
            {
                MessageBox.Show("Datos guardados incorrectamente");
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Está Seguro que quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    PrincipalBindingSource.RemoveCurrent();
                    this.PrincipalBindingSource.EndEdit();
                    this.almacenTableAdapter.Update(this.almacenDataSet.Almacen);
                    MessageBox.Show("El registro ha sido eliminado");
                    Recargar();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("El registro no ha sido eliminado");
                }

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void BuscartoolStripTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (BuscartoolStripTextBox.Text.Length > 0)
            {
                if (BuscartoolStripComboBox.SelectedIndex >= 0)
                {
                    if (BuscartoolStripComboBox.SelectedItem.ToString().Equals("Código"))
                        PrincipalBindingSource.Filter = "codigoAlmacen LIKE '*" + BuscartoolStripTextBox.Text + "*'";
                    else
                    {
                        PrincipalBindingSource.Filter = "ciudad LIKE '*" + BuscartoolStripTextBox.Text + "*'";
                    }
                }
                else
                {
                    PrincipalBindingSource.Filter = "ciudad LIKE '*" + BuscartoolStripTextBox.Text + "*'";
                }
            }
            else
            {
                PrincipalBindingSource.RemoveFilter();
                DesHabilitar();
            }
        }

        private void PrincipalBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            DataRowView drvUsuario = (DataRowView)PrincipalBindingSource.Current;
            if (drvUsuario != null)
            {
                tb_Codigo.Text = drvUsuario.Row["codigoAlmacen"].ToString();
                tb_Ciudad.Text = drvUsuario.Row["ciudad"].ToString();
                btn_guardar.Enabled = true;
                btn_eliminar.Enabled = true;
                btn_nuevo.Enabled = false;
                tb_Codigo.Enabled = true;
                tb_Ciudad.Enabled = true;
                drvUsuario = null;
            }
        }

        private void btn_Recargar_Click(object sender, EventArgs e)
        {
            BuscartoolStripTextBox.Text = "";
            Recargar();
        }
    }
}
