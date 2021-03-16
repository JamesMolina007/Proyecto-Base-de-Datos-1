using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class ClientesFrm : Form
    {
        public ClientesFrm()
        {
            InitializeComponent();
        }

        private void ClientesFrm_Load(object sender, EventArgs e)
        {
            Limpiar();
            this.clienteTableAdapter.Fill(this.clientesDataSet.Cliente);    
            gb_tipoCompra.Enabled = false;
            gb_ClienteVirtual.Enabled = false;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Está Seguro que quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    PrincipalBindingSource.RemoveCurrent();
                    this.PrincipalBindingSource.EndEdit();
                    this.clienteTableAdapter.Update(this.clientesDataSet.Cliente);
                    MessageBox.Show("El registro ha sido eliminado");
                    this.clienteTableAdapter.Fill(this.clientesDataSet.Cliente);
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("El registro no ha sido eliminado");
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void tb_BuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb_BuscarCliente.Text.Length > 0)
            {
                PrincipalBindingSource.Filter = "nombreCliente LIKE '*" + tb_BuscarCliente.Text + "*'";
            }
            else
            {
                PrincipalBindingSource.RemoveFilter();
            }
        }

        private void cb_TipoCliente_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_TipoCliente.SelectedItem.ToString().Equals("Poco Frecuente") ){
                gb_tipoCompra.Enabled = true;
            }
            else
            {
                gb_tipoCompra.Enabled = false;
                gb_ClienteVirtual.Enabled = false;
                Limpiar();
            }
               
        }

        private void cb_TipoCompra_SelectedIndexChanged(object sender, EventArgs e)
        {
            if( cb_TipoCompra.SelectedItem.ToString().Equals("Virtual"))
            {
                gb_ClienteVirtual.Enabled = true;
            }
            else
            {
                gb_ClienteVirtual.Enabled = false;
                Limpiar();
            }
        }

        private void Limpiar()
        {
            btn_Eliminar.Enabled = false;
            btn_Guardar.Enabled = false;
            btn_Nuevo.Enabled = true;
            tb_Direccion.Text = "";
            tb_MesVencimiento.Text = "";
            tb_NumeroTarjeta.Text = "";
            tb_Contrasena.Text = "";
            tb_Contrasena2.Text = "";
            tb_TarjetaHabiente.Text = "";
            tb_CodigoSeguridad.Text = "";
            tb_AñoVencimiento.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_Contrasena.Text.Equals(tb_Contrasena.Text))
                {
                    
                    this.Validate();
                    this.PrincipalBindingSource.EndEdit();
                    this.clienteTableAdapter.Update(this.clientesDataSet.Cliente);
                    DataRowView dr = (DataRowView)PrincipalBindingSource.Current;

                    if (cb_TipoCliente.SelectedItem.ToString().Equals("Poco Frecuente"))
                    {
                        FrecuenteBindingSource.CancelEdit();
                        DataRowView drv_ClientePocoFrecuente = (DataRowView)PocoFrecuenteBindingSource.Current;
                        drv_ClientePocoFrecuente.Row["idCliente"] = dr.Row["idCliente"];
                        this.PocoFrecuenteBindingSource.EndEdit();
                        this.clientePocoFrecuenteTableAdapter.Update(this.clientesDataSet.ClientePocoFrecuente);
                        if (cb_TipoCompra.SelectedItem.ToString().Equals("Virtual"))
                        {
                            TiendaBindingSource.CancelEdit();
                            DataRowView drv_ClienteVirtual = (DataRowView)VirtualBindingSource.Current;
                            drv_ClienteVirtual.Row["idCliente"] = dr.Row["idCliente"];
                            this.VirtualBindingSource.EndEdit();
                            this.clienteVirtualTableAdapter.Update(this.clientesDataSet.ClienteVirtual);
                        }
                        else if (cb_TipoCompra.SelectedItem.ToString().Equals("Tienda"))
                        {
                            DataRowView drv_ClienteTienda = (DataRowView)TiendaBindingSource.Current;
                            drv_ClienteTienda.Row["idCliente"] = dr.Row["idCliente"];
                            VirtualBindingSource.CancelEdit();
                            this.TiendaBindingSource.EndEdit();
                            this.clienteTiendaTableAdapter.Update(this.clientesDataSet.ClienteTienda);
                        }

                    }
                    else if (cb_TipoCliente.SelectedItem.ToString().Equals("Frecuente"))
                    {
                        PocoFrecuenteBindingSource.CancelEdit();
                        DataRowView drv_ClienteFrecuente = (DataRowView)FrecuenteBindingSource.Current;
                        drv_ClienteFrecuente.Row["idCliente"] = dr.Row["idCliente"];
                        this.FrecuenteBindingSource.EndEdit();
                        this.clienteFrecuenteTableAdapter.Update(this.clientesDataSet.ClienteFrecuente);
                    }
                    MessageBox.Show("Guardado Correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Las contraseñas deben ser las mismas");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }


        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            PrincipalBindingSource.AddNew();
            PocoFrecuenteBindingSource.AddNew();
            VirtualBindingSource.AddNew();   
            TiendaBindingSource.AddNew();
            FrecuenteBindingSource.AddNew();
        }

        private void tb_Buscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb_BuscarCliente.Text.Length > 0)
            {
                PrincipalBindingSource.Filter = "nombreCliente LIKE '*" + tb_BuscarCliente.Text + "*'";
            }
            else
            {
                PrincipalBindingSource.RemoveFilter();
            }
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            PrincipalBindingSource.AddNew();
            PocoFrecuenteBindingSource.AddNew();
            VirtualBindingSource.AddNew();
            TiendaBindingSource.AddNew();
            FrecuenteBindingSource.AddNew();
            btn_Eliminar.Enabled = false;
            btn_Nuevo.Enabled = false;
            btn_Guardar.Enabled = true;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            try
            {
                DialogResult dialogResult = MessageBox.Show("¿Está Seguro que quiere eliminar este registro?", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    PrincipalBindingSource.RemoveCurrent();
                    this.PrincipalBindingSource.EndEdit();
                    this.clienteTableAdapter.Update(this.clientesDataSet.Cliente);
                    MessageBox.Show("El registro ha sido eliminado");
                    recargar();
                }
                else if (dialogResult == DialogResult.No)
                {
                    MessageBox.Show("El registro no ha sido eliminado");
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (tb_Contrasena.Text.Equals(tb_Contrasena.Text))
                {

                    this.Validate();
                    this.PrincipalBindingSource.EndEdit();
                    this.clienteTableAdapter.Update(this.clientesDataSet.Cliente);
                    DataRowView dr = (DataRowView)PrincipalBindingSource.Current;

                    if (cb_TipoCliente.SelectedItem.ToString().Equals("Poco Frecuente"))
                    {
                        FrecuenteBindingSource.CancelEdit();
                        DataRowView drv_ClientePocoFrecuente = (DataRowView)PocoFrecuenteBindingSource.Current;
                        drv_ClientePocoFrecuente.Row["idCliente"] = dr.Row["idCliente"];
                        this.PocoFrecuenteBindingSource.EndEdit();
                        this.clientePocoFrecuenteTableAdapter.Update(this.clientesDataSet.ClientePocoFrecuente);
                        if (cb_TipoCompra.SelectedItem.ToString().Equals("Virtual"))
                        {
                            TiendaBindingSource.CancelEdit();
                            DataRowView drv_ClienteVirtual = (DataRowView)VirtualBindingSource.Current;
                            drv_ClienteVirtual.Row["idCliente"] = dr.Row["idCliente"];
                            this.VirtualBindingSource.EndEdit();
                            this.clienteVirtualTableAdapter.Update(this.clientesDataSet.ClienteVirtual);
                        }
                        else if (cb_TipoCompra.SelectedItem.ToString().Equals("Tienda"))
                        {
                            DataRowView drv_ClienteTienda = (DataRowView)TiendaBindingSource.Current;
                            drv_ClienteTienda.Row["idCliente"] = dr.Row["idCliente"];
                            VirtualBindingSource.CancelEdit();
                            this.TiendaBindingSource.EndEdit();
                            this.clienteTiendaTableAdapter.Update(this.clientesDataSet.ClienteTienda);
                        }

                    }
                    else if (cb_TipoCliente.SelectedItem.ToString().Equals("Frecuente"))
                    {
                        PocoFrecuenteBindingSource.CancelEdit();
                        DataRowView drv_ClienteFrecuente = (DataRowView)FrecuenteBindingSource.Current;
                        drv_ClienteFrecuente.Row["idCliente"] = dr.Row["idCliente"];
                        this.FrecuenteBindingSource.EndEdit();
                        this.clienteFrecuenteTableAdapter.Update(this.clientesDataSet.ClienteFrecuente);
                    }
                    MessageBox.Show("Guardado Correctamente");
                    Limpiar();
                    recargar();
                }
                else
                {
                    MessageBox.Show("Las contraseñas deben ser las mismas");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.ToString());
            }
        }

        private void btn_Recargar_Click(object sender, EventArgs e)
        {
            Limpiar();
            recargar();
        }

        private void recargar()
        {
            this.clienteTableAdapter.Fill(this.clientesDataSet.Cliente);
            Limpiar();
        }

        private void PrincipalBindingSource_PositionChanged(object sender, EventArgs e)
        {
            if( btn_Nuevo.Enabled == false)
            {
                btn_Nuevo.Enabled = false;
                btn_Guardar.Enabled = true;
                btn_Eliminar.Enabled = true;
                gb_ClienteVirtual.Enabled = true;
                gb_tipoCompra.Enabled = true;
            }
            DataRowView dr = (DataRowView)PrincipalBindingSource.Current;
            this.clienteFrecuenteTableAdapter.FillByID(this.clientesDataSet.ClienteFrecuente, (int)dr.Row["idCliente"]);
            this.clientePocoFrecuenteTableAdapter.FillByID(this.clientesDataSet.ClientePocoFrecuente, (int)dr.Row["idCliente"]);
            this.clienteVirtualTableAdapter.FillByID(this.clientesDataSet.ClienteVirtual, (int)dr.Row["idCliente"]);
            this.clienteTiendaTableAdapter.FillByID(this.clientesDataSet.ClienteTienda, (int)dr.Row["idCliente"]);
        }
    }
}
