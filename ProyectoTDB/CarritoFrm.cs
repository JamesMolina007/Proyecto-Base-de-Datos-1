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
            recargar();
            this.productoTableAdapter.Fill(this.carritoDataSet.Producto);
            // TODO: esta línea de código carga datos en la tabla 'carritoDataSet.Carrito' Puede moverla o quitarla según sea necesario.
            this.carritoTableAdapter.Fill(this.carritoDataSet.Carrito);
        }

        private void recargar()
        {
            gb_Datos.Enabled = false;
            btn_Nuevo.Enabled = true;
            btn_Guardar.Enabled = false;
            btn_Eliminar.Enabled = false;
            // TODO: esta línea de código carga datos en la tabla 'carritoDataSet.ClienteVirtual' Puede moverla o quitarla según sea necesario.
            this.clienteVirtualTableAdapter.Fill(this.carritoDataSet.ClienteVirtual);
            // TODO: esta línea de código carga datos en la tabla 'carritoDataSet.Producto' Puede moverla o quitarla según sea necesario.
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
    }
}
