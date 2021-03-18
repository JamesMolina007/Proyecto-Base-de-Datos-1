using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ClientesFrecuentesFrm : Form
    {
        public ClientesFrecuentesFrm()
        {
            InitializeComponent();
        }

        private void ClientesFrecuentesFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.clientesDataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClientePocoFrecuente' Puede moverla o quitarla según sea necesario.
            this.clientePocoFrecuenteTableAdapter.Fill(this.clientesDataSet.ClientePocoFrecuente);
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClienteFrecuente' Puede moverla o quitarla según sea necesario.
            // this.clienteFrecuenteTableAdapter.Fill(this.clientesDataSet.ClienteFrecuente);

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow drCliPoco = clientesDataSet.ClientePocoFrecuente.FindByidCliente(Convert.ToInt32(cb_IdCliente.SelectedValue));
                if (drCliPoco == null)
                {
                    ClienteFrecuenteBindingSource.AddNew();
                    DataRowView drvClienteFrecuente = (DataRowView)ClienteFrecuenteBindingSource.Current;
                    drvClienteFrecuente["idCliente"] = Convert.ToInt32(cb_IdCliente.SelectedValue.ToString());
                    this.Validate();
                    ClienteFrecuenteBindingSource.EndEdit();
                    clienteFrecuenteTableAdapter.Update(this.clientesDataSet.ClienteFrecuente);
                    MessageBox.Show("Agregado exitosamente!");
                }
                else
                {
                    MessageBox.Show("Este cliente es poco frecuente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente ya asignado");
            }
        }
    }
}
