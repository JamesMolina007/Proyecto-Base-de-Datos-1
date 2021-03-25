using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ClientePocoFrecuenteFrm : Form
    {
        private String tipoUsuario = "";
        public void SetTipoUsuario(String tipoUsuario)
        {
            this.tipoUsuario = tipoUsuario;
        }
        public ClientePocoFrecuenteFrm()
        {
            InitializeComponent();
        }

        private void ClientePocoFrecuenteFrm_Load(object sender, EventArgs e)
        {
            if (tipoUsuario.Equals("Personal Del Centro De Llamadas"))
            {
                btn_Agregar.Visible = false;
                button1.Visible = false;
                cb_IdCliente.Enabled = false;
            }
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.clientesDataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClienteFrecuente' Puede moverla o quitarla según sea necesario.
            this.clienteFrecuenteTableAdapter.Fill(this.clientesDataSet.ClienteFrecuente);
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClientePocoFrecuente' Puede moverla o quitarla según sea necesario.
            this.clientePocoFrecuenteTableAdapter.Fill(this.clientesDataSet.ClientePocoFrecuente);

        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow drCliFrec = clientesDataSet.ClienteFrecuente.FindByidCliente(Convert.ToInt32(cb_IdCliente.SelectedValue));
                if (drCliFrec == null)
                {
                    ClientePocoFrecuenteBindingSource.AddNew();
                    DataRowView drvClientePocoFrecuente = (DataRowView)ClientePocoFrecuenteBindingSource.Current;
                    drvClientePocoFrecuente["idCliente"] = Convert.ToInt32(cb_IdCliente.SelectedValue.ToString());
                    this.Validate();
                    ClientePocoFrecuenteBindingSource.EndEdit();
                    clientePocoFrecuenteTableAdapter.Update(this.clientesDataSet.ClientePocoFrecuente);
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("¿Está Seguro que quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                ClientePocoFrecuenteBindingSource.RemoveCurrent();
                this.ClientePocoFrecuenteBindingSource.EndEdit();
                this.clientePocoFrecuenteTableAdapter.Update(this.clientesDataSet.ClientePocoFrecuente);
                MessageBox.Show("El registro ha sido eliminado");
            }
            else if (dialogResult == DialogResult.No)
            {
                MessageBox.Show("El registro no ha sido eliminado");
            }
        }
    }
}
