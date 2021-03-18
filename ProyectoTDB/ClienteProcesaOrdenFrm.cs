using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ClienteProcesaOrdenFrm : Form
    {

        private int id_Cliente;
        public void setId_Cliente(int id_Cliente)
        {
            this.id_Cliente = id_Cliente;
        }

        public ClienteProcesaOrdenFrm()
        {
            InitializeComponent();
        }

        private void ClienteProcesaOrdenFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'empresasDeEnvioDataSet.EmpresaDeEnvio' Puede moverla o quitarla según sea necesario.
            this.empresaDeEnvioTableAdapter.Fill(this.empresasDeEnvioDataSet.EmpresaDeEnvio);
            // TODO: esta línea de código carga datos en la tabla 'ordenDataSet.Orden' Puede moverla o quitarla según sea necesario.
           /// this.ordenTableAdapter.Fill(this.ordenDataSet.Orden);
            OrdenBindingSource.AddNew();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            DataRowView drvOrden = (DataRowView)OrdenBindingSource.Current;
            drvOrden.Row["idCliente"] = id_Cliente;
            try
            {
                this.Validate();
                this.OrdenBindingSource.EndEdit();
                this.ordenTableAdapter.Update(this.ordenDataSet.Orden);
                MessageBox.Show("Guardado Correctamente");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
            

        }
    }
}
