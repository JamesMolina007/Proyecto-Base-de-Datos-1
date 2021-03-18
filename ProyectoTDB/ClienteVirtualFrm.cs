using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ClienteVirtualFrm : Form
    {
        public ClienteVirtualFrm()
        {
            InitializeComponent();
        }

        private void ClienteVirtualFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClienteFrecuente' Puede moverla o quitarla según sea necesario.
            this.clienteFrecuenteTableAdapter.Fill(this.clientesDataSet.ClienteFrecuente);
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClientePocoFrecuente' Puede moverla o quitarla según sea necesario.
            //this.clientePocoFrecuenteTableAdapter.Fill(this.clientesDataSet.ClientePocoFrecuente);
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.clientesDataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClienteVirtual' Puede moverla o quitarla según sea necesario.
            //this.clienteVirtualTableAdapter.Fill(this.clientesDataSet.ClienteVirtual);

        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            ClienteVirtualBindingSource.AddNew();
            gb_ClienteVirtual.Enabled = true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow drCliFrecuente = clientesDataSet.ClienteFrecuente.FindByidCliente(Convert.ToInt32(cb_IdCliente.SelectedValue));
                if (drCliFrecuente == null)
                {
                    DataRow drClientePoco = clientesDataSet.ClientePocoFrecuente.FindByidCliente(Convert.ToInt32(cb_IdCliente.SelectedValue));
                    if(drClientePoco == null)
                    {
                        DataRowView drvClientePocoFrecuente = (DataRowView)ClientePocoFrecuenteBindingSource.AddNew();
                        drvClientePocoFrecuente["idCliente"] = Convert.ToInt32(cb_IdCliente.SelectedValue.ToString());
                        ClientePocoFrecuenteBindingSource.EndEdit();
                        clientePocoFrecuenteTableAdapter.Update(this.clientesDataSet.ClientePocoFrecuente);
                    }
                    DataRowView drvClienteVirtual = (DataRowView)ClienteVirtualBindingSource.AddNew();
                    drvClienteVirtual["idCliente"] = Convert.ToInt32(cb_IdCliente.SelectedValue.ToString());
                    this.Validate();
                    ClienteVirtualBindingSource.EndEdit();
                    clienteVirtualTableAdapter.Update(this.clientesDataSet.ClienteVirtual);
                    MessageBox.Show("Agregado exitosamente!");
                }
                else
                {
                    MessageBox.Show("Este cliente es frecuente!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
