using System;
using System.Windows.Forms;

namespace ProyectoDB
{
    public partial class CarritoFrm : Form
    {
        public CarritoFrm()
        {
            InitializeComponent();
        }

        private void CarritoFrm_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'tiendaDataSet.Tienda' Puede moverla o quitarla según sea necesario.
            this.tiendaTableAdapter.Fill(this.tiendaDataSet.Tienda);
            recargar();
            this.productoTableAdapter.Fill(this.carritoDataSet.Producto);
        }

        private void recargar()
        {
            gb_Datos.Enabled = false;
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = false;
            this.clienteVirtualTableAdapter.Fill(this.carritoDataSet.ClienteVirtual);
        }

        private void btn_Nuevo_Click(object sender, EventArgs e)
        {
            CarritoBindingSource.AddNew();
            btn_Eliminar.Enabled = false;
            gb_Datos.Enabled = true;
            btn_Guardar.Enabled = true;
        }

        private void btn_Guardar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Validate();
                this.CarritoBindingSource.EndEdit();
                this.carritoTableAdapter.Update(this.carritoDataSet.Carrito);
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
                    CarritoBindingSource.RemoveCurrent();
                    this.CarritoBindingSource.EndEdit();
                    this.carritoTableAdapter.Update(this.carritoDataSet.Carrito);
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

        private void btn_Recargar_Click(object sender, EventArgs e)
        {
            recargar();
        }

        private void CarritoBindingSource_PositionChanged(object sender, EventArgs e)
        {
            btn_Eliminar.Enabled = true;
            btn_Guardar.Enabled = true;
            btn_Nuevo.Enabled = false;
            gb_Datos.Enabled = true;
        }

        private void tb_BuscarCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (tb_BuscarCliente.Text.Length > 0)
            {
                CarritoBindingSource.Filter = string.Format("convert(idCliente, 'System.String') Like '{0}' ", tb_BuscarCliente.Text);
            }
            else
            {
                CarritoBindingSource.RemoveFilter();
            }
            
        }
    }
}
