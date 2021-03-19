using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ProcesoOrdenFrm : Form
    {
        public ProcesoOrdenFrm()
        {
            InitializeComponent();
        }

        private void OrdenEnviadaFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'ordenDataSet.Orden' Puede moverla o quitarla según sea necesario.
            recargar();
        }

        private void recargar()
        {
            this.ordenTableAdapter.Fill(this.ordenDataSet.Orden);
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            DataRowView drvOrden = (DataRowView)OrdenBindingSource.Current;
            drvOrden["Estatus"] = "Enviado";
            OrdenBindingSource.EndEdit();
            ordenTableAdapter.Update(this.ordenDataSet.Orden);
            recargar();
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            DataRowView drvOrden = (DataRowView)OrdenBindingSource.Current;
            drvOrden["Estatus"] = "Entregado";
            OrdenBindingSource.EndEdit();
            ordenTableAdapter.Update(this.ordenDataSet.Orden);
            recargar();
        }

        private void btn_Recargar_Click(object sender, EventArgs e)
        {
            recargar();
        }

        private void tb_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb_Buscar.Text.Length > 0)
            {
                OrdenBindingSource.Filter = string.Format("convert(noOrden, 'System.String') Like '{0}' ", tb_Buscar.Text);
            }
            else
            {
                OrdenBindingSource.RemoveFilter();
            }
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            ConsultaOrdenFrm consultaOrden = new ConsultaOrdenFrm();
            DataRowView drvOrden = (DataRowView)OrdenBindingSource.Current;
            consultaOrden.setOrdenCliente(Convert.ToInt32(drvOrden["noOrden"]), Convert.ToInt32(drvOrden["idCliente"]));
            consultaOrden.Show();
        }
    }
}
