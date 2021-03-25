using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class OrdenesFrm : Form
    {
        private String tipoUsuario = "";
        public void SetTipoUsuario(String tipoUsuario)
        {
            this.tipoUsuario = tipoUsuario;
        }
        public OrdenesFrm()
        {
            InitializeComponent();
        }

        private void OrdenClienteFrm_Load(object sender, EventArgs e)
        {
            if (tipoUsuario.Equals("Personal Del Centro De Llamadas"))
            {
                btn_Eliminar.Visible = false;
                btn_Guardar.Visible = false;
                btn_Nuevo.Visible = false;
                gb_DatosOrden.Enabled = false;
            }
            // TODO: esta línea de código carga datos en la tabla 'facturasDataSet.Factura' Puede moverla o quitarla según sea necesario.
            this.facturaTableAdapter.Fill(this.facturasDataSet.Factura);
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClienteVirtual' Puede moverla o quitarla según sea necesario.
            this.clienteVirtualTableAdapter.Fill(this.clientesDataSet.ClienteVirtual);
            // TODO: esta línea de código carga datos en la tabla 'empresasDeEnvioDataSet.EmpresaDeEnvio' Puede moverla o quitarla según sea necesario.
            this.empresaDeEnvioTableAdapter.Fill(this.empresasDeEnvioDataSet.EmpresaDeEnvio);
            // TODO: esta línea de código carga datos en la tabla 'ordenDataSet.Orden' Puede moverla o quitarla según sea necesario.
            recargar();

        }

        private void recargar()
        {
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = false;
            gb_DatosOrden.Enabled = false;
            this.ordenTableAdapter.Fill(this.ordenDataSet.Orden);
            OrdenBindingSource.RemoveFilter();
            tb_Buscar.Text = "";
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            OrdenBindingSource.AddNew();
            btn_Nuevo.Enabled = false;
            btn_Eliminar.Enabled = false;
            btn_Guardar.Enabled = true;
            gb_DatosOrden.Enabled = true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv_Orden = (DataRowView)OrdenBindingSource.Current;
                drv_Orden["Estatus"] = cb_Estatus.SelectedItem.ToString();
                this.Validate();
                OrdenBindingSource.EndEdit();
                ordenTableAdapter.Update(this.ordenDataSet.Orden);
                MessageBox.Show("Datos Guardados Exitosamente!");
                recargar();
            }
            catch (Exception ex)
            {

            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Está Seguro que quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    OrdenBindingSource.RemoveCurrent();
                    this.OrdenBindingSource.EndEdit();
                    this.ordenTableAdapter.Update(this.ordenDataSet.Orden);
                    MessageBox.Show("El registro ha sido eliminado");
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("El registro no ha sido eliminado");
                }
                recargar();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btn_Recargar_Click(object sender, EventArgs e)
        {
            recargar();
        }

        private void OrdenBindingSource_PositionChanged(object sender, EventArgs e)
        {
                gb_DatosOrden.Enabled = true;
               // btn_Nuevo.Enabled = false;
                btn_Eliminar.Enabled = true;
                btn_Guardar.Enabled = true;
        }

        private void tb_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb_Buscar.Text.Length > 0)
            {
                OrdenBindingSource.Filter = string.Format("convert(idCliente, 'System.String') Like '{0}' ", tb_Buscar.Text);
            }
            else
            {
                OrdenBindingSource.RemoveFilter();
            }
        }
    }
}
