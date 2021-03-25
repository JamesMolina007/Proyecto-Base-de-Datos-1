using System;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ClienteVirtualFrm : Form
    {
        private String tipoUsuario = "";
        public void SetTipoUsuario(String tipoUsuario)
        {
            this.tipoUsuario = tipoUsuario;
        }
        public ClienteVirtualFrm()
        {
            InitializeComponent();
        }

        private void ClienteVirtualFrm_Load(object sender, EventArgs e)
        {
            if (tipoUsuario.Equals("Personal Del Centro De Llamadas"))
            {
                btn_Eliminar.Visible = false;
                btn_Guardar.Visible = false;
                btn_Nuevo.Visible = false;
                gb_ClienteVirtual.Enabled = false;
            }
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClienteFrecuente' Puede moverla o quitarla según sea necesario.
            this.clienteFrecuenteTableAdapter.Fill(this.clientesDataSet.ClienteFrecuente);
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClientePocoFrecuente' Puede moverla o quitarla según sea necesario.
            //this.clientePocoFrecuenteTableAdapter.Fill(this.clientesDataSet.ClientePocoFrecuente);
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.Cliente' Puede moverla o quitarla según sea necesario.
            this.clienteTableAdapter.Fill(this.clientesDataSet.Cliente);
            // TODO: esta línea de código carga datos en la tabla 'clientesDataSet.ClienteVirtual' Puede moverla o quitarla según sea necesario.
            recargar();
        }

        private void recargar()
        {
            this.clienteVirtualTableAdapter.Fill(this.clientesDataSet.ClienteVirtual);
            gb_ClienteVirtual.Enabled = false;
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = false;
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            ClienteVirtualBindingSource.AddNew();
            gb_ClienteVirtual.Enabled = true;
            btn_Guardar.Enabled = true;
            btn_Nuevo.Enabled = false;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_Contrasena.Text.Equals(tb_Contrasena2.Text) && ( Convert.ToInt32(tb_MesVencimiento.Text) <= 12 && Convert.ToInt32(tb_MesVencimiento.Text) > 0) && Convert.ToInt32(tb_AñoVencimiento.Text) > DateTime.Now.Year) 
                {
                    DataRow drCliFrecuente = clientesDataSet.ClienteFrecuente.FindByidCliente(Convert.ToInt32(cb_IdCliente.SelectedValue));
                    if (drCliFrecuente == null)
                    {
                        DataRow drClientePoco = clientesDataSet.ClientePocoFrecuente.FindByidCliente(Convert.ToInt32(cb_IdCliente.SelectedValue));
                        if (drClientePoco == null)
                        {
                            DataRowView drvClientePocoFrecuente = (DataRowView)ClientePocoFrecuenteBindingSource.AddNew();
                            drvClientePocoFrecuente["idCliente"] = Convert.ToInt32(cb_IdCliente.SelectedValue);
                            ClientePocoFrecuenteBindingSource.EndEdit();
                            clientePocoFrecuenteTableAdapter.Update(this.clientesDataSet.ClientePocoFrecuente);
                        }
                        DataRowView drvClienteVirtual = (DataRowView)ClienteVirtualBindingSource.Current;
                        drvClienteVirtual["idCliente"] = Convert.ToInt32(cb_IdCliente.SelectedValue);
                        this.Validate();
                        ClienteVirtualBindingSource.EndEdit();
                        clienteVirtualTableAdapter.Update(this.clientesDataSet.ClienteVirtual);
                        MessageBox.Show("Agregado exitosamente!");
                        recargar();
                    }
                    else
                    {
                        MessageBox.Show("Este cliente es frecuente!");
                    }
                }else
                    MessageBox.Show("Datos no validos!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void btn_Recargar_Click(object sender, EventArgs e)
        {
            recargar();
        }

        private void btn_Eliminar_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Está Seguro que quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    ClienteVirtualBindingSource.RemoveCurrent();
                    this.ClienteVirtualBindingSource.EndEdit();
                    this.clienteVirtualTableAdapter.Update(this.clientesDataSet.ClienteVirtual);
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

        private void ClienteVirtualBindingSource_PositionChanged(object sender, EventArgs e)
        {
            btn_Guardar.Enabled = true;
            btn_Eliminar.Enabled = true;
            gb_ClienteVirtual.Enabled = true;
        }

        private void tb_BuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            try
            {
                if (tb_BuscarCliente.Text.Length > 0)
                {
                    ClienteVirtualBindingSource.Filter = string.Format("convert(idCliente, 'System.String') Like '{0}' ", Convert.ToInt32(tb_BuscarCliente.Text));
                }
                else
                {
                    ClienteVirtualBindingSource.RemoveFilter();
                }
            }
            catch (Exception ex)
            {

            }
        }
    }
}
