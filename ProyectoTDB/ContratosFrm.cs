using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ContratosFrm : Form
    {
        private String tipoUsuario = "";
        public void SetTipoUsuario(String tipoUsuario)
        {
            this.tipoUsuario = tipoUsuario;
        }
        public ContratosFrm()
        {
            InitializeComponent();
        }

        private void ContratosFrm_Load(object sender, EventArgs e)
        {
            if(tipoUsuario.Equals("Personal Del Centro De Llamadas"))
            {
                btn_Nuevo.Visible = false;
                btn_Guardar.Visible = false;
                btn_Eliminar.Visible = false;
                gb_Datos.Enabled = false;
            }
            recargar();
        }

        private void recargar() {
            btn_Eliminar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Nuevo.Enabled = true;
            gb_Datos.Enabled = false;
            this.contratoTableAdapter.Fill(this.contratoDataSet.Contrato);
            this.clienteFrecuenteTableAdapter.Fill(this.contratoDataSet.ClienteFrecuente);
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            PrincipalBindingSource.AddNew();
            btn_Guardar.Enabled = true;
            btn_Eliminar.Enabled = false;
            btn_Nuevo.Enabled = false;
            gb_Datos.Enabled = true;
            tb_Cuota.Text = "";
            tb_numeroCuenta.Text = "";
        }

        private void btn_Recargar_Click(object sender, EventArgs e)
        {
            recargar();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.PrincipalBindingSource.EndEdit();
                this.contratoTableAdapter.Update(this.contratoDataSet.Contrato);
                MessageBox.Show("Guardado Correctamente");
                recargar();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
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
                    this.contratoTableAdapter.Update(this.contratoDataSet.Contrato);
                    MessageBox.Show("El registro ha sido eliminado");
                    recargar();
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

        private void tb_BuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb_Buscar.Text.Length > 0)
            {
                PrincipalBindingSource.Filter = string.Format("convert(idCliente, 'System.String') Like '{0}' ", tb_Buscar.Text);
            }
            else
            {
                PrincipalBindingSource.RemoveFilter();
            }
        }

        private void PrincipalBindingSource_PositionChanged(object sender, EventArgs e)
        {
            DataRowView drvProducto = (DataRowView)PrincipalBindingSource.Current;
            if (drvProducto != null)
            {
                btn_Guardar.Enabled = true;
                btn_Eliminar.Enabled = true;
                gb_Datos.Enabled = true;
                drvProducto = null;
            }
                
        }
    }
}
