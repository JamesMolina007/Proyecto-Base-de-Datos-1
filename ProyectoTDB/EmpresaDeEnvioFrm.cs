using System;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class EmpresaDeEnvioFrm : Form
    {
        public EmpresaDeEnvioFrm()
        {
            InitializeComponent();
        }

        private void EmpresaDeEnvioFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'empresasDeEnvioDataSet.EmpresaDeEnvio' Puede moverla o quitarla según sea necesario.
            this.empresaDeEnvioTableAdapter.Fill(this.empresasDeEnvioDataSet.EmpresaDeEnvio);
            PrincipalBindingSource.AddNew();
        }

        private void tb_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb_Buscar.Text.Length > 0)
            {
                PrincipalBindingSource.Filter = "nombreEmpresa LIKE '*" + tb_Buscar.Text + "*'";
            }
            else
            {
                PrincipalBindingSource.RemoveFilter();
            }
        }

        private void dataGridView1_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            try
            {
                this.Validate();
                PrincipalBindingSource.EndEdit();
                empresaDeEnvioTableAdapter.Update(this.empresasDeEnvioDataSet.EmpresaDeEnvio);
            }
            catch (Exception ex)
            {
             //   MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Está Seguro que quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    PrincipalBindingSource.RemoveCurrent();
                    this.PrincipalBindingSource.EndEdit();
                    this.empresaDeEnvioTableAdapter.Update(this.empresasDeEnvioDataSet.EmpresaDeEnvio);
                    MessageBox.Show("El registro ha sido eliminado");
                    this.empresaDeEnvioTableAdapter.Fill(this.empresasDeEnvioDataSet.EmpresaDeEnvio);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("El registro no ha sido eliminado");
                }
            }
            catch (Exception ex)
            {
                // MessageBox.Show(ex.ToString());
            }
        }
    }
}
