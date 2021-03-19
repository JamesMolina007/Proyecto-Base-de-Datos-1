using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ClienteTiendaFrm : Form
    {
        public ClienteTiendaFrm()
        {
            InitializeComponent();
        }

        private void ClienteTiendaFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.clientesDataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClienteTienda' Puede moverla o quitarla según sea necesario.
            this.clienteTiendaTableAdapter.Fill(this.clientesDataSet.ClienteTienda);
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClientePocoFrecuente' Puede moverla o quitarla según sea necesario.
            //this.clientePocoFrecuenteTableAdapter.Fill(this.clientesDataSet.ClientePocoFrecuente);
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClienteFrecuente' Puede moverla o quitarla según sea necesario.
            this.clienteFrecuenteTableAdapter.Fill(this.clientesDataSet.ClienteFrecuente);
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow drCliFrecuente = clientesDataSet.ClienteFrecuente.FindByidCliente(Convert.ToInt32(cb_IdCliente.SelectedValue));
                if (drCliFrecuente == null)
                {
                    DataRowView drvClientePocoFrecuente = (DataRowView)ClientePocoFrecuenteBindingSource.AddNew();
                    DataRowView drvClienteTienda = (DataRowView)ClienteTiendaBindingSource.AddNew();
                    drvClientePocoFrecuente["idCliente"] = Convert.ToInt32(cb_IdCliente.SelectedValue.ToString());
                    drvClienteTienda["idCliente"] = Convert.ToInt32(cb_IdCliente.SelectedValue.ToString());
                    this.Validate();
                    ClienteTiendaBindingSource.EndEdit();
                    clienteTiendaTableAdapter.Update(this.clientesDataSet.ClienteTienda);
                    ClientePocoFrecuenteBindingSource.EndEdit();
                    clientePocoFrecuenteTableAdapter.Update(this.clientesDataSet.ClientePocoFrecuente);
                    MessageBox.Show("Agregado exitosamente!");
                }
                else
                {
                    MessageBox.Show("Este cliente es frecuente!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Cliente ya asignado");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está Seguro que quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ClienteTiendaBindingSource.RemoveCurrent();
                this.ClienteTiendaBindingSource.EndEdit();
                this.clienteTiendaTableAdapter.Update(this.clientesDataSet.ClienteTienda);
                MessageBox.Show("El registro ha sido eliminado");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("El registro no ha sido eliminado");
            }
        }
    }
}
